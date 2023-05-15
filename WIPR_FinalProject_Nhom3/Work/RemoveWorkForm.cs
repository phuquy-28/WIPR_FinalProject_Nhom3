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
    public partial class RemoveWorkForm : Form
    {
        public RemoveWorkForm()
        {
            InitializeComponent();
        }
        WORK work = new WORK();
        private void RemoveWorkForm_Load(object sender, EventArgs e)
        {
            comboBoxNameWork.DataSource = work.getWork();
            comboBoxNameWork.ValueMember = "idWork";
            comboBoxNameWork.DisplayMember = "Name";
            //
        }
        private void buttonRemoveWork_Click(object sender, EventArgs e)
        {
            try
            {
                int idWork = Convert.ToInt32(comboBoxNameWork.SelectedValue.ToString());
                if (work.deleteWork(idWork))
                {
                    MessageBox.Show("Work Deleted", "Delete Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveWorkForm_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Work Not Deleted", "Delete Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
