//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// cCheckBox, checkbox set/reset a bool value 
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    public partial class cCheckBox : CheckBox
    {
        public bool PlcButtonValue { get; set; }

        public string PlcButtonTag { get; set; }

        public cCheckBox()
        {
            InitializeComponent();
            this.CheckedChanged += CCheckBox_CheckedChanged;
        }

        private void CCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.PlcButtonValue = this.Checked;
        }
    }
}
