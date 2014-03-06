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
    public partial class frmLogLease : Form
    {
        //Set form wide objects
        SqlConnection conn = new SqlConnection();
        DataSet dsLease = null;
        SqlDataAdapter daLease = null;
        BindingSource bsLease = new BindingSource();
        public frmLogLease()
        {
            InitializeComponent();
        }
        private void DeleteLease(int iLeasNumber)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DeleteLeaseAgreement";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daDeleteLease = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set param
                cmd.Parameters.AddWithValue("@LeaseNumber",iLeasNumber);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue,"Update");
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
        private void UserMessage(int iValue,string sMsg)
        {
            if (iValue < 0)
                MessageBox.Show(sMsg + "succesful");
            else
                MessageBox.Show(sMsg + "failed");
        }
        private void UpdateLease(int iLeaseNumber,DateTime dtStartDate,DateTime dtExpiryDate,string sPaymentMethod,string sDepositPaid)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdateLeaseAgreement";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdateLease = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@LeaseNumber",iLeaseNumber);
                cmd.Parameters.AddWithValue("@LeaseStartDate",dtStartDate);
                cmd.Parameters.AddWithValue("@LeaseExpiryDate",dtExpiryDate);
                cmd.Parameters.AddWithValue("@PaymentMethod",sPaymentMethod);
                cmd.Parameters.AddWithValue("@DepositPaid",sDepositPaid);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue,"Update");
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
        private int InsertLease(DateTime dtStartDate,DateTime dtExpiryDate,string sPaymentMethod,string sDepositPaid,int iClientId,int iPropertyId)
        {
            //Set Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertLease";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daInsertLease = new SqlDataAdapter(cmd);
            conn.Open();
            //Set params
            cmd.Parameters.AddWithValue("@StartDate",dtStartDate);
            cmd.Parameters.AddWithValue("@ExpiryDate",dtExpiryDate);
            cmd.Parameters.AddWithValue("@PaymentMethod",sPaymentMethod);
            cmd.Parameters.AddWithValue("@DepositPaid",sDepositPaid);
            cmd.Parameters.AddWithValue("@ClientId",iClientId);
            cmd.Parameters.AddWithValue("@PropertyId",iPropertyId);
            SqlParameter NewLeaseNumber = new SqlParameter("@NewLeaseNumber",SqlDbType.Int);
            NewLeaseNumber.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(NewLeaseNumber);
            //Execution
            int iReutrnValue = cmd.ExecuteNonQuery();
            UserMessage(iReutrnValue,"Insert");
            conn.Close();
            return (int)NewLeaseNumber.Value;
        }
        private void GetPropertyForRent()
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetPropertyForRent";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter and dataset
            SqlDataAdapter daGetProp = new SqlDataAdapter();
            DataSet dsGetProp = new DataSet();
            try 
            {
                conn.Open();
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
        private void GetData()
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from LEASE_AGREEMENT";
            //Set the adapter
            daLease = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                dsLease = new DataSet();
                daLease.Fill(dsLease,"LEASE_AGREEMENT");
                //Bindingsource
                bsLease.DataSource = dsLease.Tables["LEASE_AGREEMENT"];
                //BindingNaigator
                bnLease.BindingSource = bsLease;
                //Bind the controls
                lblNumber.DataBindings.Add(new Binding("Text",bsLease,"LeaseNumber"));
                dtpStartDate.DataBindings.Add(new Binding("Text", bsLease, "LeaseStartDate"));
                dtpExpiryDate.DataBindings.Add(new Binding("Text",bsLease,"LeaseExpiryDate"));
                dtpStartDateUpdate.DataBindings.Add(new Binding("Text", bsLease, "LeaseStartDate"));
                dtpExpiryDateUpdate.DataBindings.Add(new Binding("Text", bsLease, "LeaseExpiryDate"));
                txtPaymentMethod.DataBindings.Add(new Binding("Text",bsLease,"LeasePaymentMethod"));
                ddlDepositPaid.DataBindings.Add(new Binding("Text",bsLease,"LeaseDepositPaid"));
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

        private void frmLogLease_Load(object sender, EventArgs e)
        {
            GetConnectionString();
            GetData();
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //Set controls
            ddlClient.Enabled = true;
            ddlProperty.Enabled = true;
            btnSave.Enabled = true;
            btnEditLease.Enabled = false;
            btnDelete.Enabled = false;
            //Fill ddls
            GetPropertyForRent();
            // TODO: This line of code loads data into the 'dsNationalRealtors.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.dsNationalRealtors.CLIENT);
        }

        private void ddlProperty_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["PropertyStreet"] + " , " + r["PropertyCity"];
        }

        private void btnEditLease_Click(object sender, EventArgs e)
        {
            //Set controls
            gpbxLease.Enabled = false;
            gpbxUpdateLease.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void ddlClient_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["ClientLname"] + " , " + r["ClientFname"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Set params
            DateTime dtStartDate = dtpStartDate.Value;
            DateTime dtExpiryDate = dtpExpiryDate.Value;
            string sPaymentMethod = txtPaymentMethod.Text;
            string sDepositPaid = ddlDepositPaid.Text;
            int iClientId = int.Parse(ddlClient.SelectedValue.ToString());
            int iPropertyId = int.Parse(ddlProperty.SelectedValue.ToString());
            try 
            {
                int iNewLeaseNumber = InsertLease(dtStartDate, dtExpiryDate, sPaymentMethod, sDepositPaid, iClientId, iPropertyId);
                lblNumber.Text = iNewLeaseNumber.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            finally 
            {
                conn.Close();//Just making 100% sure the connetion closes
            }
            //Set controls
            btnEditLease.Enabled = true;
            btnDelete.Enabled = true;
            bsLease.MoveFirst();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Set params
            DateTime dtUpdateStartDate = dtpStartDateUpdate.Value;
            DateTime dtUpdateExpiryDate = dtpExpiryDateUpdate.Value;
            string sPaymentMethod = txtPayMethodUpdate.Text;
            string sDepositPaid = ddlDepositPaidUpdate.Text;
            int iLeaseNumber = int.Parse(lblNumber.Text);
            //Update the lease
            UpdateLease(iLeaseNumber, dtUpdateStartDate, dtUpdateExpiryDate, sPaymentMethod, sDepositPaid);
            //Set controls
            gpbxLease.Enabled = true;
            gpbxUpdateLease.Enabled = false;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Set param
            int iLeaseNumber = int.Parse(lblNumber.Text);
            if (MessageBox.Show("Are you sure you want to delete this entry?", "Leases", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteLease(iLeaseNumber);
                bsLease.RemoveCurrent();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
