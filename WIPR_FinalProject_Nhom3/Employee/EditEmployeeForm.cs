using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WIPR_FinalProject_Nhom3
{
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectEmployeeForm selectEmployeeF = new SelectEmployeeForm();
            selectEmployeeF.ShowDialog();

            try
            {

                int employeeid = Convert.ToInt32(selectEmployeeF.dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString());

                EMPLOYEE employee = new EMPLOYEE();
                DataTable table = employee.getEmployeeById(employeeid);

                textBoxIdEmployee.Text = table.Rows[0]["IdEmployee"].ToString();
                textBoxFname.Text = table.Rows[0]["fname"].ToString();
                textBoxLname.Text = table.Rows[0]["lname"].ToString();
                comboBoxGroup.SelectedValue = table.Rows[0]["group_id"];
                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxEmail.Text = table.Rows[0]["email"].ToString();
                richTextBoxAddress.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxEmployee.Image = Image.FromStream(picture);

            }
            catch (Exception)
            {
                MessageBox.Show("Error!", "Select Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        GROUP group = new GROUP();
        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            comboBoxGroup.DataSource = group.getGroups(GLOBALS.GlobalUserId);
            comboBoxGroup.ValueMember = "GroupId";
            comboBoxGroup.DisplayMember = "Name";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EMPLOYEE employee = new EMPLOYEE();

            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            string phone = textBoxPhone.Text;
            string address = richTextBoxAddress.Text;
            string email = textBoxEmail.Text;

            try
            {
                int id = Convert.ToInt32(textBoxIdEmployee.Text);

                int groupid = (int)comboBoxGroup.SelectedValue;

                MemoryStream pic = new MemoryStream();
                pictureBoxEmployee.Image.Save(pic, pictureBoxEmployee.Image.RawFormat);

                if (employee.updateEmployee(id, fname, lname, groupid, phone, email, address, pic))
                {
                    MessageBox.Show("Employee Information Updated", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxIdEmployee.Text = "";
                    textBoxFname.Text = "";
                    textBoxLname.Text = "";
                    textBoxPhone.Text = "";
                    textBoxEmail.Text = "";
                    richTextBoxAddress.Text = "";
                    pictureBoxEmployee.Image = null;
                    comboBoxGroup.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show("Error!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee Information Not Updated", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
