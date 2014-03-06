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
    public partial class frmReportOnClients : Form
    {
        SqlConnection conn = new SqlConnection();
        public frmReportOnClients()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ReportOnClients";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daClients = new SqlDataAdapter();
            DataSet dsClients = new DataSet();
            BindingSource bsClients = new BindingSource();
            try 
            {
                conn.Open();
                daClients.SelectCommand = cmd;
                daClients.Fill(dsClients);
                bsClients.DataSource = dsClients.Tables[0];
                //Bind to dgv
                dgvClientsLookingToRent.DataSource = bsClients;
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
        private void frmReportOnClients_Load(object sender, EventArgs e)
        {
            GetConnectionString();
            GetData();
        }
    }
}
