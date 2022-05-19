//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// cButtonLamp, button set/reset a bool value and show the state of a bool value 
//

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    public partial class cButtonLamp : Button
    {
        public cButtonLamp()
        {
            InitializeComponent();
        }

        public bool PlcButtonValue { get; set; }
        public string PlcButtonTag { get; set; }

        public string PlcOption { get; set; }

        private bool plcLampValue;
        public bool PlcLampValue
        {
            get
            {
                return plcLampValue;
            }
            set
            {
                bool update = false;
                if (value != plcLampValue)
                    update = true;

                plcLampValue = value;
                if (value)
                    this.BackColor = PlcActiveColor;
                else
                    this.BackColor = SystemColors.Control;

                if (update)
                    this.Invalidate();
            }
        }
        public string PlcLampTag { get; set; }

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
            if (!PlcOption.Contains("NC"))
                PlcButtonValue = true;
            else
                PlcButtonValue = false;
        }

        private void cButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!PlcOption.Contains("NC"))
                PlcButtonValue = false;
            else
                PlcButtonValue = true;
        }
    }
}
