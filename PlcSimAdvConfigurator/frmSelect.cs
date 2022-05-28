using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siemens.Simatic.Simulation.Runtime;
using System.Text.RegularExpressions;

namespace PlcSimAdvConfigurator
{
    public partial class frmSelect : Form
    {
        STagInfo[] myData;
        public frmSelect(STagInfo[] data)
        {
            InitializeComponent();

            myData = data;

            DataTable dt = new DataTable();
            dt.Columns.Add("Variable");

            foreach (STagInfo info in myData)
            {
                if (info.DataType == EDataType.Bool)
                {
                    DataRow row = dt.NewRow();
                    row[0] = info.Name;

                    dt.Rows.Add(row);
                }
            }

            dataGridView1.DataSource = dt;

        }

        private void radio_CheckedChanged(object sender, EventArgs e)
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
                        DataRow row = dt.NewRow();
                        row[0] = info.Name;

                        dt.Rows.Add(row);
                    }
                }
            }

            dataGridView1.DataSource = dt;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
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
    }
}
