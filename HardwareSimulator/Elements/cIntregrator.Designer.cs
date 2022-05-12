using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    partial class cIntregrator
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
            this.txtSet = new System.Windows.Forms.Label();
            this.txtActual = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.Label();
            this.txtOn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSet
            // 
            this.txtSet.AutoSize = true;
            this.txtSet.Location = new System.Drawing.Point(18, 17);
            this.txtSet.Name = "txtSet";
            this.txtSet.Size = new System.Drawing.Size(53, 13);
            this.txtSet.TabIndex = 0;
            this.txtSet.Text = "Set Value";
            // 
            // txtActual
            // 
            this.txtActual.AutoSize = true;
            this.txtActual.Location = new System.Drawing.Point(36, 78);
            this.txtActual.Name = "txtActual";
            this.txtActual.Size = new System.Drawing.Size(67, 13);
            this.txtActual.TabIndex = 1;
            this.txtActual.Text = "Actual Value";
            // 
            // txtTarget
            // 
            this.txtTarget.AutoSize = true;
            this.txtTarget.Location = new System.Drawing.Point(18, 34);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(68, 13);
            this.txtTarget.TabIndex = 2;
            this.txtTarget.Text = "Target Value";
            // 
            // txtOn
            // 
            this.txtOn.AutoSize = true;
            this.txtOn.Location = new System.Drawing.Point(121, 125);
            this.txtOn.Name = "txtOn";
            this.txtOn.Size = new System.Drawing.Size(15, 13);
            this.txtOn.TabIndex = 3;
            this.txtOn.Text = "O";
            // 
            // cIntregrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtOn);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.txtSet);
            this.Name = "cIntregrator";
            this.Size = new System.Drawing.Size(148, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSet;
        private System.Windows.Forms.Label txtActual;
        private System.Windows.Forms.Label txtTarget;
        private System.Windows.Forms.Label txtOn;

        // Serialized property.
        private ToolTip toolTip = new System.Windows.Forms.ToolTip();

        // Public and designer access to the property.
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
    }
}
