namespace WIPR_FinalProject_Nhom3
{
    partial class ViewVehicleContractForm
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
            this.dataGridViewVehicleContract = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicleContract)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVehicleContract
            // 
            this.dataGridViewVehicleContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicleContract.Location = new System.Drawing.Point(13, 59);
            this.dataGridViewVehicleContract.Name = "dataGridViewVehicleContract";
            this.dataGridViewVehicleContract.Size = new System.Drawing.Size(618, 379);
            this.dataGridViewVehicleContract.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 58;
            this.label1.Text = "Vehicle Contract";
            // 
            // ViewVehicleContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVehicleContract);
            this.Name = "ViewVehicleContractForm";
            this.Text = "ViewVehicleContractForm";
            this.Load += new System.EventHandler(this.ViewVehicleContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicleContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVehicleContract;
        private System.Windows.Forms.Label label1;
    }
}