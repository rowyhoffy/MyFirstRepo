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
    public partial class frmBranchTelNum : Form
    {
        //Set form wide objects
        SqlConnection conn = new SqlConnection();
        DataSet dsTelNum;
        SqlDataAdapter daTelnum;
        BindingSource bsTelNum = new BindingSource();
        public frmBranchTelNum()
        {
            InitializeComponent();
        }
        private void UserMessage(int iReturnValue, string sMsg)
        {
            if (iReturnValue < 0)
                MessageBox.Show(sMsg + " successful.","Telephone numbers",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show(sMsg + " failed.", "Telephone numbers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #region InsertUpdate
        private void UpdateTelephoneNumber(int iBranchTelId, string sBranchAreaCode, string sBranchTelNum, int iBranchId)
        {
            GetConnectionstring();
            //Set the command
            SqlCommand cmdUpdateTelNum = new SqlCommand();
            cmdUpdateTelNum.Connection = conn;
            cmdUpdateTelNum.CommandText = "UpdateBranchTelNumber";
            cmdUpdateTelNum.CommandType = CommandType.StoredProcedure;
            //Set the adapter
            SqlDataAdapter daUpdateTelNum = new SqlDataAdapter(cmdUpdateTelNum);
            try 
            {
                conn.Open();
                //Set params
                cmdUpdateTelNum.Parameters.AddWithValue("@BranchTelId", iBranchTelId);
                cmdUpdateTelNum.Parameters.AddWithValue("@BranchAreaCode",sBranchAreaCode);
                cmdUpdateTelNum.Parameters.AddWithValue("@BranchTelNum",sBranchTelNum);
                cmdUpdateTelNum.Parameters.AddWithValue("@BranchId",iBranchId);
                //Execution
                int iReturnValue = cmdUpdateTelNum.ExecuteNonQuery();
                UserMessage(iReturnValue, "Telephone number update");
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

        private int InsertTelephoneNumber(string sBranchAreaCode,string sBranchTelNum,int iBranchId)
        {
            GetConnectionstring();
            //Set the command
            SqlCommand cmdInsertTelNum = new SqlCommand();
            cmdInsertTelNum.Connection = conn;
            cmdInsertTelNum.CommandText = "InsertBranchTelNumber";
            cmdInsertTelNum.CommandType = CommandType.StoredProcedure;
            //Set the adapter
            SqlDataAdapter daInsertTelNum = new SqlDataAdapter(cmdInsertTelNum);
            conn.Open();
            //Set params
            cmdInsertTelNum.Parameters.AddWithValue("@BranchAreaCode", sBranchAreaCode);
            cmdInsertTelNum.Parameters.AddWithValue("@BranchTelNum",sBranchTelNum);
            cmdInsertTelNum.Parameters.AddWithValue("@BranchId",iBranchId);
            SqlParameter NewTelNumId = new SqlParameter("@NewTelNumId", SqlDbType.Int);
            NewTelNumId.Direction = ParameterDirection.Output;
            cmdInsertTelNum.Parameters.Add(NewTelNumId);
            //Execute cmd
            int iReturnValue = cmdInsertTelNum.ExecuteNonQuery();
            UserMessage(iReturnValue, "Telephone number insert");
            conn.Close();
            return (int)NewTelNumId.Value;
        }

        private void GetConnectionstring()
        {
            conn.ConnectionString = @"Data Source=csi.ufs.ac.za; Initial Catalog=RIS314_HoffmannRW; Integrated Security=false; User Id=HoffmannRW; Password=rw8707075103087h;";
        }

        private void GetData()
        {
            SqlCommand cmdTelNum = new SqlCommand();
            cmdTelNum.Connection = conn;

            cmdTelNum.CommandText = "select * from BRANCH_TEL_NUM";
            daTelnum = new SqlDataAdapter(cmdTelNum);

            try 
            {
                conn.Open();
                dsTelNum = new DataSet();
                daTelnum.Fill(dsTelNum,"BRANCH_TEL_NUM");

                bsTelNum.DataSource = dsTelNum.Tables["BRANCH_TEL_NUM"];
                bnTelNum.BindingSource = bsTelNum;
                lblTelNumId.DataBindings.Add(new Binding("Text",bsTelNum,"BranchTelId"));
                txtBranchAreaCode.DataBindings.Add(new Binding("Text",bsTelNum,"BranchAreaCode"));
                txtBranchTelNum.DataBindings.Add(new Binding("Text", bsTelNum, "BranchTelNum"));
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
        #endregion InsertUpdate
        private void frmBranchTelNum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNationalRealtors.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.dsNationalRealtors.BRANCH);
            GetConnectionstring();
            GetData();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            lblBranch.Visible = true;
            ddlBranch.Visible = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int iBranchId = int.Parse(ddlBranch.SelectedValue.ToString());
                //Insert Telephone number
                int iNewBranchTelId = InsertTelephoneNumber(txtBranchAreaCode.Text, txtBranchTelNum.Text,iBranchId);
                lblTelNumId.Text = iNewBranchTelId.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString().Replace(exc.ToString(),"This telephone number is a duplicate." + "\n"+"Inserttion failed."),
                                "Telephone numbers",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            finally 
            {
                conn.Close();
            }
            lblBranch.Visible = false;
            ddlBranch.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                int iNewBranchTelId = int.Parse(lblTelNumId.Text);
                int iBranchId = int.Parse(ddlBranch.SelectedValue.ToString());
                //Update Telephone number
                if (MessageBox.Show("Are you sure you wan to save the change(s)?", "Telephone numbers", 
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateTelephoneNumber(iNewBranchTelId, txtBranchAreaCode.Text, txtBranchTelNum.Text, iBranchId);
                }
            }
            catch(Exception exc) 
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
