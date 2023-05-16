namespace WIPR_FinalProject_Nhom3
{
    partial class VehicleListForm
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
            this.radioButtonBicycle = new System.Windows.Forms.RadioButton();
            this.radioButtonMotor = new System.Windows.Forms.RadioButton();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewVehicleList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonBicycle
            // 
            this.radioButtonBicycle.AutoSize = true;
            this.radioButtonBicycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBicycle.Location = new System.Drawing.Point(335, 40);
            this.radioButtonBicycle.Name = "radioButtonBicycle";
            this.radioButtonBicycle.Size = new System.Drawing.Size(76, 24);
            this.radioButtonBicycle.TabIndex = 60;
            this.radioButtonBicycle.Text = "Bicycle";
            this.radioButtonBicycle.UseVisualStyleBackColor = true;
            this.radioButtonBicycle.CheckedChanged += new System.EventHandler(this.radioButtonBicycle_CheckedChanged);
            // 
            // radioButtonMotor
            // 
            this.radioButtonMotor.AutoSize = true;
            this.radioButtonMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMotor.Location = new System.Drawing.Point(232, 40);
            this.radioButtonMotor.Name = "radioButtonMotor";
            this.radioButtonMotor.Size = new System.Drawing.Size(68, 24);
            this.radioButtonMotor.TabIndex = 59;
            this.radioButtonMotor.Text = "Motor";
            this.radioButtonMotor.UseVisualStyleBackColor = true;
            this.radioButtonMotor.CheckedChanged += new System.EventHandler(this.radioButtonMotor_CheckedChanged);
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Checked = true;
            this.radioButtonCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCar.Location = new System.Drawing.Point(165, 40);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(52, 24);
            this.radioButtonCar.TabIndex = 58;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            this.radioButtonCar.CheckedChanged += new System.EventHandler(this.radioButtonCar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Vehicle Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 56;
            this.label1.Text = "Vehicle List";
            // 
            // dataGridViewVehicleList
            // 
            this.dataGridViewVehicleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicleList.Location = new System.Drawing.Point(13, 70);
            this.dataGridViewVehicleList.Name = "dataGridViewVehicleList";
            this.dataGridViewVehicleList.Size = new System.Drawing.Size(896, 427);
            this.dataGridViewVehicleList.TabIndex = 61;
            this.dataGridViewVehicleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVehicleList_CellContentClick);
            this.dataGridViewVehicleList.DoubleClick += new System.EventHandler(this.dataGridViewVehicleList_DoubleClick);
            // 
            // VehicleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 509);
            this.Controls.Add(this.dataGridViewVehicleList);
            this.Controls.Add(this.radioButtonBicycle);
            this.Controls.Add(this.radioButtonMotor);
            this.Controls.Add(this.radioButtonCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VehicleListForm";
            this.Text = "Vehicle List Form";
            this.Load += new System.EventHandler(this.VehicleListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonBicycle;
        private System.Windows.Forms.RadioButton radioButtonMotor;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewVehicleList;
    }
}