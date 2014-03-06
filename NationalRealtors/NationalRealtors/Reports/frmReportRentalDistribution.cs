using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NationalRealtors.Reports
{
    public partial class frmReportRentalDistribution : Form
    {
        SqlConnection conn = new SqlConnection();
        BindingSource bsReport;
        public frmReportRentalDistribution()
        {
            InitializeComponent();
        }
        private void GetData(string sCity)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ReportRentalDistribution";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daGetReport = new SqlDataAdapter();
            DataSet dsReport = new DataSet();
            bsReport = new BindingSource();
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@City",sCity);
                daGetReport.SelectCommand = cmd;
                daGetReport.Fill(dsReport);
                bsReport.DataSource = dsReport.Tables[0];
                //Bind to dgv
                dgvRentalDistribution.DataSource = bsReport;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            finally 
            {
                conn.Close();
            }

        }
        private void GetConnectionString()
        {
            conn.ConnectionString = @"Data Source=csi.ufs.ac.za; Initial Catalog=RIS314_HoffmannRW; Integrated Security=false; User Id=HoffmannRW; Password=rw8707075103087h;";
        }
        private void frmReportRentalDistribution_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNationalRealtors.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.dsNationalRealtors.BRANCH);
            GetConnectionString();
        }

        private void ddlCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string sCity = ddlCity.SelectedValue.ToString();
                GetData(sCity);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
