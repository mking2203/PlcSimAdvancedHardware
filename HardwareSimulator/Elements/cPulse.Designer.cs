using System.ComponentModel;
using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    partial class cPulse
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTime = new System.Windows.Forms.Label();
            this.txtPulse = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Location = new System.Drawing.Point(30, 33);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(41, 13);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "500 ms";
            // 
            // txtPulse
            // 
            this.txtPulse.AutoSize = true;
            this.txtPulse.Location = new System.Drawing.Point(78, 75);
            this.txtPulse.Name = "txtPulse";
            this.txtPulse.Size = new System.Drawing.Size(15, 13);
            this.txtPulse.TabIndex = 1;
            this.txtPulse.Text = "O";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(35, 13);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Name";
            // 
            // cPulse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPulse);
            this.Controls.Add(this.txtTime);
            this.Name = "cPulse";
            this.Size = new System.Drawing.Size(98, 98);
            this.SizeChanged += new System.EventHandler(this.cPulse_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Serialized property.
        private ToolTip toolTip = new System.Windows.Forms.ToolTip();

        // Public and designer access to the property.
        [Description("Represents a small rectangular pop-up window"), Category("Design")]
        public string ToolTip
        {
            get
            {
                return toolTip.GetToolTip(this);
            }
            set
            {
                toolTip.SetToolTip(this, value);
            }
        }

        private System.Windows.Forms.Label txtTime;
        private Label txtPulse;
        private Label txtName;
    }
}
