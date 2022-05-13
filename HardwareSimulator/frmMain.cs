//
// PlcSimAdvanced Hardware Simulation (Siemens TIA Portal)
// Mark König, 05/2022
//
// Main form for testing
//

using System;
using System.Windows.Forms;

using System.Threading;
using Siemens.Simatic.Simulation.Runtime;

namespace PlcSimAdvSimulator
{
    public partial class frmMain : Form
    {
        private IInstance myInstance;
        private long aktTicks;
        private long startTicks;

        private Thread tFeedbacks;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Connect local to PlcSimAdvanced
            Console.WriteLine("Starting simulation");
            myInstance = SimulationRuntimeManager.CreateInterface("PLC");

            //Update tag list from API
            Console.WriteLine("Tags synchronization");
            myInstance.UpdateTagList();

            // write taglist as xml
            //myInstance.CreateConfigurationFile(Application.StartupPath + "\\test.xml");

            // get all vars
            STagInfo[] data = myInstance.TagInfos;

            // save the start time
            startTicks = myInstance.SystemTime.Ticks / 10000;

            //Start a thread to synchronize feedbacks inputs 
            tFeedbacks = new Thread(() => synchroFeedbacks(myInstance));
            tFeedbacks.IsBackground = true;
            tFeedbacks.Start();

            cButton2.ToolTip = "Button:\nOUT - " + cButton2.PlcButtonTag;
            cToggleButton1.ToolTip = "Toggle-Button:\nOUT - " + cToggleButton1.PlcButtonTag;
            cCheckBox2.ToolTip = "Checkbox:\nOUT - " + cCheckBox2.PlcButtonTag;
            cLamp1.ToolTip = "Lamp:\nOUT - " + cLamp1.PlcLampTag;
            cLamp2.ToolTip = "Lamp:\nOUT - " + cLamp2.PlcLampTag;
            cLamp4.ToolTip = "Lamp:\nOUT - " + cLamp4.PlcLampTag;
            cButtonLamp1.ToolTip = "ButtonLamp:\nIN - " + cButtonLamp1.PlcButtonTag + "\n" + "OUT - " + cButtonLamp1.PlcLampTag;
            cPulse1.ToolTip = "Pulse:\nOUT - " + cPulse1.PlcOutputTag + "\n" + cPulse1.PlcTimeMS.ToString() + " ms";
            cLamp3.ToolTip = "Lamp:\nOUT - " + cLamp3.PlcLampTag;
            cLamp5.ToolTip = "Lamp:\nOUT - " + cLamp5.PlcLampTag;
            cIntregrator1.ToolTip = "Intregrator";
        }

        private void synchroFeedbacks(IInstance myInstance)
        {
            while (true)
            {
                // actual system time
                aktTicks = myInstance.SystemTime.Ticks;

                // enumerate through controls
                foreach (Control crtl in this.Controls)
                {
                    if (crtl is cButton)
                    {
                        cButton c = (cButton)crtl;
                        if (c.PlcButtonTag != null)
                            myInstance.WriteBool(c.PlcButtonTag, c.PlcButtonValue);
                    }
                    if (crtl is cToggleButton)
                    {
                        cToggleButton c = (cToggleButton)crtl;
                        if (c.PlcButtonTag != null)
                            myInstance.WriteBool(c.PlcButtonTag, c.PlcButtonValue);
                    }
                    if (crtl is cCheckBox)
                    {
                        cCheckBox c = (cCheckBox)crtl;
                        if (c.PlcButtonTag != null)
                            myInstance.WriteBool(c.PlcButtonTag, c.PlcButtonValue);
                    }
                    if (crtl is cLamp)
                    {
                        cLamp c = (cLamp)crtl;
                        if (c.PlcLampTag != null)
                        {
                            c.PlcLampValue = myInstance.ReadBool(c.PlcLampTag);
                        }

                    }
                    if (crtl is cButtonLamp)
                    {
                        cButtonLamp c = (cButtonLamp)crtl;
                        // input
                        if (c.PlcButtonTag != null)
                        {
                            myInstance.WriteBool(c.PlcButtonTag, c.PlcButtonValue);
                        }
                        // output
                        if (c.PlcLampTag != null)
                            c.PlcLampValue = myInstance.ReadBool(c.PlcLampTag);
                    }
                    if (crtl is cPulse)
                    {
                        cPulse c = (cPulse)crtl;
                        c.PlcTicks = aktTicks;

                        if (c.PlcOutputTag != null)
                            myInstance.WriteBool(c.PlcOutputTag, c.PlcOutputValue);
                    }
                    if (crtl is cIntregrator)
                    {
                        cIntregrator c = (cIntregrator)crtl;
                        c.PlcTicks = aktTicks;

                        if (c.PlcSetValueTag != null)
                            c.PlcSetValue = myInstance.ReadInt16(c.PlcSetValueTag);
                        if (c.PlcTargetValueTag != null)
                            c.PlcTargetValue = myInstance.ReadInt16(c.PlcTargetValueTag);
                        if (c.PlcActualValueTag != null)
                            myInstance.WriteInt16(c.PlcActualValueTag, Convert.ToInt16(c.PlcActualValue));
                        if (c.PlcGradientTag != null)
                            c.PlcGradient = myInstance.ReadInt16(c.PlcGradientTag);

                        if (c.PlcResetValueTag != null)
                        {
                            bool b = myInstance.ReadBool(c.PlcResetValueTag);
                            if (b)
                                c.PlcResetValue();
                        }
                        if (c.PlcStartValueTag != null)
                        {
                            bool b = myInstance.ReadBool(c.PlcStartValueTag);
                            if (b)
                                c.PlcStartValue();
                            else
                                c.PlcStopValue();
                        }
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // abort reading
            tFeedbacks.Abort();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // display system time
            DateTime dt = new DateTime(aktTicks);
            txtTime.Text = "Sytemzeit: " + dt.ToLongTimeString();
        }
    }
}
