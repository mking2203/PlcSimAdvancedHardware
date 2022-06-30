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
        public enum ButtonModes
        {
            Button = 1,
            ToggleButton = 2
        }

        public cButton()
        {
            InitializeComponent();
        }

        // the button signal
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
                UpdateColor();
            }
        }

        // output the signal
        public string PlcOutputTag { get; set; }
        // output the invert signal
        public string PlcnOutputTag { get; set; }

        private bool plcLampValue = false;
        public bool PlcLampValue
        {
            get
            {
                return plcLampValue;
            }
            set
            {
                plcLampValue = value;
                UpdateColor();
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

        private ButtonModes buttonMode = ButtonModes.Button;

        public ButtonModes ButtonMode
        {
            get
            {
                return buttonMode;
            }
            set
            {
                buttonMode = value;
                this.Invalidate();
            }
        }


        private void cButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (buttonMode == ButtonModes.Button)
            {
                // button
                PlcButtonValue = true;
            }
            else
            {
                // toogle
                PlcButtonValue = !PlcButtonValue;
            }
            UpdateColor();
        }

        private void cButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (buttonMode == ButtonModes.Button)
            {
                // button
                PlcButtonValue = false;
            }
            UpdateColor();
        }

        private void UpdateColor()
        {
            if (PlcLampTag == null)
            {
                // no lamp, LED is indicator of the function
                if (PlcButtonValue)
                {
                    this.BackColor = PlcActiveColor;
                }
                else
                {
                    this.BackColor = SystemColors.Control;
                }
                this.Invalidate();
            }
            else
            {
                // lampd is defined
                if (PlcLampValue)
                {
                    this.BackColor = PlcActiveColor;
                }
                else
                {
                    this.BackColor = SystemColors.Control;
                }
                this.Invalidate();
            }
        }
    }
}
