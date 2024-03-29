﻿//
// PlcSimAdvanced Hardware Simulation Configurator (Siemens TIA Portal)
// Mark König, 05/2022
//

using System;
using System.Windows.Forms;
using Siemens.Simatic.Simulation.Runtime;

namespace PlcSimAdvConfigurator
{
    public partial class frmSelectPlc : Form
    {
        public frmSelectPlc()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.None;

            // add all instances
            foreach (SInstanceInfo s in SimulationRuntimeManager.RegisteredInstanceInfo)
            {
                listBox1.Items.Add(s.Name);
            }

            // select first instance
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                plcName = listBox1.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private string plcName;
        public string PlcName
        { get => plcName; set => plcName = value; }
    }
}
