
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
            this.cButton1.PlcActiveColor = System.Drawing.Color.Empty;
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
            this.cButton3.PlcActiveColor = System.Drawing.Color.Empty;
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
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlcSimAdvanced Hardware";
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
        private cIntregrator cIntregrator1;
        private cButton cButton1;
        private cButton cButton3;
    }
}

