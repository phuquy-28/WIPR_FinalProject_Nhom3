namespace WIPR_FinalProject_Nhom3
{
    partial class RemoveWorkForm
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
            this.comboBoxNameWork = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxNameWork
            // 
            this.comboBoxNameWork.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNameWork.FormattingEnabled = true;
            this.comboBoxNameWork.Location = new System.Drawing.Point(181, 31);
            this.comboBoxNameWork.Name = "comboBoxNameWork";
            this.comboBoxNameWork.Size = new System.Drawing.Size(225, 30);
            this.comboBoxNameWork.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name:";
            // 
            // buttonRemoveWork
            // 
            this.buttonRemoveWork.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveWork.Location = new System.Drawing.Point(181, 101);
            this.buttonRemoveWork.Name = "buttonRemoveWork";
            this.buttonRemoveWork.Size = new System.Drawing.Size(111, 58);
            this.buttonRemoveWork.TabIndex = 21;
            this.buttonRemoveWork.Text = "Remove";
            this.buttonRemoveWork.UseVisualStyleBackColor = true;
            this.buttonRemoveWork.Click += new System.EventHandler(this.buttonRemoveWork_Click);
            // 
            // RemoveWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 189);
            this.Controls.Add(this.buttonRemoveWork);
            this.Controls.Add(this.comboBoxNameWork);
            this.Controls.Add(this.label2);
            this.Name = "RemoveWorkForm";
            this.Text = "RemoveWorkForm";
            this.Load += new System.EventHandler(this.RemoveWorkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNameWork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemoveWork;
    }
}