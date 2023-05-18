using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIPR_FinalProject_Nhom3
{
    internal class INCOME
    {
        MY_DB mydb = new MY_DB();
        public DataTable getListBillToday()
        {
            SqlCommand command = new SqlCommand("SELECT Id, idvehicle, typeofvehicle, lisenceplate, total, timein, timeout, description " +
                "FROM bill " +
                "WHERE state = 'finished' " +
                "AND CONVERT(varchar(20), timeout, 101) = CONVERT(varchar(20), @today, 101)", mydb.getConnection);
            command.Parameters.Add("@today", SqlDbType.DateTime).Value = DateTime.Now.Date;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getListContractToday()
        {
            SqlCommand command = new SqlCommand("SELECT * " +
                "FROM contract " +
                "WHERE CONVERT(varchar(20), datecreate, 101) = CONVERT(varchar(20), @today, 101)", mydb.getConnection);
            command.Parameters.Add("@today", SqlDbType.DateTime).Value = DateTime.Now.Date;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getListBillUseRange(DateTime start, DateTime end)
        {
            SqlCommand command = new SqlCommand("SELECT Id, idvehicle, typeofvehicle, lisenceplate, total, timein, timeout, description " +
                "FROM bill " +
                "WHERE state = 'finished' AND " +
                "CONVERT(date, timeout) BETWEEN @startDate AND @endDate", mydb.getConnection);
            command.Parameters.Add("startDate", SqlDbType.DateTime).Value = start.Date;
            command.Parameters.Add("endDate", SqlDbType.DateTime).Value = end.Date;
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
    }
}
