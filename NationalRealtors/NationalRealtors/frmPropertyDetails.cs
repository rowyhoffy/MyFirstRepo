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
    public partial class frmPropertyDetails : Form
    {
        //Set form wide objects
        SqlConnection conn = new SqlConnection();
        DataSet dsPropertyDetails;
        string sPreviousPFR = "";
        string sPreviousPOV = "";
        public frmPropertyDetails()
        {
            InitializeComponent();
        }
        private void UpdatePropertySetPFRPOV(int iPropetyId, string sPropertyForRent, string sPropertyOnView)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdatePropertySetPFRPOV";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@PropertyId",iPropetyId);
                cmd.Parameters.AddWithValue("@PropertyForRent",sPropertyForRent);
                cmd.Parameters.AddWithValue("@PropertyOnView",sPropertyOnView);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
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
        private void DeleteProperty(int iPropertyId)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DeleteProperty";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daDeleteProperty = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set param
                cmd.Parameters.AddWithValue("@PropertyId",iPropertyId);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue,"Property deleted: ");
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
        private void DeletePropertyOnView(int iPropertyId)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DeletePropOnView";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daDeletePropOnView = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set param
                cmd.Parameters.AddWithValue("@PropertyId",iPropertyId);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue, "Delete property on view");
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
        private void DeletePropForRent(int iPropertyId)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DeletePropertyForRent";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daDeletePFR = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set param
                cmd.Parameters.AddWithValue("@PropertyId",iPropertyId);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue, "Delete property for rent");
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
        private void UpdatePropertyMovePOV2PFR(int iPropertyId, DateTime dtAvailableDate)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdatePropertyMovePOV2PFR";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daMoveProperties = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@PropertyId",iPropertyId);
                cmd.Parameters.AddWithValue("@AvailableDate",dtAvailableDate);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue,"Property move");
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
        private void UpdatePropertyMovePFR2POV(int iPropertyId, string sComments)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdatePropertyMovePFR2POV";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daMoveProperties = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@PropertyId",iPropertyId);
                cmd.Parameters.AddWithValue("@Comments",sComments);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue, "Property move");
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
        private void UpdatePropOnView(int iPropertyId, string sComments)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdatePropertyOnView";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdatePropOnView = new SqlDataAdapter(cmd);
            try
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@PropertyId", iPropertyId);
                cmd.Parameters.AddWithValue("@PropertyComments", sComments);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue, "Update property on view");
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
        private void UpdatePropForRent(int iPropertyId, DateTime dtDateAvailable)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdatePropertyForRent";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdatePropForRent = new SqlDataAdapter(cmd);
            try
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@PropertyId", iPropertyId);
                cmd.Parameters.AddWithValue("@PropertyAvailableDate", dtDateAvailable);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue, "Update property for rent");
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
        private void UpdateProperty(int IPropertyId, string sPropNum, string sStreet, string sCity, string sPostCode, decimal dPropRent, string sRooms, DateTime dtDateListed, int iStaffId, int iPropTypeId, int iOwnerId, string sPropForRent, string sPropOnView)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdateProperty";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daUpdateProp = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set other params
                cmd.Parameters.AddWithValue("@PropertyId",IPropertyId);
                cmd.Parameters.AddWithValue("@PropertyNumber", sPropNum);
                cmd.Parameters.AddWithValue("@PropertyStreet", sStreet);
                cmd.Parameters.AddWithValue("@PropertyCity", sCity);
                cmd.Parameters.AddWithValue("@PropertyPostCode", sPostCode);
                cmd.Parameters.AddWithValue("@PropertyRent", dPropRent);
                cmd.Parameters.AddWithValue("@PropertyRooms", sRooms);
                cmd.Parameters.AddWithValue("@PropertyDateListed", dtDateListed);
                cmd.Parameters.AddWithValue("@StaffId", iStaffId);
                cmd.Parameters.AddWithValue("@PropTypeId", iPropTypeId);
                cmd.Parameters.AddWithValue("@OwnerId", iOwnerId);
                cmd.Parameters.AddWithValue("@PropertyForRent", sPropForRent);
                cmd.Parameters.AddWithValue("@PropertyOnview", sPropOnView);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue, "Update");
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
        private void UserMessage(int iReturnValue,string sMsg)
        {
            if (iReturnValue < 0)
                MessageBox.Show(sMsg + " successful");
            else
                MessageBox.Show(sMsg + " failed");
        }
        private void InsertPropOnview(int iPropertyId, string sComments)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertPropOnView";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daInsertProOnView = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@PropertyId",iPropertyId);
                cmd.Parameters.AddWithValue("@PropertyComments",sComments);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue,"Insert property on view");
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
        private void InsertPropForRent(int iPropertyId, DateTime dtDateAvailable)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertPropForRent";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daInsertPropForRent = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@PropertyId",iPropertyId);
                cmd.Parameters.AddWithValue("@DateAvailable",dtDateAvailable);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue, "Insert property for rent");
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
        private int InsertProperty(string sPropNum,string sStreet,string sCity,string sPostCode,decimal dPropRent,string sRooms,DateTime dtDateListed,int iStaffId,int iPropTypeId,int iOwnerId,string sPropForRent,string sPropOnView)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertProperty";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daInsertProp = new SqlDataAdapter(cmd);
            SqlParameter NewPropertyId = new SqlParameter("@NewPropId",SqlDbType.Int);
            NewPropertyId.Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                //Set other params
                cmd.Parameters.AddWithValue("@PropertyNumber",sPropNum);
                cmd.Parameters.AddWithValue("@Propertystreet",sStreet);
                cmd.Parameters.AddWithValue("@PropertyCity",sCity);
                cmd.Parameters.AddWithValue("@PropertyPostCode",sPostCode);
                cmd.Parameters.AddWithValue("@Propertyrent",dPropRent);
                cmd.Parameters.AddWithValue("@PropertyRooms",sRooms);
                cmd.Parameters.AddWithValue("@PropertyDateList",dtDateListed);
                cmd.Parameters.AddWithValue("@StaffId",iStaffId);
                cmd.Parameters.AddWithValue("@PropTypeId",iPropTypeId);
                cmd.Parameters.AddWithValue("@OwnerId",iOwnerId);
                cmd.Parameters.AddWithValue("@PropForRent",sPropForRent);
                cmd.Parameters.AddWithValue("@PropOnview",sPropOnView);
                cmd.Parameters.Add(NewPropertyId);
                //Execution
                int iReturnValue = cmd.ExecuteNonQuery();
                UserMessage(iReturnValue,"Insert");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            finally
            {
                conn.Close();
            }
            if (NewPropertyId.Value == DBNull.Value)
                return 0;
            else
                return (int)NewPropertyId.Value;
        }
        private void GetConnectionString()
        {
            conn.ConnectionString = @"Data Source=csi.ufs.ac.za; Initial Catalog=RIS314_HoffmannRW; Integrated Security=false; User Id=HoffmannRW; Password=rw8707075103087h;";
        }
        private void GetData()
        {
            //Set the command--Property
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from PROPERTY";
            //Set adapter
            SqlDataAdapter daPropertyDetails = new SqlDataAdapter(cmd);
            BindingSource bsPropertyDetails = new BindingSource();

            //Set command -- PropertyForRent
            SqlCommand cmdPFR = new SqlCommand();
            cmdPFR.Connection = conn;
            cmdPFR.CommandText = "select * from PROPERTY_FOR_RENT";
            //Set adapater
            SqlDataAdapter daPFR = new SqlDataAdapter(cmdPFR);
            BindingSource bsPFR = new BindingSource();

            //Set command -- PropertOnView
            SqlCommand cmdPOV = new SqlCommand();
            cmdPOV.Connection = conn;
            cmdPOV.CommandText = "select * from PROPERTY_ON_VIEW";
            //Set adapter
            SqlDataAdapter daPOV = new SqlDataAdapter(cmdPOV);
            BindingSource bsPOV = new BindingSource();
            try 
            {
                conn.Open();
                dsPropertyDetails = new DataSet();
                daPropertyDetails.Fill(dsPropertyDetails, "PROPERTY");
                daPFR.Fill(dsPropertyDetails, "PROPERTY_FOR_RENT");
                daPOV.Fill(dsPropertyDetails,"PROPERTY_ON_VIEW");

                //Data realtions
                DataRelation drPropRent = new DataRelation("PropRent", dsPropertyDetails.Tables["PROPERTY"].Columns["PropertyId"],
                                                            dsPropertyDetails.Tables["PROPERTY_FOR_RENT"].Columns["PropertyId"]);
                DataRelation drPropView = new DataRelation("PropView", dsPropertyDetails.Tables["PROPERTY"].Columns["PropertyId"],
                                                            dsPropertyDetails.Tables["PROPERTY_ON_VIEW"].Columns["PropertyId"]);
                dsPropertyDetails.Relations.Add(drPropRent);
                dsPropertyDetails.Relations.Add(drPropView);
                //Binding sources
                bsPropertyDetails.DataSource = dsPropertyDetails.Tables["PROPERTY"];
                bsPFR.DataSource = bsPropertyDetails;
                bsPFR.DataMember = "PropRent";
                bsPOV.DataSource = bsPropertyDetails;
                bsPOV.DataMember = "PropView";
                //Binding navigator
                bnNavigatorProperty.BindingSource = bsPropertyDetails;
                //Bind controls
                lblDateListed.DataBindings.Add(new Binding("Text", bsPropertyDetails, "PropertyDateListed"));
                lblPropertyId.DataBindings.Add(new Binding("Text", bsPropertyDetails, "PropertyId"));
                txtPropertyNumber.DataBindings.Add(new Binding("Text",bsPropertyDetails,"PropertyNumber"));
                txtStreet.DataBindings.Add(new Binding("Text",bsPropertyDetails,"PropertyStreet"));
                txtCity.DataBindings.Add(new Binding("Text", bsPropertyDetails, "PropertyCity"));
                txtPostCode.DataBindings.Add(new Binding("Text",bsPropertyDetails,"PropertyPostCode"));
                txtRent.DataBindings.Add(new Binding("Text",bsPropertyDetails,"PropertyRent"));
                txtRooms.DataBindings.Add(new Binding("Text", bsPropertyDetails, "PropertyRooms"));
                ddlPropForRent.DataBindings.Add(new Binding("Text",bsPropertyDetails,"PropertyForRent"));
                ddlPropOnView.DataBindings.Add(new Binding("Text", bsPropertyDetails, "PropertyOnView"));
                //PFR
                dtpDateAvailable.DataBindings.Add(new Binding("Text",bsPFR,"PropertyAvailableDate"));
                //POV
                txtComments.DataBindings.Add(new Binding("Text",bsPOV,"PropertyComments"));
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
                ddlOwnedBy.DataSource = bsGetOwner;
                ddlOwnedBy.DisplayMember = "OwnerLname";
                ddlOwnedBy.ValueMember = "OwnerId";
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
        private void UserErrorMessage(int iReturnValue)
        {
            if (iReturnValue == 0)
                MessageBox.Show("Could not insert this entry");
            this.Close();
        }
        private void GetValuesOfDDLs()
        {
            //Get status of ddls PFR and POV
            sPreviousPFR = ddlPropForRent.SelectedItem.ToString();
            sPreviousPOV = ddlPropOnView.SelectedItem.ToString();
        }
        private void frmPropertyDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNationalRealtors.PROPERTY_TYPE' table. You can move, or remove it, as needed.
            this.pROPERTY_TYPETableAdapter.Fill(this.dsNationalRealtors.PROPERTY_TYPE);
            // TODO: This line of code loads data into the 'dsNationalRealtors.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.dsNationalRealtors.STAFF);
            GetConnectionString();
            GetData();
            GetOwners();
            GetValuesOfDDLs();
        }

        private void btnSaveProperty_Click(object sender, EventArgs e)
        {
            try
            {
                //Set params
                string sPropNum = txtPropertyNumber.Text;
                string sStreet = txtStreet.Text;
                string sCity = txtCity.Text;
                string sPostCode = txtPostCode.Text;
                decimal dPropRent = Convert.ToDecimal(txtRent.Text);
                string sRooms = txtRooms.Text;
                DateTime dtDateListed = DateTime.Now;
                DateTime dtDateAvailable = dtpDateAvailable.Value;
                int iStaffId = int.Parse(ddlManagedBy.SelectedValue.ToString());
                int iPropTypeId = int.Parse(ddlPropType.SelectedValue.ToString());
                int iOwnerId = int.Parse(ddlOwnedBy.SelectedValue.ToString());
                string sPropForRent = ddlPropForRent.SelectedItem.ToString();
                string sPropOnView = ddlPropOnView.SelectedItem.ToString();
                string sComments = "";

                if ((sPropForRent == "Y") && (sPropOnView == "Y"))
                {
                    int iNewPropertyId = InsertProperty(sPropNum, sStreet, sCity, sPostCode, dPropRent, sRooms,
                                                        dtDateListed, iStaffId, iPropTypeId, iOwnerId, sPropForRent, sPropOnView);
                    if (iNewPropertyId == 0)
                    {
                        UserErrorMessage(iNewPropertyId);
                    }
                    else
                    {
                        InsertPropForRent(iNewPropertyId, dtDateAvailable);
                        InsertPropOnview(iNewPropertyId, sComments);
                        lblPropertyId.Text = iNewPropertyId.ToString();
                    }
                }
                if ((sPropForRent == "N") && (sPropOnView == "N"))
                {
                    int iNewPropertyId = InsertProperty(sPropNum, sStreet, sCity, sPostCode, dPropRent, sRooms,
                                                        dtDateListed, iStaffId, iPropTypeId, iOwnerId, sPropForRent, sPropOnView);
                    lblPropertyId.Text = iNewPropertyId.ToString();
                    if (iNewPropertyId == 0)
                    {
                        UserErrorMessage(iNewPropertyId);
                    }
                }
                if ((sPropForRent == "Y") && (sPropOnView == "N"))
                {
                    int iNewPropertyId = InsertProperty(sPropNum, sStreet, sCity, sPostCode, dPropRent, sRooms,
                                                        dtDateListed, iStaffId, iPropTypeId, iOwnerId, sPropForRent, sPropOnView);
                    if (iNewPropertyId == 0)
                    {
                        UserErrorMessage(iNewPropertyId);
                    }
                    else
                    {
                        InsertPropForRent(iNewPropertyId, dtDateAvailable);
                        lblPropertyId.Text = iNewPropertyId.ToString();
                    }
                }
                if ((sPropForRent == "N") && (sPropOnView == "Y"))
                {
                    int iNewPropertyId = InsertProperty(sPropNum, sStreet, sCity, sPostCode, dPropRent, sRooms,
                                                        dtDateListed, iStaffId, iPropTypeId, iOwnerId, sPropForRent, sPropOnView);
                    if (iNewPropertyId == 0)
                    {
                        UserErrorMessage(iNewPropertyId);
                    }
                    else
                    {
                        InsertPropOnview(iNewPropertyId, sComments);
                        lblPropertyId.Text = iNewPropertyId.ToString();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void ddlOwnedBy_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["OwnerLname"] + " , " + r["OwnerFname"];
        }

        private void ddlManagedBy_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["StaffNumber"] + " , " + r["StaffLname"] + " , " + r["StaffFname"];
        }

        private void btnUpdateProperty_Click(object sender, EventArgs e)
        {
            try
            {
                //Set params
                int iPropertId = int.Parse(lblPropertyId.Text);
                string sPropNum = txtPropertyNumber.Text;
                string sStreet = txtStreet.Text;
                string sCity = txtCity.Text;
                string sPostCode = txtPostCode.Text;
                decimal dPropRent = Convert.ToDecimal(txtRent.Text);
                string sRooms = txtRooms.Text;
                DateTime dtDateListed = Convert.ToDateTime(lblDateListed.Text);
                DateTime dtDateAvailable = dtpDateAvailable.Value;
                int iStaffId = int.Parse(ddlManagedBy.SelectedValue.ToString());
                int iPropTypeId = int.Parse(ddlPropType.SelectedValue.ToString());
                int iOwnerId = int.Parse(ddlOwnedBy.SelectedValue.ToString());
                string sPropForRent = ddlPropForRent.SelectedItem.ToString();
                string sPropOnView = ddlPropOnView.SelectedItem.ToString();
                string sComments = DBNull.Value.ToString();

                if ((sPreviousPFR != sPropForRent) || (sPreviousPOV != sPropOnView))
                {
                    if ((sPropForRent == "Y") && (sPropOnView == "Y"))
                    {
                        //Update all
                        if (MessageBox.Show("Are you sure you want to save the change(s)?", "Properties",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            UpdateProperty(iPropertId, sPropNum, sStreet, sCity, sPostCode, dPropRent, sRooms, dtDateListed,
                                            iStaffId, iPropTypeId, iOwnerId, sPropForRent, sPropOnView);
                            UpdatePropForRent(iPropertId, dtDateAvailable);
                            UpdatePropOnView(iPropertId, sComments);
                        }
                    }
                    else
                    {
                        if ((sPropForRent != "Y") && (sPropOnView != "Y"))
                        {
                            //Delete entries from child table
                            if (MessageBox.Show("Are you sure you want to save the change(s)?", "Properties",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                DeletePropForRent(iPropertId);
                                DeletePropertyOnView(iPropertId);
                            }
                        }
                        else
                        {
                            if ((sPropForRent == "N") && (sPropOnView == "Y"))
                            {
                                //Check if entry exists in child table 1(PFR) if so delete it
                                //Check if entry exists in child table 2(POV) if so update it other wise insert it
                                if (MessageBox.Show("Are you sure you want to save the change(s)?", "Properties",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    UpdatePropertyMovePFR2POV(iPropertId, sComments);
                                    UpdatePropertySetPFRPOV(iPropertId, sPropForRent, sPropOnView);//Make the change in the Parent table
                                }
                            }
                            else
                            {
                                if ((sPropForRent == "Y") && (sPropOnView == "N"))
                                {
                                    //Check if entry exists in child table 1(PFR) if so update it other wise insert it
                                    //Check if entry exists in child table 2(POV) if so delete it
                                    if (MessageBox.Show("Are you sure you want to save the change(s)?", "Properties",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        UpdatePropertyMovePOV2PFR(iPropertId, dtDateAvailable);
                                        UpdatePropertySetPFRPOV(iPropertId, sPropForRent, sPropOnView);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if ((sPreviousPFR == "Y") && (sPreviousPOV == "Y"))
                    {
                        if (MessageBox.Show("Are you sure you want to save the change(s)?", "Properties",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            UpdateProperty(iPropertId, sPropNum, sStreet, sCity, sPostCode, dPropRent, sRooms,
                                            dtDateListed, iStaffId, iPropTypeId, iOwnerId, sPropForRent, sPropOnView);
                            UpdatePropForRent(iPropertId, dtDateAvailable);
                            UpdatePropOnView(iPropertId, sComments);
                        }
                    }
                    if ((sPreviousPFR == "N") && (sPreviousPOV == "N"))
                    {
                        if (MessageBox.Show("Are you sure you want to save the change(s)?", "Properties",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            UpdateProperty(iPropertId, sPropNum, sStreet, sCity, sPostCode, dPropRent, sRooms,
                                            dtDateListed, iStaffId, iPropTypeId, iOwnerId, sPropForRent, sPropOnView);
                        }
                    }
                    if ((sPreviousPFR == "Y") && (sPreviousPOV == "N"))
                    {
                        if (MessageBox.Show("Are you sure you want to save the change(s)?", "Properties",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            UpdateProperty(iPropertId, sPropNum, sStreet, sCity, sPostCode, dPropRent, sRooms,
                                            dtDateListed, iStaffId, iPropTypeId, iOwnerId, sPropForRent, sPropOnView);
                            UpdatePropForRent(iPropertId, dtDateAvailable);
                        }
                    }
                    if ((sPreviousPFR == "N") && (sPreviousPOV == "Y"))
                    {
                        if (MessageBox.Show("Are you sure you want to save the change(s)?", "Properties",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            UpdateProperty(iPropertId, sPropNum, sStreet, sCity, sPostCode, dPropRent, sRooms,
                                            dtDateListed, iStaffId, iPropTypeId, iOwnerId, sPropForRent, sPropOnView);
                            UpdatePropOnView(iPropertId, sComments);
                        }
                    }
                }
            }
            catch(Exception exc) 
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            try
            {
                //Set param
                int iPropertyId = int.Parse(lblPropertyId.Text);
                if (MessageBox.Show("Are you sure you want to delete the entry?", "Properties",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteProperty(iPropertyId);
                    bnNavigatorProperty.BindingSource.RemoveCurrent();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            GetValuesOfDDLs();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            GetValuesOfDDLs();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            GetValuesOfDDLs();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            GetValuesOfDDLs();
        }
    }
}
