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

        public string PlcButtonTag { get; set; }
        public string PlcOption { get; set; }

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
            if (PlcOption != null)
            {
                if (!PlcOption.Contains("NC"))
                    PlcButtonValue = true;
                else
                    PlcButtonValue = false;
            }
            else
                PlcButtonValue = true;

            this.BackColor = PlcActiveColor;
        }

        private void cButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (PlcOption != null)
            {
                if (!PlcOption.Contains("NC"))
                    PlcButtonValue = false;
                else
                    PlcButtonValue = true;
            }
            else
                PlcButtonValue = false;

            this.BackColor = SystemColors.Control;
        }
    }
}
