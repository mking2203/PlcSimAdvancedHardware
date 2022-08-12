using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            foreach (SInstanceInfo s in SimulationRuntimeManager.RegisteredInstanceInfo)
            {
                listBox1.Items.Add(s.Name);
            }
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
