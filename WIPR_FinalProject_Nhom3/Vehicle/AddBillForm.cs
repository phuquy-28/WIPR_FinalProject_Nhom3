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
    public partial class AddBillForm : Form
    {
        public string idVehicle { get; set; }
        public string typeOfVehicle { get; set; }
        public string licensePlate { get; set; }
        public DateTime TimeIn { get; set; }
        public AddBillForm()
        {
            InitializeComponent();
            listBoxAvail.Enabled = false;
            listBoxSelect.Enabled = false;
            buttonAddWork.Enabled = false;
        }
        Bill bill = new Bill();

        public bool verif()
        {
            if (textBoxIdBill.Text.ToString() == ""||
                idVehicle == ""||
                typeOfVehicle == "")
                return false;
            return true;
        }

        private void buttonAddBill_Click(object sender, EventArgs e)
        {
            string idBill = textBoxIdBill.Text.ToString();
            if (!verif())
            {
                MessageBox.Show("Empty Fields", "Add Bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!bill.IdBillIsExist(idBill))
            {
                if (bill.addBill(idBill, idVehicle, typeOfVehicle, TimeIn, licensePlate))
                {
                    MessageBox.Show("Adding Bill successfully", "Add Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxIdBill.Enabled = false;
                    listBoxAvail.Enabled = true;
                    listBoxSelect.Enabled = true;
                    buttonAddWork.Enabled = true;
                    reloadloadListBox();
                }
                else
                {
                    MessageBox.Show("Adding Bill fail", "Add Bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Id has already exist", "Add Bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void reloadloadListBox()
        {
            listBoxAvail.DataSource = bill.getWorkListByTypeCar(typeOfVehicle);
            listBoxAvail.DisplayMember = "name";
            listBoxAvail.ValueMember = "IdWork";
            listBoxAvail.SelectedItem = null;

            listBoxSelect.Items.Clear();
        }

        private void buttonAddWork_Click(object sender, EventArgs e)
        {
            if (listBoxAvail.SelectedItem != null) // Kiểm tra nếu có item được chọn trong lisbAvail
            {
                // Lấy ra dòng đã chọn trong ListBox
                DataRowView selectedRow = (DataRowView)listBoxAvail.SelectedItem;
                string idBill = textBoxIdBill.Text.ToString();
                string idWork = selectedRow["IdWork"].ToString();
                double price = (double)selectedRow["Price"];
                if ((Int32)selectedRow["idTypeOfWork"] == 1)
                {
                    SelectParkPlaceForm selectParkPlaceFrm = new SelectParkPlaceForm();
                    selectParkPlaceFrm.idBill = idBill;
                    selectParkPlaceFrm.idWork = idWork;
                    selectParkPlaceFrm.price = (float)price;
                    selectParkPlaceFrm.typeOfVehicle = selectedRow["TypeOfCar"].ToString();
                    selectParkPlaceFrm.idVehicle = idVehicle;
                    selectParkPlaceFrm.licensePlate = licensePlate;
                    // Thêm bản sao này vào ListBox
                    listBoxSelect.Items.Add(selectedRow);
                    listBoxSelect.ValueMember = "IdWork";
                    listBoxSelect.DisplayMember = "name";

                    // Lấy ra DataTable đã liên kết với ListBox
                    DataTable dt = (DataTable)listBoxAvail.DataSource;
                    dt.Rows.Remove(selectedRow.Row);
                    selectParkPlaceFrm.ShowDialog();
                    return;
                }
                else
                {
                    if(bill.addDetailBill(idBill, idWork, price))
                    {
                        MessageBox.Show("Adding work successfully", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Adding work fail", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    // Thêm bản sao này vào ListBox
                    listBoxSelect.Items.Add(selectedRow);
                    listBoxSelect.ValueMember = "IdWork";
                    listBoxSelect.DisplayMember = "name";

                    // Lấy ra DataTable đã liên kết với ListBox
                    DataTable dt = (DataTable)listBoxAvail.DataSource;
                    dt.Rows.Remove(selectedRow.Row);
                }
                
            }
        }
    }
}
