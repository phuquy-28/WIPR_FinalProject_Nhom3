﻿using System;
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
            buttonFindCt.Enabled = false;
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
        public void loadTodayCt()
        {
            DataTable table = income.getListContractToday();
            // Khởi tạo các biến tính tổng
            float rentTotal = 0;
            float forRentTotal = 0;

            // Duyệt qua từng hàng trong DataTable
            foreach (DataRow row in table.Rows)
            {
                // Kiểm tra nếu TypeOfContract là 'rent'
                if (row["TypeOfContract"].ToString() == "rent")
                {
                    // Cộng dồn giá trị của trường 'Total' cho rentTotal
                    rentTotal += Convert.ToSingle(row["Total"]);
                }
                // Kiểm tra nếu TypeOfContract là 'for rent'
                else if (row["TypeOfContract"].ToString() == "for rent")
                {
                    // Cộng dồn giá trị của trường 'Total' cho forRentTotal
                    forRentTotal += Convert.ToSingle(row["Total"]);
                }
            }
            dataGridViewContractList.DataSource = table;
            dataGridViewContractList.Columns["description"].HeaderText = "Description";
            labelRentTotal.Text = rentTotal.ToString();
            labelForRentTotal.Text = forRentTotal.ToString();

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
        public void loadRangeCt()
        {
            DateTime startTime = dateTimePickerStartCt.Value;
            DateTime endTime = dateTimePickerEndCt.Value;
            DataTable table = income.getListContractUseRange(startTime, endTime);
            // Khởi tạo các biến tính tổng
            float rentTotal = 0;
            float forRentTotal = 0;

            // Duyệt qua từng hàng trong DataTable
            foreach (DataRow row in table.Rows)
            {
                // Kiểm tra nếu TypeOfContract là 'rent'
                if (row["TypeOfContract"].ToString() == "rent")
                {
                    // Cộng dồn giá trị của trường 'Total' cho rentTotal
                    rentTotal += Convert.ToSingle(row["Total"]);
                }
                // Kiểm tra nếu TypeOfContract là 'for rent'
                else if (row["TypeOfContract"].ToString() == "for rent")
                {
                    // Cộng dồn giá trị của trường 'Total' cho forRentTotal
                    forRentTotal += Convert.ToSingle(row["Total"]);
                }
            }
            dataGridViewContractList.DataSource = table;
            dataGridViewContractList.Columns["description"].HeaderText = "Description";
            labelRentTotal.Text = rentTotal.ToString();
            labelForRentTotal.Text = forRentTotal.ToString();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            loadRange();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                loadToday();
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                loadTodayCt();
            }
        }

        private void radioButtonTodayCt_CheckedChanged(object sender, EventArgs e)
        {
            buttonFindCt.Enabled = false;
            loadTodayCt();
        }

        private void radioButtonRangeCt_CheckedChanged(object sender, EventArgs e)
        {
            buttonFindCt.Enabled = true;
        }

        private void buttonFindCt_Click(object sender, EventArgs e)
        {
            loadRangeCt();
        }

        private void buttonExportCt_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            Excel.Range headerRange = worksheet.Range["A1", "I1"];
            headerRange.Font.Bold = true;
            headerRange.Font.Size += 2;

            // Ghi header vào file Excel
            for (int j = 0; j < dataGridViewContractList.Columns.Count; j++)
            {
                worksheet.Cells[1, j + 1] = dataGridViewContractList.Columns[j].HeaderText;
            }

            // Ghi dữ liệu vào file Excel
            for (int i = 0; i < dataGridViewContractList.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewContractList.Columns.Count; j++)
                {
                    if (dataGridViewContractList.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewContractList.Rows[i].Cells[j].Value.ToString();
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
    }       
}
