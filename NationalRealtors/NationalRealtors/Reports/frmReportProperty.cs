using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NationalRealtors.Reports
{
    public partial class frmReportProperty : Form
    {
        public frmReportProperty()
        {
            InitializeComponent();
        }

        private void frmReportProperty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNationalRealtors.vReportProperty' table. You can move, or remove it, as needed.
            this.vReportPropertyTableAdapter.Fill(this.dsNationalRealtors.vReportProperty);

        }
    }
}
