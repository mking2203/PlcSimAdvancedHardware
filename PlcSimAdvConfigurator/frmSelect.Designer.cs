
namespace PlcSimAdvConfigurator
{
    partial class frmSelect
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
            this.radioMarker = new System.Windows.Forms.RadioButton();
            this.radioOutput = new System.Windows.Forms.RadioButton();
            this.radioInput = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.txtFilter = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Size = new System.Drawing.Size(601, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
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
            // radioMarker
            // 
            this.radioMarker.AutoSize = true;
            this.radioMarker.Location = new System.Drawing.Point(21, 89);
            this.radioMarker.Name = "radioMarker";
            this.radioMarker.Size = new System.Drawing.Size(58, 17);
            this.radioMarker.TabIndex = 3;
            this.radioMarker.Text = "Merker";
            this.radioMarker.UseVisualStyleBackColor = true;
            this.radioMarker.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioOutput
            // 
            this.radioOutput.AutoSize = true;
            this.radioOutput.Location = new System.Drawing.Point(21, 66);
            this.radioOutput.Name = "radioOutput";
            this.radioOutput.Size = new System.Drawing.Size(73, 17);
            this.radioOutput.TabIndex = 2;
            this.radioOutput.Text = "Ausgänge";
            this.radioOutput.UseVisualStyleBackColor = true;
            this.radioOutput.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioInput
            // 
            this.radioInput.AutoSize = true;
            this.radioInput.Location = new System.Drawing.Point(21, 43);
            this.radioInput.Name = "radioInput";
            this.radioInput.Size = new System.Drawing.Size(70, 17);
            this.radioInput.TabIndex = 1;
            this.radioInput.Text = "Eingänge";
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
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(28, 132);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSelect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variable wählen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMarker;
        private System.Windows.Forms.RadioButton radioOutput;
        private System.Windows.Forms.RadioButton radioInput;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.TextBox txtFilter;
    }
}