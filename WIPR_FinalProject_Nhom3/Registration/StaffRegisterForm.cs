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
        public int role_id { get; set; }

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
                int id = Convert.ToInt32(textBoxId.Text.ToString());
                string username = textBoxUsername.Text.ToString();
                string password = textBoxPassword.Text.ToString();
                string phone = textBoxPhone.Text.ToString();
                string email = textBoxEmail.Text.ToString();
                int role = role_id;
                if (!user.IdOrUsernameIsExistPeding(id, username))
                {
                    if (user.insertPending(id, username, password, phone, email, role))
                    {
                        MessageBox.Show("Adding succesfully", "Register Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //textBoxUsername.Clear();
                        //textBoxPassword.Clear();
                        //textBoxEmail.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Adding fail", "Register Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The username or id has already exist", "Register Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Staff Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffRegisterForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(role_id.ToString());
        }
    }
}
