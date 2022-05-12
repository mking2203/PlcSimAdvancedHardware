//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// cButtonLamp, button set/reset a bool value and show the state of a bool value 
//

using System;
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
                    this.BackColor = Color.Green;
                else
                    this.BackColor = SystemColors.Control;

                if (update)
                    this.Invalidate();
            }
        }
        public string PlcLampTag { get; set; }

        private void cButton_MouseDown(object sender, MouseEventArgs e)
        {
            PlcButtonValue = true;         
        }

        private void cButton_MouseUp(object sender, MouseEventArgs e)
        {
            PlcButtonValue = false;
        }
    }
}
