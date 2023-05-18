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
    public partial class PedingAccountForm : Form
    {
        public PedingAccountForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        USER user = new USER();
        private void PedingAccountForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from pending", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridViewAccList.DataSource = table;
            dataGridViewAccList.Columns["id"].HeaderText = "Id";
            dataGridViewAccList.Columns["username"].HeaderText = "Username";
            dataGridViewAccList.Columns["password"].HeaderText = "Password";
            dataGridViewAccList.Columns["phone"].HeaderText = "Phone";
            dataGridViewAccList.Columns["email"].HeaderText = "Email";
            dataGridViewAccList.Columns["role_id"].HeaderText = "Role Id";
            dataGridViewAccList.ClearSelection();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewAccList.CurrentRow.Cells["id"].Value.ToString());
            string username = dataGridViewAccList.CurrentRow.Cells["username"].Value.ToString();
            string passwork = dataGridViewAccList.CurrentRow.Cells["password"].Value.ToString();
            string phone = dataGridViewAccList.CurrentRow.Cells["phone"].Value.ToString();
            string email = dataGridViewAccList.CurrentRow.Cells["email"].Value.ToString();
            int role = Convert.ToInt32(dataGridViewAccList.CurrentRow.Cells["role_id"].Value.ToString());
            if(!user.IdOrUsernameIsExistLogin(id, username))
            {
                if(user.insertLogin(id, username, passwork, phone, email, role))
                {
                    user.deletePending(username);
                    MessageBox.Show("Adding successfully", "Pending Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PedingAccountForm_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Adding fail", "Pending Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Id or username has already exist in login table", "Pending Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string username = dataGridViewAccList.CurrentRow.Cells["username"].Value.ToString();
            if (user.deletePending(username))
            {
                MessageBox.Show("Deleting successfully", "Pending Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PedingAccountForm_Load(null, null);
            }
            else
            {
                MessageBox.Show("Deleting fail", "Pending Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
