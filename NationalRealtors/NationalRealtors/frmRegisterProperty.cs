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
    public partial class frmRegisterProperty : Form
    {
        //Set form wide objects
        SqlConnection conn = new SqlConnection();
        DataSet dsOwner;
        public frmRegisterProperty()
        {
            InitializeComponent();
        }
        private void InsertBusiness(int iOwnerId,string sBusName,string sBusType, string sContactLname,string sContactFname)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertBusiness";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daInsertBus = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@OwnerId",iOwnerId);
                cmd.Parameters.AddWithValue("@BusinessName",sBusName);
                cmd.Parameters.AddWithValue("@BusinessType",sBusType);
                cmd.Parameters.AddWithValue("@BusContactLname",sContactLname);
                cmd.Parameters.AddWithValue("@BusContactFname",sContactFname);
                //Execution
                int iRetuenValue = cmd.ExecuteNonQuery();
                UserMessage(iRetuenValue, "Insert business");
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
        private void InsertIndividual(int iOwnerId,string sLastName,string sFirstName)
        { 
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertIndividual";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daInsetrIndividu = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@OwnerId",iOwnerId);
                cmd.Parameters.AddWithValue("@IndividLname",sLastName);
                cmd.Parameters.AddWithValue("@IndividFname",sFirstName);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue,"Insert individual");
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
        private void DeleteOwner(int iOwnerId)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DeleteOwner";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdateOwner = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set param
                cmd.Parameters.AddWithValue("@OwnerId",iOwnerId);
                //Execution
                int iReturnVlaue = cmd.ExecuteNonQuery();
                UserMessage(iReturnVlaue, "Delete");
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
        private void UserMessage(int iReturnValue, string sMsg)
        {
            if (iReturnValue < 0)
                MessageBox.Show(sMsg + " succesful");
            else
                MessageBox.Show(sMsg + " failed");
        }
        private void UpdateBusiness(int iOwnerId, string sBusinessName, string sBusinessType, string sContactLastName, string sContactFisrtName)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdateBusiness";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdateBisuness = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@OwnerId",iOwnerId);
                cmd.Parameters.AddWithValue("@BusName",sBusinessName);
                cmd.Parameters.AddWithValue("@BusType",sBusinessType);
                cmd.Parameters.AddWithValue("@BusContactLname",sContactLastName);
                cmd.Parameters.AddWithValue("@BusContactFname",sContactFisrtName);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue,"Update business");
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
        private void UpdateIndividual(int iOwnerId,string sIndividualLname,string sIndividualFname)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdateIndividual";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdateIndividual = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@OwnerId",iOwnerId);
                cmd.Parameters.AddWithValue("@IndividualLname",sIndividualLname);
                cmd.Parameters.AddWithValue("@IndividualFname",sIndividualFname);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue,"Update individual");
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
        private void UpdateOwner(int iOwnerId,string sOwnerNumber,string sStreet,string sCity,string sPostCode,string sOwnerType)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdateOwner";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdateOwner = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@OwnerId",iOwnerId);
                cmd.Parameters.AddWithValue("@OwnerNumber",sOwnerNumber);
                cmd.Parameters.AddWithValue("@OwnerStreet",sStreet);
                cmd.Parameters.AddWithValue("@OwnerCity",sCity);
                cmd.Parameters.AddWithValue("@OwnerPostCode",sPostCode);
                cmd.Parameters.AddWithValue("@OwnerType",sOwnerType);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue, "Update");
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
        private int InsertOwner(string sOwnerNumber, string sStreet, string sCity, string sPostCode, string sOwnerType)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertOwner";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daInsertOwner = new SqlDataAdapter(cmd);
            conn.Open();
            //Set params
            cmd.Parameters.AddWithValue("@OwnerNumber",sOwnerNumber);
            cmd.Parameters.AddWithValue("@OwnerStreet",sStreet);
            cmd.Parameters.AddWithValue("@OwnerCity",sCity);
            cmd.Parameters.AddWithValue("@OwnerPostCode",sPostCode);
            cmd.Parameters.AddWithValue("@OwnerType",sOwnerType);
            SqlParameter NewOwnerId = new SqlParameter("@NewOwnerId",SqlDbType.Int);
            NewOwnerId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(NewOwnerId);
            //Execution
            int iReturnValue = cmd.ExecuteNonQuery();
            UserMessage(iReturnValue, "Insert");
            return (int)NewOwnerId.Value;
        }
        private void GetData()
        {
            //Set commands and adapters
            SqlCommand cmdOwner = new SqlCommand();
            cmdOwner.Connection = conn;
            cmdOwner.CommandText = "select * from [OWNER]";
            SqlDataAdapter daOwner = new SqlDataAdapter(cmdOwner);
            BindingSource bsOwner = new BindingSource();

            SqlCommand cmdOwnerTel = new SqlCommand();
            cmdOwnerTel.Connection = conn;
            cmdOwnerTel.CommandText = "select * from OWNER_TEL_NUM";
            SqlDataAdapter daOwnerTelNum = new SqlDataAdapter(cmdOwnerTel);
            BindingSource bsOwnerTel = new BindingSource();

            SqlCommand cmdIndividual = new SqlCommand();
            cmdIndividual.Connection = conn;
            cmdIndividual.CommandText = "select * from INDIVIDUAL";
            SqlDataAdapter daIndividu = new SqlDataAdapter(cmdIndividual);
            BindingSource bsIndividu = new BindingSource();

            SqlCommand cmdBusiness = new SqlCommand();
            cmdBusiness.Connection = conn;
            cmdBusiness.CommandText = "select * from BUSINESS";
            SqlDataAdapter daBusiness = new SqlDataAdapter(cmdBusiness);
            BindingSource bsBusiness = new BindingSource();
            try 
            {
                conn.Open();
                //Fill datasets
                dsOwner = new DataSet();
                daOwner.Fill(dsOwner, "OWNER");
                daOwnerTelNum.Fill(dsOwner, "OWNER_TEL_NUM");
                daIndividu.Fill(dsOwner, "INDIVIDUAL");
                daBusiness.Fill(dsOwner, "BUSINESS");
                //Data relations
                DataRelation drOwnerOwnerTel = new DataRelation("OwnerTelId", dsOwner.Tables["OWNER"].Columns["OwnerId"],
                                                                dsOwner.Tables["OWNER_TEL_NUM"].Columns["OwnerId"]);
                DataRelation drOwnerIndividual = new DataRelation("IndividLname", dsOwner.Tables["OWNER"].Columns["OwnerId"], 
                                                                dsOwner.Tables["INDIVIDUAL"].Columns["OwnerId"]);
                DataRelation drOwnerBusiness = new DataRelation("BusinessName", dsOwner.Tables["OWNER"].Columns["OwnerId"],
                                                                dsOwner.Tables["BUSINESS"].Columns["OwnerId"]);
                //Add relations
                dsOwner.Relations.Add(drOwnerOwnerTel);
                dsOwner.Relations.Add(drOwnerIndividual);
                dsOwner.Relations.Add(drOwnerBusiness);
                //Binding sources
                bsOwner.DataSource = dsOwner.Tables["OWNER"];
                bsOwnerTel.DataSource = bsOwner;
                bsOwnerTel.DataMember = "OwnerTelId";
                bsIndividu.DataSource = bsOwner;
                bsIndividu.DataMember = "IndividLname";
                bsBusiness.DataSource = bsOwner;
                bsBusiness.DataMember = "BusinessName";
                //Binding navigator
                bnOwner.BindingSource = bsOwner;
                //Bind controls
                lblOwnerId.DataBindings.Add(new Binding("Text", bsOwner,"OwnerId"));
                txtOwnerNumber.DataBindings.Add(new Binding("Text",bsOwner,"OwnerNumber"));
                txtOwnerStreet.DataBindings.Add(new Binding("Text",bsOwner,"OwnerStreet"));
                txtOwnerCity.DataBindings.Add(new Binding("Text",bsOwner,"OwnerCity"));
                txtOwnerPostCode.DataBindings.Add(new Binding("Text",bsOwner,"OwnerPostCode"));
                //Set the gridview
                dgvOwnerTelNum.AutoGenerateColumns = false;
                dgvOwnerTelNum.DataSource = bsOwnerTel;
                dgvOwnerTelNum.Columns["AreaCode"].DataPropertyName = "OwnerAreaCode";
                dgvOwnerTelNum.Columns["Number"].DataPropertyName = "OwnerTelNum";
                //Set controls pertaining to an individual
                txtIndividualLastName.DataBindings.Add(new Binding("Text",bsIndividu,"IndividLname"));
                txtIndividualFirstName.DataBindings.Add(new Binding("Text",bsIndividu,"IndividFname"));
                //Set controls pertaininf to an business
                txtBusinessType.DataBindings.Add(new Binding("Text",bsBusiness,"BusinessType"));
                txtBusinessName.DataBindings.Add(new Binding("Text",bsBusiness,"BusinessName"));
                txtContactFirstName.DataBindings.Add(new Binding("Text",bsBusiness,"BusContactFname"));
                txtContactLastName.DataBindings.Add(new Binding("Text",bsBusiness,"BusContactLname"));
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
        private void btnTelephoneNumbers_Click(object sender, EventArgs e)
        {
            //Instantiate and show form for additional telephone numbers
            frmOwnerTelNum NewOwnerNum = new frmOwnerTelNum();
            NewOwnerNum.ShowDialog();
        }

        private void btnManagePropertyTypes_Click(object sender, EventArgs e)
        {
            //Instantiate and sho form for managing property types
            frmManagePropertyTypes NewPropType = new frmManagePropertyTypes();
            NewPropType.ShowDialog();
        }

        private void frmRegisterProperty_Load(object sender, EventArgs e)
        {
            GetConnectionString();
            GetData();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //Set controls
            btnSaveOwner.Enabled = true;
        }

        private void ddlOwnerType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ddlOwnerType.SelectedItem.ToString() == "Individual")
            {
                grpbxIndividual.Enabled = true;
                if (grpbxBusiness.Enabled)
                {
                    grpbxBusiness.Enabled = false;
                }
            }
            if (ddlOwnerType.SelectedItem.ToString() == "Business")
            {
                grpbxBusiness.Enabled = true;
                if (grpbxIndividual.Enabled)
                {
                    grpbxIndividual.Enabled = false;
                }
            }
        }

        private void btnPropertyDetails_Click(object sender, EventArgs e)
        {
            //Show property details form
            frmPropertyDetails NewPropDetails = new frmPropertyDetails();
            NewPropDetails.ShowDialog();
        }

        private void btnSaveOwner_Click(object sender, EventArgs e)
        {
            //Set params
            string sOwnerNumber = txtOwnerNumber.Text;
            string sStreet = txtOwnerStreet.Text;
            string sCity = txtOwnerCity.Text;
            string sPostCode = txtOwnerPostCode.Text;
            string sOwnerType = ddlOwnerType.SelectedItem.ToString();
            //Individual
            string sLastName = txtIndividualLastName.Text;
            string sFirstName = txtIndividualFirstName.Text;
            //Business
            string sBusinessType = txtBusinessType.Text;
            string sBusName = txtBusinessName.Text;
            string sContactLname = txtContactLastName.Text;
            string sContactFname = txtContactFirstName.Text;
            try 
            {

                if (ddlOwnerType.SelectedItem.ToString() == "Individual")
                {
                    sOwnerType = "I";
                    int iNewOwnerId = InsertOwner(sOwnerNumber, sStreet, sCity, sPostCode, sOwnerType);
                    lblOwnerId.Text = iNewOwnerId.ToString();
                    conn.Close();
                    InsertIndividual(iNewOwnerId, sLastName, sFirstName);
                }
                else 
                {
                    sOwnerType = "B";
                    int iNewOwnerId = InsertOwner(sOwnerNumber, sStreet, sCity, sPostCode, sOwnerType);
                    lblOwnerId.Text = iNewOwnerId.ToString();
                    conn.Close();
                    InsertBusiness(iNewOwnerId, sBusName, sBusinessType, sContactLname, sContactFname);
                }
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

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            //Set param
            int iOwnerId = int.Parse(lblOwnerId.Text);
            if (MessageBox.Show("Are you sure you want to delete this entry?", "Owners", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteOwner(iOwnerId);
                bnOwner.BindingSource.RemoveCurrent();
            }
        }

        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            //Set params
            int iOwnerId = int.Parse(lblOwnerId.Text);
            string sOwnerNumber = txtOwnerNumber.Text;
            string sStreet = txtOwnerStreet.Text;
            string sCity = txtOwnerCity.Text;
            string sPostCode = txtOwnerPostCode.Text;
            string sOwnerType = ddlOwnerType.SelectedItem.ToString();
            //Individual
            string sLastName = txtIndividualLastName.Text;
            string sFirstName = txtIndividualFirstName.Text;
            //Business
            string sBusinessType = txtBusinessType.Text;
            string sBusName = txtBusinessName.Text;
            string sContactLname = txtContactLastName.Text;
            string sContactFname = txtContactFirstName.Text;
            //Update
            if (ddlOwnerType.SelectedItem.ToString() == "Individual")
            {
                sOwnerType = "I";
                if (MessageBox.Show("Are you sure you want to save the change(s)?", "Owners", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateOwner(iOwnerId, sOwnerNumber, sStreet, sCity, sPostCode, sOwnerType);
                    UpdateIndividual(iOwnerId, sLastName, sFirstName);
                }
            }
            else
            {
                sOwnerType = "B";
                if (MessageBox.Show("Are you sure you want to save the change(s)?", "Owners", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateOwner(iOwnerId, sOwnerNumber, sStreet, sCity, sPostCode, sOwnerType);
                    UpdateBusiness(iOwnerId, sBusName, sBusinessType, sContactLname, sContactFname);
                }
            }
        }
    }
}
