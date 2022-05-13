//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// cLamp, shows state of a bool value 
//

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    public partial class cLamp : Label
    {
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

        public cLamp()
        {
            InitializeComponent();
        }
    }
}
