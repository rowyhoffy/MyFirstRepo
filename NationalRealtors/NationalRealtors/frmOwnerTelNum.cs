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
    public partial class frmOwnerTelNum : Form
    {
        //Set form wide objects
        SqlConnection conn = new SqlConnection();
        DataSet dsOwnerTelNum;
        public frmOwnerTelNum()
        {
            InitializeComponent();
        }
        private void GetOwners()
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetOwners";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daGetOwners = new SqlDataAdapter();
            DataSet dsGetOwners = new DataSet();
            BindingSource bsGetOwner = new BindingSource();
            try 
            {
                conn.Open();
                daGetOwners.SelectCommand = cmd;
                daGetOwners.Fill(dsGetOwners);
                bsGetOwner.DataSource = dsGetOwners.Tables[0];
                ddlOwner.DataSource = bsGetOwner;
                ddlOwner.DisplayMember = "OwnerLname";
                ddlOwner.ValueMember = "OwnerId";
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
        private void UpdateOwnerTelNum(int iOwnerTelId,int iOwnerId,string sAreaCode,string sNumber)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdateOwnerTelNumber";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdateTelNum = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@OwnerTelId",iOwnerTelId);
                cmd.Parameters.AddWithValue("@OwnerId",iOwnerId);
                cmd.Parameters.AddWithValue("@OwnerAreaCode",sAreaCode);
                cmd.Parameters.AddWithValue("@OwnerTelNum",sNumber);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue,"Update telephone number");
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
        private int InsertOwnerTelNum(int iOwnerId, string sAreaCode, string sNumber)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertOwnerTelNumber";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daInsertTelNum = new SqlDataAdapter(cmd);
            SqlParameter NewOwnerTelId = new SqlParameter("@NewOwnerTelId", SqlDbType.Int);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@OwnerId",iOwnerId);
                cmd.Parameters.AddWithValue("@OwnerAreaCode",sAreaCode);
                cmd.Parameters.AddWithValue("@OwnerTelNum", sNumber);
                NewOwnerTelId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(NewOwnerTelId);
                //Execution
                int iReturnVlaue = cmd.ExecuteNonQuery();
                UserMessage(iReturnVlaue, "Insert telephone number");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            finally 
            {
                conn.Close();
            } return (int)NewOwnerTelId.Value;
        }
        private void UserMessage(int iReturnValue, string sMsg)
        {
            if (iReturnValue < 0)
                MessageBox.Show(sMsg + "successful");
            else
                MessageBox.Show(sMsg + "failed");
        }
        private void GetData()
        {
            //Set commands,adapters and bindingsources--Owner
            SqlCommand cmdOwner = new SqlCommand();
            cmdOwner.Connection = conn;
            cmdOwner.CommandText = "select * from [OWNER]";
            SqlDataAdapter daOwner = new SqlDataAdapter(cmdOwner);
            BindingSource bsOwner = new BindingSource();
            //Owner Telephone number
            SqlCommand cmdOwnerTelNum = new SqlCommand();
            cmdOwnerTelNum.Connection = conn;
            cmdOwnerTelNum.CommandText = "select * from OWNER_TEL_NUM";
            SqlDataAdapter daOwnerTelNum = new SqlDataAdapter(cmdOwnerTelNum);
            BindingSource bsOwnerTelNum = new BindingSource();
            //Individual
            SqlCommand cmdIndividu = new SqlCommand();
            cmdIndividu.Connection = conn;
            cmdIndividu.CommandText = "select * from INDIVIDUAL";
            SqlDataAdapter daIndividu = new SqlDataAdapter(cmdIndividu);
            BindingSource bsIndividu = new BindingSource();
            //Business
            SqlCommand cmdBusiness = new SqlCommand();
            cmdBusiness.Connection = conn;
            cmdBusiness.CommandText = "select * from BUSINESS";
            SqlDataAdapter daBusiness = new SqlDataAdapter(cmdBusiness);
            BindingSource bsBusiness = new BindingSource();
            try 
            {
                conn.Open();
                //Fill datasets
                dsOwnerTelNum = new DataSet();
                daOwner.Fill(dsOwnerTelNum, "OWNER");
                daOwnerTelNum.Fill(dsOwnerTelNum, "OWNER_TEL_NUM");
                daIndividu.Fill(dsOwnerTelNum, "INDIVIDUAL");
                daBusiness.Fill(dsOwnerTelNum,"BUSINESS");
                //Add datarelation
                DataRelation drOwnerTelNum = new DataRelation("OwnerTelNum", dsOwnerTelNum.Tables["OWNER"].Columns["OwnerId"], dsOwnerTelNum.Tables["OWNER_TEL_NUM"].Columns["OwnerId"]);
                DataRelation drOwnerIndividual = new DataRelation("OwnerIndividual",dsOwnerTelNum.Tables["OWNER"].Columns["OwnerId"],dsOwnerTelNum.Tables["INDIVIDUAL"].Columns["OwnerId"]);
                DataRelation drOwnerBusiness = new DataRelation("OwnerBusiness",dsOwnerTelNum.Tables["OWNER"].Columns["OwnerId"],dsOwnerTelNum.Tables["BUSINESS"].Columns["OwnerId"]);
                dsOwnerTelNum.Relations.Add(drOwnerTelNum);
                dsOwnerTelNum.Relations.Add(drOwnerIndividual);
                dsOwnerTelNum.Relations.Add(drOwnerBusiness);
                //Binding the sources
                bsOwner.DataSource = dsOwnerTelNum.Tables["OWNER"];
                bsOwnerTelNum.DataSource = bsOwner;
                bsOwnerTelNum.DataMember = "OwnerTelNum";
                bsIndividu.DataSource = bsOwner;
                bsIndividu.DataMember = "OwnerIndividual";
                bsBusiness.DataSource = bsOwner;
                bsBusiness.DataMember = "OwnerBusiness";
                //Binding navigator
                bnOwnerTelNum.BindingSource = bsOwner;
                //Bind controls--TelNum
                lblTelId.DataBindings.Add(new Binding("Text",bsOwnerTelNum,"OwnerTelId"));
                txtAreaCode.DataBindings.Add(new Binding("Text",bsOwnerTelNum,"OwnerAreaCode"));
                txtTelNum.DataBindings.Add(new Binding("Text",bsOwnerTelNum,"OwnerTelNum"));
                //Owner
                lblDisplayOwnerId.DataBindings.Add(new Binding("Text",bsOwner,"OwnerId"));
                txtIndividual.DataBindings.Add(new Binding("Text",bsIndividu,"IndividLname"));
                txtBusiness.DataBindings.Add(new Binding("Text",bsBusiness,"BusinessName"));
            }
            catch(Exception exc) 
            {
                MessageBox.Show(exc.ToString());
            }
            finally
            {
                conn.Close();
            }
            GetOwners();
        }
        private void GetConnectionString()
        {
            conn.ConnectionString = @"Data Source=csi.ufs.ac.za; Initial Catalog=RIS314_HoffmannRW; Integrated Security=false; User Id=HoffmannRW; Password=rw8707075103087h;";
        }

        private void frmOwnerTelNum_Load(object sender, EventArgs e)
        {
            GetConnectionString();
            GetData();
            bnOwnerTelNum.BindingSource.MoveLast();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Set params
            int iOwnerId = int.Parse(ddlOwner.SelectedValue.ToString());
            string sAreaCode = txtAreaCode.Text;
            string sNumber = txtTelNum.Text;
            //Insert the number
            int iNewOwnerTelId = InsertOwnerTelNum(iOwnerId, sAreaCode, sNumber);
            lblTelId.Text = iNewOwnerTelId.ToString();
            //Set controls
            ddlOwner.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Set params
            int iOwnerId = int.Parse(lblDisplayOwnerId.Text);
            int iOwnerTelId = int.Parse(lblTelId.Text);
            string sAreaCode = txtAreaCode.Text;
            string sNumber = txtTelNum.Text;
            //Upate the number
            if (MessageBox.Show("Are you sure you want to save the change(s)?", "Owner telephone numbers", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateOwnerTelNum(iOwnerTelId, iOwnerId, sAreaCode, sNumber);
            }

        }

        private void tsbtnAddAdditional_Click(object sender, EventArgs e)
        {
            //Set controls
            ddlOwner.Enabled = true;
        }

        private void ddlOwner_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["OwnerLname"] + " , " + r["OwnerFname"];
        }
    }
}
