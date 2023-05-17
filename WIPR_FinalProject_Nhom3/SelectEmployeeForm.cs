using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR_FinalProject_Nhom3
{
    public partial class SelectEmployeeForm : Form
    {
        public SelectEmployeeForm()
        {
            InitializeComponent();
        }
        EMPLOYEE employee = new EMPLOYEE();
        private void SelectEmployeeForm_Load(object sender, EventArgs e)
        {
            dataGridViewEmployee.DataSource = employee.getEmployees();
            //
            dataGridViewEmployee.AllowUserToAddRows = false;
            dataGridViewEmployee.ReadOnly = true;
            dataGridViewEmployee.Columns[0].HeaderText = "ID Employee";
            dataGridViewEmployee.Columns[1].HeaderText = "First Name";
            dataGridViewEmployee.Columns[2].HeaderText = "Last Name";
            dataGridViewEmployee.Columns[3].HeaderText = "Phone";
            dataGridViewEmployee.Columns[4].HeaderText = "Email";
        }

        private void dataGridViewEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
