using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPR_FinalProject_Nhom3
{
    internal class USER
    {
        MY_DB mydb = new MY_DB();

        public bool usernameStaffExist(string username)
        {
            SqlCommand command = new SqlCommand("select * from staffAccount where username = @uname", mydb.getConnection);
            command.Parameters.Add("uname", SqlDbType.NVarChar).Value = username;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool insertStaff(string username, string password, string email, string rol = "Staff")
        {
            SqlCommand command = new SqlCommand("insert into staffAccount (username, password, email, rol) values (@uname, @pass, @mail, @rol)", mydb.getConnection);
            command.Parameters.Add("uname", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("pass", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("mail", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("rol", SqlDbType.NVarChar).Value = rol;

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
    }
}
