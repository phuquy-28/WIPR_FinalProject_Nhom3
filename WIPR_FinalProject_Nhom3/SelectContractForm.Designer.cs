namespace WIPR_FinalProject_Nhom3
{
    partial class SelectContractForm
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
            this.dataGridViewSelectContact = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectContact)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSelectContact
            // 
            this.dataGridViewSelectContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelectContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectContact.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewSelectContact.Name = "dataGridViewSelectContact";
            this.dataGridViewSelectContact.Size = new System.Drawing.Size(335, 283);
            this.dataGridViewSelectContact.TabIndex = 0;
            // 
            // SelectContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 309);
            this.Controls.Add(this.dataGridViewSelectContact);
            this.Name = "SelectContractForm";
            this.Text = "SelectContractForm";
            this.Load += new System.EventHandler(this.SelectContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridViewSelectContact;
    }
}