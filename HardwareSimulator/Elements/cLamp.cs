//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// cLamp, shows state of a bool value 
//

using System;
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
                    this.BackColor = Color.Green;
                else
                    this.BackColor = SystemColors.Control;

                if (update)
                    this.Invalidate();

            }
        }

        public string PlcLampTag { get; set; }

        public cLamp()
        {
            InitializeComponent();
        }

        protected override void InitLayout()
        {
            base.InitLayout();
            base.AutoSize = false;
            base.BorderStyle = BorderStyle.FixedSingle;
            base.TextAlign = ContentAlignment.MiddleCenter;
        }

    }
}
