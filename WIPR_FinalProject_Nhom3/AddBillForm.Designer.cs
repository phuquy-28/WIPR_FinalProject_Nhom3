namespace WIPR_FinalProject_Nhom3
{
    partial class AddBillForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddBill = new System.Windows.Forms.Button();
            this.textBoxIdBill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxAvail = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSelect = new System.Windows.Forms.ListBox();
            this.buttonAddWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 57;
            this.label1.Text = "Add Bill";
            // 
            // buttonAddBill
            // 
            this.buttonAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBill.Location = new System.Drawing.Point(307, 53);
            this.buttonAddBill.Name = "buttonAddBill";
            this.buttonAddBill.Size = new System.Drawing.Size(69, 29);
            this.buttonAddBill.TabIndex = 60;
            this.buttonAddBill.Text = "Add";
            this.buttonAddBill.UseVisualStyleBackColor = true;
            this.buttonAddBill.Click += new System.EventHandler(this.buttonAddBill_Click);
            // 
            // textBoxIdBill
            // 
            this.textBoxIdBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdBill.Location = new System.Drawing.Point(159, 56);
            this.textBoxIdBill.Name = "textBoxIdBill";
            this.textBoxIdBill.Size = new System.Drawing.Size(142, 26);
            this.textBoxIdBill.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "New ID Bill:";
            // 
            // listBoxAvail
            // 
            this.listBoxAvail.FormattingEnabled = true;
            this.listBoxAvail.Location = new System.Drawing.Point(45, 145);
            this.listBoxAvail.Name = "listBoxAvail";
            this.listBoxAvail.Size = new System.Drawing.Size(255, 160);
            this.listBoxAvail.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 62;
            this.label2.Text = "Add Work";
            // 
            // listBoxSelect
            // 
            this.listBoxSelect.FormattingEnabled = true;
            this.listBoxSelect.Location = new System.Drawing.Point(423, 145);
            this.listBoxSelect.Name = "listBoxSelect";
            this.listBoxSelect.Size = new System.Drawing.Size(255, 160);
            this.listBoxSelect.TabIndex = 63;
            // 
            // buttonAddWork
            // 
            this.buttonAddWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddWork.Location = new System.Drawing.Point(325, 206);
            this.buttonAddWork.Name = "buttonAddWork";
            this.buttonAddWork.Size = new System.Drawing.Size(69, 29);
            this.buttonAddWork.TabIndex = 64;
            this.buttonAddWork.Text = "Add";
            this.buttonAddWork.UseVisualStyleBackColor = true;
            this.buttonAddWork.Click += new System.EventHandler(this.buttonAddWork_Click);
            // 
            // AddBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 369);
            this.Controls.Add(this.buttonAddWork);
            this.Controls.Add(this.listBoxSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxAvail);
            this.Controls.Add(this.buttonAddBill);
            this.Controls.Add(this.textBoxIdBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddBillForm";
            this.Text = "Add Work Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddBill;
        private System.Windows.Forms.TextBox textBoxIdBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxAvail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxSelect;
        private System.Windows.Forms.Button buttonAddWork;
    }
}