namespace WIPR_FinalProject_Nhom3
{
    partial class AddVehicleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIdCard = new System.Windows.Forms.TextBox();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.radioButtonMotor = new System.Windows.Forms.RadioButton();
            this.radioButtonBicycle = new System.Windows.Forms.RadioButton();
            this.textBoxLicensePlate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTicketType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerTimeIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateIn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.labelImageOrPlate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonUpload1 = new System.Windows.Forms.Button();
            this.buttonUpload2 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCustomerOrBrand = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxParking = new System.Windows.Forms.CheckBox();
            this.checkBoxRepair = new System.Windows.Forms.CheckBox();
            this.checkBoxWash = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Vehicle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Card:";
            // 
            // textBoxIdCard
            // 
            this.textBoxIdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdCard.Location = new System.Drawing.Point(188, 125);
            this.textBoxIdCard.Name = "textBoxIdCard";
            this.textBoxIdCard.Size = new System.Drawing.Size(217, 26);
            this.textBoxIdCard.TabIndex = 4;
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Checked = true;
            this.radioButtonCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCar.Location = new System.Drawing.Point(188, 60);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(52, 24);
            this.radioButtonCar.TabIndex = 5;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            // 
            // radioButtonMotor
            // 
            this.radioButtonMotor.AutoSize = true;
            this.radioButtonMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMotor.Location = new System.Drawing.Point(255, 60);
            this.radioButtonMotor.Name = "radioButtonMotor";
            this.radioButtonMotor.Size = new System.Drawing.Size(97, 24);
            this.radioButtonMotor.TabIndex = 6;
            this.radioButtonMotor.Text = "Motorbike";
            this.radioButtonMotor.UseVisualStyleBackColor = true;
            // 
            // radioButtonBicycle
            // 
            this.radioButtonBicycle.AutoSize = true;
            this.radioButtonBicycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBicycle.Location = new System.Drawing.Point(358, 60);
            this.radioButtonBicycle.Name = "radioButtonBicycle";
            this.radioButtonBicycle.Size = new System.Drawing.Size(76, 24);
            this.radioButtonBicycle.TabIndex = 7;
            this.radioButtonBicycle.Text = "Bicycle";
            this.radioButtonBicycle.UseVisualStyleBackColor = true;
            // 
            // textBoxLicensePlate
            // 
            this.textBoxLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLicensePlate.Location = new System.Drawing.Point(188, 157);
            this.textBoxLicensePlate.Name = "textBoxLicensePlate";
            this.textBoxLicensePlate.Size = new System.Drawing.Size(217, 26);
            this.textBoxLicensePlate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "License Plate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ticket Type:";
            // 
            // comboBoxTicketType
            // 
            this.comboBoxTicketType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTicketType.FormattingEnabled = true;
            this.comboBoxTicketType.Items.AddRange(new object[] {
            "Giờ",
            "Ngày",
            "Tuần",
            "Tháng"});
            this.comboBoxTicketType.Location = new System.Drawing.Point(188, 189);
            this.comboBoxTicketType.Name = "comboBoxTicketType";
            this.comboBoxTicketType.Size = new System.Drawing.Size(217, 28);
            this.comboBoxTicketType.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Time in:";
            // 
            // dateTimePickerTimeIn
            // 
            this.dateTimePickerTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTimeIn.Location = new System.Drawing.Point(537, 125);
            this.dateTimePickerTimeIn.Name = "dateTimePickerTimeIn";
            this.dateTimePickerTimeIn.Size = new System.Drawing.Size(217, 26);
            this.dateTimePickerTimeIn.TabIndex = 15;
            // 
            // dateTimePickerDateIn
            // 
            this.dateTimePickerDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateIn.Location = new System.Drawing.Point(537, 157);
            this.dateTimePickerDateIn.Name = "dateTimePickerDateIn";
            this.dateTimePickerDateIn.Size = new System.Drawing.Size(217, 26);
            this.dateTimePickerDateIn.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date in:";
            // 
            // labelImageOrPlate
            // 
            this.labelImageOrPlate.AutoSize = true;
            this.labelImageOrPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImageOrPlate.Location = new System.Drawing.Point(115, 234);
            this.labelImageOrPlate.Name = "labelImageOrPlate";
            this.labelImageOrPlate.Size = new System.Drawing.Size(55, 20);
            this.labelImageOrPlate.TabIndex = 18;
            this.labelImageOrPlate.Text = "Plate:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(188, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 171);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(537, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 171);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // buttonUpload1
            // 
            this.buttonUpload1.Location = new System.Drawing.Point(255, 411);
            this.buttonUpload1.Name = "buttonUpload1";
            this.buttonUpload1.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload1.TabIndex = 22;
            this.buttonUpload1.Text = "Upload";
            this.buttonUpload1.UseVisualStyleBackColor = true;
            // 
            // buttonUpload2
            // 
            this.buttonUpload2.Location = new System.Drawing.Point(610, 411);
            this.buttonUpload2.Name = "buttonUpload2";
            this.buttonUpload2.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload2.TabIndex = 23;
            this.buttonUpload2.Text = "Upload";
            this.buttonUpload2.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(390, 435);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 35);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // labelCustomerOrBrand
            // 
            this.labelCustomerOrBrand.AutoSize = true;
            this.labelCustomerOrBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerOrBrand.Location = new System.Drawing.Point(458, 234);
            this.labelCustomerOrBrand.Name = "labelCustomerOrBrand";
            this.labelCustomerOrBrand.Size = new System.Drawing.Size(62, 20);
            this.labelCustomerOrBrand.TabIndex = 20;
            this.labelCustomerOrBrand.Text = "Brand:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Services:";
            // 
            // checkBoxParking
            // 
            this.checkBoxParking.AutoSize = true;
            this.checkBoxParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxParking.Location = new System.Drawing.Point(188, 95);
            this.checkBoxParking.Name = "checkBoxParking";
            this.checkBoxParking.Size = new System.Drawing.Size(81, 24);
            this.checkBoxParking.TabIndex = 26;
            this.checkBoxParking.Text = "Parking";
            this.checkBoxParking.UseVisualStyleBackColor = true;
            // 
            // checkBoxRepair
            // 
            this.checkBoxRepair.AutoSize = true;
            this.checkBoxRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRepair.Location = new System.Drawing.Point(275, 95);
            this.checkBoxRepair.Name = "checkBoxRepair";
            this.checkBoxRepair.Size = new System.Drawing.Size(75, 24);
            this.checkBoxRepair.TabIndex = 27;
            this.checkBoxRepair.Text = "Repair";
            this.checkBoxRepair.UseVisualStyleBackColor = true;
            // 
            // checkBoxWash
            // 
            this.checkBoxWash.AutoSize = true;
            this.checkBoxWash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWash.Location = new System.Drawing.Point(356, 95);
            this.checkBoxWash.Name = "checkBoxWash";
            this.checkBoxWash.Size = new System.Drawing.Size(69, 24);
            this.checkBoxWash.TabIndex = 28;
            this.checkBoxWash.Text = "Wash";
            this.checkBoxWash.UseVisualStyleBackColor = true;
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 490);
            this.Controls.Add(this.checkBoxWash);
            this.Controls.Add(this.checkBoxRepair);
            this.Controls.Add(this.checkBoxParking);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpload2);
            this.Controls.Add(this.buttonUpload1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelCustomerOrBrand);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelImageOrPlate);
            this.Controls.Add(this.dateTimePickerDateIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerTimeIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTicketType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLicensePlate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonBicycle);
            this.Controls.Add(this.radioButtonMotor);
            this.Controls.Add(this.radioButtonCar);
            this.Controls.Add(this.textBoxIdCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddVehicleForm";
            this.Text = "AddVehicleForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIdCard;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.RadioButton radioButtonMotor;
        private System.Windows.Forms.RadioButton radioButtonBicycle;
        private System.Windows.Forms.TextBox textBoxLicensePlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTicketType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelImageOrPlate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonUpload1;
        private System.Windows.Forms.Button buttonUpload2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCustomerOrBrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxParking;
        private System.Windows.Forms.CheckBox checkBoxRepair;
        private System.Windows.Forms.CheckBox checkBoxWash;
    }
}

