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
    public partial class frmRegisterBranch : Form
    {
        //Form wide objects
        SqlConnection conn = new SqlConnection();
        DataSet dsBranch;
        SqlDataAdapter daBranch;
        BindingSource bsBranch = new BindingSource();
        public frmRegisterBranch()
        {
            InitializeComponent();
        }
        #region Events
        private void btnAddTel_Click(object sender, EventArgs e)
        {
            //Instantiate and show dialog for an Additional Branch Telephone number
            frmBranchTelNum AdditionalNumber = new frmBranchTelNum();
            AdditionalNumber.ShowDialog();
        }

        private void frmRegisterBranch_Load(object sender, EventArgs e)
        {
            GetConnectionstring();
            GetData();
            //Set buttons
            //btnSave.Enabled = false;
            btnDone.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert new branch
                int iNewBranchId = InsertBranch(txtBranchNumber.Text, txtBranchStreet.Text, txtBranchCity.Text, txtBranchPostCode.Text);
                lblBranchId.Text = iNewBranchId.ToString();
                //Set buttons
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Visible = false;
                btnDone.Visible = true;
                btnAddTel.Enabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(""+exc.ToString().Replace(exc.ToString(),"This branch already exists"),"",
                                MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            finally 
            {
                    conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sBranchId = lblBranchId.Text;
                int iBranchId = int.Parse(sBranchId);
                if (MessageBox.Show("Are you sure you want to delete this entry?", "Branches",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {//Delete branch
                    DeleteBranch(iBranchId);
                    bsBranch.RemoveCurrent();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString().Trim());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Update branch
                string sBranchId = lblBranchId.Text;
                int iBranchId = int.Parse(sBranchId);
                if (MessageBox.Show("Are you sure you want to save the change(s)?", "Branches", 
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateBranch(iBranchId, txtBranchNumber.Text, txtBranchStreet.Text, txtBranchCity.Text, txtBranchPostCode.Text);
                    bsBranch.ResetCurrentItem();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            //Set buttons
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnAddTel.Enabled = false;
            btnSave.Enabled = true;
            bsBranch.AddNew();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion Events
        #region InsertUpdateDelte
        private void GetConnectionstring()
        {
            conn.ConnectionString = @"Data Source=csi.ufs.ac.za; Initial Catalog=RIS314_HoffmannRW; Integrated Security=false; User Id=HoffmannRW; Password=rw8707075103087h;";
        }

        private void GetData()
        {
            SqlCommand cmdBranch = new SqlCommand();
            //Set the connection for each command
            cmdBranch.Connection = conn;
            //Set the text for commands
            cmdBranch.CommandText = "select * from BRANCH";
            //The adapters
            daBranch = new SqlDataAdapter(cmdBranch);

            //Set command for Branch TelNum
            SqlCommand cmdTelNum = new SqlCommand();
            cmdTelNum.Connection = conn;
            cmdTelNum.CommandText = "select * from BRANCH_TEL_NUM";
            //Set adapter
            SqlDataAdapter daTelNum = new SqlDataAdapter(cmdTelNum);
            BindingSource bsTelnum = new BindingSource();

            try
            {
                conn.Open();
                dsBranch = new DataSet();
                daBranch.Fill(dsBranch, "BRANCH");
                daTelNum.Fill(dsBranch,"BRANCH_TEL_NUM");
                DataRelation dr = new DataRelation("BranchTelNum",dsBranch.Tables["BRANCH"].Columns["BranchId"],
                                                   dsBranch.Tables["BRANCH_TEL_NUM"].Columns["BranchId"]);
                dsBranch.Relations.Add(dr);
                //Bindingsources
                bsBranch.DataSource = dsBranch.Tables["BRANCH"];
                bsTelnum.DataSource = bsBranch;
                bsTelnum.DataMember = "BranchTelNum";
                //Bindingnavigator needs a source
                bnBranch.BindingSource = bsBranch;
                //Bind the Branch controls
                lblBranchId.DataBindings.Add(new Binding("Text", bsBranch, "BranchId"));
                txtBranchNumber.DataBindings.Add(new Binding("Text", bsBranch, "BranchNumber"));
                txtBranchStreet.DataBindings.Add(new Binding("Text", bsBranch, "BranchStreet"));
                txtBranchCity.DataBindings.Add(new Binding("Text", bsBranch, "BranchCity"));
                txtBranchPostCode.DataBindings.Add(new Binding("Text", bsBranch, "BranchPostCode"));
                //Set the gridview
                dgvTelNum.AutoGenerateColumns = false;
                dgvTelNum.DataSource = bsTelnum;
                dgvTelNum.Columns["AreaCode"].DataPropertyName = "BranchAreaCode";
                dgvTelNum.Columns["Number"].DataPropertyName = "BranchTelNum";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private int InsertBranch(string sBranchNumber, string sBranchStreet, string sBranchCity, string sBranchPostCode)
        {
            GetConnectionstring();
            //Set the command
            SqlCommand cmdInsertBranch = new SqlCommand();
            cmdInsertBranch.Connection = conn;
            cmdInsertBranch.CommandText = "InsertBranch";
            cmdInsertBranch.CommandType = CommandType.StoredProcedure;
            //Set the adapter
            SqlDataAdapter daInsertBranch = new SqlDataAdapter(cmdInsertBranch);
            conn.Open();
            //Set the params
            cmdInsertBranch.Parameters.AddWithValue("@BranchNumber", sBranchNumber);
            cmdInsertBranch.Parameters.AddWithValue("@BranchStreet", sBranchStreet);
            cmdInsertBranch.Parameters.AddWithValue("@BranchCity", sBranchCity);
            cmdInsertBranch.Parameters.AddWithValue("@BranchPostCode", sBranchPostCode);
            SqlParameter NewBranchId = new SqlParameter("@NewBranchId", SqlDbType.Int);
            NewBranchId.Direction = ParameterDirection.Output;
            cmdInsertBranch.Parameters.Add(NewBranchId);
            
            //Execute command
            int iReturnValue = cmdInsertBranch.ExecuteNonQuery();
            if (iReturnValue < 0)
            {
                MessageBox.Show("Branch added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Addition failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            return (int)NewBranchId.Value;
        }

        private void UpdateBranch(int iBranchId, string sBranchNumber, string sBranchStreet, string sBranchCity, string sBranchPostCode)
        {
            GetConnectionstring();
            //Set the command
            SqlCommand cmdUpdateBranch = new SqlCommand();
            cmdUpdateBranch.Connection = conn;
            cmdUpdateBranch.CommandText = "UpdateBranch";
            cmdUpdateBranch.CommandType = CommandType.StoredProcedure;
            //Set the data adapter
            SqlDataAdapter daUpdateBranch = new SqlDataAdapter(cmdUpdateBranch);
            try
            {
                conn.Open();
                //Set the params
                cmdUpdateBranch.Parameters.AddWithValue("@BranchId", iBranchId);
                cmdUpdateBranch.Parameters.AddWithValue("@BranchNumber", sBranchNumber);
                cmdUpdateBranch.Parameters.AddWithValue("@BranchStreet", sBranchStreet);
                cmdUpdateBranch.Parameters.AddWithValue("@BranchCity", sBranchCity);
                cmdUpdateBranch.Parameters.AddWithValue("@BranchPostCode", sBranchPostCode);
                //Execute command
                int iReturnValue = cmdUpdateBranch.ExecuteNonQuery();
                if (iReturnValue < 0)
                    MessageBox.Show("Branch updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error: Update failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Your design is flawed-correct it!!" + exc.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void DeleteBranch(int iBranchId)
        {
            GetConnectionstring();
            //Set the command
            SqlCommand cmdDeleteBranch = new SqlCommand();
            cmdDeleteBranch.Connection = conn;
            cmdDeleteBranch.CommandText = "DeleteBranch";
            cmdDeleteBranch.CommandType = CommandType.StoredProcedure;
            //Set the adapter
            SqlDataAdapter DeleteBranch = new SqlDataAdapter(cmdDeleteBranch);
            try
            {
                conn.Open();
                //Set param
                cmdDeleteBranch.Parameters.AddWithValue("@BranchId", iBranchId);
                int iReturnValue = cmdDeleteBranch.ExecuteNonQuery();
                if (iReturnValue < 0)
                    MessageBox.Show("Branch Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error: Delete failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Your design is flawed-correct it!!" + exc.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion InsertUpdateDelete

    }
}
