namespace WIPR_FinalProject_Nhom3
{
    partial class UpdateWorkForm
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
            this.buttonEditWork = new System.Windows.Forms.Button();
            this.radioButtonBicycle = new System.Windows.Forms.RadioButton();
            this.radioButtonMotobike = new System.Windows.Forms.RadioButton();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxTypeWork = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNameWork = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonEditWork
            // 
            this.buttonEditWork.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditWork.Location = new System.Drawing.Point(188, 285);
            this.buttonEditWork.Name = "buttonEditWork";
            this.buttonEditWork.Size = new System.Drawing.Size(111, 58);
            this.buttonEditWork.TabIndex = 20;
            this.buttonEditWork.Text = "Edit";
            this.buttonEditWork.UseVisualStyleBackColor = true;
            this.buttonEditWork.Click += new System.EventHandler(this.buttonEditWork_Click);
            // 
            // radioButtonBicycle
            // 
            this.radioButtonBicycle.AutoSize = true;
            this.radioButtonBicycle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBicycle.Location = new System.Drawing.Point(313, 212);
            this.radioButtonBicycle.Name = "radioButtonBicycle";
            this.radioButtonBicycle.Size = new System.Drawing.Size(100, 30);
            this.radioButtonBicycle.TabIndex = 19;
            this.radioButtonBicycle.TabStop = true;
            this.radioButtonBicycle.Text = "Bicycle";
            this.radioButtonBicycle.UseVisualStyleBackColor = true;
            // 
            // radioButtonMotobike
            // 
            this.radioButtonMotobike.AutoSize = true;
            this.radioButtonMotobike.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMotobike.Location = new System.Drawing.Point(163, 212);
            this.radioButtonMotobike.Name = "radioButtonMotobike";
            this.radioButtonMotobike.Size = new System.Drawing.Size(122, 30);
            this.radioButtonMotobike.TabIndex = 18;
            this.radioButtonMotobike.TabStop = true;
            this.radioButtonMotobike.Text = "Motobike";
            this.radioButtonMotobike.UseVisualStyleBackColor = true;
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCar.Location = new System.Drawing.Point(50, 212);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(66, 30);
            this.radioButtonCar.TabIndex = 17;
            this.radioButtonCar.TabStop = true;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(188, 82);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(225, 34);
            this.textBoxPrice.TabIndex = 14;
            // 
            // comboBoxTypeWork
            // 
            this.comboBoxTypeWork.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTypeWork.FormattingEnabled = true;
            this.comboBoxTypeWork.Location = new System.Drawing.Point(188, 142);
            this.comboBoxTypeWork.Name = "comboBoxTypeWork";
            this.comboBoxTypeWork.Size = new System.Drawing.Size(225, 30);
            this.comboBoxTypeWork.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type Work:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // comboBoxNameWork
            // 
            this.comboBoxNameWork.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNameWork.FormattingEnabled = true;
            this.comboBoxNameWork.Location = new System.Drawing.Point(188, 29);
            this.comboBoxNameWork.Name = "comboBoxNameWork";
            this.comboBoxNameWork.Size = new System.Drawing.Size(225, 30);
            this.comboBoxNameWork.TabIndex = 13;
            this.comboBoxNameWork.SelectedIndexChanged += new System.EventHandler(this.comboBoxNameWork_SelectedIndexChanged);
            // 
            // UpdateWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 500);
            this.Controls.Add(this.comboBoxNameWork);
            this.Controls.Add(this.buttonEditWork);
            this.Controls.Add(this.radioButtonBicycle);
            this.Controls.Add(this.radioButtonMotobike);
            this.Controls.Add(this.radioButtonCar);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxTypeWork);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UpdateWorkForm";
            this.Text = "UpdateWorkForm";
            this.Load += new System.EventHandler(this.UpdateWorkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditWork;
        private System.Windows.Forms.RadioButton radioButtonBicycle;
        private System.Windows.Forms.RadioButton radioButtonMotobike;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxTypeWork;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNameWork;
    }
}