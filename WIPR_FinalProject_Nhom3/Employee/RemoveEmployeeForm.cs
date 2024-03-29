﻿using System;
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
    public partial class RemoveEmployeeForm : Form
    {
        public RemoveEmployeeForm()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            EMPLOYEE employee = new EMPLOYEE();
            try
            {
                int employeeid = Convert.ToInt32(dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString());
                if (employee.deleteEmployee(employeeid))
                {
                    MessageBox.Show("Employee Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveEmployeeForm_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        EMPLOYEE employee = new EMPLOYEE();
        private void RemoveEmployeeForm_Load(object sender, EventArgs e)
        {
            dataGridViewEmployee.DataSource = employee.getEmployees();
            dataGridViewEmployee.AllowUserToAddRows = false;
            dataGridViewEmployee.ReadOnly = true;
            dataGridViewEmployee.Columns[0].HeaderText = "ID Employee";
            dataGridViewEmployee.Columns[1].HeaderText = "First Name";
            dataGridViewEmployee.Columns[2].HeaderText = "Last Name";
            dataGridViewEmployee.Columns[3].HeaderText = "Phone";
            dataGridViewEmployee.Columns[4].HeaderText = "Email";
        }
    }
}
