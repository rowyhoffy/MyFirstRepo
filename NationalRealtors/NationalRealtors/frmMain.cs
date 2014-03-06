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
    public partial class frmMain : Form
    {
        SqlConnection conn = new SqlConnection();
        public frmMain()
        {
            InitializeComponent();
        }
        private void GetClientsWishingToRent()
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetClientsWTR";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daGetClients = new SqlDataAdapter();
            DataSet dsGetClients = new DataSet();
            BindingSource bsGetClients = new BindingSource();
            try 
            {
                conn.Open();
                daGetClients.SelectCommand = cmd;
                daGetClients.Fill(dsGetClients);
                bsGetClients.DataSource = dsGetClients.Tables[0];
                //Bind to dgv
                dgvClients.DataSource = bsGetClients;
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
        private void GetAllPropertyForRent()
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetAllPropertyForRent";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daGetAllPropsForRent = new SqlDataAdapter();
            DataSet dsGetAll = new DataSet();
            BindingSource bsGetAll = new BindingSource();
            try 
            {
                conn.Open();
                daGetAllPropsForRent.SelectCommand = cmd;
                daGetAllPropsForRent.Fill(dsGetAll);
                bsGetAll.DataSource = dsGetAll.Tables[0];
                //Bind to dgv
                dgvPropertyForRent.DataSource = bsGetAll;
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
        private void GetPropertyByCity(string sCity,string sForRent)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetPropertyByCity";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set Adapter
            SqlDataAdapter daGetPropertyByCity = new SqlDataAdapter();
            DataSet dsGetProps = new DataSet();
            BindingSource bsGetProps = new BindingSource();
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@City",sCity);
                cmd.Parameters.AddWithValue("@ForRent",sForRent);
                daGetPropertyByCity.SelectCommand = cmd;
                daGetPropertyByCity.Fill(dsGetProps);
                bsGetProps.DataSource = dsGetProps.Tables[0];
                //Bind to dgv
                dgvPropertyForRent.DataSource = bsGetProps;
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
        private void btnRegisterBranch_Click(object sender, EventArgs e)
        {
            //Instantiate and show registration form for a Branch
            frmRegisterBranch NewBranch = new frmRegisterBranch();
            NewBranch.ShowDialog();
        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            //Instantiate and show registration form for a new staff member
            frmRegisterStaff NewStaffMember = new frmRegisterStaff();
            NewStaffMember.ShowDialog();
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            //Instantiate and show registration form for a new client
            frmRegisterClient NewClient = new frmRegisterClient();
            NewClient.ShowDialog();
        }

        private void btnRegisterProperty_Click(object sender, EventArgs e)
        {
            //Instantiate and show registration form for listing property
            frmRegisterProperty NewProperty = new frmRegisterProperty();
            NewProperty.ShowDialog();
        }

        private void btnViewing_Click(object sender, EventArgs e)
        {
            //Instantiate and show the form to log a viewing
            frmLogViewing NewViewing = new frmLogViewing();
            NewViewing.ShowDialog();
        }

        private void btnLeaseAgreement_Click(object sender, EventArgs e)
        {
            //Instantiate and show the form to log a lease agreement
            frmLogLease NewLease = new frmLogLease();
            NewLease.ShowDialog();
        }

        private void btnAcceptPayment_Click(object sender, EventArgs e)
        {
            //Instantiate and show the form to accept payments
            frmPayment NewPayment = new frmPayment();
            NewPayment.ShowDialog();
        }

        private void btnStaffClass_Click(object sender, EventArgs e)
        {
            //Show Class form
            Manage.frmStaffClassification NewClassification = new Manage.frmStaffClassification();
            NewClassification.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetConnectionString();
            try
            {
                //Set params
                string sCity = txtCity.Text;
                string sForRent = ddlForRent.SelectedItem.ToString();
                //Load data to dgv
                GetPropertyByCity(sCity, sForRent);
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.ToString().Replace(exc.ToString(),"Please enter a City and/or Property status."), "Properties for Rent", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            GetConnectionString();
            GetAllPropertyForRent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNationalRealtors.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.dsNationalRealtors.STAFF);
            // TODO: This line of code loads data into the 'dsNationalRealtors.BRANCH' table. You can move, or remove it, as needed.
            this.bRANCHTableAdapter.Fill(this.dsNationalRealtors.BRANCH);
            GetConnectionString();
            // TODO: This line of code loads data into the 'dsNationalRealtors.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.dsNationalRealtors.CLIENT);
            GetClientsWishingToRent();

        }

        private void btnPropertyForRent_Click(object sender, EventArgs e)
        {
            Reports.frmReportPropertiesForRent frmPropertiesForRent = new Reports.frmReportPropertiesForRent();
            frmPropertiesForRent.ShowDialog();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            Reports.frmReportOnClients frmClients = new Reports.frmReportOnClients();
            frmClients.ShowDialog();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            Reports.frmReportProperty frmPropertyReport = new Reports.frmReportProperty();
            frmPropertyReport.ShowDialog();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            Reports.frmReportRental frmRentalReport = new Reports.frmReportRental();
            frmRentalReport.ShowDialog();
        }

        private void btnPropertyViewings_Click(object sender, EventArgs e)
        {
            Reports.frmReportPropertyViewings frmViewings = new Reports.frmReportPropertyViewings();
            frmViewings.ShowDialog();
        }

        private void btnRentalDistrib_Click(object sender, EventArgs e)
        {
            Reports.frmReportRentalDistribution frmRentalDistrib = new Reports.frmReportRentalDistribution();
            frmRentalDistrib.ShowDialog();
        }

        private void btnComments_Click(object sender, EventArgs e)
        {
            frmPropertyComments frmComments = new frmPropertyComments();
            frmComments.ShowDialog();
        }
    }
}
