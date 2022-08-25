using System.ComponentModel;
using System.Windows.Forms;

namespace PlcSimAdvConfigurator
{
    partial class cTrackBar
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
            this.txtName = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(0, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(35, 13);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "label1";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(6, 51);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(144, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.AutoSize = true;
            this.txtValue.Location = new System.Drawing.Point(3, 137);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(35, 13);
            this.txtValue.TabIndex = 2;
            this.txtValue.Text = "label1";
            // 
            // cTrackBar
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txtName);
            this.Name = "cTrackBar";
            this.Size = new System.Drawing.Size(148, 148);
            this.SizeChanged += new System.EventHandler(this.TrackBar1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Serialized property.
        private ToolTip toolTip = new System.Windows.Forms.ToolTip();
        private Label txtName;
        private TrackBar trackBar1;
        private Label txtValue;

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
    }
}
