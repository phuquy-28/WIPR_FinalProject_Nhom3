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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = buttonLogin;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (radioButtonStaff.Checked)
            {

                this.DialogResult = DialogResult.OK;
            }
            else
            {

                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelNewUser_Click(object sender, EventArgs e)
        {

        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                textboxPassword.PasswordChar = '\0';
            }
            else
            {
                textboxPassword.PasswordChar = '●';
            }
        }
    }
}
