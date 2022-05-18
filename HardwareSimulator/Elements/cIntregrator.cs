//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// Intregrator, Set/Target/Actual Value with 
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    public partial class cIntregrator : UserControl
    {
        private long start;
        private int direction;

        public cIntregrator()
        {
            InitializeComponent();
        }

        public string PlcSetValueTag { get; set; }
        public int PlcSetValue { get; set; }

        public string PlcTargetValueTag { get; set; }
        public int PlcTargetValue { get; set; }

        public string PlcActualValueTag { get; set; }
        public int PlcActualValue { get; set; }

        public string PlcGradientTag { get; set; }
        public int PlcGradient { get; set; }

        public string PlcSetTag { get; set; }
        public void PlcReset()
        {
            PlcActualValue = PlcSetValue;
            start = 0;
        }
        public string PlcStartTag { get; set; }
        public void PlcStart()
        {
            if (start == 0)
            {
                start = PlcTicks;
                if(PlcTargetValue > PlcActualValue)
                {
                    direction = 1;
                }
                else
                {
                    direction = -1;
                }
            }
        }
        public void PlcStop()
        {
            start = 0;
        }

        private long plcTicks;
        public long PlcTicks
        {
            get
            {
                return plcTicks;
            }
            set
            {
                plcTicks = value;
                DateTime dt = new DateTime(plcTicks);

                if (start != 0)
                {
                    long span = (plcTicks - start) / 10000;
                    long wert = (span * PlcGradient) / 1000;

                    PlcActualValue = PlcActualValue + ((int)wert * direction);

                    if (((PlcActualValue > PlcTargetValue) && (direction == 1)) ||
                        ((PlcActualValue < PlcTargetValue) && (direction == -1)))
                    {
                        start = 0;
                        PlcActualValue = PlcTargetValue;
                    }
                    else
                        start = plcTicks;
                }

                try
                {
                    if (txtSet.InvokeRequired)
                    {
                        txtSet.Invoke((MethodInvoker)(() => txtSet.Text = "SetValue: " + PlcSetValue.ToString()));
                        txtTarget.Invoke((MethodInvoker)(() => txtTarget.Text = "TargetValue: " + PlcTargetValue.ToString()));
                        txtActual.Invoke((MethodInvoker)(() => txtActual.Text = "Actual: " + PlcActualValue.ToString()));
                    }
                    else
                    {
                        txtSet.Text = "SetValue: " + PlcSetValue.ToString();
                        txtTarget.Text = "TargetValue: " + PlcTargetValue.ToString();
                        txtActual.Text = "Actual: " + PlcActualValue.ToString();
                    }

                    if ((dt.Second % 2) != 0)
                    {
                        txtOn.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        txtOn.BackColor = SystemColors.Control;
                    }
                }
                catch { }
            }
        }

    }
}
