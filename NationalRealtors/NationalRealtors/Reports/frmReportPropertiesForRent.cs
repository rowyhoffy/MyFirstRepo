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
    public partial class frmReportPropertiesForRent : Form
    {
        SqlConnection conn = new SqlConnection();
        public frmReportPropertiesForRent()
        {
            InitializeComponent();
        }
        private void GetPropertiesForRent(string sCity)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ReportPropertiesForRent";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dsGetProps = new DataSet();
            BindingSource bsGetProps = new BindingSource();
            try 
            {
                conn.Open();
                //Set param
                cmd.Parameters.AddWithValue("@City",sCity);
                da.SelectCommand = cmd;
                da.Fill(dsGetProps);
                bsGetProps.DataSource = dsGetProps.Tables[0];
                //Bind to dgv
                dgvPropertiesForRent.DataSource = bsGetProps;
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
        private void GetConnetionString()
        {
            conn.ConnectionString = @"Data Source=csi.ufs.ac.za; Initial Catalog=RIS314_HoffmannRW; Integrated Security=false; User Id=HoffmannRW; Password=rw8707075103087h;";
        }
        private void frmReportPropertiesForRent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNationalRealtors.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.dsNationalRealtors.BRANCH);

        }

        private void ddlCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetConnetionString();
            try
            {
                string sCity = ddlCity.SelectedValue.ToString();
                GetPropertiesForRent(sCity);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
