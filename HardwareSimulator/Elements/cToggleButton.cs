//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// cToggleButton, toggle button, toggles a bool value 
//

using System;
using System.ComponentModel;
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

        private bool plcButtonValue;
        public bool PlcButtonValue
        {
            get
            {
                return plcButtonValue;
            }
            set
            {
                plcButtonValue = value;
                if (plcButtonValue)
                {
                    this.BackColor = plcActiveColor;
                }
                else
                {
                    this.BackColor = SystemColors.Control;
                }

            }
        }

        public string PlcButtonTag { get; set; }

        // output the signal
        public string PlcOutputTag { get; set; }
        // output the invert signal
        public string PlcnOutputTag { get; set; }

        private Color plcActiveColor = Color.ForestGreen;
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
            if (PlcButtonValue)
            {
                PlcButtonValue = false;
                this.BackColor = SystemColors.Control;
            }
            else
            {
                PlcButtonValue = true;
                this.BackColor = PlcActiveColor;
            }
        }
    }
}
