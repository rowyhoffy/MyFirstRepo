using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NationalRealtors
{
    public partial class frmLogViewing : Form
    {
        SqlConnection conn = new SqlConnection();
        public frmLogViewing()
        {
            InitializeComponent();
        }
        private void GetPropertyOnView()
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetPropertyOnView";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter and dataset
            SqlDataAdapter daGetProp = new SqlDataAdapter();
            DataSet dsGetProp = new DataSet();
            try 
            {
                daGetProp.SelectCommand = cmd;
                daGetProp.Fill(dsGetProp);
                ddlProperty.DataSource = dsGetProp.Tables[0];
                ddlProperty.DisplayMember = dsGetProp.Tables[0].Columns["PropertyStreet"].ColumnName;
                ddlProperty.ValueMember = dsGetProp.Tables[0].Columns["PropertyId"].ColumnName;
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
        private void LogViewing(int iClientId,int iPropertyId,DateTime dtViewDate)
        {
            //Set command
            SqlCommand cmdLogView = new SqlCommand();
            cmdLogView.Connection = conn;
            cmdLogView.CommandText = "InsertView";
            cmdLogView.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daLogView = new SqlDataAdapter(cmdLogView);
            try 
            {
                conn.Open();
                //Set params
                cmdLogView.Parameters.AddWithValue("@ClientId",iClientId);
                cmdLogView.Parameters.AddWithValue("@PropertyId",iPropertyId);
                cmdLogView.Parameters.AddWithValue("@ViewDate",dtViewDate);
                //Execution
                int iReturnValue = cmdLogView.ExecuteNonQuery();
                if (iReturnValue < 0)
                    MessageBox.Show("Insert successful");
                else
                    MessageBox.Show("Insert failed");
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

        private void frmLogViewing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNationalRealtors.PROPERTY' table. You can move, or remove it, as needed.
            //this.pROPERTYTableAdapter.Fill(this.dsNationalRealtors.PROPERTY);
            // TODO: This line of code loads data into the 'dsNationalRealtors.PROPERTY' table. You can move, or remove it, as needed.
            //this.pROPERTYTableAdapter.Fill(this.dsNationalRealtors.PROPERTY);
            // TODO: This line of code loads data into the 'dsNationalRealtors.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.dsNationalRealtors.CLIENT);
            GetConnectionString();
            GetPropertyOnView();
        }

        private void ddlProperty_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["PropertyStreet"] + " , " + r["PropertyCity"];
        }

        private void ddlClient_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["ClientLname"] + " , " + r["ClientFname"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetConnectionString();
            //Set params
            int iClientId = int.Parse(ddlClient.SelectedValue.ToString());
            int iPropertyId = int.Parse(ddlProperty.SelectedValue.ToString());
            DateTime dtViewDate = dtpViewDate.Value;
            //Log view
            LogViewing(iClientId, iPropertyId, dtViewDate);
        }
    }
}
