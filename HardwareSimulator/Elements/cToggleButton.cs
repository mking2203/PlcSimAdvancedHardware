//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// cToggleButton, toggle button, toggles a bool value 
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    public partial class cToggleButton : Button
    {
        public cToggleButton()
        {
            InitializeComponent();
        }

        public bool PlcButtonValue { get; set; }

        public string PlcButtonTag { get; set; }

        private void cButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (PlcButtonValue)
            {
                PlcButtonValue = false;
                this.BackColor = SystemColors.Control;
            }
            else
            {
                PlcButtonValue = true;
                this.BackColor = Color.ForestGreen;
            }
        }
    }
}
