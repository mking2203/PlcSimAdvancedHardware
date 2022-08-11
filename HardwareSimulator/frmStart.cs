using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    public partial class frmStart : Form
    {
        private string statusText = string.Empty;
        private int statusProcent = 0;

        public frmStart()
        {
            InitializeComponent();
            progressBar1.Value = 0;
        }

        public string StatusText
        {
            set
            {
                label1.Text = value;
                statusText = value;
            }
        }
        public int StatusProcent
        {
            set
            {
                progressBar1.Value = value;
                statusProcent = value;
            }
        }

    }
}
