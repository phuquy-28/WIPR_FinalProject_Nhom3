using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPR_FinalProject_Nhom3
{
    internal class PARKPLACE
        
    {
        MY_DB mydb = new MY_DB();
        public bool addParkPlace (string idParkPlace, string typeOfCar)
        {
            SqlCommand command = new SqlCommand("insert into parkplace (idparkplace, typeofcar, state) values (@id, @type, @state)", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.NVarChar).Value = idParkPlace;
            command.Parameters.Add("type", SqlDbType.NVarChar).Value = typeOfCar;
            command.Parameters.Add("state", SqlDbType.NVarChar).Value = "empty";

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

        public bool IdParkPlaceIsExist(string idParkPlace)
        {
            SqlCommand command = new SqlCommand("select * from parkplace where idparkplace = @id", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.NVarChar).Value = idParkPlace;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                return true;
            }
            return false;

        }

        public bool deleteEmptyParkPlace(string idParkPlace)
        {
            SqlCommand command = new SqlCommand("delete from parkplace where IdParkPlace = @id and State = 'empty'", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.NVarChar).Value = idParkPlace;

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

        public DataTable getEmptyParkPlace()
        {
            SqlCommand command = new SqlCommand("select IdParkPlace, TypeOfCar, State from ParkPlace where State = 'empty'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getParkByTypeOfVehicle(string typeOfVehicle)
        {
            SqlCommand command = new SqlCommand("select * from ParkPlace where TypeOfCar = @type", mydb.getConnection);
            command.Parameters.Add("type", SqlDbType.NVarChar).Value = typeOfVehicle;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public int getNumOfParkPlaceByType(string type)
        {
            SqlCommand command = new SqlCommand ("select count(*) from parkplace where TypeOfCar = @type", mydb.getConnection);
            command.Parameters.Add("type", SqlDbType.NVarChar).Value = type;

            mydb.openConnection();

            int count = 0;

            count = (int)command.ExecuteScalar();

            mydb.closeConnection();

            return count;
        }

        public int getNumOfEmptyParkPlaceByType(string type)
        {
            SqlCommand command = new SqlCommand("select count(*) from parkplace where TypeOfCar = @type and state = 'empty'", mydb.getConnection);
            command.Parameters.Add("type", SqlDbType.NVarChar).Value = type;

            mydb.openConnection();

            int count = 0;

            count = (int)command.ExecuteScalar();

            mydb.closeConnection();

            return count;
        }

    }
}
