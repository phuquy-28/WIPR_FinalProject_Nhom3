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
    public partial class DeleteContractForm : Form
    {
        public DeleteContractForm()
        {
            InitializeComponent();
        }
        CONTRACT contract = new CONTRACT();

        private void buttonFind_Click(object sender, EventArgs e)
        {
            SelectContractForm selectContractFrm = new SelectContractForm();

            selectContractFrm.ShowDialog();
            textBoxContractId.Text = selectContractFrm.dataGridViewSelectContact.CurrentRow.Cells["IdContract"].Value.ToString();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string contractid = textBoxContractId.Text.ToString();
            if (contract.deleteContract(contractid)){
                MessageBox.Show("deleting successfully");
            }
            else
            {
                MessageBox.Show("deleting fail");
            }
        }
    }
}
