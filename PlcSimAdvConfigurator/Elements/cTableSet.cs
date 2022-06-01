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

namespace PlcSimAdvConfigurator
{
    public partial class cTableSet : Label
    {
        public string PlcValueTag { get; set; }

        public string PlcTagStep01 { get; set; }
        public string PlcTagStep02 { get; set; }
        public string PlcTagStep03 { get; set; }
        public string PlcTagStep04 { get; set; }
        public string PlcTagStep05 { get; set; }
        public string PlcTagStep06 { get; set; }
        public string PlcTagStep07 { get; set; }
        public string PlcTagStep08 { get; set; }
        public string PlcTagStep09 { get; set; }
        public string PlcTagStep10 { get; set; }

        public int PlcValueStep01 { get; set; }
        public int PlcValueStep02 { get; set; }
        public int PlcValueStep03 { get; set; }
        public int PlcValueStep04 { get; set; }
        public int PlcValueStep05 { get; set; }
        public int PlcValueStep06 { get; set; }
        public int PlcValueStep07 { get; set; }
        public int PlcValueStep08 { get; set; }
        public int PlcValueStep09 { get; set; }
        public int PlcValueStep10 { get; set; }

        public cTableSet()
        {
            InitializeComponent();
        }
    }
}
