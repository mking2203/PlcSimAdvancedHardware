
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtItemID = new System.Windows.Forms.Label();
            this.btnCheckBox = new System.Windows.Forms.Button();
            this.dataProperties = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtSimulation = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPulse = new System.Windows.Forms.Button();
            this.btnTrackBar = new System.Windows.Forms.Button();
            this.btnLabel = new System.Windows.Forms.Button();
            this.btnIntregrator = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnTableSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProperties)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pMain.Location = new System.Drawing.Point(203, 33);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(800, 600);
            this.pMain.TabIndex = 0;
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(12, 59);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(180, 40);
            this.btnButton.TabIndex = 1;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnToggleButton
            // 
            this.btnToggleButton.Location = new System.Drawing.Point(12, 105);
            this.btnToggleButton.Name = "btnToggleButton";
            this.btnToggleButton.Size = new System.Drawing.Size(180, 40);
            this.btnToggleButton.TabIndex = 2;
            this.btnToggleButton.Text = "Toggle-Button";
            this.btnToggleButton.UseVisualStyleBackColor = true;
            this.btnToggleButton.Click += new System.EventHandler(this.btnToggleButton_Click);
            // 
            // btnButtonLamp
            // 
            this.btnButtonLamp.Location = new System.Drawing.Point(12, 151);
            this.btnButtonLamp.Name = "btnButtonLamp";
            this.btnButtonLamp.Size = new System.Drawing.Size(180, 40);
            this.btnButtonLamp.TabIndex = 3;
            this.btnButtonLamp.Text = "Button-Lamp";
            this.btnButtonLamp.UseVisualStyleBackColor = true;
            this.btnButtonLamp.Click += new System.EventHandler(this.btnButtonLamp_Click);
            // 
            // btnLamp
            // 
            this.btnLamp.Location = new System.Drawing.Point(12, 197);
            this.btnLamp.Name = "btnLamp";
            this.btnLamp.Size = new System.Drawing.Size(180, 40);
            this.btnLamp.TabIndex = 4;
            this.btnLamp.Text = "Lamp";
            this.btnLamp.UseVisualStyleBackColor = true;
            this.btnLamp.Click += new System.EventHandler(this.btnLamp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1018, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 40);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Item";
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
            this.btnCheckBox.Location = new System.Drawing.Point(12, 243);
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
            this.dataProperties.AllowUserToResizeRows = false;
            this.dataProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProperties.Location = new System.Drawing.Point(1013, 33);
            this.dataProperties.MultiSelect = false;
            this.dataProperties.Name = "dataProperties";
            this.dataProperties.ReadOnly = true;
            this.dataProperties.RowHeadersVisible = false;
            this.dataProperties.Size = new System.Drawing.Size(207, 359);
            this.dataProperties.TabIndex = 9;
            this.dataProperties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProperties_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.simulationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuNew,
            this.toolStripMenuItem2,
            this.mnuSave,
            this.mnuSaveAs,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(111, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(111, 22);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(111, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(111, 22);
            this.mnuSaveAs.Text = "SaveAs";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(111, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReload});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // mnuReload
            // 
            this.mnuReload.Name = "mnuReload";
            this.mnuReload.Size = new System.Drawing.Size(110, 22);
            this.mnuReload.Text = "Reload";
            this.mnuReload.Click += new System.EventHandler(this.mnuReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Toolbox";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSimulation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1234, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtSimulation
            // 
            this.txtSimulation.Name = "txtSimulation";
            this.txtSimulation.Size = new System.Drawing.Size(78, 17);
            this.txtSimulation.Text = "txtSimulation";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPulse
            // 
            this.btnPulse.Location = new System.Drawing.Point(12, 289);
            this.btnPulse.Name = "btnPulse";
            this.btnPulse.Size = new System.Drawing.Size(180, 40);
            this.btnPulse.TabIndex = 13;
            this.btnPulse.Text = "Pulse Generator";
            this.btnPulse.UseVisualStyleBackColor = true;
            this.btnPulse.Click += new System.EventHandler(this.btnPulse_Click);
            // 
            // btnTrackBar
            // 
            this.btnTrackBar.Location = new System.Drawing.Point(12, 335);
            this.btnTrackBar.Name = "btnTrackBar";
            this.btnTrackBar.Size = new System.Drawing.Size(180, 40);
            this.btnTrackBar.TabIndex = 14;
            this.btnTrackBar.Text = "TrackBar";
            this.btnTrackBar.UseVisualStyleBackColor = true;
            this.btnTrackBar.Click += new System.EventHandler(this.btnTrackBar_Click);
            // 
            // btnLabel
            // 
            this.btnLabel.Location = new System.Drawing.Point(12, 381);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(180, 40);
            this.btnLabel.TabIndex = 15;
            this.btnLabel.Text = "Label";
            this.btnLabel.UseVisualStyleBackColor = true;
            this.btnLabel.Click += new System.EventHandler(this.btnLabel_Click);
            // 
            // btnIntregrator
            // 
            this.btnIntregrator.Location = new System.Drawing.Point(12, 427);
            this.btnIntregrator.Name = "btnIntregrator";
            this.btnIntregrator.Size = new System.Drawing.Size(180, 40);
            this.btnIntregrator.TabIndex = 16;
            this.btnIntregrator.Text = "Intregrator";
            this.btnIntregrator.UseVisualStyleBackColor = true;
            this.btnIntregrator.Click += new System.EventHandler(this.btnIntregrator_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(12, 519);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(180, 40);
            this.btnInput.TabIndex = 17;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnTableSet
            // 
            this.btnTableSet.Location = new System.Drawing.Point(12, 473);
            this.btnTableSet.Name = "btnTableSet";
            this.btnTableSet.Size = new System.Drawing.Size(180, 40);
            this.btnTableSet.TabIndex = 18;
            this.btnTableSet.Text = "TableSet";
            this.btnTableSet.UseVisualStyleBackColor = true;
            this.btnTableSet.Click += new System.EventHandler(this.btnTableSet_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.btnTableSet);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnIntregrator);
            this.Controls.Add(this.btnLabel);
            this.Controls.Add(this.btnTrackBar);
            this.Controls.Add(this.btnPulse);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataProperties);
            this.Controls.Add(this.btnCheckBox);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLamp);
            this.Controls.Add(this.btnButtonLamp);
            this.Controls.Add(this.btnToggleButton);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLC";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProperties)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnToggleButton;
        private System.Windows.Forms.Button btnButtonLamp;
        private System.Windows.Forms.Button btnLamp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label txtItemID;
        private System.Windows.Forms.Button btnCheckBox;
        private System.Windows.Forms.DataGridView dataProperties;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtSimulation;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPulse;
        private System.Windows.Forms.Button btnTrackBar;
        private System.Windows.Forms.Button btnLabel;
        private System.Windows.Forms.Button btnIntregrator;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnTableSet;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

