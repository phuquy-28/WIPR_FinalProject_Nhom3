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

        public bool IdOrUsernameIsExistPeding(int id, string username)
        {
            SqlCommand command = new SqlCommand("select * from Pending where id = @id or username = @uname", mydb.getConnection);
            command.Parameters.Add("uname", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool IdOrUsernameIsExistLogin(int id, string username)
        {
            SqlCommand command = new SqlCommand("select * from Login where id = @id or username = @uname", mydb.getConnection);
            command.Parameters.Add("uname", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool insertPending(int id, string username, string password, string phone, string email, int rol_id)
        {
            SqlCommand command = new SqlCommand("insert into Pending values (@id, @uname, @pass, @phone, @mail, @rol)", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.Int).Value = id;
            command.Parameters.Add("uname", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("pass", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("mail", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("rol", SqlDbType.Int).Value = rol_id;

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
        
        public bool insertLogin(int id, string username, string password, string phone, string email, int rol_id)
        {
            SqlCommand command = new SqlCommand("insert into Login values (@id, @uname, @pass, @phone, @mail, @rol)", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.Int).Value = id;
            command.Parameters.Add("uname", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("pass", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("mail", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("rol", SqlDbType.Int).Value = rol_id;

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

        public bool deletePending(string username)
        {
            SqlCommand command = new SqlCommand("delete from pending where username = @uname", mydb.getConnection);
            command.Parameters.Add("uname", SqlDbType.NVarChar).Value = username;

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
