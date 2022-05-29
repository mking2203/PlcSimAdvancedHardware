using System;
using System.Data;
using System.Windows.Forms;

namespace PlcSimAdvConfigurator
{
    public partial class frmSelectDefault : Form
    {
        public bool ActualSelection
        {
            get; set;
        }

        DataTable dt = new DataTable();
        public frmSelectDefault()
        {
            InitializeComponent();
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;

            if (r.Name == "radioFalse") ActualSelection = false;
            if (r.Name == "radioTrue") ActualSelection = true;

            txtVar.Text = "Aktuelle Variable: " + ActualSelection.ToString();
        }

        private void frmSelect_Load(object sender, EventArgs e)
        {
            if (ActualSelection)
            {
                radioTrue.Checked = true;
            }
            else
            {
                radioFalse.Checked = true;
            }

            txtVar.Text = "Aktuelle Variable: " + ActualSelection.ToString();
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
    }
}
