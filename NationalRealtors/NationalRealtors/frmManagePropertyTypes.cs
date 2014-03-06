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
    public partial class frmManagePropertyTypes : Form
    {
        //Set form wide objects
        SqlConnection conn = new SqlConnection();
        DataSet dsPropType = null;
        SqlDataAdapter daPropType = null;
        BindingSource bsPropType = new BindingSource();
        public frmManagePropertyTypes()
        {
            InitializeComponent();
        }
        private void DeletePropertyType(int iPropertyTypeId)
        {
            //Set the command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DeletePropertyType";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdatePropType = new SqlDataAdapter();
            try 
            {
                conn.Open();
                //Set param
                cmd.Parameters.AddWithValue("@PropTypeId",iPropertyTypeId);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                if (iReturnValue < 0)
                    MessageBox.Show("Delete successful");
                else
                    MessageBox.Show("Delete failed");
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
        private void UpdatePropertyType(int iPropTypeId, string sPropType)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdatePropertyType";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdatePropType = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@PropTypeId",iPropTypeId);
                cmd.Parameters.AddWithValue("@PropertyType",sPropType);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                if (iReturnValue < 0)
                    MessageBox.Show("Update successful");
                else
                    MessageBox.Show("Update failed");
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
        private int InsertPropType(string sPropertyType)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertPropertyType";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set the adapter
            SqlDataAdapter daInsertPropType = new SqlDataAdapter(cmd);
            conn.Open();
            //Set param(s)
            cmd.Parameters.AddWithValue("@PropType",sPropertyType);
            SqlParameter NewPropTypeId = new SqlParameter("@NewPropTypeId",SqlDbType.Int);
            NewPropTypeId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(NewPropTypeId);
            //Execution
            int iReturnValue = cmd.ExecuteNonQuery();
            if(iReturnValue<0)
                MessageBox.Show("Insert successful");
            else
                MessageBox.Show("Insert failed");
            conn.Close();
            return (int)NewPropTypeId.Value;
        }
        private void GetData()
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from PROPERTY_TYPE";
            //Set the adapter
            daPropType = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                dsPropType = new DataSet();
                daPropType.Fill(dsPropType,"PROPERTY_TYPE");
                //Binding source
                bsPropType.DataSource = dsPropType.Tables["PROPERTY_TYPE"];
                //Binding navigator
                bnPropertyType.BindingSource = bsPropType;
                //Bind controls
                lblPropTypeId.DataBindings.Add(new Binding("Text",bsPropType,"PropTypeId"));
                txtPropType.DataBindings.Add(new Binding("Text", bsPropType, "PropertyType"));
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
        private void frmManagePropertyTypes_Load(object sender, EventArgs e)
        {
            GetConnectionString();
            GetData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Set params
            int iPropTypeId = int.Parse(lblPropTypeId.Text);
            string sPropType = txtPropType.Text;
            //Update Proptype
            if (MessageBox.Show("Are you sure you want to save the change(s)?", "Property Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdatePropertyType(iPropTypeId, sPropType);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //Set controls
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Set param
            string sPropertyType = txtPropType.Text;
            try
            {
                //Insert property type
                int iNewPropTypeId = InsertPropType(sPropertyType);
                lblPropTypeId.Text = iNewPropTypeId.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            finally 
            {
                conn.Close();//Just making 100% sur the connection closes
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Set params
            int iPropTypeId = int.Parse(lblPropTypeId.Text);
            if (MessageBox.Show("Are you sure you want to delete this entry?", "Property Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeletePropertyType(iPropTypeId);
                bsPropType.RemoveCurrent();
            }
        }
    }
}
