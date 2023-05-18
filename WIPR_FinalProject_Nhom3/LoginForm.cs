using Microsoft.Office.Interop.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using DataTable = System.Data.DataTable;

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
            //if (radioButtonStaff.Checked)
            //{

            //    this.DialogResult = DialogResult.OK;
            //}
            //else
            //{

            //    this.DialogResult = DialogResult.OK;
            //}
            try
            {
                if (radioButtonStaff.Checked == true) GLOBALS.role = 1; //staff
                else if (radioButtonManager.Checked == true) GLOBALS.role = 2;  //manager
                else GLOBALS.role = 0;  //admin
                //
                MY_DB db = new MY_DB();

                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable table = new DataTable();

                //staff
                SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE username = @User AND password = @Pass and role_id = 1", db.getConnection);
                if (radioButtonManager.Checked)
                {
                    //manager
                    command = new SqlCommand("SELECT * FROM Login WHERE username = @User AND password = @Pass and role_id = 2", db.getConnection);
                }
                else if (radioButtonAdmin.Checked)
                {
                    //admin
                    command = new SqlCommand("SELECT * FROM Login WHERE username = @User AND password = @Pass and role_id = 0", db.getConnection);
                }

                if (textboxUsername.Text == "" && textboxPassword.Text == "")
                {
                    Exception nullUserAndPass = new Exception("Please enter Username and Password!");
                    throw nullUserAndPass;
                }

                if (textboxUsername.Text == "")
                {
                    Exception nullUser = new Exception("Please enter Username!");
                    throw nullUser;
                }

                if (textboxPassword.Text == "")
                {
                    Exception nullPass = new Exception("Please enter Password!");
                    throw nullPass;
                }

                command.Parameters.Add("@User", SqlDbType.NVarChar).Value = textboxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = textboxPassword.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    int userid = Convert.ToInt16(table.Rows[0][0].ToString());
                    GLOBALS.SetGlobalUserId(userid);

                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Ok, next time will be go to Main Menu of App");
                    MessageBox.Show($"userid {userid},  role_id {GLOBALS.role}");
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelNewUser_Click(object sender, EventArgs e)
        {
            if (radioButtonStaff.Checked)
            {
                StaffRegisterForm staffRegisterFrm = new StaffRegisterForm();
                staffRegisterFrm.role_id = 1;   //1 - staff
                staffRegisterFrm.labeltype.Text = "STAFF ACCOUNT";
                staffRegisterFrm.ShowDialog();
            }
            else if (radioButtonManager.Checked)
            {
                StaffRegisterForm staffRegisterFrm = new StaffRegisterForm();
                staffRegisterFrm.role_id = 2;   //2 - manager
                staffRegisterFrm.labeltype.Text = "MANAGER ACCOUNT";
                staffRegisterFrm.ShowDialog();
            }
            
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

        private void labelForgetPassWord_Click(object sender, EventArgs e)
        {
            if (radioButtonStaff.Checked)
            {
                RecoveryPasswordForm recoveryPasswordForm = new RecoveryPasswordForm();
                recoveryPasswordForm.ShowDialog();
            }
            else if (radioButtonManager.Checked)
            {
                RecoveryPasswordForm recoveryPasswordForm = new RecoveryPasswordForm();
                recoveryPasswordForm.labelTypeAccount.Text = "MANAGER ACCOUNT";
                recoveryPasswordForm.ShowDialog();
            }
        }
    }
}
