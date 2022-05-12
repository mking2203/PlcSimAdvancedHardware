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

        public string PlcResetValueTag { get; set; }
        public void PlcResetValue()
        {
            PlcActualValue = PlcSetValue;
            start = 0;
        }
        public string PlcStartValueTag { get; set; }
        public void PlcStartValue()
        {
            if (start == 0)
                start = PlcTicks;
        }
        public void PlcStopValue()
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
                    long wert = (span * 2000) / 1000;

                    PlcActualValue = PlcActualValue + (int)wert;

                    if (PlcActualValue > PlcTargetValue)
                    {
                        start = 0;
                        PlcActualValue = PlcTargetValue;
                    }
                    else
                        start = plcTicks;
                }

                try
                {
                    txtSet.Invoke((MethodInvoker)(() => txtSet.Text = "SetValue: " + PlcSetValue.ToString()));
                    txtTarget.Invoke((MethodInvoker)(() => txtTarget.Text = "TargetValue: " + PlcTargetValue.ToString()));
                    txtActual.Invoke((MethodInvoker)(() => txtActual.Text = "Actual: " + PlcActualValue.ToString()));

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
