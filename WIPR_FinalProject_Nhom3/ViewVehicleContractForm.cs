using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR_FinalProject_Nhom3
{
    public partial class ViewVehicleContractForm : Form
    {
        public ViewVehicleContractForm()
        {
            InitializeComponent();
        }
        public string idVehicle { get; set; }
        MY_DB mydb = new MY_DB();

        private void ViewVehicleContractForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT  dc.IdVehicle, ct.* " +
                "FROM dbo.Vehicle vehi JOIN dbo.DetailContract dc ON vehi.IdVehicle = dc.IdVehicle " +
                "JOIN dbo.Contract ct ON ct.IdContract = dc.IdContract " +
                "WHERE dc.IdVehicle = @idvehi", mydb.getConnection);
            command.Parameters.Add("idvehi", SqlDbType.NVarChar).Value = idVehicle;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridViewVehicleContract.DataSource = dt;
            dataGridViewVehicleContract.Columns["description"].HeaderText = "Description";
            dataGridViewVehicleContract.AllowUserToAddRows = false;
        }
    }
}
