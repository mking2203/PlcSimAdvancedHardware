//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// cButton, button set/reset a bool value 
//

using System;
using System.ComponentModel;
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

        // output the signal
        public string PlcOutputTag { get; set; }
        // output the invert signal
        public string PlcnOutputTag { get; set; }

        Color plcActiveColor = Color.ForestGreen;
        [Description("Represents the ON color off the button"), Category("Design")]
        public Color PlcActiveColor
        {
            get
            {
                return plcActiveColor;
            }
            set
            {
                plcActiveColor = value;
            }
        }

        private void cButton_MouseDown(object sender, MouseEventArgs e)
        {
            PlcButtonValue = true;
            this.BackColor = PlcActiveColor;
        }

        private void cButton_MouseUp(object sender, MouseEventArgs e)
        {
            PlcButtonValue = false;
            this.BackColor = SystemColors.Control;
        }
    }
}
