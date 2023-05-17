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
    public partial class AddParkPlaceForm : Form
    {
        public AddParkPlaceForm()
        {
            InitializeComponent();
        }
        PARKPLACE parkplace = new PARKPLACE();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string type = "";
            if (radioButtonCar.Checked)
                type = "Car";
            else if (radioButtonMotor.Checked)
                type = "Motor";
            else
                type = "Bicycle";

            string id = textBoxIdParkPlace.Text.ToString();

            if (!parkplace.IdParkPlaceIsExist(id))
            {
                if (parkplace.addParkPlace(id, type))
                {
                    MessageBox.Show("Adding successfully", "Add Park Place", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Adding fail", "Add Park Place", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Id Park Place has already exist", "Add Park Place", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
