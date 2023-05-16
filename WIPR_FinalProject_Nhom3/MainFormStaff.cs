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
    public partial class MainFormStaff : Form
    {
        public MainFormStaff()
        {
            InitializeComponent();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWorkForm addWorkF = new AddWorkForm();
            addWorkF.ShowDialog();
        }

        private void editWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateWorkForm updateWorkF = new UpdateWorkForm();
            updateWorkF.ShowDialog();
        }

        private void deleteWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveWorkForm removeWorkF = new RemoveWorkForm();
            removeWorkF.ShowDialog();
        }

        private void workListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListWorkForm listWorkF = new ListWorkForm();
            listWorkF.ShowDialog();
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicleFrm = new AddVehicleForm();
            addVehicleFrm.ShowDialog();
        }

        private void editVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditVehicleForm editVehicleFrm = new EditVehicleForm();
            editVehicleFrm.ShowDialog();
        }

        private void deleteVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteVehicleForm deletevehicleFrm = new DeleteVehicleForm();
            deletevehicleFrm.ShowDialog();
        }
    }
}
