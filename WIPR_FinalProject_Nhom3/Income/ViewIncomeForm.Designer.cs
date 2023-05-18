namespace WIPR_FinalProject_Nhom3
{
    partial class ViewIncomeForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.radioButtonRange = new System.Windows.Forms.RadioButton();
            this.radioButtonToday = new System.Windows.Forms.RadioButton();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.tabContract = new System.Windows.Forms.TabPage();
            this.pARKING_LOTDataSet = new WIPR_FinalProject_Nhom3.PARKING_LOTDataSet();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new WIPR_FinalProject_Nhom3.PARKING_LOTDataSetTableAdapters.BillTableAdapter();
            this.buttonFindCt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerEndCt = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartCt = new System.Windows.Forms.DateTimePicker();
            this.radioButtonRangeCt = new System.Windows.Forms.RadioButton();
            this.radioButtonTodayCt = new System.Windows.Forms.RadioButton();
            this.dataGridViewContractList = new System.Windows.Forms.DataGridView();
            this.labelRentTotal = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.buttonExportCt = new System.Windows.Forms.Button();
            this.labelForRentTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.tabContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARKING_LOTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContractList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBill);
            this.tabControl1.Controls.Add(this.tabContract);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 499);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.buttonFind);
            this.tabBill.Controls.Add(this.label2);
            this.tabBill.Controls.Add(this.dateTimePickerEnd);
            this.tabBill.Controls.Add(this.dateTimePickerStart);
            this.tabBill.Controls.Add(this.radioButtonRange);
            this.tabBill.Controls.Add(this.radioButtonToday);
            this.tabBill.Controls.Add(this.labelTotal);
            this.tabBill.Controls.Add(this.label1);
            this.tabBill.Controls.Add(this.buttonExport);
            this.tabBill.Controls.Add(this.dataGridViewBill);
            this.tabBill.Location = new System.Drawing.Point(4, 22);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabBill.Size = new System.Drawing.Size(906, 473);
            this.tabBill.TabIndex = 0;
            this.tabBill.Text = "Bill";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Location = new System.Drawing.Point(430, 4);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 9;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "between to";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(324, 6);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerEnd.TabIndex = 7;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(152, 7);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerStart.TabIndex = 6;
            // 
            // radioButtonRange
            // 
            this.radioButtonRange.AutoSize = true;
            this.radioButtonRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRange.Location = new System.Drawing.Point(88, 7);
            this.radioButtonRange.Name = "radioButtonRange";
            this.radioButtonRange.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRange.TabIndex = 5;
            this.radioButtonRange.Text = "Range";
            this.radioButtonRange.UseVisualStyleBackColor = true;
            this.radioButtonRange.CheckedChanged += new System.EventHandler(this.radioButtonRange_CheckedChanged);
            // 
            // radioButtonToday
            // 
            this.radioButtonToday.AutoSize = true;
            this.radioButtonToday.Checked = true;
            this.radioButtonToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonToday.Location = new System.Drawing.Point(11, 7);
            this.radioButtonToday.Name = "radioButtonToday";
            this.radioButtonToday.Size = new System.Drawing.Size(60, 17);
            this.radioButtonToday.TabIndex = 4;
            this.radioButtonToday.TabStop = true;
            this.radioButtonToday.Text = "Today";
            this.radioButtonToday.UseVisualStyleBackColor = true;
            this.radioButtonToday.CheckedChanged += new System.EventHandler(this.radioButtonToday_CheckedChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(67, 426);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(54, 20);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(802, 425);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(98, 30);
            this.buttonExport.TabIndex = 1;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Location = new System.Drawing.Point(7, 36);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.Size = new System.Drawing.Size(893, 383);
            this.dataGridViewBill.TabIndex = 0;
            // 
            // tabContract
            // 
            this.tabContract.Controls.Add(this.labelForRentTotal);
            this.tabContract.Controls.Add(this.label5);
            this.tabContract.Controls.Add(this.labelRentTotal);
            this.tabContract.Controls.Add(this.label);
            this.tabContract.Controls.Add(this.buttonExportCt);
            this.tabContract.Controls.Add(this.buttonFindCt);
            this.tabContract.Controls.Add(this.label3);
            this.tabContract.Controls.Add(this.dateTimePickerEndCt);
            this.tabContract.Controls.Add(this.dateTimePickerStartCt);
            this.tabContract.Controls.Add(this.radioButtonRangeCt);
            this.tabContract.Controls.Add(this.radioButtonTodayCt);
            this.tabContract.Controls.Add(this.dataGridViewContractList);
            this.tabContract.Location = new System.Drawing.Point(4, 22);
            this.tabContract.Name = "tabContract";
            this.tabContract.Padding = new System.Windows.Forms.Padding(3);
            this.tabContract.Size = new System.Drawing.Size(906, 473);
            this.tabContract.TabIndex = 1;
            this.tabContract.Text = "Contract";
            this.tabContract.UseVisualStyleBackColor = true;
            // 
            // pARKING_LOTDataSet
            // 
            this.pARKING_LOTDataSet.DataSetName = "PARKING_LOTDataSet";
            this.pARKING_LOTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.pARKING_LOTDataSet;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // buttonFindCt
            // 
            this.buttonFindCt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindCt.Location = new System.Drawing.Point(430, 6);
            this.buttonFindCt.Name = "buttonFindCt";
            this.buttonFindCt.Size = new System.Drawing.Size(75, 23);
            this.buttonFindCt.TabIndex = 16;
            this.buttonFindCt.Text = "Find";
            this.buttonFindCt.UseVisualStyleBackColor = true;
            this.buttonFindCt.Click += new System.EventHandler(this.buttonFindCt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "between to";
            // 
            // dateTimePickerEndCt
            // 
            this.dateTimePickerEndCt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndCt.Location = new System.Drawing.Point(324, 8);
            this.dateTimePickerEndCt.Name = "dateTimePickerEndCt";
            this.dateTimePickerEndCt.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerEndCt.TabIndex = 14;
            // 
            // dateTimePickerStartCt
            // 
            this.dateTimePickerStartCt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartCt.Location = new System.Drawing.Point(152, 9);
            this.dateTimePickerStartCt.Name = "dateTimePickerStartCt";
            this.dateTimePickerStartCt.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerStartCt.TabIndex = 13;
            // 
            // radioButtonRangeCt
            // 
            this.radioButtonRangeCt.AutoSize = true;
            this.radioButtonRangeCt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRangeCt.Location = new System.Drawing.Point(88, 9);
            this.radioButtonRangeCt.Name = "radioButtonRangeCt";
            this.radioButtonRangeCt.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRangeCt.TabIndex = 12;
            this.radioButtonRangeCt.Text = "Range";
            this.radioButtonRangeCt.UseVisualStyleBackColor = true;
            this.radioButtonRangeCt.CheckedChanged += new System.EventHandler(this.radioButtonRangeCt_CheckedChanged);
            // 
            // radioButtonTodayCt
            // 
            this.radioButtonTodayCt.AutoSize = true;
            this.radioButtonTodayCt.Checked = true;
            this.radioButtonTodayCt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTodayCt.Location = new System.Drawing.Point(11, 9);
            this.radioButtonTodayCt.Name = "radioButtonTodayCt";
            this.radioButtonTodayCt.Size = new System.Drawing.Size(60, 17);
            this.radioButtonTodayCt.TabIndex = 11;
            this.radioButtonTodayCt.TabStop = true;
            this.radioButtonTodayCt.Text = "Today";
            this.radioButtonTodayCt.UseVisualStyleBackColor = true;
            this.radioButtonTodayCt.CheckedChanged += new System.EventHandler(this.radioButtonTodayCt_CheckedChanged);
            // 
            // dataGridViewContractList
            // 
            this.dataGridViewContractList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContractList.Location = new System.Drawing.Point(7, 38);
            this.dataGridViewContractList.Name = "dataGridViewContractList";
            this.dataGridViewContractList.Size = new System.Drawing.Size(893, 383);
            this.dataGridViewContractList.TabIndex = 10;
            // 
            // labelRentTotal
            // 
            this.labelRentTotal.AutoSize = true;
            this.labelRentTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentTotal.Location = new System.Drawing.Point(111, 434);
            this.labelRentTotal.Name = "labelRentTotal";
            this.labelRentTotal.Size = new System.Drawing.Size(54, 20);
            this.labelRentTotal.TabIndex = 19;
            this.labelRentTotal.Text = "Total:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(7, 434);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 20);
            this.label.TabIndex = 18;
            this.label.Text = "Rent Total:";
            // 
            // buttonExportCt
            // 
            this.buttonExportCt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportCt.Location = new System.Drawing.Point(802, 433);
            this.buttonExportCt.Name = "buttonExportCt";
            this.buttonExportCt.Size = new System.Drawing.Size(98, 30);
            this.buttonExportCt.TabIndex = 17;
            this.buttonExportCt.Text = "Export";
            this.buttonExportCt.UseVisualStyleBackColor = true;
            this.buttonExportCt.Click += new System.EventHandler(this.buttonExportCt_Click);
            // 
            // labelForRentTotal
            // 
            this.labelForRentTotal.AutoSize = true;
            this.labelForRentTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForRentTotal.Location = new System.Drawing.Point(447, 434);
            this.labelForRentTotal.Name = "labelForRentTotal";
            this.labelForRentTotal.Size = new System.Drawing.Size(54, 20);
            this.labelForRentTotal.TabIndex = 21;
            this.labelForRentTotal.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "For Rent Total:";
            // 
            // ViewIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 523);
            this.Controls.Add(this.tabControl1);
            this.Name = "ViewIncomeForm";
            this.Text = "ViewIncomeForm";
            this.Load += new System.EventHandler(this.ViewIncomeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBill.ResumeLayout(false);
            this.tabBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.tabContract.ResumeLayout(false);
            this.tabContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARKING_LOTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContractList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.TabPage tabContract;
        private PARKING_LOTDataSet pARKING_LOTDataSet;
        private System.Windows.Forms.BindingSource billBindingSource;
        private PARKING_LOTDataSetTableAdapters.BillTableAdapter billTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.RadioButton radioButtonRange;
        private System.Windows.Forms.RadioButton radioButtonToday;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonFindCt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndCt;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartCt;
        private System.Windows.Forms.RadioButton radioButtonRangeCt;
        private System.Windows.Forms.RadioButton radioButtonTodayCt;
        private System.Windows.Forms.DataGridView dataGridViewContractList;
        private System.Windows.Forms.Label labelRentTotal;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonExportCt;
        private System.Windows.Forms.Label labelForRentTotal;
        private System.Windows.Forms.Label label5;
    }
}