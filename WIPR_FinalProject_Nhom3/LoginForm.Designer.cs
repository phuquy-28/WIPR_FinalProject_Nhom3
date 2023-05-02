namespace WIPR_FinalProject_Nhom3
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelNewUser = new System.Windows.Forms.Label();
            this.checkboxShowPass = new System.Windows.Forms.CheckBox();
            this.radioButtonStaff = new System.Windows.Forms.RadioButton();
            this.radioButtonManager = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // textboxUsername
            // 
            this.textboxUsername.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUsername.Location = new System.Drawing.Point(443, 119);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(202, 25);
            this.textboxUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // textboxPassword
            // 
            this.textboxPassword.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPassword.Location = new System.Drawing.Point(443, 151);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '●';
            this.textboxPassword.Size = new System.Drawing.Size(202, 25);
            this.textboxPassword.TabIndex = 6;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonLogin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(412, 247);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(96, 30);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonClose.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(540, 247);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 30);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelNewUser
            // 
            this.labelNewUser.AutoSize = true;
            this.labelNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNewUser.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewUser.Location = new System.Drawing.Point(318, 330);
            this.labelNewUser.Name = "labelNewUser";
            this.labelNewUser.Size = new System.Drawing.Size(72, 18);
            this.labelNewUser.TabIndex = 11;
            this.labelNewUser.Text = "New user?";
            this.labelNewUser.Click += new System.EventHandler(this.labelNewUser_Click);
            // 
            // checkboxShowPass
            // 
            this.checkboxShowPass.AutoSize = true;
            this.checkboxShowPass.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxShowPass.Location = new System.Drawing.Point(443, 184);
            this.checkboxShowPass.Name = "checkboxShowPass";
            this.checkboxShowPass.Size = new System.Drawing.Size(94, 18);
            this.checkboxShowPass.TabIndex = 8;
            this.checkboxShowPass.Text = "Show Password";
            this.checkboxShowPass.UseVisualStyleBackColor = true;
            this.checkboxShowPass.CheckedChanged += new System.EventHandler(this.checkboxShowPass_CheckedChanged);
            // 
            // radioButtonStaff
            // 
            this.radioButtonStaff.AutoSize = true;
            this.radioButtonStaff.Checked = true;
            this.radioButtonStaff.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStaff.Location = new System.Drawing.Point(443, 209);
            this.radioButtonStaff.Name = "radioButtonStaff";
            this.radioButtonStaff.Size = new System.Drawing.Size(52, 19);
            this.radioButtonStaff.TabIndex = 12;
            this.radioButtonStaff.Text = "Staff";
            this.radioButtonStaff.UseVisualStyleBackColor = true;
            // 
            // radioButtonManager
            // 
            this.radioButtonManager.AutoSize = true;
            this.radioButtonManager.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonManager.Location = new System.Drawing.Point(534, 209);
            this.radioButtonManager.Name = "radioButtonManager";
            this.radioButtonManager.Size = new System.Drawing.Size(71, 19);
            this.radioButtonManager.TabIndex = 13;
            this.radioButtonManager.Text = "Manager";
            this.radioButtonManager.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 355);
            this.Controls.Add(this.radioButtonManager);
            this.Controls.Add(this.radioButtonStaff);
            this.Controls.Add(this.labelNewUser);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkboxShowPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelNewUser;
        private System.Windows.Forms.CheckBox checkboxShowPass;
        private System.Windows.Forms.RadioButton radioButtonStaff;
        private System.Windows.Forms.RadioButton radioButtonManager;
    }
}