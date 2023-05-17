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
    public partial class EditContractForm : Form
    {
        public EditContractForm()
        {
            InitializeComponent();
            textBoxContractId.Enabled = false;
            textBoxCustomerId.Enabled = false;
        }
        CONTRACT contract = new CONTRACT();

        private void textBoxContractId_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("you're right");
            DataTable dt = new DataTable();
            dt = contract.findContractByID(textBoxContractId.Text.ToString());
            if (dt.Rows[0]["TypeOfContract"].ToString().ToLower() == "rent")
                radioButtonRent.Checked = true;
            else
                radioButtonForRent.Checked = true;
            textBoxContractId.Text = dt.Rows[0]["IdContract"].ToString();
            textBoxCustomerId.Text = dt.Rows[0]["IdCustomer"].ToString();
            textBoxCustomerName.Text = dt.Rows[0]["Name"].ToString();
            textBoxCustomerPhone.Text = dt.Rows[0]["PhoneNumber"].ToString();
            dateTimePickerDateCreate.Value = (DateTime)dt.Rows[0]["DateCreate"];
            textBoxTotal.Text = dt.Rows[0]["Total"].ToString();   
            richTextBoxDescription.Text = dt.Rows[0]["description"].ToString();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            SelectContractForm selectContractFrm = new SelectContractForm();
            
            selectContractFrm.ShowDialog();
            textBoxContractId.Text = selectContractFrm.dataGridViewSelectContact.CurrentRow.Cells["IdContract"].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string contractid = textBoxContractId.Text.ToString();
            string cusid = textBoxCustomerId.Text.ToString();
            string cusname = textBoxCustomerName.Text.ToString();
            string cusphone = textBoxCustomerPhone.Text.ToString();
            DateTime date = dateTimePickerDateCreate.Value;
            float total = Convert.ToSingle(textBoxTotal.Text);
            string des = richTextBoxDescription.Text.ToString();
            string type = "rent";
            if (radioButtonRent.Checked)
                type = "rent";
            else
                type = "for rent";
            if(contract.updateContract(contractid, cusid, cusname, cusphone, type, date, total, des))
            {
                MessageBox.Show("update successfully");
            }
            else
            {
                MessageBox.Show("update fail");
            }
        }
    }
}
