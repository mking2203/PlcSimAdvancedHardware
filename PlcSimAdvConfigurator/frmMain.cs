//
// PlcSimAdvanced Hardware Simulation Configurator (Siemens TIA Portal)
// Mark König, 05/2022
//

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using Siemens.Simatic.Simulation.Runtime;
using Microsoft.VisualBasic;
using PlcSimAdvConfigurator.Properties;

namespace PlcSimAdvConfigurator
{
    public partial class frmMain : Form
    {
        // save the start point of the control
        Point controlPos = new Point();
        // save the start point of the mouse
        Point mousePos = new Point();

        // grid size
        private int snapGrid = 20;
        // move is active
        bool move;

        List<Dictionary<string, string>> myList = new List<Dictionary<string, string>>();
        string controlID = string.Empty;
        string plcName = string.Empty;
        string actID = string.Empty;

        // api interface
        private IInstance myInstance;
        private STagInfo[] VarData;

        // actual fileName
        private string fileName = string.Empty;

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lstEvents.Items.Add("Start PlcSimAdv Hardware Configurator");

            snapGrid = (int)Settings.Default["SnapGrid"];
            setSnapGrid();

            // load last file if possible
            string lastFile = (Settings.Default["LastConfigFile"].ToString());
            if (!String.IsNullOrEmpty(lastFile))
            {
                TryLoadJson(lastFile);
            }
        }

        private int TryLoadJson(string fileName)
        {
            lstEvents.Items.Add("Try to load last file: " + fileName);

            int result = LoadJson(fileName);
            switch (result)
            {
                case 1:
                    lstEvents.Items.Add("Load file OK");
                    break;
                case -1:
                    lstEvents.Items.Add("Last File not exists");
                    break;
                default:
                    lstEvents.Items.Add("Load file error: " + result.ToString());
                    break;
            }

            return result;
        }

