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
    public partial class VehicleListForm : Form
    {
        public VehicleListForm()
        {
            InitializeComponent();
        }
        VEHICLE vehicle = new VEHICLE();

        private void VehicleListForm_Load(object sender, EventArgs e)
        {
            dataGridViewVehicleList.DataSource = null;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();

            dataGridViewVehicleList.RowTemplate.Height = 80;

            dataGridViewVehicleList.DataSource = vehicle.getCarList();
            dataGridViewVehicleList.Columns["IdVehicle"].HeaderText = "Id Vehicle";
            dataGridViewVehicleList.Columns["TimeIn"].HeaderText = "Time In";
            dataGridViewVehicleList.Columns["LisencePlate"].HeaderText = "License Plate";
            dataGridViewVehicleList.Columns["BrandName"].HeaderText = "Brand Name";
            dataGridViewVehicleList.Columns["IdParkPlace"].HeaderText = "Park Place";
            dataGridViewVehicleList.Columns["LicensePlatePicture"].HeaderText = "Plate Picture";
            dataGridViewVehicleList.Columns["BrandPicture"].HeaderText = "Brand Picture";
            //dataGridViewVehicleList.Columns["CustomerPicture"].HeaderText = "Customer Picture";
            //dataGridViewVehicleList.Columns["VehiclePicture"].HeaderText = "Vehicle Picture";
            dataGridViewVehicleList.AllowUserToAddRows = false;

            picCol = (DataGridViewImageColumn)dataGridViewVehicleList.Columns["LicensePlatePicture"];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)dataGridViewVehicleList.Columns["BrandPicture"];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        public void loadMotorList()
        {
            dataGridViewVehicleList.DataSource = null;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();

            dataGridViewVehicleList.RowTemplate.Height = 80;

            dataGridViewVehicleList.DataSource = vehicle.getMotorList();
            dataGridViewVehicleList.Columns["IdVehicle"].HeaderText = "Id Vehicle";
            dataGridViewVehicleList.Columns["TimeIn"].HeaderText = "Time In";
            dataGridViewVehicleList.Columns["LisencePlate"].HeaderText = "License Plate";
            dataGridViewVehicleList.Columns["BrandName"].HeaderText = "Brand Name";
            dataGridViewVehicleList.Columns["IdParkPlace"].HeaderText = "Park Place";
            dataGridViewVehicleList.Columns["LicensePlatePicture"].HeaderText = "Plate Picture";
            //dataGridViewVehicleList.Columns["BrandPicture"].HeaderText = "Brand Picture";
            dataGridViewVehicleList.Columns["CustomerPicture"].HeaderText = "Customer Picture";
            //dataGridViewVehicleList.Columns["VehiclePicture"].HeaderText = "Vehicle Picture";
            dataGridViewVehicleList.AllowUserToAddRows = false;

            picCol = (DataGridViewImageColumn)dataGridViewVehicleList.Columns["LicensePlatePicture"];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)dataGridViewVehicleList.Columns["CustomerPicture"];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        public void loadBicycleList()
        {
            dataGridViewVehicleList.DataSource = null;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();

            dataGridViewVehicleList.RowTemplate.Height = 80;

            dataGridViewVehicleList.DataSource = vehicle.getBicycleList();
            dataGridViewVehicleList.Columns["IdVehicle"].HeaderText = "Id Vehicle";
            dataGridViewVehicleList.Columns["TimeIn"].HeaderText = "Time In";
            //dataGridViewVehicleList.Columns["LisencePlate"].HeaderText = "License Plate";
            //dataGridViewVehicleList.Columns["BrandName"].HeaderText = "Brand Name";
            dataGridViewVehicleList.Columns["IdParkPlace"].HeaderText = "Park Place";
            //dataGridViewVehicleList.Columns["LicensePlatePicture"].HeaderText = "Plate Picture";
            //dataGridViewVehicleList.Columns["BrandPicture"].HeaderText = "Brand Picture";
            dataGridViewVehicleList.Columns["VehiclePicture"].HeaderText = "Vehicle Picture";
            dataGridViewVehicleList.Columns["CustomerPicture"].HeaderText = "Customer Picture";
            dataGridViewVehicleList.AllowUserToAddRows = false;

            picCol = (DataGridViewImageColumn)dataGridViewVehicleList.Columns["VehiclePicture"];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)dataGridViewVehicleList.Columns["CustomerPicture"];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void radioButtonCar_CheckedChanged(object sender, EventArgs e)
        {
            VehicleListForm_Load(null, null);
        }

        private void radioButtonMotor_CheckedChanged(object sender, EventArgs e)
        {
            loadMotorList();
        }

        private void radioButtonBicycle_CheckedChanged(object sender, EventArgs e)
        {
            loadBicycleList();
        }

        private void dataGridViewVehicleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewVehicleList_DoubleClick(object sender, EventArgs e)
        {
            VehicleInforForm checkOutFrm = new VehicleInforForm();
            checkOutFrm.textBoxIdVehicle.Text = dataGridViewVehicleList.CurrentRow.Cells["IdVehicle"].Value.ToString();
            checkOutFrm.ShowDialog();
            VehicleListForm_Load(null, null);
        }
    }
}
