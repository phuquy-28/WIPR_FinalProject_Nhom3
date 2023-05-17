using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPR_FinalProject_Nhom3
{
    internal class CONTRACT
    {
        MY_DB mydb = new MY_DB();

        public bool IdContractIsExist(string idContract)
        {
            SqlCommand command = new SqlCommand("select * from contract where idcontract = @id", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.NVarChar).Value = idContract;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool addContract(string idContract, string customerId, string customerPhone, string typeOfContract, DateTime dateCreate, float total, string description = "")
        {
            SqlCommand command = new SqlCommand("insert into contract " +
                "values (@idcon, @idcus, @phone, @type, @date, @total, @des)", mydb.getConnection);
            command.Parameters.Add("idcon", SqlDbType.NVarChar).Value = idContract;
            command.Parameters.Add("idcus", SqlDbType.NVarChar).Value = customerId;
            command.Parameters.Add("phone", SqlDbType.NVarChar).Value = customerPhone;
            command.Parameters.Add("type", SqlDbType.NVarChar).Value = typeOfContract;
            command.Parameters.Add("date", SqlDbType.DateTime).Value = dateCreate;
            command.Parameters.Add("total", SqlDbType.Float).Value = total;
            command.Parameters.Add("des", SqlDbType.NVarChar).Value = description;
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

        public bool addCustomer(string customerId, string customerName, string customerPhone)
        {
            SqlCommand command = new SqlCommand("insert into customer " +
                "values (@idcus, @name, @phone)", mydb.getConnection);
            command.Parameters.Add("idcus", SqlDbType.NVarChar).Value = customerId;
            command.Parameters.Add("name", SqlDbType.NVarChar).Value = customerName;
            command.Parameters.Add("phone", SqlDbType.NVarChar).Value = customerPhone;
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

        public bool IdCustomerIsExist(string CustomerId)
        {
            SqlCommand command = new SqlCommand("select * from customer where idcustomer = @id", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.NVarChar).Value = CustomerId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable getVehicleRent()
        {
            SqlCommand command = new SqlCommand("select * from vehicle where idparkplace <> 'null'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getVehicleForRen()
        {
            SqlCommand command = new SqlCommand("select * from vehicle", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool addDetailContract(string idCon, string idCus, string typeVehi, string license, DateTime start, DateTime end, string description)
        {
            SqlCommand command = new SqlCommand("insert into detailcontract values (@idcon, @idcus, @typevehi, @plate, @start, @end, @des)", mydb.getConnection);
            command.Parameters.Add("idcon", SqlDbType.NVarChar).Value = idCon;
            command.Parameters.Add("idcus", SqlDbType.NVarChar).Value = idCus;
            command.Parameters.Add("typevehi", SqlDbType.NVarChar).Value = typeVehi;
            command.Parameters.Add("plate", SqlDbType.NVarChar).Value = license;
            command.Parameters.Add("start", SqlDbType.DateTime).Value = start;
            command.Parameters.Add("end", SqlDbType.DateTime).Value = end;
            command.Parameters.Add("des", SqlDbType.NVarChar).Value = description;

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

        public DataTable getSelectContract()
        {
            SqlCommand command = new SqlCommand("select idcontract, idcustomer, typeofcontract from contract", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable findContractByID(string contractId)
        {
            SqlCommand command = new SqlCommand("SELECT con.TypeOfContract, con.IdContract, cus.IdCustomer, cus.Name, " +
                "cus.PhoneNumber, con.DateCreate, con.Total, con.description " +
                "FROM dbo.Contract con JOIN dbo.Customer cus ON con.IdCustomer = cus.IdCustomer " +
                "WHERE con.IdContract = @idcon ", mydb.getConnection);
            command.Parameters.Add("idcon", SqlDbType.NVarChar).Value = contractId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateContract(string contractId, string cusid, string cusname, string phone, string type, DateTime date, float total, string des)
        {
            SqlCommand command = new SqlCommand("update contract set customerphone = @phone, typeofcontract = @type, datecreate = @date, " +
                "total = @total, description = @des where idcontract = @idcon", mydb.getConnection);
            command.Parameters.Add("idcon", SqlDbType.NVarChar).Value = contractId;
            command.Parameters.Add("phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("type", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("date", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("total", SqlDbType.Float).Value = total;
            command.Parameters.Add("des", SqlDbType.NVarChar).Value = des;
            mydb.openConnection();

            SqlCommand sqlCommand = new SqlCommand("update customer set name = @name, phonenumber = @phone", mydb.getConnection);
            sqlCommand.Parameters.Add("name", SqlDbType.NVarChar).Value = cusname;
            sqlCommand.Parameters.Add("phone", SqlDbType.NVarChar).Value = phone;
            sqlCommand.ExecuteNonQuery();

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

        public bool deleteContract(string contractId)
        {
            SqlCommand command = new SqlCommand("delete from contract where idcontract = @idcon", mydb.getConnection);
            command.Parameters.Add("idcon", SqlDbType.NVarChar).Value = contractId;
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

        public DataTable getListContract()
        {
            SqlCommand command = new SqlCommand("select * from contract", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getListContractUseRange(DateTime start, DateTime end)
        {
            SqlCommand command = new SqlCommand("SELECT * " +
                "FROM contract " +
                "WHERE CONVERT(date, datecreate) BETWEEN @startDate AND @endDate", mydb.getConnection);
            command.Parameters.Add("startDate", SqlDbType.DateTime).Value = start.Date;
            command.Parameters.Add("endDate", SqlDbType.DateTime).Value = end.Date;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public DataTable getDetailContractByID(string idcon)
        {
            SqlCommand command = new SqlCommand("select * from detailcontract where idcontract = @id", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.NVarChar).Value = idcon;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
