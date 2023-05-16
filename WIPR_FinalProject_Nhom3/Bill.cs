using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPR_FinalProject_Nhom3
{
    internal class Bill
    {
        MY_DB mydb = new MY_DB();
        public bool addBill(string idBill, string idVehicle, string typeOfVehicle, string licencePlate = "")
        {
            SqlCommand command = new SqlCommand("insert into Bill (Id, IdVehicle, TypeOfVehicle, LisencePlate, State) values (@idBill, @idVehi, @type, @plate, @state)", mydb.getConnection);
            command.Parameters.Add("idBill", SqlDbType.NVarChar).Value = idBill;
            command.Parameters.Add("idVehi", SqlDbType.NVarChar).Value = idVehicle;
            command.Parameters.Add("type", SqlDbType.NVarChar).Value = typeOfVehicle;
            command.Parameters.Add("plate", SqlDbType.NVarChar).Value = licencePlate;
            command.Parameters.Add("state", SqlDbType.NVarChar).Value = "Temporary";

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

        public bool IdBillIsExist(string idBill)
        {
            SqlCommand command = new SqlCommand("select * from bill where Id = @id", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.NVarChar).Value = idBill;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 1)
            {
                return true;
            }
            return false;
        }

        public DataTable getWorkListByTypeCar(string typeCar)
        {
            SqlCommand command = new SqlCommand("select * from work where TypeOfCar = @type", mydb.getConnection);
            command.Parameters.Add("type", SqlDbType.NVarChar).Value = typeCar;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool addDetailBill(string idBill, string idWork, double price, string description = "")
        {
            SqlCommand command_insert = new SqlCommand("insert into DetailBill values(@idbill, @idwork, @price, @des)", mydb.getConnection);
            command_insert.Parameters.Add("idbill", SqlDbType.NVarChar).Value = idBill;
            command_insert.Parameters.Add("idwork", SqlDbType.NVarChar).Value = idWork;
            command_insert.Parameters.Add("price", SqlDbType.Float).Value = price;
            command_insert.Parameters.Add("des", SqlDbType.NVarChar).Value = description;

            SqlCommand command_update = new SqlCommand("UPDATE Bill " +
                "SET Total = ISNULL(Total, 0) + @price " +
                "WHERE Id = @id", mydb.getConnection);
            command_update.Parameters.Add("price", SqlDbType.Float).Value = (float)price;
            command_update.Parameters.Add("id", SqlDbType.NVarChar).Value = idBill;

            mydb.openConnection();
            int affectedRows = command_insert.ExecuteNonQuery();
            affectedRows += command_update.ExecuteNonQuery();

            if (affectedRows == 2)
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
    }
}
