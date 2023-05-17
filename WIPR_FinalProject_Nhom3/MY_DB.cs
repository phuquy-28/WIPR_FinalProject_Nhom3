using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPR_FinalProject_Nhom3
{
    internal class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CMFK1I\SQLEXPRESS;Initial Catalog=PARKING_LOT;Integrated Security=True");
        //Data Source=DESKTOP-2CMFK1I\SQLEXPRESS;Initial Catalog=PARKING_LOT;Integrated Security=True

        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }


        // open the connection
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }

    }
}
