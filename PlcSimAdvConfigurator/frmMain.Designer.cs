
namespace PlcSimAdvConfigurator
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
            this.pMain = new System.Windows.Forms.Panel();
            this.btnButton = new System.Windows.Forms.Button();
            this.btnToggleButton = new System.Windows.Forms.Button();
            this.btnButtonLamp = new System.Windows.Forms.Button();
            this.btnLamp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtItemID = new System.Windows.Forms.Label();
            this.btnCheckBox = new System.Windows.Forms.Button();
            this.dataProperties = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pMain.Location = new System.Drawing.Point(209, 1);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(800, 600);
            this.pMain.TabIndex = 0;
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(12, 12);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(180, 40);
            this.btnButton.TabIndex = 1;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnToggleButton
            // 
            this.btnToggleButton.Location = new System.Drawing.Point(12, 58);
            this.btnToggleButton.Name = "btnToggleButton";
            this.btnToggleButton.Size = new System.Drawing.Size(180, 40);
            this.btnToggleButton.TabIndex = 2;
            this.btnToggleButton.Text = "Toggle-Button";
            this.btnToggleButton.UseVisualStyleBackColor = true;
            this.btnToggleButton.Click += new System.EventHandler(this.btnToggleButton_Click);
            // 
            // btnButtonLamp
            // 
            this.btnButtonLamp.Location = new System.Drawing.Point(12, 104);
            this.btnButtonLamp.Name = "btnButtonLamp";
            this.btnButtonLamp.Size = new System.Drawing.Size(180, 40);
            this.btnButtonLamp.TabIndex = 3;
            this.btnButtonLamp.Text = "Button-Lamp";
            this.btnButtonLamp.UseVisualStyleBackColor = true;
            this.btnButtonLamp.Click += new System.EventHandler(this.btnButtonLamp_Click);
            // 
            // btnLamp
            // 
            this.btnLamp.Location = new System.Drawing.Point(12, 150);
            this.btnLamp.Name = "btnLamp";
            this.btnLamp.Size = new System.Drawing.Size(180, 40);
            this.btnLamp.TabIndex = 4;
            this.btnLamp.Text = "Lamp";
            this.btnLamp.UseVisualStyleBackColor = true;
            this.btnLamp.Click += new System.EventHandler(this.btnLamp_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1018, 552);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(207, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1018, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 40);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtItemID
            // 
            this.txtItemID.AutoSize = true;
            this.txtItemID.Location = new System.Drawing.Point(1035, 379);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(27, 13);
            this.txtItemID.TabIndex = 7;
            this.txtItemID.Text = "Item";
            // 
            // btnCheckBox
            // 
            this.btnCheckBox.Location = new System.Drawing.Point(12, 218);
            this.btnCheckBox.Name = "btnCheckBox";
            this.btnCheckBox.Size = new System.Drawing.Size(180, 40);
            this.btnCheckBox.TabIndex = 8;
            this.btnCheckBox.Text = "CheckBox";
            this.btnCheckBox.UseVisualStyleBackColor = true;
            this.btnCheckBox.Click += new System.EventHandler(this.btnCheckBox_Click);
            // 
            // dataProperties
            // 
            this.dataProperties.AllowUserToAddRows = false;
            this.dataProperties.AllowUserToDeleteRows = false;
            this.dataProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProperties.Location = new System.Drawing.Point(1018, 4);
            this.dataProperties.MultiSelect = false;
            this.dataProperties.Name = "dataProperties";
            this.dataProperties.ReadOnly = true;
            this.dataProperties.RowHeadersVisible = false;
            this.dataProperties.Size = new System.Drawing.Size(207, 359);
            this.dataProperties.TabIndex = 9;
            this.dataProperties.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProperties_CellContentDoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 604);
            this.Controls.Add(this.dataProperties);
            this.Controls.Add(this.btnCheckBox);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLamp);
            this.Controls.Add(this.btnButtonLamp);
            this.Controls.Add(this.btnToggleButton);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnToggleButton;
        private System.Windows.Forms.Button btnButtonLamp;
        private System.Windows.Forms.Button btnLamp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label txtItemID;
        private System.Windows.Forms.Button btnCheckBox;
        private System.Windows.Forms.DataGridView dataProperties;
    }
}

