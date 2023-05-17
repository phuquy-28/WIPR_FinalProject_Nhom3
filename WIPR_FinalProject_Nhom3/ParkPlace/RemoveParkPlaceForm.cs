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
    public partial class RemoveParkPlaceForm : Form
    {
        public RemoveParkPlaceForm()
        {
            InitializeComponent();
            
        }
        PARKPLACE parkplace = new PARKPLACE();

        private void button1_Click(object sender, EventArgs e)
        {
            string idParkPlace = "";
            if (dataGridViewEmptyParkPlace.CurrentRow.Cells["IdParkPlace"].Value != System.DBNull.Value)
                idParkPlace = dataGridViewEmptyParkPlace.CurrentRow.Cells["IdParkPlace"].Value.ToString();
            if (parkplace.deleteEmptyParkPlace(idParkPlace))
            {
                MessageBox.Show("Deleting successfully", "Delete Park Place", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RemoveParkPlaceForm_Load(null, null);
            }
            else
            {
                MessageBox.Show("Deleting fail", "Delete Park Place", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveParkPlaceForm_Load(object sender, EventArgs e)
        {
            dataGridViewEmptyParkPlace.DataSource = parkplace.getEmptyParkPlace();
            dataGridViewEmptyParkPlace.Columns["IdParkPlace"].HeaderText = "Id Park Place";
            dataGridViewEmptyParkPlace.Columns["TypeOfCar"].HeaderText = "Type Of Vehicle";
        }
    }
}
