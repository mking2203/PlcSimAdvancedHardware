//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// cPulse, deliver a pulse signal (50% / 50%)
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    public partial class cPulse : UserControl
    {
        private int plcTimeMS = 500;
        private bool plcOutpuValue;
        private long start;
        private long actual;

        public int PlcTimeMS
        {
            get
            {
                return plcTimeMS;
            }
            set
            {
                plcTimeMS = value;
                label1.Text = plcTimeMS.ToString() + " ms";
            }
        }
        public bool PlcOutputValue
        {
            get
            {
                if (start != 0)
                    if ((actual / 10000) - (start / 10000) > (plcTimeMS / 2))
                    {
                        plcOutpuValue = !plcOutpuValue;
                        start = 0;
                    }

                if (plcOutpuValue)
                    label2.BackColor = Color.Green;
                else
                    label2.BackColor = SystemColors.Control;

                return plcOutpuValue;
            }
        }

        public string PlcOutputTag { get; set; }

        public long PlcTicks
        {
            set
            {
                if (start == 0)
                    start = value;
                actual = value;
            }
        }

        public cPulse()
        {
            InitializeComponent();
            label1.Text = plcTimeMS.ToString() + " ms";
        }
    }
}
