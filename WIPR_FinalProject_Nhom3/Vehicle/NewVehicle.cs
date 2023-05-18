using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR_FinalProject_Nhom3
{
    public partial class AddVehicleForm : Form
    {
        VEHICLE vehicle = new VEHICLE();
        public AddVehicleForm()
        {
            InitializeComponent();
            dateTimePickerTimeIn.Format = DateTimePickerFormat.Custom;
            dateTimePickerTimeIn.CustomFormat = "dd/MM/yy hh:mm:tt";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            buttonAddWork.Enabled = false;
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
            textBoxBrand.Enabled = false ;
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

        public bool checkEmptyField(string typeOfVehicle)
        {
            if (typeOfVehicle == "bicycle")
            {
                if (textBoxIdVehicle.Text == "" || pictureBox1.Image == null || pictureBox2.Image == null)
                {
                    return false;
                }
            }
            else
            {
                if (textBoxIdVehicle.Text == "" || textBoxLicensePlate.Text == "" || pictureBox1.Image == null || pictureBox2.Image == null)
                {
                    return false;
                }
            }
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string IdVehicle = textBoxIdVehicle.Text.ToString();
                string type;
                if (radioButtonBicycle.Checked)
                    type = radioButtonBicycle.Text.ToString();
                else if (radioButtonMotor.Checked)
                    type = radioButtonMotor.Text.ToString();
                else
                    type = radioButtonCar.Text.ToString();
                string dateString = dateTimePickerTimeIn.Value.ToString("dd/MM/yyyy hh:mm:tt");
                DateTime timeIn = DateTime.ParseExact(dateString, "dd/MM/yyyy hh:mm:tt", CultureInfo.InvariantCulture);
                string plate = textBoxLicensePlate.Text.ToString();
                string brand = textBoxBrand.Text.ToString();

                MemoryStream platePic = new MemoryStream();
                MemoryStream brandPic = new MemoryStream();
                MemoryStream cusPic = new MemoryStream();
                MemoryStream vehiclePic = new MemoryStream();
                if (radioButtonCar.Checked)
                {
                    pictureBox1.Image.Save(platePic, pictureBox1.Image.RawFormat);
                    pictureBox2.Image.Save(brandPic, pictureBox2.Image.RawFormat);
                }
                else if (radioButtonMotor.Checked)
                {
                    pictureBox1.Image.Save(platePic, pictureBox1.Image.RawFormat);
                    pictureBox2.Image.Save(cusPic, pictureBox2.Image.RawFormat);
                }
                else
                {
                    pictureBox1.Image.Save(vehiclePic, pictureBox1.Image.RawFormat);
                    pictureBox2.Image.Save(cusPic, pictureBox2.Image.RawFormat);
                }

                if (!vehicle.IdVehicleIsExist(IdVehicle))
                {
                    if (radioButtonCar.Checked)
                    {
                        if (vehicle.insertVehicle(type, IdVehicle, timeIn, platePic, brandPic, plate, brand))
                        {
                            MessageBox.Show("Adding successfully", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            buttonAddWork.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Adding fail", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (radioButtonMotor.Checked)
                    {
                        if (vehicle.insertVehicle(type, IdVehicle, timeIn, platePic, cusPic, plate, brand))
                        {
                            MessageBox.Show("Adding successfully", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            buttonAddWork.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Adding fail", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (vehicle.insertVehicle(type, IdVehicle, timeIn, vehiclePic, cusPic))
                        {
                            MessageBox.Show("Adding successfully", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            buttonAddWork.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Adding fail", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("IdVehicle has already exist", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddWork_Click(object sender, EventArgs e)
        {
            AddBillForm addBillFrm = new AddBillForm();
            addBillFrm.idVehicle = textBoxIdVehicle.Text.ToString();
            string dateString = dateTimePickerTimeIn.Value.ToString("dd/MM/yyyy hh:mm:tt");
            DateTime timeIn = DateTime.ParseExact(dateString, "dd/MM/yyyy hh:mm:tt", CultureInfo.InvariantCulture);
            addBillFrm.TimeIn = timeIn;
            if (radioButtonCar.Checked)
                addBillFrm.typeOfVehicle = "Car";
            else if(radioButtonMotor.Checked)
                addBillFrm.typeOfVehicle = "Motor";
            else
                addBillFrm.typeOfVehicle = "Bicycle";

            if (radioButtonCar.Checked || radioButtonMotor.Checked)
                addBillFrm.licensePlate = textBoxLicensePlate.Text.ToString();
            else
                addBillFrm.licensePlate = "";

            addBillFrm.ShowDialog();
        }
    }
}
