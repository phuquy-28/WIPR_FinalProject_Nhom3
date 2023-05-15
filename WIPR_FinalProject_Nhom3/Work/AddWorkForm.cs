using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPR_FinalProject_Nhom3
{
    public partial class AddWorkForm : Form
    {
        public AddWorkForm()
        {
            InitializeComponent();
        }

        private void AddWorkForm_Load(object sender, EventArgs e)
        {
            radioButtonCar.Checked = true;
            //
            comboBoxTypeWork.DataSource = work.getTypeOfWork();
            comboBoxTypeWork.ValueMember = "idTypeOfWork";
            comboBoxTypeWork.DisplayMember = "nameTypeOfWork";
        }
        WORK work = new WORK();
        private void buttonAddWork_Click(object sender, EventArgs e)
        {
            try
            {
                string typeOfCar;
                int idWork = Convert.ToInt32(textBoxIdWork.Text);
                string name = textBoxNameWork.Text;
                float price;
                float.TryParse(textBoxPrice.Text, out price);
                int idTypeOfWork = Convert.ToInt32(comboBoxTypeWork.SelectedValue.ToString());
                if (radioButtonCar.Checked == true) { typeOfCar = "Car"; }
                else if (radioButtonMotobike.Checked == true) { typeOfCar = "Motobike"; }
                else { typeOfCar = "Bicycle"; }
                if (work.idWorkExist(idWork)==false)
                {
                    if (work.insertWork(idWork, name, price, idTypeOfWork, typeOfCar))
                    {
                        MessageBox.Show("Work Added", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Work Not Added!", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Id Work Is Exist!", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Work Not Added!", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
