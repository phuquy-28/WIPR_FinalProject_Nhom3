using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR_FinalProject_Nhom3
{
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();

        }
        public DateTime TimeIn { get; set; }
        public string IdVehicle { get; set; }
        public string Plate { get; set; }
        MY_DB mydb = new MY_DB();
        VEHICLE vehicle = new VEHICLE();

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            labelIdVehicle.Text = IdVehicle;
            labelLicensePlate.Text = Plate;
            labelTimeIn.Text = TimeIn.ToString("dd/MM/yyyy hh:mm:tt");
            labelTimeOut.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:tt");

            string dateString = DateTime.Now.ToString("dd/MM/yyyy hh:mm:tt");
            DateTime timeOut = DateTime.ParseExact(dateString, "dd/MM/yyyy hh:mm:tt", CultureInfo.InvariantCulture);
            SqlCommand command = new SqlCommand("update bill set timeout = @timeout where idvehicle = @idvehi and state = 'Temporary'", mydb.getConnection);
            command.Parameters.Add("timeout", SqlDbType.DateTime).Value = timeOut;
            //command.Parameters.Add("state", SqlDbType.NVarChar).Value = "Finished";
            command.Parameters.Add("idvehi", SqlDbType.NVarChar).Value = IdVehicle;
            mydb.openConnection();
            command.ExecuteNonQuery();
            mydb.closeConnection();
            checkOut();
        }


        public float getPriceByIdWork(string idwork)
        {
            SqlCommand command = new SqlCommand("select price from work where idwork = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = idwork;
            mydb.openConnection();
            object result = command.ExecuteScalar();
            mydb.closeConnection();
            if (result != null && float.TryParse(result.ToString(), out float price))
            {
                return price;
            }
            else
            {
                return 0; // hoặc giá trị mặc định khác tùy vào ý định của bạn
            }
        }

        public float calFine(string idwork, float price, int time, DateTime timeIn, DateTime timeOut)
        {
            int idWork_int = Convert.ToInt32(idwork);
            if (idWork_int <= 3)
            {
                TimeSpan timeSpan = timeOut - timeIn;
                int hours = timeSpan.Days * 24 + timeSpan.Hours;
                if (timeSpan.Minutes > 0) hours++;
                if (hours - time > 24)
                {
                    idWork_int += 3;
                    return getPriceByIdWork(idWork_int.ToString()) * 2;
                }
            }
            else if (idWork_int <= 6)
            {
                TimeSpan timeSpan = timeOut - timeIn;
                int days = timeSpan.Days;
                if (timeSpan.Hours > 0 || timeSpan.Minutes > 0) days++;
                if (days - time > 1)
                {
                    idWork_int += 3;
                    return getPriceByIdWork(idWork_int.ToString());
                }
            }
            else if (idWork_int <= 9)
            {
                TimeSpan timeSpan = timeOut - timeIn;
                int days = timeSpan.Days;
                if (timeSpan.Hours > 0 || timeSpan.Minutes > 0) days++;
                if (days - time * 7 > 10 && days - time * 7 < 30)
                {
                    idWork_int += 3;
                    return getPriceByIdWork(idWork_int.ToString());
                }
            }
            return 0;
        }

        public float getChargeByIdVehicle(string idVehicle)
        {
            SqlCommand command = new SqlCommand("select total from bill where idvehicle = @id and state = 'Temporary'", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = idVehicle;
            mydb.openConnection();
            object result = command.ExecuteScalar();
            mydb.closeConnection();
            if (result != null && float.TryParse(result.ToString(), out float total))
            {
                return total;
            }
            else
            {
                return 0; // hoặc giá trị mặc định khác tùy vào ý định của bạn
            }
        }

        public void updateParkPlace(string idVehicle)
        {
            SqlCommand command = new SqlCommand("update parkplace set idvehicle = NULL, lisencePlate = NULL, state = 'empty' " +
                "where idvehicle = @id and state = 'parked'", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.NVarChar).Value = IdVehicle;
            mydb.openConnection();
            int affected = command.ExecuteNonQuery();
            mydb.closeConnection();

            SqlCommand command2 = new SqlCommand("update capacity set currentcapacity -= 1 ", mydb.getConnection);
            mydb.openConnection();
            if (affected > 0)
                command2.ExecuteNonQuery();
            mydb.closeConnection();
        }

        public void finishBill(string idVehicle, float total, float fine)
        {
            if (fine > 0)
            {
                string fine_string = fine.ToString() + " (overtime)";
                SqlCommand command = new SqlCommand("update bill set total = @newTotal, description = @fineString, state = 'Finished' where idvehicle = @id and state = 'temporary'", mydb.getConnection);
                command.Parameters.Add("id", SqlDbType.NVarChar).Value = IdVehicle;
                command.Parameters.Add("newTotal", SqlDbType.Float).Value = total;
                command.Parameters.Add("fineString", SqlDbType.NVarChar).Value = fine_string;
                mydb.openConnection();
                command.ExecuteNonQuery();
                mydb.closeConnection();
            }
            else
            {
                SqlCommand command = new SqlCommand("update bill set state = 'Finished' where idvehicle = @id and state = 'temporary'", mydb.getConnection);
                command.Parameters.Add("id", SqlDbType.NVarChar).Value = IdVehicle;
                mydb.openConnection();
                command.ExecuteNonQuery();
                mydb.closeConnection();
            }
        }

        public void checkOut()
        {
            SqlCommand command = new SqlCommand("select bill.id, work.idwork, work.name, work.price, detailbill.time, bill.timein, bill.timeout, detailbill.description " +
                "from bill join detailbill on bill.id = detailbill.idbill " +
                "join work on work.idwork = detailbill.idwork " +
                "where bill.idvehicle = @idvehi and bill.state = 'temporary'", mydb.getConnection);
            command.Parameters.Add("idvehi", SqlDbType.NVarChar).Value = IdVehicle;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            float fine = 0;

            foreach(DataRow row in table.Rows)
            {
                if (Convert.ToInt32(row["idwork"].ToString()) > 0 && Convert.ToInt32(row["idwork"].ToString()) < 13)
                {
                    string idwork = row["idwork"].ToString();
                    float price = Convert.ToInt32(row["price"].ToString());
                    int time = Convert.ToInt32(row["time"].ToString());
                    DateTime timeIn = (DateTime)row["timein"];
                    DateTime timeOut = (DateTime)row["timeout"];
                    if (calFine(idwork, price, time, timeIn, timeOut) != 0)
                    {
                        fine += calFine(idwork, price, time, timeIn, timeOut);
                        row["description"] = calFine(idwork, price, time, timeIn, timeOut).ToString() + " (overtime)";
                    }
                    updateParkPlace(IdVehicle);
                }
            }

            float charge = getChargeByIdVehicle(IdVehicle);
            labelCharge.Text = charge.ToString();
            labelFine.Text = fine.ToString();
            float total = fine + charge;
            labelTotal.Text = total.ToString();
            finishBill(IdVehicle, total, fine);
            vehicle.deleteVehicle(IdVehicle);

            dataGridViewDetail.DataSource = table;
            dataGridViewDetail.Columns["id"].HeaderText = "Id Bill";
            dataGridViewDetail.Columns["idwork"].HeaderText = "Id Work";
            dataGridViewDetail.Columns["name"].HeaderText = "Name Work";
            dataGridViewDetail.Columns["price"].HeaderText = "Price";
            dataGridViewDetail.Columns["time"].HeaderText = "Time";
            dataGridViewDetail.Columns["timein"].HeaderText = "Time In";
            dataGridViewDetail.Columns["timeout"].HeaderText = "Time Out";
            dataGridViewDetail.Columns["description"].HeaderText = "Description";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
