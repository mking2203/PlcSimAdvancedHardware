﻿using System;
using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    public partial class cTrackBar : UserControl
    {
        public cTrackBar()
        {
            InitializeComponent();

            txtValue.Text = "Actual Value: 0";
            trackBar1.ValueChanged += CTrackbar_ValueChanged;
        }

        private void TrackBar1_SizeChanged(object sender, EventArgs e)
        {
            txtName.Location = new System.Drawing.Point(0, 0);
            trackBar1.Location = new System.Drawing.Point(0, (this.Height - 50) / 2);
            trackBar1.Width = this.Width;
            txtValue.Location = new System.Drawing.Point(0, this.Height - 20);
        }

        private void CTrackbar_ValueChanged(object sender, EventArgs e)
        {
            PlcOutputValue = (Int16)trackBar1.Value;

            if (txtValue.InvokeRequired)
            {
                txtValue.Invoke((MethodInvoker)(() => txtValue.Text = "Actual Value: " + PlcOutputValue.ToString()));
            }
            else
            {
                txtValue.Text = "Actual Value: " + PlcOutputValue.ToString();
            }
        }
        
        private Int16 plcOutputValue;     
        public Int16 PlcOutputValue 
        { 
            get
            {
                return plcOutputValue;
            }
            set
            {
                plcOutputValue = value;
                trackBar1.Value = (int)value;
            }
        }

        public string PlcOutputTag { get; set; }

        private int plcMaxValue;
        public int PlcMaxValue
        {
            set
            {
                trackBar1.Maximum = value;
                PlcOutputValue = (Int16)trackBar1.Value;
                txtValue.Text = "Actual Value: " + PlcOutputValue.ToString();

                plcMaxValue = value;
            }
            get
            {
                return plcMaxValue;
            }
        }
        private int plcMinValue;
        public int PlcMinValue
        {
            set
            {
                trackBar1.Minimum = value;
                PlcOutputValue = (Int16)trackBar1.Value;
                txtValue.Text = "Actual Value: " + PlcOutputValue.ToString();

                plcMinValue = value;
            }
            get
            {
                return plcMinValue;
            }
        }
        override public string Text
        {
            set
            {
                txtName.Text = value;
            }
            get
            {
                return txtName.Text;
            }
        }
    }
}
