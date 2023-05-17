using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPR_FinalProject_Nhom3
{
    public class GROUP
    {
        MY_DB mydb = new MY_DB();

        public DataTable getGroups(int userid)
        {
            SqlCommand command = new SqlCommand("Select * from mygroup where manage_id = @uid", mydb.getConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}
