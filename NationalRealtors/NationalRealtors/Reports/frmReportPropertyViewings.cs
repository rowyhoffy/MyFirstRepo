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
    
    public partial class frmReportPropertyViewings : Form
    {
        SqlConnection conn = new SqlConnection();
        BindingSource bsViewings;
        public frmReportPropertyViewings()
        {
            InitializeComponent();
        }
        private void GetData(int iPropertyId)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ReportPropertyViewings";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daViewings = new SqlDataAdapter();
            DataSet dsViewings = new DataSet();
            bsViewings = new BindingSource();
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@PropertyId",iPropertyId);
                daViewings.SelectCommand = cmd;
                daViewings.Fill(dsViewings);
                bsViewings.DataSource = dsViewings.Tables[0];
                //Bind to dgv
                dgvPropertyViewings.AutoGenerateColumns = false;
                dgvPropertyViewings.DataSource = bsViewings;
                dgvPropertyViewings.Columns["ClientNumber"].DataPropertyName = "ClientNumber";
                dgvPropertyViewings.Columns["ClientLname"].DataPropertyName = "ClientLname";
                dgvPropertyViewings.Columns["ClientFname"].DataPropertyName = "ClientFname";
                dgvPropertyViewings.Columns["ViewDate"].DataPropertyName = "ViewDate";
                dgvPropertyViewings.Columns["PropertyComments"].DataPropertyName = "PropertyComments";
            }
            catch(Exception exc) 
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
        private void frmReportPropertyViewings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNationalRealtors.PROPERTY' table. You can move, or remove it, as needed.
            this.pROPERTYTableAdapter.Fill(this.dsNationalRealtors.PROPERTY);
        }

        private void ddlProperties_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            GetConnectionString();
            try
            {
                int iPropertyId = int.Parse(ddlProperties.SelectedValue.ToString());
                GetData(iPropertyId);
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            
        }
    }
}
