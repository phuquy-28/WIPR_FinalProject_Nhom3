using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR_FinalProject_Nhom3
{
    public partial class StaffRegisterForm : Form
    {
        public StaffRegisterForm()
        {
            InitializeComponent();
            this.AcceptButton = buttonRegister;
        }
        USER user = new USER();

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked == true)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!(new EmailAddressAttribute().IsValid(textBoxEmail.Text)))
            {
                MessageBox.Show("Email Address is not valid", "Email Address", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxEmail.Text = "";
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUsername.Text.ToString();
                string password = textBoxPassword.Text.ToString();
                string email = textBoxEmail.Text.ToString();
                if (!user.usernameStaffExist(username))
                {
                    if (user.insertStaff(username, password, email))
                    {
                        MessageBox.Show("Adding succesfully", "Staff Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                        textBoxEmail.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Adding fail", "Staff Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The username has already exist", "Staff Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Staff Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
