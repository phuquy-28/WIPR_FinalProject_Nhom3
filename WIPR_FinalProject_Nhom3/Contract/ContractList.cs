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
    public partial class ContractList : Form
    {
        public ContractList()
        {
            InitializeComponent();
        }
        CONTRACT contract = new CONTRACT();
        MY_DB mydb = new MY_DB();

        private void ContractList_Load(object sender, EventArgs e)
        {
            dataGridViewContractList.DataSource = contract.getListContract();
            dataGridViewContractList.AllowUserToAddRows = false;
            dataGridViewContractList.Columns["IdContract"].HeaderText = "Id Contract";
            dataGridViewContractList.Columns["IdCustomer"].HeaderText = "Id Customer";
            dataGridViewContractList.Columns["CustomerPhone"].HeaderText = "Customer Phone";
            dataGridViewContractList.Columns["TypeOfContract"].HeaderText = "Type Of Contract";
            dataGridViewContractList.Columns["DateCreate"].HeaderText = "Date Created";
            dataGridViewContractList.Columns["Total"].HeaderText = "Total";
            dataGridViewContractList.Columns["description"].HeaderText = "Description";
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            DateTime startTime = dateTimePickerStart.Value;
            DateTime endTime = dateTimePickerEnd.Value;
            DataTable table = contract.getListContractUseRange(startTime, endTime);
            dataGridViewContractList.DataSource = table;
            dataGridViewContractList.AllowUserToAddRows = false;
            dataGridViewContractList.Columns["IdContract"].HeaderText = "Id Contract";
            dataGridViewContractList.Columns["IdCustomer"].HeaderText = "Id Customer";
            dataGridViewContractList.Columns["CustomerPhone"].HeaderText = "Customer Phone";
            dataGridViewContractList.Columns["TypeOfContract"].HeaderText = "Type Of Contract";
            dataGridViewContractList.Columns["DateCreate"].HeaderText = "Date Created";
            dataGridViewContractList.Columns["Total"].HeaderText = "Total";
            dataGridViewContractList.Columns["description"].HeaderText = "Description";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ContractList_Load(null, null);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string str = textBoxString.Text.ToString();
            SqlCommand cmd = new SqlCommand("SELECT * FROM contract WHERE CONCAT (idcontract, customerphone) LIKE '%" + str + "%'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewContractList.DataSource = dt;
            dataGridViewContractList.AllowUserToAddRows = false;
            dataGridViewContractList.Columns["IdContract"].HeaderText = "Id Contract";
            dataGridViewContractList.Columns["IdCustomer"].HeaderText = "Id Customer";
            dataGridViewContractList.Columns["CustomerPhone"].HeaderText = "Customer Phone";
            dataGridViewContractList.Columns["TypeOfContract"].HeaderText = "Type Of Contract";
            dataGridViewContractList.Columns["DateCreate"].HeaderText = "Date Created";
            dataGridViewContractList.Columns["Total"].HeaderText = "Total";
            dataGridViewContractList.Columns["description"].HeaderText = "Description";
        }

        private void dataGridViewContractList_DoubleClick(object sender, EventArgs e)
        {
            DetailContractForm detailFrm = new DetailContractForm();
            detailFrm.idContract = dataGridViewContractList.CurrentRow.Cells["IdContract"].Value.ToString();
            detailFrm.ShowDialog();
        }
    }
}
