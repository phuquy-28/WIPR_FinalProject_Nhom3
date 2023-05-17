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
    public partial class DetailContractForm : Form
    {
        public DetailContractForm()
        {
            InitializeComponent();
        }
        CONTRACT contract = new CONTRACT();
        public string idContract { get; set; }

        private void DetailContractForm_Load(object sender, EventArgs e)
        {
            dataGridViewDetailContract.DataSource = contract.getDetailContractByID(idContract);
        }
    }
}
