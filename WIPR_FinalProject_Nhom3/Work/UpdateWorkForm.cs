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
    public partial class UpdateWorkForm : Form
    {
        public UpdateWorkForm()
        {
            InitializeComponent();
        }
        int idWork = 1;
        string typeOfCar = "Car";
        int idTypeOfWork = 1;
        float price = 0;
        WORK work = new WORK();
        private void UpdateWorkForm_Load(object sender, EventArgs e)
        {
            comboBoxNameWork.DataSource = work.getWork();
            comboBoxNameWork.ValueMember = "idWork";
            comboBoxNameWork.DisplayMember = "Name";
            //
            comboBoxTypeWork.DataSource = work.getTypeOfWork();
            comboBoxTypeWork.ValueMember = "idTypeOfWork";
            comboBoxTypeWork.DisplayMember = "nameTypeOfWork";
            //
            idWork = Convert.ToInt32(comboBoxNameWork.SelectedValue.ToString());
            DataTable dt = work.getWorkById(idWork);
            typeOfCar = dt.Rows[0]["TypeOfCar"].ToString();
            if (typeOfCar == "Car") { radioButtonCar.Checked = true; }
            else if (typeOfCar == "Motobike") { radioButtonMotobike.Checked = true; }
            else { radioButtonBicycle.Checked = true; }
            //
            idTypeOfWork = Convert.ToInt32(dt.Rows[0]["idTypeOfWork"].ToString());
            comboBoxTypeWork.SelectedValue = idTypeOfWork;
            //
            textBoxPrice.Text = dt.Rows[0]["price"].ToString();
        }

        private void comboBoxNameWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            try
            {
                if (comboBoxNameWork.SelectedValue != null)
                {
                    idWork = Convert.ToInt32(comboBoxNameWork.SelectedValue.ToString());
                }
                DataTable dt = work.getWorkById(idWork);
                string typeOfCar = dt.Rows[0]["TypeOfCar"].ToString();
                if (typeOfCar == "Car") { radioButtonCar.Checked = true; }
                else if (typeOfCar == "Motobike") { radioButtonMotobike.Checked = true; }
                else { radioButtonBicycle.Checked = true; }
                //
                idTypeOfWork = Convert.ToInt32(dt.Rows[0]["idTypeOfWork"].ToString());
                comboBoxTypeWork.SelectedValue = idTypeOfWork;
                //
                textBoxPrice.Text = dt.Rows[0]["price"].ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonEditWork_Click(object sender, EventArgs e)
        {
            try
            {
                string typeOfCar;
                int idWork = Convert.ToInt32(comboBoxNameWork.SelectedValue.ToString());
                float price;
                float.TryParse(textBoxPrice.Text, out price);
                int idTypeOfWork = Convert.ToInt32(comboBoxTypeWork.SelectedValue.ToString());
                if (radioButtonCar.Checked == true) { typeOfCar = "Car"; }
                else if (radioButtonMotobike.Checked == true) { typeOfCar = "Motor"; }
                else { typeOfCar = "Bicycle"; }
                if (work.editWork(idWork, price, idTypeOfWork, typeOfCar))
                {
                    MessageBox.Show("Work Edited", "Edit Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateWorkForm_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Work Not Edited!", "Edit Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Work Not Edited!", "Add Work", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
