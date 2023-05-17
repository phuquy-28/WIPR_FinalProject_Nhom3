namespace WIPR_FinalProject_Nhom3
{
    partial class AddParkPlaceForm
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
            this.radioButtonBicycle = new System.Windows.Forms.RadioButton();
            this.radioButtonMotor = new System.Windows.Forms.RadioButton();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIdParkPlace = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Park Place";
            // 
            // radioButtonBicycle
            // 
            this.radioButtonBicycle.AutoSize = true;
            this.radioButtonBicycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBicycle.Location = new System.Drawing.Point(338, 54);
            this.radioButtonBicycle.Name = "radioButtonBicycle";
            this.radioButtonBicycle.Size = new System.Drawing.Size(76, 24);
            this.radioButtonBicycle.TabIndex = 11;
            this.radioButtonBicycle.Text = "Bicycle";
            this.radioButtonBicycle.UseVisualStyleBackColor = true;
            // 
            // radioButtonMotor
            // 
            this.radioButtonMotor.AutoSize = true;
            this.radioButtonMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMotor.Location = new System.Drawing.Point(253, 54);
            this.radioButtonMotor.Name = "radioButtonMotor";
            this.radioButtonMotor.Size = new System.Drawing.Size(68, 24);
            this.radioButtonMotor.TabIndex = 10;
            this.radioButtonMotor.Text = "Motor";
            this.radioButtonMotor.UseVisualStyleBackColor = true;
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Checked = true;
            this.radioButtonCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCar.Location = new System.Drawing.Point(186, 54);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(52, 24);
            this.radioButtonCar.TabIndex = 9;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vehicle Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Id Park Place:";
            // 
            // textBoxIdParkPlace
            // 
            this.textBoxIdParkPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdParkPlace.Location = new System.Drawing.Point(186, 98);
            this.textBoxIdParkPlace.Name = "textBoxIdParkPlace";
            this.textBoxIdParkPlace.Size = new System.Drawing.Size(135, 26);
            this.textBoxIdParkPlace.TabIndex = 13;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(186, 146);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 36);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddParkPlaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 208);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxIdParkPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonBicycle);
            this.Controls.Add(this.radioButtonMotor);
            this.Controls.Add(this.radioButtonCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddParkPlaceForm";
            this.Text = "Add Park Place Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonBicycle;
        private System.Windows.Forms.RadioButton radioButtonMotor;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIdParkPlace;
        private System.Windows.Forms.Button buttonAdd;
    }
}