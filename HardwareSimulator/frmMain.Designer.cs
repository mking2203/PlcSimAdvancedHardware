
namespace PlcSimAdvSimulator
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.cButton2 = new PlcSimAdvSimulator.cButton();
            this.cToggleButton1 = new PlcSimAdvSimulator.cToggleButton();
            this.cCheckBox2 = new PlcSimAdvSimulator.cCheckBox();
            this.cButtonLamp1 = new PlcSimAdvSimulator.cButtonLamp();
            this.cLamp4 = new PlcSimAdvSimulator.cLamp();
            this.cLamp1 = new PlcSimAdvSimulator.cLamp();
            this.cLamp2 = new PlcSimAdvSimulator.cLamp();
            this.cPulse1 = new PlcSimAdvSimulator.cPulse();
            this.cLamp3 = new PlcSimAdvSimulator.cLamp();
            this.cLamp5 = new PlcSimAdvSimulator.cLamp();
            this.cIntregrator1 = new PlcSimAdvSimulator.cIntregrator();
            this.cButton1 = new PlcSimAdvSimulator.cButton();
            this.cButton3 = new PlcSimAdvSimulator.cButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtTime
            // 
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(33, 17);
            this.txtTime.Text = "Time";
            // 
            // cButton2
            // 
            this.cButton2.Location = new System.Drawing.Point(12, 99);
            this.cButton2.Name = "cButton2";
            this.cButton2.PlcButtonTag = "Eingang_02";
            this.cButton2.PlcButtonValue = false;
            this.cButton2.Size = new System.Drawing.Size(223, 77);
            this.cButton2.TabIndex = 2;
            this.cButton2.Tag = "";
            this.cButton2.Text = "Button";
            this.cButton2.ToolTip = "";
            this.cButton2.UseVisualStyleBackColor = true;
            // 
            // cToggleButton1
            // 
            this.cToggleButton1.Location = new System.Drawing.Point(12, 12);
            this.cToggleButton1.Name = "cToggleButton1";
            this.cToggleButton1.PlcButtonTag = "Eingang_01";
            this.cToggleButton1.PlcButtonValue = false;
            this.cToggleButton1.Size = new System.Drawing.Size(223, 81);
            this.cToggleButton1.TabIndex = 3;
            this.cToggleButton1.Tag = "";
            this.cToggleButton1.Text = "ToggleButton";
            this.cToggleButton1.ToolTip = "";
            this.cToggleButton1.UseVisualStyleBackColor = true;
            // 
            // cCheckBox2
            // 
            this.cCheckBox2.AutoSize = true;
            this.cCheckBox2.Location = new System.Drawing.Point(121, 199);
            this.cCheckBox2.Name = "cCheckBox2";
            this.cCheckBox2.PlcButtonTag = "Eingang_03";
            this.cCheckBox2.PlcButtonValue = false;
            this.cCheckBox2.Size = new System.Drawing.Size(75, 17);
            this.cCheckBox2.TabIndex = 5;
            this.cCheckBox2.Text = "CheckBox";
            this.cCheckBox2.ToolTip = "";
            this.cCheckBox2.UseVisualStyleBackColor = true;
            // 
            // cButtonLamp1
            // 
            this.cButtonLamp1.BackColor = System.Drawing.SystemColors.Control;
            this.cButtonLamp1.Location = new System.Drawing.Point(202, 295);
            this.cButtonLamp1.Name = "cButtonLamp1";
            this.cButtonLamp1.PlcButtonTag = "Eingang_04";
            this.cButtonLamp1.PlcButtonValue = false;
            this.cButtonLamp1.PlcLampTag = "Ausgang_03";
            this.cButtonLamp1.PlcLampValue = false;
            this.cButtonLamp1.Size = new System.Drawing.Size(154, 63);
            this.cButtonLamp1.TabIndex = 9;
            this.cButtonLamp1.Text = "cButtonLamp1";
            this.cButtonLamp1.ToolTip = "";
            this.cButtonLamp1.UseVisualStyleBackColor = true;
            // 
            // cLamp4
            // 
            this.cLamp4.BackColor = System.Drawing.SystemColors.Control;
            this.cLamp4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cLamp4.Location = new System.Drawing.Point(254, 199);
            this.cLamp4.Name = "cLamp4";
            this.cLamp4.PlcLampTag = "Eingang_03";
            this.cLamp4.PlcLampValue = false;
            this.cLamp4.Size = new System.Drawing.Size(45, 50);
            this.cLamp4.TabIndex = 11;
            this.cLamp4.Text = "cLamp4";
            this.cLamp4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLamp4.ToolTip = "";
            // 
            // cLamp1
            // 
            this.cLamp1.BackColor = System.Drawing.SystemColors.Control;
            this.cLamp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cLamp1.Location = new System.Drawing.Point(257, 115);
            this.cLamp1.Name = "cLamp1";
            this.cLamp1.PlcLampTag = "Eingang_02";
            this.cLamp1.PlcLampValue = false;
            this.cLamp1.Size = new System.Drawing.Size(45, 42);
            this.cLamp1.TabIndex = 12;
            this.cLamp1.Text = "cLamp1";
            this.cLamp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLamp1.ToolTip = "";
            // 
            // cLamp2
            // 
            this.cLamp2.BackColor = System.Drawing.SystemColors.Control;
            this.cLamp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cLamp2.Location = new System.Drawing.Point(257, 45);
            this.cLamp2.Name = "cLamp2";
            this.cLamp2.PlcLampTag = "Eingang_01";
            this.cLamp2.PlcLampValue = false;
            this.cLamp2.Size = new System.Drawing.Size(45, 39);
            this.cLamp2.TabIndex = 13;
            this.cLamp2.Text = "cLamp2";
            this.cLamp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLamp2.ToolTip = "";
            // 
            // cPulse1
            // 
            this.cPulse1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPulse1.Location = new System.Drawing.Point(486, 136);
            this.cPulse1.Name = "cPulse1";
            this.cPulse1.PlcOutputTag = "Eingang_05";
            this.cPulse1.PlcTimeMS = 1000;
            this.cPulse1.Size = new System.Drawing.Size(98, 98);
            this.cPulse1.TabIndex = 14;
            this.cPulse1.ToolTip = "";
            // 
            // cLamp3
            // 
            this.cLamp3.BackColor = System.Drawing.SystemColors.Control;
            this.cLamp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cLamp3.Location = new System.Drawing.Point(364, 45);
            this.cLamp3.Name = "cLamp3";
            this.cLamp3.PlcLampTag = "Ausgang_01";
            this.cLamp3.PlcLampValue = false;
            this.cLamp3.Size = new System.Drawing.Size(45, 39);
            this.cLamp3.TabIndex = 15;
            this.cLamp3.Tag = "";
            this.cLamp3.Text = "cLamp3";
            this.cLamp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLamp3.ToolTip = "";
            // 
            // cLamp5
            // 
            this.cLamp5.BackColor = System.Drawing.SystemColors.Control;
            this.cLamp5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cLamp5.Location = new System.Drawing.Point(364, 115);
            this.cLamp5.Name = "cLamp5";
            this.cLamp5.PlcLampTag = "Ausgang_02";
            this.cLamp5.PlcLampValue = false;
            this.cLamp5.Size = new System.Drawing.Size(45, 39);
            this.cLamp5.TabIndex = 16;
            this.cLamp5.Tag = "";
            this.cLamp5.Text = "cLamp5";
            this.cLamp5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cLamp5.ToolTip = "";
            // 
            // cIntregrator1
            // 
            this.cIntregrator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cIntregrator1.Location = new System.Drawing.Point(486, 241);
            this.cIntregrator1.Name = "cIntregrator1";
            this.cIntregrator1.PlcActualValue = 0;
            this.cIntregrator1.PlcActualValueTag = "Value_Actual";
            this.cIntregrator1.PlcGradient = 0;
            this.cIntregrator1.PlcGradientTag = "Value_Gradient";
            this.cIntregrator1.PlcResetValueTag = "Eingang_06";
            this.cIntregrator1.PlcSetValue = 0;
            this.cIntregrator1.PlcSetValueTag = "Value_Set";
            this.cIntregrator1.PlcStartValueTag = "Eingang_07";
            this.cIntregrator1.PlcTargetValue = 0;
            this.cIntregrator1.PlcTargetValueTag = "Value_Target";
            this.cIntregrator1.PlcTicks = ((long)(0));
            this.cIntregrator1.Size = new System.Drawing.Size(148, 148);
            this.cIntregrator1.TabIndex = 17;
            this.cIntregrator1.ToolTip = "";
            // 
            // cButton1
            // 
            this.cButton1.Location = new System.Drawing.Point(670, 241);
            this.cButton1.Name = "cButton1";
            this.cButton1.PlcButtonTag = "Eingang_06";
            this.cButton1.PlcButtonValue = false;
            this.cButton1.Size = new System.Drawing.Size(75, 23);
            this.cButton1.TabIndex = 18;
            this.cButton1.Text = "Reset";
            this.cButton1.ToolTip = "";
            this.cButton1.UseVisualStyleBackColor = true;
            // 
            // cButton3
            // 
            this.cButton3.Location = new System.Drawing.Point(670, 285);
            this.cButton3.Name = "cButton3";
            this.cButton3.PlcButtonTag = "Eingang_07";
            this.cButton3.PlcButtonValue = false;
            this.cButton3.Size = new System.Drawing.Size(75, 23);
            this.cButton3.TabIndex = 19;
            this.cButton3.Text = "Start";
            this.cButton3.ToolTip = "";
            this.cButton3.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cButton3);
            this.Controls.Add(this.cButton1);
            this.Controls.Add(this.cIntregrator1);
            this.Controls.Add(this.cLamp5);
            this.Controls.Add(this.cLamp3);
            this.Controls.Add(this.cPulse1);
            this.Controls.Add(this.cLamp2);
            this.Controls.Add(this.cLamp1);
            this.Controls.Add(this.cLamp4);
            this.Controls.Add(this.cButtonLamp1);
            this.Controls.Add(this.cCheckBox2);
            this.Controls.Add(this.cToggleButton1);
            this.Controls.Add(this.cButton2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtTime;
        private cButton cButton2;
        private cToggleButton cToggleButton1;
        private cCheckBox cCheckBox2;
        private cButtonLamp cButtonLamp1;
        private cLamp cLamp4;
        private cLamp cLamp1;
        private cLamp cLamp2;
        private cPulse cPulse1;
        private cLamp cLamp3;
        private cLamp cLamp5;
        private cIntregrator cIntregrator1;
        private cButton cButton1;
        private cButton cButton3;
    }
}

