using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPR_FinalProject_Nhom3
{
    public class EMPLOYEE
    {
        MY_DB mydb = new MY_DB();

        public bool insertEmployee(int id, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture, int userid)
        {
            SqlCommand cmd = new SqlCommand("insert into Employee values (@id, @fn, @ln, @grp, @phone, @mail, @adrs, @pic, @uid)", mydb.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
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
        public bool updateEmployee(int id, string fname, string lname, int groupid, string phone, string email, string address, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("update Employee set fname = @fn, lname = @ln, group_id = @grp, phone = @phn, email = @mail, address = @add, picture = @pic where IdEmployee = @id", mydb.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            cmd.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
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
        public bool deleteEmployee(int employeeid)
        {
            SqlCommand command = new SqlCommand("delete from Employee where IdEmployee = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = employeeid;

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
        public DataTable getEmployees()
        {
            SqlCommand command = new SqlCommand("select IdEmployee, fname, lname, phone, email from Employee", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getEmployeeById(int employeeid)
        {
            SqlCommand command = new SqlCommand("select IdEmployee, fname, lname, group_id, phone, email, address, picture from Employee where IdEmployee = @id ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = employeeid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
