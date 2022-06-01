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
                txtTime.Text = plcTimeMS.ToString() + " ms";
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
                    txtPulse.BackColor = Color.Green;
                else
                    txtPulse.BackColor = SystemColors.Control;

                return plcOutpuValue;
            }
        }

        // output the signal
        public string PlcOutputTag { get; set; }
        // output the invert signal
        public string PlcnOutputTag { get; set; }

        public string caption;
        override public string Text
        {
            get
            {
                return caption;
            }
            set
            {
                caption = value;
                txtName.Text = caption;
            }
        }

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
            txtTime.Text = plcTimeMS.ToString() + " ms";
        }

        private void cPulse_SizeChanged(object sender, EventArgs e)
        {
            txtName.Location = new Point(10, 10);
            txtTime.Location = new Point(10, this.Height / 2);
            txtPulse.Location = new Point(this.Width - 30, this.Height - 30);
        }
    }
}