        private int LoadJson(string FileName)
        {
            if (File.Exists(FileName))
            {
                fileName = FileName;

                try
                {
                    string json = File.ReadAllText(FileName);
                    myList = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(json);

                    foreach (Dictionary<string, string> item in myList)
                    {
                        if (VarData != null)
                        {
                            if (item.ContainsKey("Output"))
                            {
                                bool result = checkVar(item["Output"]);
                                if (!result)
                                {
                                    lstEvents.Items.Add("Unknown var: " + item["Output"]);
                                    item["Output"] = "";
                                }
                            }
                        }

                        if (item["Control"] == "Settings")
                        {
                            plcName = item["PLC"];
                            controlID = item["ID"];
                            this.Text = "Actual PLC: " + plcName;
                        }
                        else if (item["Control"] == "cButton")
                        {
                            Button t = new Button();
                            t.Text = item["Text"];
                            t.Size = GetSize(item["Size"]);
                            t.Location = GetLocation(item["Location"]);

                            t.MouseDown += CrtlMouseDown;
                            t.MouseMove += CrtlMouseMove;
                            t.MouseUp += CrtlMouseUp;

                            t.Tag = item["ID"];

                            pMain.Controls.Add(t);
                        }
                        else if (item["Control"] == "cToggleButton")
                        {
                            Button t = new Button();
                            t.Text = item["Text"];
                            t.Size = GetSize(item["Size"]);
                            t.Location = GetLocation(item["Location"]);

                            t.MouseDown += CrtlMouseDown;
                            t.MouseMove += CrtlMouseMove;
                            t.MouseUp += CrtlMouseUp;

                            t.Tag = item["ID"];

                            pMain.Controls.Add(t);
                        }
                        else if (item["Control"] == "cButtonLamp")
                        {
                            Button t = new Button();
                            t.Text = item["Text"];
                            t.Size = GetSize(item["Size"]);
                            t.Location = GetLocation(item["Location"]);

                            t.MouseDown += CrtlMouseDown;
                            t.MouseMove += CrtlMouseMove;
                            t.MouseUp += CrtlMouseUp;

                            t.Tag = item["ID"];

                            pMain.Controls.Add(t);
                        }
                        else if (item["Control"] == "cLamp")
                        {
                            Button t = new Button();
                            t.Text = item["Text"];
                            t.Size = GetSize(item["Size"]);
                            t.Location = GetLocation(item["Location"]);

                            t.MouseDown += CrtlMouseDown;
                            t.MouseMove += CrtlMouseMove;
                            t.MouseUp += CrtlMouseUp;

                            t.Tag = item["ID"];

                            pMain.Controls.Add(t);
                        }
                        else if (item["Control"] == "cCheckBox")
                        {
                            CheckBox t = new CheckBox();
                            t.Text = item["Text"];
                            t.Size = GetSize(item["Size"]);
                            t.Location = GetLocation(item["Location"]);

                            t.MouseDown += CrtlMouseDown;
                            t.MouseMove += CrtlMouseMove;
                            t.MouseUp += CrtlMouseUp;

                            t.Tag = item["ID"];

                            t.AutoCheck = false;

                            pMain.Controls.Add(t);
                        }
                        else if (item["Control"] == "cPulse")
                        {
                            Button t = new Button();
                            t.Text = item["Text"];
                            t.Size = GetSize(item["Size"]);
                            t.Location = GetLocation(item["Location"]);

                            t.MouseDown += CrtlMouseDown;
                            t.MouseMove += CrtlMouseMove;
                            t.MouseUp += CrtlMouseUp;

                            t.Tag = item["ID"];

                            pMain.Controls.Add(t);
                        }
                        else if (item["Control"] == "cTrackBar")
                        {
                            cTrackBar t = new cTrackBar();
                            t.Text = item["Text"];
                            t.Size = GetSize(item["Size"]);
                            t.Location = GetLocation(item["Location"]);

                            t.ModMouseDown += CrtlMouseDown;
                            t.ModMouseMove += CrtlMouseMove;
                            t.ModMouseUp += CrtlMouseUp;

                            //t.MouseDown += CrtlMouseDown;
                            //t.MouseMove += CrtlMouseMove;
                            //t.MouseUp += CrtlMouseUp;

                            t.Tag = item["ID"];

                            pMain.Controls.Add(t);
                        }
                        else if (item["Control"] == "cLabel")
                        {
                            Label t = new Label();
                            t.Text = item["Text"];
                            t.Font = new System.Drawing.Font("Arial", float.Parse(item["FontSize"]));
                            t.Size = GetSize(item["Size"]);
                            t.Location = GetLocation(item["Location"]);
                            t.BorderStyle = BorderStyle.FixedSingle;

                            t.MouseDown += CrtlMouseDown;
                            t.MouseMove += CrtlMouseMove;
                            t.MouseUp += CrtlMouseUp;

                            t.Tag = item["ID"];

                            pMain.Controls.Add(t);
                        }
                        else if (item["Control"] == "cIntregrator")
                        {
                            Button t = new Button();
                            t.Text = item["Text"];
                            t.Size = GetSize(item["Size"]);
                            t.Location = GetLocation(item["Location"]);

                            t.MouseDown += CrtlMouseDown;
                            t.MouseMove += CrtlMouseMove;
                            t.MouseUp += CrtlMouseUp;

                            t.Tag = item["ID"];

                            pMain.Controls.Add(t);
                        }
                        else if (item["Control"] == "cTableSet")
                        {
                            Button t = new Button();
                            t.Text = item["Text"];
                            t.Size = GetSize(item["Size"]);
                            t.Location = GetLocation(item["Location"]);

                            t.MouseDown += CrtlMouseDown;
                            t.MouseMove += CrtlMouseMove;
                            t.MouseUp += CrtlMouseUp;

                            t.Tag = item["ID"];

                            pMain.Controls.Add(t);
                        }
                        else if (item["Control"] == "cInput")
                        {
                            cInput t = new cInput();
                            t.Text = item["Text"];
                            t.Size = GetSize(item["Size"]);
                            t.Location = GetLocation(item["Location"]);

                            if (item.ContainsKey("Output"))
                                if (!String.IsNullOrEmpty(item["Output"]))
                                    t.PlcOutputTag = item["Output"];

                            if (item.ContainsKey("Value"))
                                if (!String.IsNullOrEmpty(item["Value"]))
                                    t.PlcOutputValue = Int16.Parse(item["Value"]);

                            t.ToolTip = "OUT: " + (string)item["Output"];

                            t.MouseDown += CrtlMouseDown;
                            t.MouseMove += CrtlMouseMove;
                            t.MouseUp += CrtlMouseUp;

                            t.Tag = item["ID"];

                            pMain.Controls.Add(t);
                        }
                    }
                }
                catch (Exception ex)
                {
                    lstEvents.Items.Add("Error load JSON: " + ex.Message);
                    return -1000;
                }

                if (fileName != string.Empty)
                {
                    this.Text = "Actual PLC: " + plcName + " File: " + fileName;
                    ConnectPLC();
                }

                return 1;
            }
            else
                return -1;
        }

