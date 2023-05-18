using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR_FinalProject_Nhom3
{
    public partial class AddDetailContractForm : Form
    {
        public AddDetailContractForm()
        {
            InitializeComponent();
            
        }
        public string contractId { get; set; }
        public string customerId { get; set; }
        public string typeOfContract { get; set; }
        CONTRACT contract = new CONTRACT();
        public void reloadloadListBox()
        {
            if(typeOfContract.ToLower() == "rent")
                listBoxAvail.DataSource = contract.getVehicleRent();
            else if (typeOfContract.ToLower() == "for rent")
                listBoxAvail.DataSource = contract.getVehicleForRen();
            listBoxAvail.DisplayMember = "IdVehicle";
            listBoxAvail.ValueMember = "IdVehicle";
            listBoxAvail.SelectedItem = null;

            listBoxSelect.Items.Clear();
        }

        private void AddDetailContractForm_Load(object sender, EventArgs e)
        {
            labelContractId.Text = $"Contract Id: {contractId}";
            labelCustomerId.Text = $"Customer Id: {customerId}";
            labelTypeOfContract.Text = $"Type of Contract: {typeOfContract}";
            reloadloadListBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxAvail.SelectedItem != null) // Kiểm tra nếu có item được chọn trong lisbAvail
            {
                // Lấy ra dòng đã chọn trong ListBox
                DataRowView selectedRow = (DataRowView)listBoxAvail.SelectedItem;
                string idvehi = selectedRow["IdVehicle"].ToString();
                string typeVehi = selectedRow["Type"].ToString();
                string license = selectedRow["LisencePlate"].ToString();
                DateTime start = dateTimePickerStart.Value;
                DateTime end = dateTimePickerEnd.Value;
                string description = richTextBoxDes.Text.ToString();
                if (contract.addDetailContract(contractId, idvehi, typeVehi, license, start, end, description))
                {
                    // Thêm bản sao này vào ListBox
                    listBoxSelect.Items.Add(selectedRow);
                    listBoxSelect.ValueMember = "IdVehicle";
                    listBoxSelect.DisplayMember = "IdVehicle";

                    // Lấy ra DataTable đã liên kết với ListBox
                    DataTable dt = (DataTable)listBoxAvail.DataSource;
                    dt.Rows.Remove(selectedRow.Row);
                    MessageBox.Show("Add Detail Contract successfully", "Add Detail Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dateTimePickerStart.ResetText();
                    dateTimePickerEnd.ResetText();
                    richTextBoxDes.Clear();
                }
                else
                {
                    MessageBox.Show("Add Detail Contract fail", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void labelAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicleFrm = new AddVehicleForm();
            addVehicleFrm.ShowDialog();
            reloadloadListBox();
        }
    }
}
