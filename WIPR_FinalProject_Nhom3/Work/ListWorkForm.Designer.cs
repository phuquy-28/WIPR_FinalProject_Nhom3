namespace WIPR_FinalProject_Nhom3
{
    partial class ListWorkForm
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
            this.dataGridViewListWork = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListWork)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListWork
            // 
            this.dataGridViewListWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListWork.Location = new System.Drawing.Point(29, 27);
            this.dataGridViewListWork.Name = "dataGridViewListWork";
            this.dataGridViewListWork.RowHeadersWidth = 51;
            this.dataGridViewListWork.RowTemplate.Height = 24;
            this.dataGridViewListWork.Size = new System.Drawing.Size(736, 346);
            this.dataGridViewListWork.TabIndex = 0;
            // 
            // ListWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewListWork);
            this.Name = "ListWorkForm";
            this.Text = "ListWorkForm";
            this.Load += new System.EventHandler(this.ListWorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListWork;
    }
}