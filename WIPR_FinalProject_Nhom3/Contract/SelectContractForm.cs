﻿using System;
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
    public partial class SelectContractForm : Form
    {
        public SelectContractForm()
        {
            InitializeComponent();
            dataGridViewSelectContact.DataSource = contract.getSelectContract();
            dataGridViewSelectContact.CurrentCell = null;
        }
        CONTRACT contract = new CONTRACT();

        private void SelectContractForm_Load(object sender, EventArgs e)
        {
            dataGridViewSelectContact.ClearSelection();
        }
    }
}
