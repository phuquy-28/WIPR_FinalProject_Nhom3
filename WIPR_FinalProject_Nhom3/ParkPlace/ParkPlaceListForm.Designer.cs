namespace WIPR_FinalProject_Nhom3
{
    partial class ParkPlaceListForm
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
            this.dataGridViewParkPlaceList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMaxCapacity = new System.Windows.Forms.Label();
            this.labelEmptyParkPlace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParkPlaceList)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonBicycle
            // 
            this.radioButtonBicycle.AutoSize = true;
            this.radioButtonBicycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBicycle.Location = new System.Drawing.Point(338, 54);
            this.radioButtonBicycle.Name = "radioButtonBicycle";
            this.radioButtonBicycle.Size = new System.Drawing.Size(76, 24);
            this.radioButtonBicycle.TabIndex = 16;
            this.radioButtonBicycle.Text = "Bicycle";
            this.radioButtonBicycle.UseVisualStyleBackColor = true;
            this.radioButtonBicycle.CheckedChanged += new System.EventHandler(this.radioButtonBicycle_CheckedChanged);
            // 
            // radioButtonMotor
            // 
            this.radioButtonMotor.AutoSize = true;
            this.radioButtonMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMotor.Location = new System.Drawing.Point(253, 54);
            this.radioButtonMotor.Name = "radioButtonMotor";
            this.radioButtonMotor.Size = new System.Drawing.Size(68, 24);
            this.radioButtonMotor.TabIndex = 15;
            this.radioButtonMotor.Text = "Motor";
            this.radioButtonMotor.UseVisualStyleBackColor = true;
            this.radioButtonMotor.CheckedChanged += new System.EventHandler(this.radioButtonMotor_CheckedChanged);
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Checked = true;
            this.radioButtonCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCar.Location = new System.Drawing.Point(186, 54);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(52, 24);
            this.radioButtonCar.TabIndex = 14;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            this.radioButtonCar.CheckedChanged += new System.EventHandler(this.radioButtonCar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Vehicle Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Park Place List";
            // 
            // dataGridViewParkPlaceList
            // 
            this.dataGridViewParkPlaceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParkPlaceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParkPlaceList.Location = new System.Drawing.Point(13, 87);
            this.dataGridViewParkPlaceList.Name = "dataGridViewParkPlaceList";
            this.dataGridViewParkPlaceList.Size = new System.Drawing.Size(775, 351);
            this.dataGridViewParkPlaceList.TabIndex = 17;
            this.dataGridViewParkPlaceList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewParkPlaceList_DataBindingComplete);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Empty Park Place:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(616, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Max Capacity:";
            // 
            // labelMaxCapacity
            // 
            this.labelMaxCapacity.AutoSize = true;
            this.labelMaxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxCapacity.Location = new System.Drawing.Point(742, 453);
            this.labelMaxCapacity.Name = "labelMaxCapacity";
            this.labelMaxCapacity.Size = new System.Drawing.Size(41, 20);
            this.labelMaxCapacity.TabIndex = 20;
            this.labelMaxCapacity.Text = "Max";
            // 
            // labelEmptyParkPlace
            // 
            this.labelEmptyParkPlace.AutoSize = true;
            this.labelEmptyParkPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmptyParkPlace.Location = new System.Drawing.Point(510, 453);
            this.labelEmptyParkPlace.Name = "labelEmptyParkPlace";
            this.labelEmptyParkPlace.Size = new System.Drawing.Size(41, 20);
            this.labelEmptyParkPlace.TabIndex = 21;
            this.labelEmptyParkPlace.Text = "Max";
            // 
            // ParkPlaceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.labelEmptyParkPlace);
            this.Controls.Add(this.labelMaxCapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewParkPlaceList);
            this.Controls.Add(this.radioButtonBicycle);
            this.Controls.Add(this.radioButtonMotor);
            this.Controls.Add(this.radioButtonCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ParkPlaceListForm";
            this.Text = "Park Place List Form";
            this.Load += new System.EventHandler(this.ParkPlaceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParkPlaceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonBicycle;
        private System.Windows.Forms.RadioButton radioButtonMotor;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewParkPlaceList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMaxCapacity;
        private System.Windows.Forms.Label labelEmptyParkPlace;
    }
}