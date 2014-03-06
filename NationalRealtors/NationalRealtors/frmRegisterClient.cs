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
    public partial class frmRegisterClient : Form
    {
        //Set form wide objects
        SqlConnection conn = new SqlConnection();
        DataSet dsClient;
        SqlDataAdapter daClient;
        BindingSource bsClient = new BindingSource();
        public frmRegisterClient()
        {
            InitializeComponent();
        }
        private int InsertClient(string sClientNumber,string sLastName,string sFirstName,DateTime dtDateReg,int iStaffId)
        {
            //Set the command
            SqlCommand cmdInsertClient = new SqlCommand();
            cmdInsertClient.Connection = conn;
            cmdInsertClient.CommandText = "InsertClient";
            cmdInsertClient.CommandType = CommandType.StoredProcedure;
            //Set the adapter
            SqlDataAdapter daInsertClient = new SqlDataAdapter(cmdInsertClient);
            conn.Open();
            //Set params
            cmdInsertClient.Parameters.AddWithValue("@ClientNumber",sClientNumber);
            cmdInsertClient.Parameters.AddWithValue("@ClientLname",sLastName);
            cmdInsertClient.Parameters.AddWithValue("@ClientFname",sFirstName);
            cmdInsertClient.Parameters.AddWithValue("@DateRegistered",dtDateReg);
            cmdInsertClient.Parameters.AddWithValue("@StaffId",iStaffId);
            SqlParameter NewClientId = new SqlParameter("@NewClientId", SqlDbType.Int);
            NewClientId.Direction = ParameterDirection.Output;
            cmdInsertClient.Parameters.Add(NewClientId);
            //Execution
            int iReturnValue = cmdInsertClient.ExecuteNonQuery();

            UserMessage(iReturnValue,"Insert");

            conn.Close();
            return (int)NewClientId.Value;
        }
        private int InsertClientPref(decimal dMaxRrent, int iClientId, int iPropTypeId)
        {
            //Set command
            SqlCommand cmdInsertClientPref = new SqlCommand();
            cmdInsertClientPref.Connection = conn;
            cmdInsertClientPref.CommandText = "InsertClientPreference";
            cmdInsertClientPref.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daInsertClientPref = new SqlDataAdapter(cmdInsertClientPref);
            conn.Open();
            //Set params
            cmdInsertClientPref.Parameters.AddWithValue("@ClientPrefMaxRent",dMaxRrent);
            cmdInsertClientPref.Parameters.AddWithValue("@ClientId",iClientId);
            cmdInsertClientPref.Parameters.AddWithValue("@PropTypeId",iPropTypeId);
            SqlParameter NewClientPrefId = new SqlParameter("@NewClientPrefId",SqlDbType.Int);
            NewClientPrefId.Direction = ParameterDirection.Output;
            cmdInsertClientPref.Parameters.Add(NewClientPrefId);
            //Execution
            int iReturnValue = cmdInsertClientPref.ExecuteNonQuery();

            UserMessage(iReturnValue,"Insert");

            conn.Close();
            return (int)NewClientPrefId.Value;
        }
        private void UserMessage(int iReturnValue,string sMsg)
        {
            if (iReturnValue < 0)
                MessageBox.Show(sMsg +" successful");
            else
                MessageBox.Show(sMsg +" failed");
        }
        private void UpdateClient(int iClientId,string sClientNumber,string sLastName,string sFirstName,DateTime dtDateReg,int iStaffId)
        {
            //Set command
            SqlCommand cmdUpdateClient = new SqlCommand();
            cmdUpdateClient.Connection = conn;
            cmdUpdateClient.CommandText = "UpdateClient";
            cmdUpdateClient.CommandType = CommandType.StoredProcedure;
            //Set the adapter
            SqlDataAdapter daUpdateClient = new SqlDataAdapter(cmdUpdateClient);
            try 
            {
                conn.Open();
                //Set params
                cmdUpdateClient.Parameters.AddWithValue("@ClientId",iClientId);
                cmdUpdateClient.Parameters.AddWithValue("@ClientNumber",sClientNumber);
                cmdUpdateClient.Parameters.AddWithValue("@ClientLname",sLastName);
                cmdUpdateClient.Parameters.AddWithValue("@ClientFname",sFirstName);
                cmdUpdateClient.Parameters.AddWithValue("@DateRegistered",dtDateReg);
                cmdUpdateClient.Parameters.AddWithValue("@StaffId",iStaffId);
                //Execution
                int iReturnValue = cmdUpdateClient.ExecuteNonQuery();
                UserMessage(iReturnValue,"Update");
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
        private void UpdateClientPref(int iClientPrefId,decimal dMaxRent,int iClientId,int iPropTypeId)
        {
            //Set command
            SqlCommand cmdUpdateClientPref = new SqlCommand();
            cmdUpdateClientPref.Connection = conn;
            cmdUpdateClientPref.CommandText = "UpdateClientPreference";
            cmdUpdateClientPref.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdateClientPref = new SqlDataAdapter(cmdUpdateClientPref);
            try
            {
                conn.Open();
                //Set params
                cmdUpdateClientPref.Parameters.AddWithValue("@ClientPrefId",iClientPrefId);
                cmdUpdateClientPref.Parameters.AddWithValue("@ClientPrefMaxRent",dMaxRent);
                cmdUpdateClientPref.Parameters.AddWithValue("@ClientId",iClientId);
                cmdUpdateClientPref.Parameters.AddWithValue("@PropTypeId",iPropTypeId);
                //Execution
                int iReturnValue = cmdUpdateClientPref.ExecuteNonQuery();
                UserMessage(iReturnValue,"Update");
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
        private void DeleteClient(int iClientId)
        {
            //Set command
            SqlCommand cmdDeleteClient = new SqlCommand();
            cmdDeleteClient.Connection = conn;
            cmdDeleteClient.CommandText = "DeleteClient";
            cmdDeleteClient.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daDeleteClient = new SqlDataAdapter(cmdDeleteClient);
            try 
            {
                conn.Open();
                //Set param
                cmdDeleteClient.Parameters.AddWithValue("@ClientId",iClientId);
                //Execution
                int iReturnValue = cmdDeleteClient.ExecuteNonQuery();
                UserMessage(iReturnValue, "Delete");
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
        private void GetConnectionstring()
        {
            conn.ConnectionString = @"Data Source=csi.ufs.ac.za; Initial Catalog=RIS314_HoffmannRW; Integrated Security=false; User Id=HoffmannRW; Password=rw8707075103087h;";
        }
        private void GetData()
        {
            //Set command and adapter
            SqlCommand cmdGetClient = new SqlCommand();
            cmdGetClient.Connection = conn;
            cmdGetClient.CommandText = "select * from CLIENT";
            daClient = new SqlDataAdapter(cmdGetClient);
            try 
            {
                conn.Open();
                dsClient = new DataSet();
                daClient.Fill(dsClient, "CLIENT");
                bsClient.DataSource = dsClient.Tables["CLIENT"];
                bnClient.BindingSource = bsClient;
                //Bind controls
                lblClientId.DataBindings.Add(new Binding("Text",bsClient,"ClientId"));
                txtClientNumber.DataBindings.Add(new Binding("Text",bsClient,"ClientNumber"));
                txtClientLname.DataBindings.Add(new Binding("Text",bsClient,"ClientLname"));
                txtClientFirstName.DataBindings.Add(new Binding("Text",bsClient,"ClientFname"));
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
        private void frmRegisterClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNationalRealtors.PROPERTY_TYPE' table. You can move, or remove it, as needed.
            this.pROPERTY_TYPETableAdapter.Fill(this.dsNationalRealtors.PROPERTY_TYPE);
            // TODO: This line of code loads data into the 'dsNationalRealtors.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.dsNationalRealtors.STAFF);
            GetConnectionstring();
            GetData();
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ddlRegisteredBy.Enabled = true;
            grpbxClientPref.Enabled = true;
            btnSave.Enabled = true;
            if ((btnDelete.Enabled) && (btnUpdate.Enabled))
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Set params
            string sClientNumber = txtClientNumber.Text;
            string sLastName = txtClientLname.Text;
            string sFirstName = txtClientFirstName.Text;
            DateTime dtDateReg = DateTime.Now;
            decimal dMaxRent = Convert.ToDecimal(txtMaxRent.Text);
            int iPropTypeId = int.Parse(ddlPropertyType.SelectedValue.ToString());
            int iStaffId = int.Parse(ddlRegisteredBy.SelectedValue.ToString());
            try 
            {
                //Insert Client
                int iNewClientId = InsertClient(sClientNumber, sLastName, sFirstName, dtDateReg, iStaffId);
                lblClientId.Text = iNewClientId.ToString();
                //Insert client preference
                int iNewClientPrefId = InsertClientPref(dMaxRent, iNewClientId, iPropTypeId);
                lblClientPrefId.Text = iNewClientPrefId.ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Set param
            int iClientId = int.Parse(lblClientId.Text);
            if (MessageBox.Show("Are you sure you want to delete this entry?", "Clients", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteClient(iClientId);
                bsClient.RemoveCurrent();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Set params
            int iClientId = int.Parse(lblClientId.Text);
            string sClientNumber = txtClientNumber.Text;
            string sLastName = txtClientLname.Text;
            string sFirstName = txtClientFirstName.Text;
            DateTime dtDateReg = DateTime.Now;
            int iStaffId = int.Parse(ddlRegisteredBy.SelectedValue.ToString());

            //Update client
            if (MessageBox.Show("Are you sure you want to save these changes?", "Clients", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                UpdateClient(iClientId, sClientNumber, sLastName, sFirstName, dtDateReg, iStaffId);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            grpbxClientPref.Enabled = false;
            ddlRegisteredBy.Enabled = true;
            if (btnSave.Enabled)
                btnSave.Enabled = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
