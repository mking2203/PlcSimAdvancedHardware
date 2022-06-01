//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// cPulse, deliver a pulse signal (50% / 50%)
//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlcSimAdvConfigurator
{
    public partial class cInput : UserControl
    {
        public string PlcOutputTag { get; set; }

        private int plcOutpuValue;

        public int PlcOutputValue
        {
            get
            {
                return plcOutpuValue;
            }
            set
            {
                int val = 0;
                int.TryParse(value.ToString(), out val);

                plcOutpuValue = val;
                txtInput.Text = val.ToString();

                Application.DoEvents();

                txtInput.BackColor = Color.White;
            }
        }

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

        public cInput()
        {
            InitializeComponent();
        }

        private void cInput_SizeChanged(object sender, EventArgs e)
        {
            txtName.Location = new Point(10, 10);
            txtInput.Location = new Point(10, this.Height / 2);
            txtInput.Width = this.Width - 25;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            txtInput.BackColor = Color.Orange;
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int val = 0;
                int.TryParse(txtInput.Text, out val);

                plcOutpuValue = val;
                txtInput.Text = val.ToString();

                Application.DoEvents();

                txtInput.BackColor = Color.White;
            }
        }
    }
}
