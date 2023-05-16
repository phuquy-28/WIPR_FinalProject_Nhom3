namespace WIPR_FinalProject_Nhom3
{
    partial class SelectParkPlaceForm
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
            this.dataGridViewParkPlace = new System.Windows.Forms.DataGridView();
            this.buttonSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParkPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewParkPlace
            // 
            this.dataGridViewParkPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParkPlace.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewParkPlace.Name = "dataGridViewParkPlace";
            this.dataGridViewParkPlace.Size = new System.Drawing.Size(414, 389);
            this.dataGridViewParkPlace.TabIndex = 0;
            this.dataGridViewParkPlace.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParkPlace_CellContentClick);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(170, 415);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // SelectParkPlaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.dataGridViewParkPlace);
            this.Name = "SelectParkPlaceForm";
            this.Text = "SelectParkPlaceForm";
            this.Load += new System.EventHandler(this.SelectParkPlaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParkPlace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewParkPlace;
        private System.Windows.Forms.Button buttonSelect;
    }
}