        private void SaveJson(string FileName)
        {
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            string json = JsonSerializer.Serialize<List<Dictionary<string, string>>>(myList, options);
            File.WriteAllText(FileName, json, System.Text.Encoding.UTF8);
        }

        private void ConnectPLC()
        {
            txtSimulation.Text = "Simulation: not connected";
            lstEvents.Items.Add("Try to connect to PLC instance "+ plcName);

            if (checkPlcIntanceExists(plcName))
            {

                VarData = null;

                try
                {
                    myInstance = SimulationRuntimeManager.CreateInterface(plcName);

                    txtSimulation.Text = "Simulation: connected";

                    //Update tag list from API
                    myInstance.UpdateTagList();

                    txtSimulation.Text = "Simulation: update tags";

                    // get all vars
                    VarData = myInstance.TagInfos;

                    txtSimulation.Text = "Simulation: ready";
                    lstEvents.Items.Add($"PLC instance {plcName} is connected.");
                }
                catch (Exception ex)
                {
                    lstEvents.Items.Add("Could not start PLC instance " + plcName);
                    MessageBox.Show("Could not start PLC instance " + plcName);

                    txtSimulation.Text = "Simulation: error ->" + ex.Message;

                    if (myInstance != null)
                    {
                        myInstance.UnregisterInstance();
                        myInstance = null;
                    }
                }
            }
        }

        #region menu items

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            fileName = string.Empty;
            string input = Interaction.InputBox("Enter PLC name:", "New project", "");

            if (input.Length > 0)
            {
                myList.Clear();

                Dictionary<string, string> item = new Dictionary<string, string>();
                item.Add("Control", "Settings");
                item.Add("PLC", input);
                item.Add("ID", "1");

                plcName = input;
                controlID = "1";

                myList.Add(item);
                pMain.Controls.Clear();

                this.Text = "Actual PLC: " + plcName;
                fileName = string.Empty;
            }

