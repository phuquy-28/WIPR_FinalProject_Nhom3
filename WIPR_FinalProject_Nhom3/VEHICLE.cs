using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPR_FinalProject_Nhom3
{
    internal class VEHICLE
    {
        MY_DB mydb = new MY_DB();
        public DataTable getParkPlaceEmpty(string typeVehicle)
        {
            SqlCommand command = new SqlCommand("select * from ParkPlace where state = 'empty' and TypeOfCar = @type", mydb.getConnection);
            command.Parameters.Add("type", SqlDbType.NVarChar).Value = typeVehicle;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool IdVehicleIsExist(string idVehicle)
        {
            SqlCommand command = new SqlCommand("select * from vehicle where IdVehicle = @id", mydb.getConnection);
            command.Parameters.Add("type", SqlDbType.NVarChar).Value = idVehicle;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool insertVehicle(string type, string idCard, DateTime timeIn, MemoryStream pic1, MemoryStream pic2, string plate = "", string brand = "")
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            if(type.ToLower() == "car")
            {
                command.CommandText = "insert into Vehicle (IdVehicle, Type, TimeIn, LisencePlate, BrandName, LicensePlatePicture, BrandPicture) " +
                    "values (@id, @type, @time, @plate, @brand, @platePic, @brandPic)";
                command.Parameters.Add("id", SqlDbType.NVarChar).Value = idCard;
                command.Parameters.Add("type", SqlDbType.NVarChar).Value = type;
                command.Parameters.Add("time", SqlDbType.DateTime).Value = timeIn;
                command.Parameters.Add("plate", SqlDbType.NVarChar).Value = plate;
                command.Parameters.Add("brand", SqlDbType.NVarChar).Value = brand;
                command.Parameters.Add("platePic", SqlDbType.Image).Value = pic1.ToArray();
                command.Parameters.Add("brandPic", SqlDbType.Image).Value = pic2.ToArray();
                mydb.openConnection();
                if(command.ExecuteNonQuery() == 1)
                {
                    mydb.closeConnection();
                    return true;
                }
            }
            else if (type.ToLower() == "motor")
            {
                command.CommandText = "insert into Vehicle (IdVehicle, Type, TimeIn, LisencePlate, BrandName, LicensePlatePicture, CustomerPicture) " +
                    "values (@id, @type, @time, @plate, @brand, @platePic, @cusPic)";
                command.Parameters.Add("id", SqlDbType.NVarChar).Value = idCard;
                command.Parameters.Add("type", SqlDbType.NVarChar).Value = type;
                command.Parameters.Add("time", SqlDbType.DateTime).Value = timeIn;
                command.Parameters.Add("plate", SqlDbType.NVarChar).Value = plate;
                command.Parameters.Add("brand", SqlDbType.NVarChar).Value = brand;
                command.Parameters.Add("platePic", SqlDbType.Image).Value = pic1.ToArray();
                command.Parameters.Add("cusPic", SqlDbType.Image).Value = pic2.ToArray();
                mydb.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    mydb.closeConnection();
                    return true;
                }
            }
            else if (type.ToLower() == "bicycle")
            {
                command.CommandText = "insert into Vehicle (IdVehicle, Type, TimeIn, VehiclePicture, CustomerPicture) " +
                    "values (@id, @type, @time, @vehiclePic, @cusPic)";
                command.Parameters.Add("id", SqlDbType.NVarChar).Value = idCard;
                command.Parameters.Add("type", SqlDbType.NVarChar).Value = type;
                command.Parameters.Add("time", SqlDbType.DateTime).Value = timeIn;
                command.Parameters.Add("vehiclePic", SqlDbType.Image).Value = pic1.ToArray();
                command.Parameters.Add("cusPic", SqlDbType.Image).Value = pic2.ToArray();
                mydb.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    mydb.closeConnection();
                    return true;
                }
            }
            return false;
        }

        public bool editVehicle(string type, string idCard, DateTime timeIn, MemoryStream pic1, MemoryStream pic2, string plate = "", string brand = "")
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            if (type.ToLower() == "car")
            {
                command.CommandText = "update Vehicle set Type = @type, TimeIn = @time, LisencePlate = @plate, BrandName = @brand, " +
                    "LicensePlatePicture = @platePic, BrandPicture = @brandPic " +
                    "where IdVehicle = @id";
                command.Parameters.Add("id", SqlDbType.NVarChar).Value = idCard;
                command.Parameters.Add("type", SqlDbType.NVarChar).Value = type;
                command.Parameters.Add("time", SqlDbType.DateTime).Value = timeIn;
                command.Parameters.Add("plate", SqlDbType.NVarChar).Value = plate;
                command.Parameters.Add("brand", SqlDbType.NVarChar).Value = brand;
                command.Parameters.Add("platePic", SqlDbType.Image).Value = pic1.ToArray();
                command.Parameters.Add("brandPic", SqlDbType.Image).Value = pic2.ToArray();
                mydb.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    mydb.closeConnection();
                    return true;
                }
            }
            else if (type.ToLower() == "motor")
            {
                command.CommandText = "update Vehicle set Type = @type, TimeIn = @time, LisencePlate = @plate, CustomerPicture = @cusPic" +
                    "where IdVehicle = @id";
                command.Parameters.Add("id", SqlDbType.NVarChar).Value = idCard;
                command.Parameters.Add("type", SqlDbType.NVarChar).Value = type;
                command.Parameters.Add("time", SqlDbType.DateTime).Value = timeIn;
                command.Parameters.Add("plate", SqlDbType.NVarChar).Value = plate;
                command.Parameters.Add("brand", SqlDbType.NVarChar).Value = brand;
                command.Parameters.Add("platePic", SqlDbType.Image).Value = pic1.ToArray();
                command.Parameters.Add("cusPic", SqlDbType.Image).Value = pic2.ToArray();
                mydb.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    mydb.closeConnection();
                    return true;
                }
            }
            else if (type.ToLower() == "bicycle")
            {
                command.CommandText = "update Vehicle set Type = @type, TimeIn = @time VehiclePicture = @vehiclePic, CustomerPicture = @cusPic" +
                    "where IdVehicle = @id";
                command.Parameters.Add("id", SqlDbType.NVarChar).Value = idCard;
                command.Parameters.Add("type", SqlDbType.NVarChar).Value = type;
                command.Parameters.Add("time", SqlDbType.DateTime).Value = timeIn;
                command.Parameters.Add("vehiclePic", SqlDbType.Image).Value = pic1.ToArray();
                command.Parameters.Add("cusPic", SqlDbType.Image).Value = pic2.ToArray();
                mydb.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    mydb.closeConnection();
                    return true;
                }
            }
            return false;
        }

        public bool deleteVehicle(string id)
        {
            SqlCommand command = new SqlCommand("delete from Vehicle where IdVehicle = @id", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.NVarChar).Value = id;
            mydb.openConnection();
            if(command.ExecuteNonQuery() == 1)
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

        public DataTable findById(string id)
        {
            SqlCommand command = new SqlCommand("select * from Vehicle where IdVehicle = @id", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable findByPlate(string plate)
        {
            SqlCommand command = new SqlCommand("select * from Vehicle where LisencePlate = @plate", mydb.getConnection);
            command.Parameters.Add("plate", SqlDbType.NVarChar).Value = plate;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
