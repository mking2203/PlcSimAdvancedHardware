//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// cButton, button set/reset a bool value 
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    public partial class cButton : Button
    {
        public cButton()
        {
            InitializeComponent();
        }

        public bool PlcButtonValue { get; set; }

        public string PlcButtonTag { get; set; }

        private void cButton_MouseDown(object sender, MouseEventArgs e)
        {
            PlcButtonValue = true;
            this.BackColor = Color.ForestGreen;
        }

        private void cButton_MouseUp(object sender, MouseEventArgs e)
        {
            PlcButtonValue = false;
            this.BackColor = SystemColors.Control;
        }
    }
}
