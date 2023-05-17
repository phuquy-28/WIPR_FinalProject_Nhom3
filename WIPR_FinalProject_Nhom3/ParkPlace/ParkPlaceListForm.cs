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
    public partial class ParkPlaceListForm : Form
    {
        public ParkPlaceListForm()
        {
            InitializeComponent();
        }
        PARKPLACE parkplace = new PARKPLACE();

        private void ParkPlaceListForm_Load(object sender, EventArgs e)
        {
            loadParkPlaceCarList();
        }

        public void loadParkPlaceCarList()
        {
            labelMaxCapacity.Text = parkplace.getNumOfParkPlaceByType("car").ToString();
            labelEmptyParkPlace.Text = parkplace.getNumOfEmptyParkPlaceByType("car").ToString();
            dataGridViewParkPlaceList.DataSource = parkplace.getParkByTypeOfVehicle("Car");
            dataGridViewParkPlaceList.Columns["IdParkPlace"].HeaderText = "Id Park Place";
            dataGridViewParkPlaceList.Columns["TypeOfCar"].HeaderText = "Type Of Car";
            dataGridViewParkPlaceList.Columns["IdVehicle"].HeaderText = "Id Vehicle";
            dataGridViewParkPlaceList.Columns["LisencePlate"].HeaderText = "License Plate";
            dataGridViewParkPlaceList.Columns["State"].HeaderText = "State";
        }
        public void loadParkPlaceMotorList()
        {
            labelMaxCapacity.Text = parkplace.getNumOfParkPlaceByType("motor").ToString();
            labelEmptyParkPlace.Text = parkplace.getNumOfEmptyParkPlaceByType("motor").ToString();
            dataGridViewParkPlaceList.DataSource = parkplace.getParkByTypeOfVehicle("Motor");
            dataGridViewParkPlaceList.Columns["IdParkPlace"].HeaderText = "Id Park Place";
            dataGridViewParkPlaceList.Columns["TypeOfCar"].HeaderText = "Type Of Car";
            dataGridViewParkPlaceList.Columns["IdVehicle"].HeaderText = "Id Vehicle";
            dataGridViewParkPlaceList.Columns["LisencePlate"].HeaderText = "License Plate";
            dataGridViewParkPlaceList.Columns["State"].HeaderText = "State";
        }
        public void loadParkPlaceBicycleList()
        {
            labelMaxCapacity.Text = parkplace.getNumOfParkPlaceByType("bicycle").ToString();
            labelEmptyParkPlace.Text = parkplace.getNumOfEmptyParkPlaceByType("bicycle").ToString();
            dataGridViewParkPlaceList.DataSource = parkplace.getParkByTypeOfVehicle("Bicycle");
            dataGridViewParkPlaceList.Columns["IdParkPlace"].HeaderText = "Id Park Place";
            dataGridViewParkPlaceList.Columns["TypeOfCar"].HeaderText = "Type Of Car";
            dataGridViewParkPlaceList.Columns["IdVehicle"].HeaderText = "Id Vehicle";
            dataGridViewParkPlaceList.Columns["LisencePlate"].HeaderText = "License Plate";
            dataGridViewParkPlaceList.Columns["State"].HeaderText = "State";
        }

        private void radioButtonCar_CheckedChanged(object sender, EventArgs e)
        {
            loadParkPlaceCarList();
        }

        private void radioButtonMotor_CheckedChanged(object sender, EventArgs e)
        {
            loadParkPlaceMotorList();
        }

        private void radioButtonBicycle_CheckedChanged(object sender, EventArgs e)
        {
            loadParkPlaceBicycleList();
        }

        private void dataGridViewParkPlaceList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if(dataGridViewParkPlaceList.DataSource != null)
            {
                // Duyệt qua từng hàng của DataGridView
                foreach (DataGridViewRow row in dataGridViewParkPlaceList.Rows)
                {
                    // Lấy giá trị của ô trong cột "Tên công viên"
                    if (row.Cells["State"].Value == null)
                        continue;
                    string cellValue = row.Cells["State"].Value.ToString();

                    // Nếu ô chứa chuỗi "park" thì tô màu đỏ
                    if (cellValue.ToLower().Contains("park"))
                    {
                        row.DefaultCellStyle.BackColor = Color.IndianRed;
                    }
                }
            }
           
        }
    }
}
