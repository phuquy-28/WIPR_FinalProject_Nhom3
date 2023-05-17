using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WIPR_FinalProject_Nhom3
{
    public partial class ViewIncomeForm : Form
    {
        public ViewIncomeForm()
        {
            InitializeComponent();
            buttonFind.Enabled = false;
            loadToday();
        }
        INCOME income = new INCOME();

        public void loadToday()
        {
            DataTable table = income.getListBillToday();
            float total = 0;
            foreach (DataRow row in table.Rows)
            {
                var value = row["Total"];
                if (value != DBNull.Value)
                {
                    total += Convert.ToSingle(value);
                }
            }
            labelTotal.Text = total.ToString();
            dataGridViewBill.DataSource = table;
            dataGridViewBill.Columns["Id"].HeaderText = "Id Bill";
            dataGridViewBill.Columns["IdVehicle"].HeaderText = "Id Vehicle";
            dataGridViewBill.Columns["TypeOfVehicle"].HeaderText = "Type Of Vehicle";
            dataGridViewBill.Columns["LisencePlate"].HeaderText = "License Plate";
            dataGridViewBill.Columns["Total"].HeaderText = "Total";
            dataGridViewBill.Columns["TimeIn"].HeaderText = "Time In";
            dataGridViewBill.Columns["TimeOut"].HeaderText = "Time Out";
            dataGridViewBill.Columns["Description"].HeaderText = "Description";
            dataGridViewBill.AllowUserToAddRows = false;
        }

        private void ViewIncomeForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonToday_CheckedChanged(object sender, EventArgs e)
        {
            buttonFind.Enabled = false;
            loadToday();
        }

        private void radioButtonRange_CheckedChanged(object sender, EventArgs e)
        {
            buttonFind.Enabled = true;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            Excel.Range headerRange = worksheet.Range["A1", "I1"];
            headerRange.Font.Bold = true;
            headerRange.Font.Size += 2;

            // Ghi header vào file Excel
            for (int j = 0; j < dataGridViewBill.Columns.Count; j++)
            {
                worksheet.Cells[1, j + 1] = dataGridViewBill.Columns[j].HeaderText;
            }

            // Ghi dữ liệu vào file Excel
            for (int i = 0; i < dataGridViewBill.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewBill.Columns.Count; j++)
                {
                    if (dataGridViewBill.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewBill.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }

            // Cài đặt kích thước cho các cột trong file Excel
            worksheet.Columns.AutoFit();

            // Hiển thị SaveFileDialog để chọn đường dẫn lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "output.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu file Excel và đóng các đối tượng Excel
                workbook.SaveAs(saveFileDialog.FileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Export successfully!");
            }
        }

        public void loadRange()
        {
            DateTime startTime = dateTimePickerStart.Value;
            DateTime endTime = dateTimePickerEnd.Value;
            DataTable table = income.getListBillUseRange(startTime, endTime);
            float total = 0;
            foreach (DataRow row in table.Rows)
            {
                var value = row["Total"];
                if (value != DBNull.Value)
                {
                    total += Convert.ToSingle(value);
                }
            }
            labelTotal.Text = total.ToString();
            dataGridViewBill.DataSource = table;
            dataGridViewBill.Columns["Id"].HeaderText = "Id Bill";
            dataGridViewBill.Columns["IdVehicle"].HeaderText = "Id Vehicle";
            dataGridViewBill.Columns["TypeOfVehicle"].HeaderText = "Type Of Vehicle";
            dataGridViewBill.Columns["LisencePlate"].HeaderText = "License Plate";
            dataGridViewBill.Columns["Total"].HeaderText = "Total";
            dataGridViewBill.Columns["TimeIn"].HeaderText = "Time In";
            dataGridViewBill.Columns["TimeOut"].HeaderText = "Time Out";
            dataGridViewBill.Columns["Description"].HeaderText = "Description";
            dataGridViewBill.AllowUserToAddRows = false;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            loadRange();
        }
    }       
}
