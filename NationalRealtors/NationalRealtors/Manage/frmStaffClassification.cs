using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NationalRealtors.Manage
{
    public partial class frmStaffClassification : Form
    {
        //Set form wide objects
        SqlConnection conn = new SqlConnection();
        DataSet dsStaffClassification;
        SqlDataAdapter daStaffClassification;
        BindingSource bsStaffClassification = new BindingSource();
        public frmStaffClassification()
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
        private void DeleteClassification(int iStaffClassId)
        {
            //Set the command
            SqlCommand cmdDeleteClass = new SqlCommand();
            cmdDeleteClass.Connection = conn;
            cmdDeleteClass.CommandText = "DeleteStaffClass";
            cmdDeleteClass.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daDeleteClass = new SqlDataAdapter(cmdDeleteClass);
            try 
            {
                conn.Open();
                //Set the param
                cmdDeleteClass.Parameters.AddWithValue("@StaffClassId",iStaffClassId);
                //Execution
                int iReturnValue = cmdDeleteClass.ExecuteNonQuery();
                UserMessage(iReturnValue, "Classification delete ");
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
        private void UpdateClassification(int iClassId, string sPosition, decimal dSalary, decimal dBonus)
        {
            //Set the command
            SqlCommand cmdUpdateClass = new SqlCommand();
            cmdUpdateClass.Connection = conn;
            cmdUpdateClass.CommandText = "UpdateStaffClass";
            cmdUpdateClass.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdateClass = new SqlDataAdapter(cmdUpdateClass);
            try 
            {
                conn.Open();
                //Set the params
                cmdUpdateClass.Parameters.AddWithValue("@StaffClassID",iClassId);
                cmdUpdateClass.Parameters.AddWithValue("@Staffposition",sPosition);
                cmdUpdateClass.Parameters.AddWithValue("@StaffSalary",dSalary);
                cmdUpdateClass.Parameters.AddWithValue("@StaffBonus",dBonus);
                //Execution
                int iReturnValue = cmdUpdateClass.ExecuteNonQuery();
                UserMessage(iReturnValue, "Classification update ");
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
        private int InsertClassification(string sPosition,decimal dSalary,decimal dBonus)
        {
            //Set the command
            SqlCommand cmdInsertClass = new SqlCommand();
            cmdInsertClass.Connection = conn;
            cmdInsertClass.CommandText = "InsertStaffClass";
            cmdInsertClass.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daInsertClass = new SqlDataAdapter(cmdInsertClass);
            conn.Open();
            //Set params
            cmdInsertClass.Parameters.AddWithValue("@StaffPosition",sPosition);
            cmdInsertClass.Parameters.AddWithValue("@StaffSalary",dSalary);
            cmdInsertClass.Parameters.AddWithValue("@StaffBonus",dBonus);
            SqlParameter NewClassId = new SqlParameter("@NewStaffClassId", SqlDbType.Int);
            NewClassId.Direction = ParameterDirection.Output;
            cmdInsertClass.Parameters.Add(NewClassId);
            //Execution
            int iReturnValue = cmdInsertClass.ExecuteNonQuery();
            UserMessage(iReturnValue, "Classification insert ");
            conn.Close();

            return (int)NewClassId.Value;
        }
        private void GetConnectionstring()
        {
            conn.ConnectionString = @"Data Source=csi.ufs.ac.za; Initial Catalog=RIS314_HoffmannRW; Integrated Security=false; User Id=HoffmannRW; Password=rw8707075103087h;";
        }
        private void GetData()
        {
            //Set command and adapter
            SqlCommand cmdStaffClass = new SqlCommand();
            cmdStaffClass.Connection = conn;
            cmdStaffClass.CommandText = "select * from STAFF_CLASS";
            daStaffClassification = new SqlDataAdapter(cmdStaffClass);
            try 
            {
                conn.Open();
                dsStaffClassification = new DataSet();
                daStaffClassification.Fill(dsStaffClassification,"STAFF_CLASS");
                bsStaffClassification.DataSource = dsStaffClassification.Tables["STAFF_CLASS"];
                bnStaffClass.BindingSource = bsStaffClassification;
                //Bind controls
                lblStaffClassId.DataBindings.Add(new Binding("Text",bsStaffClassification,"StaffClassId"));
                txtStaffPosition.DataBindings.Add(new Binding("Text",bsStaffClassification,"StaffPosition"));
                txtStaffSalary.DataBindings.Add(new Binding("Text", bsStaffClassification, "StaffSalary"));
                txtStaffBonus.DataBindings.Add(new Binding("Text",bsStaffClassification,"StaffBonus"));
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
        private void frmStaffClassification_Load(object sender, EventArgs e)
        {
            GetConnectionstring();
            GetData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sPosition = txtStaffPosition.Text;
                decimal dSalary = Convert.ToDecimal(txtStaffSalary.Text);
                decimal dBonus = Convert.ToDecimal(txtStaffBonus.Text);
                //Insert Class
                int iNewClassId = InsertClassification(sPosition, dSalary, dBonus);
                lblStaffClassId.Text = iNewClassId.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString().Replace(exc.ToString(),"Please make sure you entered all the data."),
                                "Classifications",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int iStaffClassId = int.Parse(lblStaffClassId.Text);
                string sPosition = txtStaffPosition.Text;
                decimal dSalary = Convert.ToDecimal(txtStaffSalary.Text);
                decimal dBonus = Convert.ToDecimal(txtStaffBonus.Text);
                //Update Class
                if (MessageBox.Show("Are you sure you want to save the changes?", "Classification",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    UpdateClassification(iStaffClassId, sPosition, dSalary, dBonus);
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.ToString().Replace(exc.ToString(), "Please make sure you entered all the data."),
                                "Classifications", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int iStaffClassId = int.Parse(lblStaffClassId.Text);
                if (MessageBox.Show("Are you sure you want to delete this entry?", "Classification",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    DeleteClassification(iStaffClassId);
                bsStaffClassification.RemoveCurrent();
            }catch(Exception exc)
            {
                MessageBox.Show(exc.ToString().Replace(exc.ToString(), "Please make sure you delete a valid entry."),
                                "Classifications",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
