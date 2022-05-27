using System;
using System.Drawing;
using System.Windows.Forms;

using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace PlcSimAdvConfigurator
{
    public partial class frmMain : Form
    {
        // save the start point of the control
        Point controlPos = new Point();
        // save the start point of the mouse
        Point mousePos = new Point();

        // grid size
        const int snap = 20;
        // move is active
        bool move;

        List<Dictionary<string, string>> myList;

        public frmMain()
        {
            InitializeComponent();

            string json = File.ReadAllText(Application.StartupPath + "\\elements.json");
            myList = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(json);

            int id = 1;

            foreach (Dictionary<string, string> item in myList)
            {
                if (item["Control"] == "cButton")
                {
                    Button t = new Button();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);

                    t.MouseDown += B_MouseDown;
                    t.MouseMove += B_MouseMove;
                    t.MouseUp += B_MouseUp;

                    t.Tag = id;

                    pMain.Controls.Add(t);
                }
                else if (item["Control"] == "cToggleButton")
                {
                    Button t = new Button();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);

                    t.MouseDown += B_MouseDown;
                    t.MouseMove += B_MouseMove;
                    t.MouseUp += B_MouseUp;

                    t.Tag = id;

                    pMain.Controls.Add(t);
                }
                else if (item["Control"] == "cButtonLamp")
                {
                    Button t = new Button();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);

                    t.MouseDown += B_MouseDown;
                    t.MouseMove += B_MouseMove;
                    t.MouseUp += B_MouseUp;

                    t.Tag = id;

                    pMain.Controls.Add(t);
                }
                else if (item["Control"] == "cLamp")
                {
                    Button t = new Button();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);

                    t.MouseDown += B_MouseDown;
                    t.MouseMove += B_MouseMove;
                    t.MouseUp += B_MouseUp;

                    t.Tag = id;

                    pMain.Controls.Add(t);
                }
                else if (item["Control"] == "cInvert")
                {
                    Button t = new Button();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);

                    t.MouseDown += B_MouseDown;
                    t.MouseMove += B_MouseMove;
                    t.MouseUp += B_MouseUp;

                    t.Tag = id;

                    pMain.Controls.Add(t);
                }
                else if (item["Control"] == "cCheckBox")
                {
                    CheckBox t = new CheckBox();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);

                    t.MouseDown += B_MouseDown;
                    t.MouseMove += B_MouseMove;
                    t.MouseUp += B_MouseUp;

                    t.Tag = id;

                    pMain.Controls.Add(t);
                }
                else if (item["Control"] == "cPulse")
                {
                    Button t = new Button();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);

                    t.MouseDown += B_MouseDown;
                    t.MouseMove += B_MouseMove;
                    t.MouseUp += B_MouseUp;

                    t.Tag = id;

                    pMain.Controls.Add(t);
                }
                else if (item["Control"] == "cTrackbar")
                {
                    TrackBar t = new TrackBar();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);

                    t.MouseDown += B_MouseDown;
                    t.MouseMove += B_MouseMove;
                    t.MouseUp += B_MouseUp;

                    t.Tag = id;

                    pMain.Controls.Add(t);
                }
                else if (item["Control"] == "cLabel")
                {
                    Label t = new Label();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);
                    t.BorderStyle = BorderStyle.FixedSingle;

                    t.MouseDown += B_MouseDown;
                    t.MouseMove += B_MouseMove;
                    t.MouseUp += B_MouseUp;

                    t.Tag = id;

                    pMain.Controls.Add(t);
                }
                else if (item["Control"] == "cIntregrator")
                {
                    Button t = new Button();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);

                    t.MouseDown += B_MouseDown;
                    t.MouseMove += B_MouseMove;
                    t.MouseUp += B_MouseUp;

                    t.Tag = id;

                    pMain.Controls.Add(t);
                }
                else if (item["Control"] == "cTableSet")
                {
                    Button t = new Button();
                    t.Text = item["Text"];
                    t.Size = GetSize(item["Size"]);
                    t.Location = GetLocation(item["Location"]);

                    t.MouseDown += B_MouseDown;
                    t.MouseMove += B_MouseMove;
                    t.MouseUp += B_MouseUp;

                    t.Tag = id;

                    pMain.Controls.Add(t);
                }

                id++;
            }
        }

        private System.Drawing.Size GetSize(string value)
        {
            return new System.Drawing.Size(Convert.ToInt16(value.Split('x')[0]), Convert.ToInt16(value.Split('x')[1]));
        }
        private System.Drawing.Point GetLocation(string value)
        {
            return new System.Drawing.Point(Convert.ToInt16(value.Split(',')[0]), Convert.ToInt16(value.Split(',')[1]));
        }

        private void B_MouseUp(object sender, MouseEventArgs e)
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
                int dX = newX / snap;
                int dy = newY / snap;
                // calc the remaining px
                int rX = newX - dX * snap;
                int rY = newY - dy * snap;

                // re-calc the position
                newX = dX * snap;
                newY = dy * snap;
                // if more the half use next grid point
                if (rX > (snap / 2)) newX += snap;
                if (rY > (snap / 2)) newY += snap;

                b.Location = new Point(newX, newY);
            }
        }

        private void B_MouseMove(object sender, MouseEventArgs e)
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

        private void B_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control b = (Control)sender;
                controlPos = b.Location;
                mousePos = MousePosition;

                b.BringToFront();

                move = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button t = new Button();
            t.Text = "neuer Button";
            t.Size = new Size(100,50);
            t.Location = new Point(snap,snap);

            t.MouseDown += B_MouseDown;
            t.MouseMove += B_MouseMove;
            t.MouseUp += B_MouseUp;

            //t.Tag = id;

            pMain.Controls.Add(t);
            t.BringToFront();
        }
    }
}
