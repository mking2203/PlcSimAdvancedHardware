
namespace PlcSimAdvConfigurator
{
    partial class frmSelectVar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.radioMarker = new System.Windows.Forms.RadioButton();
            this.radioOutput = new System.Windows.Forms.RadioButton();
            this.radioInput = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.txtVar = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(601, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.radioMarker);
            this.groupBox1.Controls.Add(this.radioOutput);
            this.groupBox1.Controls.Add(this.radioInput);
            this.groupBox1.Controls.Add(this.radioAll);
            this.groupBox1.Location = new System.Drawing.Point(620, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(134, 131);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(26, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(21, 132);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(107, 20);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // radioMarker
            // 
            this.radioMarker.AutoSize = true;
            this.radioMarker.Location = new System.Drawing.Point(21, 89);
            this.radioMarker.Name = "radioMarker";
            this.radioMarker.Size = new System.Drawing.Size(58, 17);
            this.radioMarker.TabIndex = 3;
            this.radioMarker.Text = "Marker";
            this.radioMarker.UseVisualStyleBackColor = true;
            this.radioMarker.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioOutput
            // 
            this.radioOutput.AutoSize = true;
            this.radioOutput.Location = new System.Drawing.Point(21, 66);
            this.radioOutput.Name = "radioOutput";
            this.radioOutput.Size = new System.Drawing.Size(62, 17);
            this.radioOutput.TabIndex = 2;
            this.radioOutput.Text = "Outputs";
            this.radioOutput.UseVisualStyleBackColor = true;
            this.radioOutput.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioInput
            // 
            this.radioInput.AutoSize = true;
            this.radioInput.Location = new System.Drawing.Point(21, 43);
            this.radioInput.Name = "radioInput";
            this.radioInput.Size = new System.Drawing.Size(54, 17);
            this.radioInput.TabIndex = 1;
            this.radioInput.Text = "Inputs";
            this.radioInput.UseVisualStyleBackColor = true;
            this.radioInput.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Checked = true;
            this.radioAll.Location = new System.Drawing.Point(21, 20);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(59, 17);
            this.radioAll.TabIndex = 0;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All vars";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // txtVar
            // 
            this.txtVar.AutoSize = true;
            this.txtVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVar.Location = new System.Drawing.Point(25, 409);
            this.txtVar.Name = "txtVar";
            this.txtVar.Size = new System.Drawing.Size(147, 24);
            this.txtVar.TabIndex = 2;
            this.txtVar.Text = "Actual selection:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(620, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(648, 291);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Variable löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(708, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Abbruch";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSelectVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectVar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variable wählen";
            this.Load += new System.EventHandler(this.frmSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMarker;
        private System.Windows.Forms.RadioButton radioOutput;
        private System.Windows.Forms.RadioButton radioInput;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Label txtVar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}