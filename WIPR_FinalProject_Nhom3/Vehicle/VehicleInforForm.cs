using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR_FinalProject_Nhom3
{
    public partial class VehicleInforForm : Form
    {
        public VehicleInforForm()
        {
            InitializeComponent();
            dateTimePickerTimeIn.Format = DateTimePickerFormat.Custom;
            dateTimePickerTimeIn.CustomFormat = "dd/MM/yy hh:mm:tt";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        VEHICLE vehicle = new VEHICLE();

        private void buttonFindById_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxIdVehicle.Text.ToString();
                DataTable table = vehicle.findById(id);
                if (table.Rows.Count > 0)
                {
                    if (table.Rows[0]["Type"].ToString().ToLower() == "car")
                    {
                        //gán radiobuttonCar, gán hình biển số
                        radioButtonCar.Checked = true;
                        if (table.Rows[0]["LicensePlatePicture"] != System.DBNull.Value)
                        {
                            byte[] pic = (byte[])table.Rows[0]["LicensePlatePicture"];
                            MemoryStream platePic = new MemoryStream(pic);
                            pictureBox1.Image = Image.FromStream(platePic);
                        }
                        if (table.Rows[0]["BrandPicture"] != System.DBNull.Value)
                        {
                            //gán hình hiệu xe
                            byte[] pic2 = (byte[])table.Rows[0]["BrandPicture"];
                            MemoryStream brandPic = new MemoryStream(pic2);
                            pictureBox2.Image = Image.FromStream(brandPic);
                        }

                        //chỉnh label
                        labelImageOrPlate.Text = "Plate Image:";
                        labelCustomerOrBrand.Text = "Brand Image:";
                        textBoxLicensePlate.Enabled = true;
                        textBoxBrand.Enabled = true;
                    }
                    else if (table.Rows[0]["Type"].ToString().ToLower() == "motor")
                    {
                        radioButtonMotor.Checked = true;
                        if (table.Rows[0]["LicensePlatePicture"] != System.DBNull.Value)
                        {
                            byte[] pic = (byte[])table.Rows[0]["LicensePlatePicture"];
                            MemoryStream platePic = new MemoryStream(pic);
                            pictureBox1.Image = Image.FromStream(platePic);
                        }

                        if (table.Rows[0]["CustomerPicture"] != System.DBNull.Value)
                        {
                            byte[] pic2 = (byte[])table.Rows[0]["CustomerPicture"];
                            MemoryStream cusPic = new MemoryStream(pic2);
                            pictureBox2.Image = Image.FromStream(cusPic);
                        }

                        textBoxLicensePlate.Enabled = true;
                        labelImageOrPlate.Text = "Plate Image:";
                        labelCustomerOrBrand.Text = "Customer Image:";
                        textBoxBrand.Enabled = true;
                    }
                    else if (table.Rows[0]["Type"].ToString().ToLower() == "bicycle")
                    {
                        radioButtonBicycle.Checked = true;
                        if (table.Rows[0]["VehiclePicture"] != System.DBNull.Value)
                        {
                            byte[] pic = (byte[])table.Rows[0]["VehiclePicture"];
                            MemoryStream vehiclePic = new MemoryStream(pic);
                            pictureBox1.Image = Image.FromStream(vehiclePic);
                        }

                        if (table.Rows[0]["CustomerPicture"] != System.DBNull.Value)
                        {
                            byte[] pic2 = (byte[])table.Rows[0]["CustomerPicture"];
                            MemoryStream cusPic = new MemoryStream(pic2);
                            pictureBox2.Image = Image.FromStream(cusPic);
                        }

                        textBoxLicensePlate.Enabled = false;
                        labelImageOrPlate.Text = "Bicycle Image:";
                        labelCustomerOrBrand.Text = "Customer Image:";
                        textBoxBrand.Enabled = false;
                    }

                    textBoxLicensePlate.Text = table.Rows[0]["LisencePlate"].ToString();
                    textBoxBrand.Text = table.Rows[0]["BrandName"].ToString();


                    string dateString = table.Rows[0]["TimeIn"].ToString();
                    DateTime dateValue;
                    if (DateTime.TryParse(dateString, out dateValue))
                    {
                        dateTimePickerTimeIn.Format = DateTimePickerFormat.Custom;
                        dateTimePickerTimeIn.CustomFormat = "dd/MM/yy hh:mm:ss";
                        dateTimePickerTimeIn.Value = dateValue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonFindByPlate_Click(object sender, EventArgs e)
        {
            string plate = textBoxIdVehicle.Text.ToString();
            DataTable table = vehicle.findByPlate(plate);
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0]["Type"].ToString().ToLower() == "car")
                {
                    //gán radiobuttonCar, gán hình biển số
                    radioButtonCar.Checked = true;
                    if (table.Rows[0]["LicensePlatePicture"] != System.DBNull.Value)
                    {
                        byte[] pic = (byte[])table.Rows[0]["LicensePlatePicture"];
                        MemoryStream platePic = new MemoryStream(pic);
                        pictureBox1.Image = Image.FromStream(platePic);
                    }
                    if (table.Rows[0]["BrandPicture"] != System.DBNull.Value)
                    {
                        //gán hình hiệu xe
                        byte[] pic2 = (byte[])table.Rows[0]["BrandPicture"];
                        MemoryStream brandPic = new MemoryStream(pic2);
                        pictureBox2.Image = Image.FromStream(brandPic);
                    }

                    //chỉnh label
                    labelImageOrPlate.Text = "Plate Image:";
                    labelCustomerOrBrand.Text = "Brand Image:";
                    textBoxLicensePlate.Enabled = true;
                    textBoxBrand.Enabled = true;
                }
                else if (table.Rows[0]["Type"].ToString().ToLower() == "motor")
                {
                    radioButtonMotor.Checked = true;
                    if (table.Rows[0]["LicensePlatePicture"] != System.DBNull.Value)
                    {
                        byte[] pic = (byte[])table.Rows[0]["LicensePlatePicture"];
                        MemoryStream platePic = new MemoryStream(pic);
                        pictureBox1.Image = Image.FromStream(platePic);
                    }

                    if (table.Rows[0]["CustomerPicture"] != System.DBNull.Value)
                    {
                        byte[] pic2 = (byte[])table.Rows[0]["CustomerPicture"];
                        MemoryStream cusPic = new MemoryStream(pic2);
                        pictureBox2.Image = Image.FromStream(cusPic);
                    }

                    textBoxLicensePlate.Enabled = true;
                    labelImageOrPlate.Text = "Plate Image:";
                    labelCustomerOrBrand.Text = "Customer Image:";
                    textBoxBrand.Enabled = true;
                }
                else if (table.Rows[0]["Type"].ToString().ToLower() == "bicycle")
                {
                    radioButtonBicycle.Checked = true;
                    if (table.Rows[0]["VehiclePicture"] != System.DBNull.Value)
                    {
                        byte[] pic = (byte[])table.Rows[0]["VehiclePicture"];
                        MemoryStream vehiclePic = new MemoryStream(pic);
                        pictureBox1.Image = Image.FromStream(vehiclePic);
                    }

                    if (table.Rows[0]["CustomerPicture"] != System.DBNull.Value)
                    {
                        byte[] pic2 = (byte[])table.Rows[0]["CustomerPicture"];
                        MemoryStream cusPic = new MemoryStream(pic2);
                        pictureBox2.Image = Image.FromStream(cusPic);
                    }

                    textBoxLicensePlate.Enabled = false;
                    labelImageOrPlate.Text = "Bicycle Image:";
                    labelCustomerOrBrand.Text = "Customer Image:";
                    textBoxBrand.Enabled = false;
                }

                textBoxLicensePlate.Text = table.Rows[0]["LisencePlate"].ToString();
                textBoxBrand.Text = table.Rows[0]["BrandName"].ToString();


                string dateString = table.Rows[0]["TimeIn"].ToString();
                DateTime dateValue;
                if (DateTime.TryParse(dateString, out dateValue))
                {
                    dateTimePickerTimeIn.Format = DateTimePickerFormat.Custom;
                    dateTimePickerTimeIn.CustomFormat = "dd/MM/yy hh:mm:ss";
                    dateTimePickerTimeIn.Value = dateValue;
                }
            }
        }

        private void radioButtonCar_CheckedChanged(object sender, EventArgs e)
        {
            labelImageOrPlate.Text = "Plate Image:";
            labelCustomerOrBrand.Text = "Brand Image:";
            textBoxLicensePlate.Enabled = true;
            textBoxBrand.Enabled = true;
        }

        private void radioButtonMotor_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLicensePlate.Enabled = true;
            labelImageOrPlate.Text = "Plate Image:";
            labelCustomerOrBrand.Text = "Customer Image:";
            textBoxBrand.Enabled = true;
        }

        private void radioButtonBicycle_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLicensePlate.Enabled = false;
            labelImageOrPlate.Text = "Bicycle Image:";
            labelCustomerOrBrand.Text = "Customer Image:";
            textBoxBrand.Enabled = false;
        }

        private void buttonUpload1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonUpload2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutForm checkOutFrm = new CheckOutForm();
            string dateString = dateTimePickerTimeIn.Value.ToString("dd/MM/yyyy hh:mm:tt");
            DateTime timeIn = DateTime.ParseExact(dateString, "dd/MM/yyyy hh:mm:tt", CultureInfo.InvariantCulture);
            checkOutFrm.TimeIn = timeIn;
            checkOutFrm.IdVehicle = textBoxIdVehicle.Text;
            checkOutFrm.Plate = textBoxLicensePlate.Text;
            checkOutFrm.ShowDialog();
        }

        private void buttonViewContract_Click(object sender, EventArgs e)
        {
            ViewVehicleContractForm vehicleContractFrm = new ViewVehicleContractForm();
            vehicleContractFrm.idVehicle = textBoxIdVehicle.Text.ToString();
            vehicleContractFrm.ShowDialog();
        }
    }
}
