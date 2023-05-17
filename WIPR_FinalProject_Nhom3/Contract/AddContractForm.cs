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
    public partial class AddContractForm : Form
    {
        public AddContractForm()
        {
            InitializeComponent();
            buttonAddDetail.Enabled = false;
        }
        CONTRACT contract = new CONTRACT();


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string typeOfContract = "";
            if (radioButtonRent.Checked)
                typeOfContract = "rent";
            else
                typeOfContract = "for rent";
            string contractId = textBoxContractId.Text.ToString();
            string customerId = textBoxCustomerId.Text.ToString();
            string customerName = textBoxCustomerName.Text.ToString();
            string customerPhone = textBoxCustomerPhone.Text.ToString();
            DateTime dateCreate = dateTimePickerDateCreate.Value;
            float total;
            if (float.TryParse(textBoxTotal.Text, out total))
            {
                
            }
            else
            {
                MessageBox.Show("Hãy nhập vào một số thực");
                return;
            }

            string description = richTextBoxDescription.Text.ToString();

            if (!contract.IdCustomerIsExist(customerId))
            {
                if(contract.addCustomer(customerId, customerName, customerPhone))
                {

                }
            }

            if (!contract.IdContractIsExist(contractId))
            {
                if (contract.addContract(contractId, customerId, customerPhone, typeOfContract, dateCreate, total, description))
                {
                    MessageBox.Show("Add Contract successfully", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonAddDetail.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Add Contract fail", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Id Contract has already exist", "Add Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddDetail_Click(object sender, EventArgs e)
        {
            AddDetailContractForm addDetailContractFrm = new AddDetailContractForm();
            addDetailContractFrm.contractId = textBoxContractId.Text.ToString();
            addDetailContractFrm.customerId = textBoxCustomerId.Text.ToString();
            if (radioButtonRent.Checked)
                addDetailContractFrm.typeOfContract = "rent";
            else
                addDetailContractFrm.typeOfContract = "for rent";

            addDetailContractFrm.ShowDialog();
        }
    }
}
