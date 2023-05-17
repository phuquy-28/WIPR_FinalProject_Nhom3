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
    public partial class ViewIncomeForm : Form
    {
        public ViewIncomeForm()
        {
            InitializeComponent();
        }

        private void ViewIncomeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pARKING_LOTDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.pARKING_LOTDataSet.Bill);

        }
    }
}
