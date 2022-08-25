//
// PlcSimAdvanced Hardware Simulation Configurator (Siemens TIA Portal)
// Mark König, 05/2022
//

using System;
using System.Windows.Forms;
using Siemens.Simatic.Simulation.Runtime;

namespace PlcSimAdvConfigurator
{
    static class Program
    {
        public static string PlcName = string.Empty;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region check siemens
            bool check = false;

            try
            {
                // test PlcSimAdvanced is installed
                if (SimulationRuntimeManager.IsRuntimeManagerAvailable)
                {
                    // test PlcSimAdvanced - at least one season active
                    if (SimulationRuntimeManager.RegisteredInstanceInfo.Length > 0)
                    {
                        frmSelectPlc frm = new frmSelectPlc();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            // select PlcSimAdvanced instance
                            PlcName = frm.PlcName;
                            check = true;
                        }
                    }
                    else
                    {
                        //no intance found
                        MessageBox.Show("Could not find a PlcSimAdvanced instance. Load at least one instance.",
                            "Instance not found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                //not installed
                MessageBox.Show("Could not find PlcSimAdvanced. Installed?",
                    "Siemens not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            #endregion



            // start application
            if (check)
                Application.Run(new frmMain());
        }
    }
}