            ConnectPLC();
        }

        private void mnuReload_Click(object sender, EventArgs e)
        {
            ConnectPLC();
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (fileName != string.Empty)
            {
                SaveJson(fileName);

                Settings.Default["LastConfigFile"] = fileName;
                Settings.Default.Save();

                MessageBox.Show("File saved");
            }
            else
            {
                mnuSaveAs_Click(sender, e);
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open configuration";
            openFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = plcName + ".json";

            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pMain.Controls.Clear();
                if (myList != null)
                    myList.Clear();

                int result = TryLoadJson(openFileDialog1.FileName);

                if (result == 1)
                {
                    Settings.Default["LastConfigFile"] = openFileDialog1.FileName;
                    Settings.Default.Save();

                    this.Text = "Actual PLC: " + plcName + " File: " + fileName;
                }
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save configuration";
            saveFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = plcName + ".json";

            DialogResult res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                SaveJson(saveFileDialog1.FileName);

                Settings.Default["LastConfigFile"] = saveFileDialog1.FileName;
                Settings.Default.Save();

                fileName = saveFileDialog1.FileName;
                this.Text = "Actual PLC: " + plcName + " File: " + fileName;
            }
        }

        #endregion

        #region mouse events 

        private void CrtlMouseUp(object sender, MouseEventArgs e)
        {
            if (move)
            {
                Control b = (Control)sender;

                move = false;

                // calc difference
                int x1 = MousePosition.X - mousePos.X;
                int y1 = MousePosition.Y - mousePos.Y;
                // calc new position
                int newX = controlPos.X + x1;
                int newY = controlPos.Y + y1;

                //limit the movement to the panel
                if (newX < 0) newX = 0;
                if (newY < 0) newY = 0;
                if (newX > pMain.Width - b.Width) newX = pMain.Width - b.Width;
                if (newY > pMain.Height - b.Height) newY = pMain.Height - b.Height;

                // calc for grid
                int dX = newX / snapGrid;
                int dy = newY / snapGrid;
                // calc the remaining px
                int rX = newX - dX * snapGrid;
                int rY = newY - dy * snapGrid;

                // re-calc the position
                newX = dX * snapGrid;
                newY = dy * snapGrid;
                // if more the half use next grid point
                if (rX > (snapGrid / 2)) newX += snapGrid;
                if (rY > (snapGrid / 2)) newY += snapGrid;

                b.Location = new Point(newX, newY);

                GetItemByID((string)b.Tag)["Location"] = b.Location.X.ToString() + "," + b.Location.Y.ToString();

            }
        }

        private void CrtlMouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                Control b = (Control)sender;

                // calc difference
                int x1 = MousePosition.X - mousePos.X;
                int y1 = MousePosition.Y - mousePos.Y;
                // calc new position
                int newX = controlPos.X + x1;
                int newY = controlPos.Y + y1;

                //limit the movement to the panel
                if (newX < 0) newX = 0;
                if (newY < 0) newY = 0;
                if (newX > pMain.Width - b.Width) newX = pMain.Width - b.Width;
                if (newY > pMain.Height - b.Height) newY = pMain.Height - b.Height;

                b.Location = new Point(newX, newY);
            }
        }

        private void CrtlMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                foreach (Control crtl in pMain.Controls)
                {
                    crtl.BackColor = pMain.BackColor;
                }

                Control b = (Control)sender;
                controlPos = b.Location;
                mousePos = MousePosition;

                txtItemID.Text = "ItemID: " + (string)b.Tag;
                actID = (string)b.Tag;

                Dictionary<string, string> item = GetItemByID(actID);
                DataTable dt = new DataTable();

                dt.Columns.Add("Key");
                dt.Columns.Add("Value");

                foreach (KeyValuePair<string, string> v in item)
                {
                    DataRow row = dt.NewRow();
                    row[0] = v.Key;
                    row[1] = v.Value;

                    dt.Rows.Add(row);
                }

                dataProperties.DataSource = dt;

                b.BackColor = Color.LightGray;
                b.BringToFront();

                move = true;
            }
        }

        #endregion

        #region new controls

        private void btnButton_Click(object sender, EventArgs e)
        {
            if (myList != null)
            {
                Dictionary<string, string> newItem = Defination.getButton();
                Button t = new Button();

                t.Text = "neuer Button";
                newItem["Text"] = t.Text;

                t.Size = GetSize(newItem["Size"]);

                t.Location = new Point(snapGrid, snapGrid);
                newItem["Location"] = t.Location.X.ToString() + "," + t.Location.Y.ToString();

                t.Tag = controlID;
                newItem["ID"] = controlID;
                IncControlID();

                myList.Add(newItem);

                AddControl((Control)t);
            }
        }
        private void btnToggleButton_Click(object sender, EventArgs e)
        {
            if (myList != null)
            {
                Dictionary<string, string> newItem = Defination.getToggleButton();
                Button t = new Button();

                t.Text = "neuer Toggle Button";
                newItem["Text"] = t.Text;

                t.Size = GetSize(newItem["Size"]);

                t.Location = new Point(snapGrid, snapGrid);
                newItem["Location"] = t.Location.X.ToString() + "," + t.Location.Y.ToString();

                t.Tag = controlID;
                newItem["ID"] = controlID;
                IncControlID();

                myList.Add(newItem);

                AddControl((Control)t);
            }
        }
        private void btnButtonLamp_Click(object sender, EventArgs e)
        {
            if (myList != null)
            {
                Dictionary<string, string> newItem = Defination.getButtonLamp();
                Button t = new Button();

                t.Text = "neue Button - Lamp";
                newItem["Text"] = t.Text;

                t.Size = GetSize(newItem["Size"]);

                t.Location = new Point(snapGrid, snapGrid);
                newItem["Location"] = t.Location.X.ToString() + "," + t.Location.Y.ToString();

                t.Tag = controlID;
                newItem["ID"] = controlID;
                IncControlID();

                myList.Add(newItem);

                AddControl((Control)t);
            }
        }
        private void btnLamp_Click(object sender, EventArgs e)
        {
            if (myList != null)
            {
                Dictionary<string, string> newItem = Defination.getLamp();
                Button t = new Button();

                t.Text = "neue Lampe";
                newItem["Text"] = t.Text;

                t.Size = GetSize(newItem["Size"]);

                t.Location = new Point(snapGrid, snapGrid);
                newItem["Location"] = t.Location.X.ToString() + "," + t.Location.Y.ToString();

                t.Tag = controlID;
                newItem["ID"] = controlID;
                IncControlID();

                myList.Add(newItem);

                AddControl((Control)t);
            }
        }
        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            if (myList != null)
            {
                Dictionary<string, string> newItem = Defination.getCheckBox();
                CheckBox t = new CheckBox();

                t.Text = "neue Checkbox";
                newItem["Text"] = t.Text;

                t.Size = GetSize(newItem["Size"]);

                t.Location = new Point(snapGrid, snapGrid);
                newItem["Location"] = t.Location.X.ToString() + "," + t.Location.Y.ToString();

                t.Tag = controlID;
                newItem["ID"] = controlID;
                IncControlID();

                myList.Add(newItem);

                t.AutoCheck = false;

                AddControl((Control)t);
            }
        }
        private void btnPulse_Click(object sender, EventArgs e)
        {
            if (myList != null)
            {
                Dictionary<string, string> newItem = Defination.getPulse();
                Button t = new Button();

                t.Text = "neuer Pulse Generator";
                newItem["Text"] = t.Text;

                t.Size = GetSize(newItem["Size"]);

                t.Location = new Point(snapGrid, snapGrid);
                newItem["Location"] = t.Location.X.ToString() + "," + t.Location.Y.ToString();

                t.Tag = controlID;
                newItem["ID"] = controlID;
                IncControlID();

                myList.Add(newItem);

                AddControl((Control)t);
            }
        }
        private void btnTrackBar_Click(object sender, EventArgs e)
        {
            if (myList != null)
            {
                Dictionary<string, string> newItem = Defination.getTrackbar();
                cTrackBar t = new cTrackBar();

                t.Text = "neue TrackBar";
                newItem["Text"] = t.Text;

                t.Size = GetSize(newItem["Size"]);

                t.Location = new Point(snapGrid, snapGrid);
                newItem["Location"] = t.Location.X.ToString() + "," + t.Location.Y.ToString();

                t.Tag = controlID;
                newItem["ID"] = controlID;
                IncControlID();

                myList.Add(newItem);

                AddControl((Control)t);
            }
        }
        private void btnLabel_Click(object sender, EventArgs e)
        {
            if (myList != null)
            {
                Dictionary<string, string> newItem = Defination.getLabel();
                Label t = new Label();

                t.Text = "neuer Label";
                newItem["Text"] = t.Text;

                t.Font = new System.Drawing.Font("Arial", 15.0f);

                t.Size = GetSize(newItem["Size"]);

                t.Location = new Point(snapGrid, snapGrid);
                newItem["Location"] = t.Location.X.ToString() + "," + t.Location.Y.ToString();

                t.Tag = controlID;
                newItem["ID"] = controlID;
                IncControlID();

                myList.Add(newItem);

                AddControl((Control)t);
            }
        }
        private void btnIntregrator_Click(object sender, EventArgs e)
        {
            if (myList != null)
            {
                Dictionary<string, string> newItem = Defination.getIntregator();
                cIntregrator t = new cIntregrator();

                t.Text = "neuer Intregrator";
                newItem["Text"] = t.Text;

                t.Size = GetSize(newItem["Size"]);

                t.Location = new Point(snapGrid, snapGrid);
                newItem["Location"] = t.Location.X.ToString() + "," + t.Location.Y.ToString();

                t.Tag = controlID;
                newItem["ID"] = controlID;
                IncControlID();

                if (!String.IsNullOrEmpty((string)newItem["SetPoint"]))
                    t.PlcSetValue = int.Parse(newItem["SetPoint"]);
                if (!String.IsNullOrEmpty((string)newItem["Target"]))
                    t.PlcTargetValue = int.Parse(newItem["Target"]);

                // force output
                t.PlcTicks = 0;

                myList.Add(newItem);

                AddControl((Control)t);
            }
        }
        private void btnTableSet_Click(object sender, EventArgs e)
        {
            if (myList != null)
            {
                Dictionary<string, string> newItem = Defination.getTableSet();
                cTableSet t = new cTableSet();

                t.Text = "neuer TableSet";
                newItem["Text"] = t.Text;

                t.Size = GetSize(newItem["Size"]);

                t.Location = new Point(snapGrid, snapGrid);
                newItem["Location"] = t.Location.X.ToString() + "," + t.Location.Y.ToString();

                t.Tag = controlID;
                newItem["ID"] = controlID;
                IncControlID();

                t.BorderStyle = BorderStyle.FixedSingle;

                myList.Add(newItem);

                AddControl((Control)t);
            }
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            if (myList != null)
            {
                Dictionary<string, string> newItem = Defination.getInput();
                cInput t = new cInput();

                t.Text = "neue Eingabe";
                newItem["Text"] = t.Text;

                t.Size = GetSize(newItem["Size"]);

                t.Location = new Point(snapGrid, snapGrid);
                newItem["Location"] = t.Location.X.ToString() + "," + t.Location.Y.ToString();

                t.Tag = controlID;
                newItem["ID"] = controlID;
                IncControlID();

                myList.Add(newItem);

                AddControl((Control)t);
            }
        }

        #endregion

        private void IncControlID()
        {
            int nextID = int.Parse(controlID) + 1;
            controlID = nextID.ToString();
            myList[0]["ID"] = controlID;
        }

        private Size GetSize(string value)
        {
            return new Size(Convert.ToInt16(value.Split('x')[0]), Convert.ToInt16(value.Split('x')[1]));
        }
        private Point GetLocation(string value)
        {
            return new Point(Convert.ToInt16(value.Split(',')[0]), Convert.ToInt16(value.Split(',')[1]));
        }

        private void AddControl(Control crtl)
        {
            crtl.MouseDown += CrtlMouseDown;
            crtl.MouseMove += CrtlMouseMove;
            crtl.MouseUp += CrtlMouseUp;

            pMain.Controls.Add(crtl);
            crtl.BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (actID != string.Empty)
            {
                DialogResult res = MessageBox.Show("Really delete item ?", "Delete item", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    DeleteItemByID(actID);
                    dataProperties.DataSource = null;
                }
            }
        }

        private Dictionary<string, string> GetItemByID(string id)
        {
            foreach (Dictionary<string, string> item in myList)
            {
                if (item["ID"] == id) return item;
            }
            return null;
        }

        private void DeleteItemByID(string id)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i]["ID"] == id)
                {
                    myList.RemoveAt(i);
                    foreach (Control c in pMain.Controls)
                    {
                        if ((string)c.Tag == id)
                        {
                            pMain.Controls.Remove(c);

                            txtItemID.Text = string.Empty;
                            actID = string.Empty;

                            return;
                        }
                    }
                }
            }
        }

        private void dataProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string key = (string)dataProperties.Rows[e.RowIndex].Cells[0].Value;
                string val = (string)dataProperties.Rows[e.RowIndex].Cells[1].Value;

                if (key == "Text")
                {
                    string input = Interaction.InputBox("Enter new text for the control:", "New text", val);

                    if ((input != val) && (input.Length > 0))
                    {
                        GetItemByID(actID)["Text"] = input;

                        foreach (Control c in pMain.Controls)
                        {
                            if ((string)c.Tag == actID)
                            {
                                c.Text = input;
                                dataProperties.Rows[e.RowIndex].Cells[1].Value = input;
                                return;
                            }
                        }
                    }
                }
                if (key == "Size")
                {
                    string input = Interaction.InputBox("Enter a new size in the format AAAxBBB (e.g. 100x50):", "New size", val);

                    if ((input != val) && (input.Length > 0))
                    {
                        try
                        {
                            Size newSize = GetSize(input);

                            GetItemByID(actID)["Size"] = newSize.Width.ToString() + "x" + newSize.Height.ToString();

                            foreach (Control c in pMain.Controls)
                            {
                                if ((string)c.Tag == actID)
                                {
                                    c.Size = newSize;
                                    dataProperties.Rows[e.RowIndex].Cells[1].Value = newSize.Width.ToString() + "x" + newSize.Height.ToString();
                                    return;
                                }
                            }
                        }
                        catch { }


                    }
                }
                if ((key == "Button") ||
                    (key == "Lamp") ||
                    (key == "Output_Q") ||
                    (key == "Output_nQ") ||
                    (key == "Start") ||
                    (key == "Set") ||
                    (key.StartsWith("Step")))
                {
                    if (myInstance != null)
                    {
                        if (VarData != null)
                        {
                            frmSelectVar sel = new frmSelectVar(VarData, EDataType.Bool);
                            sel.ActualSelection = val;

                            DialogResult res = sel.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                GetItemByID(actID)[key] = sel.ActualSelection;
                                dataProperties.Rows[e.RowIndex].Cells[1].Value = sel.ActualSelection;
                            }
                        }
                    }
                }
                if ((key == "Output") ||
                    (key == "Target") ||
                    (key == "Gradiant") ||
                    (key == "SetPoint"))
                {
                    if (myInstance != null)
                    {
                        if (VarData != null)
                        {
                            frmSelectVar sel = new frmSelectVar(VarData, EDataType.Word);
                            sel.ActualSelection = val;

                            DialogResult res = sel.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                GetItemByID(actID)[key] = sel.ActualSelection;
                                dataProperties.Rows[e.RowIndex].Cells[1].Value = sel.ActualSelection;
                            }
                        }
                    }
                }
                if ((key == "Value") ||
                    (key.StartsWith("Value")))
                {
                    if (myInstance != null)
                    {
                        Dictionary<string, string> item = GetItemByID(actID);

                        if ((item["Control"] != "cTrackBar") && (item["Control"] != "cTableSet"))
                        {
                            bool set = false;
                            bool.TryParse(val, out set);

                            frmSelectDefault sel = new frmSelectDefault();
                            sel.ActualSelection = set;

                            DialogResult res = sel.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                GetItemByID(actID)["Value"] = sel.ActualSelection.ToString();
                                dataProperties.Rows[e.RowIndex].Cells[1].Value = sel.ActualSelection.ToString();
                            }
                        }
                        else
                        {
                            string input = Interaction.InputBox("Enter new value for the control:", "New value", val);

                            if ((input != val) && (input.Length > 0))
                            {
                                int set = 0;
                                int.TryParse(input, out set);

                                GetItemByID(actID)["Value"] = set.ToString();
                                dataProperties.Rows[e.RowIndex].Cells[1].Value = set.ToString();
                            }
                        }
                    }
                }
                if ((key == "Min") ||
                    (key == "Max"))
                {
                    string input = Interaction.InputBox("Enter new value for the control:", "New value", val);

                    if ((input != val) && (input.Length > 0))
                    {
                        int set = 0;
                        int.TryParse(input, out set);

                        GetItemByID(actID)[key] = set.ToString();
                        dataProperties.Rows[e.RowIndex].Cells[1].Value = set.ToString();
                    }
                }
                if (key == "ActiveColor")
                {
                    colorDialog1.Color = ColorTranslator.FromHtml(val);
                    DialogResult res = colorDialog1.ShowDialog();

                    if (res == DialogResult.OK)
                    {
                        string f = ColorTranslator.ToHtml(colorDialog1.Color);
                        GetItemByID(actID)["ActiveColor"] = f;
                        dataProperties.Rows[e.RowIndex].Cells[1].Value = f;
                    }

                }
            }
        }

        private bool checkVar(string var)
        {
            foreach (STagInfo info in VarData)
            {
                if (info.Name == var)
                    return true;
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SimulationRuntimeManager.RegisteredInstanceInfo.Length == 0)
            {
                btnPlcName.Text = "no PLC instance available";
                btnPlcName.Enabled = false;
                btnPlcName.BackColor = Color.Orange;
            }
            else
            {
                btnPlcName.Enabled = true;
                
                // check instance is available
                if (plcName != string.Empty)
                {
                    if (!checkPlcIntanceExists(plcName))
                    {
                        lstEvents.Items.Add("PLC instance not available!");
                        plcName = string.Empty;
                    }
                }

                // display name of the PLC instance
                if (plcName == string.Empty)
                {
                    btnPlcName.BackColor = SystemColors.Control;
                    btnPlcName.Text = "no PLC selected";
                }
                else
                {
                    btnPlcName.Text = "PLC: " + plcName;
                    btnPlcName.BackColor = Color.ForestGreen;

                    if (myInstance == null)
                        ConnectPLC();
                    else
                        if (myInstance.Name != plcName)
                            ConnectPLC();
                }
            }
        }

        private bool checkPlcIntanceExists(string name)
        {
            foreach (SInstanceInfo s in SimulationRuntimeManager.RegisteredInstanceInfo)
            {
                if (s.Name == name) return true;
            }
            return false;
        }


        private void btnPlcName_Click(object sender, EventArgs e)
        {
            frmSelectPlc plc = new frmSelectPlc();
            if (plc.ShowDialog() == DialogResult.OK)
            {
                plcName = plc.PlcName;

                ConnectPLC();
            }
        }

        private void menuSnapTo05_Click(object sender, EventArgs e)
        {
            snapGrid = 5;
            setSnapGrid();
        }

        private void menuSnapTo10_Click(object sender, EventArgs e)
        {
            snapGrid = 10;
            setSnapGrid();
        }

        private void menuSnapTo20_Click(object sender, EventArgs e)
        {
            snapGrid = 20;
            setSnapGrid();
        }

        private void setSnapGrid()
        {
            menuSnapTo05.Checked = false;
            menuSnapTo10.Checked = false;
            menuSnapTo20.Checked = false;

            if(snapGrid == 5) menuSnapTo05.Checked = true;
            if (snapGrid == 10) menuSnapTo10.Checked = true;
            if (snapGrid == 20) menuSnapTo20.Checked = true;

            lstEvents.Items.Add("Set snap to grid to " + snapGrid.ToString());

            Settings.Default["SnapGrid"] = snapGrid;
            Settings.Default.Save();
        }
    }
}
