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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxIdEmployee.Text);
                string fname = textBoxFname.Text;
                string lname = textBoxLname.Text;
                string phone = textBoxPhone.Text;
                string address = richTextBoxAddress.Text;
                string email = textBoxEmail.Text;
                int userid = GLOBALS.GlobalUserId;

                int groupid = (int)comboBoxGroup.SelectedValue;


                MemoryStream pic = new MemoryStream();
                pictureBoxEmployee.Image.Save(pic, pictureBoxEmployee.Image.RawFormat);

                EMPLOYEE employee = new EMPLOYEE();

                //if (contact.checkID(Convert.ToInt32(txtContactId.Text)))
                //{
                if (employee.insertEmployee(id, fname, lname, groupid, phone, email, address, pic, userid))
                {
                    MessageBox.Show("New Employee Added", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Error", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //}
                //else
                //{
                //    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("One Or More Fields Are Empty!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        GROUP group = new GROUP();
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            comboBoxGroup.DataSource = group.getGroups(GLOBALS.GlobalUserId);
            comboBoxGroup.ValueMember = "GroupId";
            comboBoxGroup.DisplayMember = "Name";
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxEmployee.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
