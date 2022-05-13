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
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

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
            #region read json config

            string json =File.ReadAllText(Application.StartupPath + "\\elements.json");
            List<Dictionary<string, string>> myList = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(json);

            foreach (Dictionary<string, string> item in myList)
            {
                if(item["Control"] == "cButton")
                {
                    cButton t = new cButton();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);
                    t.PlcButtonTag = item["Button"];

                    t.ToolTip = "OUT: " + item["Button"];
                    this.Controls.Add(t);
                }
                else if (item["Control"] == "cToggleButton")
                {
                    cToggleButton t = new cToggleButton();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);
                    t.PlcButtonTag = item["Button"];

                    t.ToolTip = "OUT: " + item["Button"];
                    this.Controls.Add(t);
                }
                else if (item["Control"] == "cButtonLamp")
                {
                    cButtonLamp t = new cButtonLamp();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);
                    t.PlcButtonTag = item["Button"];
                    t.PlcLampTag = item["Lamp"];

                    t.ToolTip = "IN: " + item["Lamp"] + "- OUT: " + item["Button"];
                    this.Controls.Add(t);
                }
                else if (item["Control"] == "cLamp")
                {
                    cLamp t = new cLamp();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);
                    t.PlcLampTag = item["Lamp"];

                    t.ToolTip = "OUT: " + item["Lamp"];
                    this.Controls.Add(t);
                }
                else if (item["Control"] == "cCheckBox")
                {
                    cCheckBox t = new cCheckBox();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);
                    t.PlcButtonTag = item["Button"];

                    t.ToolTip = "OUT: " + item["Button"];
                    this.Controls.Add(t);
                }
                else if (item["Control"] == "cLabel")
                {
                    Label t = new Label();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);
                    t.Font = new System.Drawing.Font("Arial", float.Parse(item["FontSize"]));

                    this.Controls.Add(t);
                }
            }

            #endregion

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

            cPulse1.ToolTip = "Pulse:\nOUT - " + cPulse1.PlcOutputTag + "\n" + cPulse1.PlcTimeMS.ToString() + " ms";
            cIntregrator1.ToolTip = "Intregrator";
        }

        private System.Drawing.Size GetSize(string value)
        {
            return new System.Drawing.Size(Convert.ToInt16(value.Split('x')[0]), Convert.ToInt16(value.Split('x')[1]));
        }
        private System.Drawing.Point GetLocation(string value)
        {
            return new System.Drawing.Point(Convert.ToInt16(value.Split(',')[0]), Convert.ToInt16(value.Split(',')[1]));
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
                    #region work on controls
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
                    #endregion
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
