using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR_FinalProject_Nhom3
{
    public partial class DeleteVehicleForm : Form
    {
        public DeleteVehicleForm()
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxIdVehicle.Text.ToString();
                if (vehicle.deleteVehicle(id))
                {
                    MessageBox.Show("Deleting successfully", "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deleting faild", "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
