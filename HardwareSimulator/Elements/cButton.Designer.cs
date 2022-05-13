using System.ComponentModel;
using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    partial class cButton
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
            this.SuspendLayout();
            // 
            // cButton
            // 
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cButton_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cButton_MouseUp);
            this.ResumeLayout(false);

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
    }
}
