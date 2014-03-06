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
    public partial class frmRegisterStaff : Form
    {
        //Set form wide objects
        SqlConnection conn = new SqlConnection();
        DataSet dsStaff;
        SqlDataAdapter daStaff;
        BindingSource bsStaff = new BindingSource();
        public frmRegisterStaff()
        {
            InitializeComponent();
        }
        private void UserMessage(int iReturnValue, string sMsg)
        {
            if (iReturnValue < 0)
                MessageBox.Show(sMsg + "successful", "Staff Members", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(sMsg + "failed", "Staff Members", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void DeleteStaff(int iStaffid)
        {
            GetConnectionstring();
            //Ste the command
            SqlCommand cmdDeleteStaff = new SqlCommand();
            cmdDeleteStaff.Connection = conn;
            cmdDeleteStaff.CommandText = "DeleteStaff";
            cmdDeleteStaff.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daDeleteStaff = new SqlDataAdapter(cmdDeleteStaff);
            try 
            {
                conn.Open();
                //Set param
                cmdDeleteStaff.Parameters.AddWithValue("@StaffId",iStaffid);
                //Execution
                int iReturnValue = cmdDeleteStaff.ExecuteNonQuery();
                UserMessage(iReturnValue, "Staff member delete ");
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

        private void UpdateStaff(int iStaffId, string sStaffNumber, string sTitle, string sLastName, string sFirstName, string sGender, DateTime dtDOB, DateTime dtStartDate, int iSupervisor, int iClassId, int iBranchId)
        {
            GetConnectionstring();
            //Set the command
            SqlCommand cmdUpdateStaff = new SqlCommand();
            cmdUpdateStaff.Connection = conn;
            cmdUpdateStaff.CommandText = "UpdateStaff";
            cmdUpdateStaff.CommandType = CommandType.StoredProcedure;
            //Set the adapter
            SqlDataAdapter daUpdateStaff = new SqlDataAdapter(cmdUpdateStaff);
            try 
            {
                conn.Open();
                //Set params
                cmdUpdateStaff.Parameters.AddWithValue("@StaffId",iStaffId);
                cmdUpdateStaff.Parameters.AddWithValue("@StaffNumber", sStaffNumber);
                cmdUpdateStaff.Parameters.AddWithValue("@StaffTitle", sTitle);
                cmdUpdateStaff.Parameters.AddWithValue("@StaffLname", sLastName);
                cmdUpdateStaff.Parameters.AddWithValue("@StaffFname", sFirstName);
                cmdUpdateStaff.Parameters.AddWithValue("@StaffGender", sGender);
                cmdUpdateStaff.Parameters.AddWithValue("@StaffDOB", dtDOB);
                cmdUpdateStaff.Parameters.AddWithValue("@StaffStartDate", dtStartDate);
                cmdUpdateStaff.Parameters.AddWithValue("@StaffSupervisor", iSupervisor);
                cmdUpdateStaff.Parameters.AddWithValue("@StaffClassId", iClassId);
                cmdUpdateStaff.Parameters.AddWithValue("@BranchId", iBranchId);
                //Execution
                int iReturnValue = cmdUpdateStaff.ExecuteNonQuery();
                UserMessage(iReturnValue,"Staff member update ");
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

        private int InsertStaff(string sStaffNumber, string sTitle, string sLastName, string sFirstName, string sGender, DateTime dtDOB, DateTime dtStartDate, int iSupervisor, int iClassId, int iBranchId)
        {
            GetConnectionstring();
            //Set the command
            SqlCommand cmdInsertStaff = new SqlCommand();
            cmdInsertStaff.Connection = conn;
            cmdInsertStaff.CommandText = "InsertStaff";
            cmdInsertStaff.CommandType = CommandType.StoredProcedure;
            //Set Adapter
            SqlDataAdapter daInsertStaff = new SqlDataAdapter(cmdInsertStaff);
            conn.Open();
            //Set params
            cmdInsertStaff.Parameters.AddWithValue("@StaffNumber",sStaffNumber);
            cmdInsertStaff.Parameters.AddWithValue("@StaffTitle",sTitle);
            cmdInsertStaff.Parameters.AddWithValue("@StaffLname",sLastName);
            cmdInsertStaff.Parameters.AddWithValue("@StaffFname",sFirstName);
            cmdInsertStaff.Parameters.AddWithValue("@StaffGender",sGender);
            cmdInsertStaff.Parameters.AddWithValue("@StaffDOB",dtDOB);
            cmdInsertStaff.Parameters.AddWithValue("@StaffStartDate",dtStartDate);
            cmdInsertStaff.Parameters.AddWithValue("@StaffSupervisor",iSupervisor);
            cmdInsertStaff.Parameters.AddWithValue("@StaffClassId",iClassId);
            cmdInsertStaff.Parameters.AddWithValue("@BranchId",iBranchId);
            SqlParameter NewStaffId = new SqlParameter("@NewStaffId", SqlDbType.Int);
            NewStaffId.Direction = ParameterDirection.Output;
            cmdInsertStaff.Parameters.Add(NewStaffId);

            int iReturnValue = cmdInsertStaff.ExecuteNonQuery();
            UserMessage(iReturnValue, "Staff member insert ");
            conn.Close();
            return (int)NewStaffId.Value;
        }

        private void GetConnectionstring()
        {
            conn.ConnectionString = @"Data Source=csi.ufs.ac.za; Initial Catalog=RIS314_HoffmannRW; Integrated Security=false; User Id=HoffmannRW; Password=rw8707075103087h;";
        }

        private void GetData()
        {
            //Set command and adapter
            SqlCommand cmdStaff = new SqlCommand();
            cmdStaff.Connection = conn;
            cmdStaff.CommandText = "select * from STAFF";
            daStaff = new SqlDataAdapter(cmdStaff);
            

            try 
            {
                conn.Open();
                dsStaff = new DataSet();
                daStaff.Fill(dsStaff, "STAFF");
                bsStaff.DataSource = dsStaff.Tables["STAFF"];
                bnStaff.BindingSource = bsStaff;
                //Bind controls
                lblStaffId.DataBindings.Add(new Binding("Text",bsStaff,"StaffId"));
                txtStaffNumber.DataBindings.Add(new Binding("Text",bsStaff,"StaffNumber"));
                txtStaffTitle.DataBindings.Add(new Binding("Text",bsStaff,"StaffTitle"));
                txtStaffLname.DataBindings.Add(new Binding("Text",bsStaff,"StaffLname"));
                txtStaffFirstName.DataBindings.Add(new Binding("Text", bsStaff,"StaffFname"));
                txtStaffGender.DataBindings.Add(new Binding("Text",bsStaff,"StaffGender"));
                dtpStaffDOB.DataBindings.Add(new Binding("Text",bsStaff,"StaffDOB"));
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

        private void btnNewStaffClass_Click(object sender, EventArgs e)
        {
            //Instantiate and show the form for adding staff classifications
            NationalRealtors.Manage.frmStaffClassification AddStaffClass = new Manage.frmStaffClassification();
            AddStaffClass.ShowDialog();
        }

        private void frmRegisterStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNationalRealtors.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.dsNationalRealtors.BRANCH);
            // TODO: This line of code loads data into the 'dsNationalRealtors.STAFF_CLASS' table. You can move, or remove it, as needed.
            this.sTAFF_CLASSTableAdapter.Fill(this.dsNationalRealtors.STAFF_CLASS);
            // TODO: This line of code loads data into the 'dsNationalRealtors.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.dsNationalRealtors.STAFF);
            GetConnectionstring();
            GetData();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            gpbxInsertUpdate.Enabled = true;
            dtpStaffDOB.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Get all values from textboxes and ddls
                int iSupervisor;
                int iClassId;
                int iBranchId;
                if (ddlSupervisorIU.SelectedValue == null)
                {
                    iSupervisor = 0;
                }
                else
                {
                    iSupervisor = int.Parse(ddlSupervisorIU.SelectedValue.ToString());
                }
                if (ddlPositionIU.SelectedValue == null)
                {
                    iClassId = 0;
                }
                else
                {
                    iClassId = int.Parse(ddlPositionIU.SelectedValue.ToString());
                }

                if (ddlBranchIU.SelectedValue == null)
                {
                    iBranchId = 0;
                }
                else
                {
                    iBranchId = int.Parse(ddlBranchIU.SelectedValue.ToString());
                }
                string sStaffNumber = txtStaffNumber.Text;
                string sTitle = txtStaffTitle.Text;
                string sLastName = txtStaffLname.Text;
                string sFirstName = txtStaffFirstName.Text;
                string sGender = txtStaffGender.Text;
                DateTime dtDOB = dtpStaffDOB.Value;
                DateTime dtStartDate = dtpStartDateIU.Value;
                //Insert new staff memmeber
                int iNewStaffId = InsertStaff(sStaffNumber, sTitle, sLastName, sFirstName, sGender, dtDOB, dtStartDate, iSupervisor, iClassId, iBranchId);
                lblStaffId.Text = iNewStaffId.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString().Replace(exc.ToString(),"Duplicate staff numbers are not allowed."),"Staff",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            finally 
            {
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Set the params
                int iStaffId = int.Parse(lblStaffId.Text);
                string sStaffNumber = txtStaffNumber.Text;
                string sTitle = txtStaffTitle.Text;
                string sLastName = txtStaffLname.Text;
                string sFirstName = txtStaffFirstName.Text;
                string sGender = txtStaffGender.Text;
                DateTime dtDOB = dtpStaffDOB.Value;
                DateTime dtStartDate = dtpStartDateIU.Value;
                int iStaffSupervisor = int.Parse(ddlSupervisorIU.SelectedValue.ToString());
                int iClassId = int.Parse(ddlPositionIU.SelectedValue.ToString());
                int iBranchId = int.Parse(ddlBranchIU.SelectedValue.ToString());
                //Update
                if (MessageBox.Show("Are you sure you want to save these changes?", "Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateStaff(iStaffId, sStaffNumber, sTitle, sLastName, sFirstName, sGender, dtDOB, dtStartDate, iStaffSupervisor, iClassId, iBranchId);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            finally 
            {
                btnUpdate.Enabled = false;
            }
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            gpbxInsertUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Set param
            int iStaffId = int.Parse(lblStaffId.Text);
            if (MessageBox.Show("Are you sure you want to delte this entry?", "Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DeleteStaff(iStaffId);
                        bsStaff.RemoveCurrent();
                    }
                    catch(Exception exc) 
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
