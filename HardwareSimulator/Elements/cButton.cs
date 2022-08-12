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
        // the button can act in normal or toggle mode
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

        // output the button signal (main signal)
        public string PlcButtonTag { get; set; }
        // output the button signal
        public string PlcOutputTag { get; set; }
        // output the invert button signal
        public string PlcnOutputTag { get; set; }

        // holds the lamp value if used, otherwise the state is displayed
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

        // default color for the active state
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

        // selector for the lamp - lamp or state is displayed
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

        // mouse events
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

        // update the backcolor as lamp or state
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
