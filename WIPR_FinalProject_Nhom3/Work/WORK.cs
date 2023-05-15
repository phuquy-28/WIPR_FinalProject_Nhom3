using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace WIPR_FinalProject_Nhom3
{
    public class WORK
    {
        MY_DB mydb = new MY_DB();
        public bool insertWork(int idWork, string name, float price, int idTypeOfWork, string typeOfCar)
        {
            SqlCommand command = new SqlCommand("insert into Work values (@idwork, @name, @price, @idtype, @typeofcar)", mydb.getConnection);
            command.Parameters.AddWithValue("@idwork", idWork);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@idtype", idTypeOfWork);
            command.Parameters.AddWithValue("@typeofcar", typeOfCar);
            //
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool editWork(int idWork, float price, int idTypeOfWork, string typeOfCar)
        {
            SqlCommand command = new SqlCommand("UPDATE Work SET Price = @price, idTypeOfWork = @idtype, TypeOfCar = @typeOfCar Where idWork = " + idWork, mydb.getConnection);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@idtype", idTypeOfWork);
            command.Parameters.AddWithValue("@typeofcar", typeOfCar);
            //
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool deleteWork(int idWork)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Work Where idWork = " + idWork, mydb.getConnection);
            //
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool idWorkExist(int idWork)
        {
            SqlCommand command = new SqlCommand("select * from Work where IdWork = @idwork", mydb.getConnection);
            command.Parameters.AddWithValue("@idwork", idWork);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable getWork()
        {
            SqlCommand command = new SqlCommand("select * from Work", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable getTypeOfWork()
        {
            SqlCommand command = new SqlCommand("select * from TypeOfWork", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable getWorkById(int idWork)
        {
            SqlCommand command = new SqlCommand("select * from Work where idWork = " + idWork, mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public DataTable getWorkList()
        {
            SqlCommand command = new SqlCommand("select IdWork, Name, Price from Work", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
    }
}
