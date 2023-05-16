using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR_FinalProject_Nhom3
{
    public partial class SelectParkPlaceForm : Form
    {
        public SelectParkPlaceForm()
        {
            InitializeComponent();
        }
        public string idBill { get; set; }
        public string idWork { get; set; }
        public float price { get; set; }
        public string typeOfVehicle { get; set; }
        public string idVehicle { get; set; }
        public string licensePlate { get; set; }
        MY_DB mydb = new MY_DB();
        Bill bill = new Bill();
        public DataTable getEmptyParkByTypeOfVehicle()
        {
            SqlCommand command = new SqlCommand("select IdParkPlace, IdVehicle, LisencePlate from ParkPlace where State = 'empty' and TypeOfCar = @type", mydb.getConnection);
            command.Parameters.Add("type", SqlDbType.NVarChar).Value = typeOfVehicle;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void dataGridViewParkPlace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectParkPlaceForm_Load(object sender, EventArgs e)
        {
            dataGridViewParkPlace.DataSource = getEmptyParkByTypeOfVehicle();
            dataGridViewParkPlace.AllowUserToAddRows = false;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (dataGridViewParkPlace.CurrentRow.Cells["IdParkplace"].Value != System.DBNull.Value)
            {
                string idPark = dataGridViewParkPlace.CurrentRow.Cells["IdParkplace"].Value.ToString();
                SqlCommand cmd_update_parkplace = new SqlCommand("update parkplace set idvehicle = @idvehi, lisenceplate = @plate, state = 'parked' " +
                    "where idparkplace = @idpark", mydb.getConnection);
                cmd_update_parkplace.Parameters.Add("idvehi", SqlDbType.NVarChar).Value = idVehicle;
                cmd_update_parkplace.Parameters.Add("plate", SqlDbType.NVarChar).Value = licensePlate;
                cmd_update_parkplace.Parameters.Add("idpark", SqlDbType.NVarChar).Value = idPark;

                SqlCommand cmd_update_capacity = new SqlCommand("update capacity set currentcapacity += 1 where typeofcar = @type", mydb.getConnection);
                cmd_update_capacity.Parameters.Add("type", SqlDbType.NVarChar).Value = typeOfVehicle;

                if (bill.addDetailBill(idBill, idWork, price))
                {
                    mydb.openConnection();

                    cmd_update_parkplace.ExecuteNonQuery();
                    cmd_update_capacity.ExecuteNonQuery();
                    mydb.closeConnection();
                    MessageBox.Show("Adding work successfully", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Empty park place", "Select Park Place", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
