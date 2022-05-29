using System;
using System.Data;
using System.Windows.Forms;
using Siemens.Simatic.Simulation.Runtime;
using System.Text.RegularExpressions;

namespace PlcSimAdvConfigurator
{
    public partial class frmSelectVar : Form
    {
        private STagInfo[] myData;
        public string ActualSelection
        {
            get; set;
        }

        private DataTable dt = new DataTable();
        public frmSelectVar(STagInfo[] data)
        {
            InitializeComponent();

            myData = data;
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataTable();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            UpdateDataTable();
        }

        private void UpdateDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Variable");

            foreach (STagInfo info in myData)
            {
                if (info.DataType == EDataType.Bool)
                {
                    if ((radioAll.Checked) ||
                        (radioInput.Checked && (info.Area == EArea.Input)) ||
                        (radioOutput.Checked && (info.Area == EArea.Output)) ||
                        (radioMarker.Checked && (info.Area == EArea.Marker)))
                    {
                        if (Regex.Match(info.Name, txtFilter.Text, RegexOptions.Singleline | RegexOptions.IgnoreCase).Success)
                        {
                            DataRow row = dt.NewRow();
                            row[0] = info.Name;

                            dt.Rows.Add(row);
                        }
                    }
                }
            }

            dataGridView1.DataSource = dt;
        }

        private void frmSelect_Load(object sender, EventArgs e)
        {
            UpdateDataTable();

            txtVar.Text = "Aktuelle Variable: " + ActualSelection;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFilter.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ActualSelection = string.Empty;
            txtVar.Text = "Aktuelle Variable: " + ActualSelection;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string key = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                ActualSelection = key;
                txtVar.Text = "Aktuelle Variable: " + ActualSelection;
            }
        }
    }
}
