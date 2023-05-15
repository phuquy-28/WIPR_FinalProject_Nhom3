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
    public partial class ListWorkForm : Form
    {
        public ListWorkForm()
        {
            InitializeComponent();
        }
        WORK work = new WORK();
        private void ListWorkForm_Load(object sender, EventArgs e)
        {
            dataGridViewListWork.DataSource = work.getWorkList();
            dataGridViewListWork.ReadOnly = true;
            dataGridViewListWork.AllowUserToAddRows = false;
            //
        }
    }
}
