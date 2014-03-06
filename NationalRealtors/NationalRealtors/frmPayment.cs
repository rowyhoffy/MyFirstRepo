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
    public partial class frmPayment : Form
    {
        SqlConnection conn = new SqlConnection();
        BindingSource bsClientRent = new BindingSource();
        BindingSource bsClientPayment = new BindingSource();
        public frmPayment()
        {
            InitializeComponent();
        }

        private void GetConnetionString()
        {
            conn.ConnectionString = @"Data Source=csi.ufs.ac.za; Initial Catalog=RIS314_HoffmannRW; Integrated Security=false; User Id=HoffmannRW; Password=rw8707075103087h;";
        }
        private void InsertPayment(DateTime dtPaymentDate,decimal dAmount,int iClientId)
        { 
            //Set the command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "InsertPayment";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daInsertPayment = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Ste the params
                cmd.Parameters.AddWithValue("@PaymentDate",dtPaymentDate);
                cmd.Parameters.AddWithValue("@PaymentAmount",dAmount);
                cmd.Parameters.AddWithValue("@ClientId",iClientId);
                //Execution
                int iRetunrValue = cmd.ExecuteNonQuery();
                if (iRetunrValue < 0)
                    MessageBox.Show("Insert successful");
                else
                    MessageBox.Show("Insert failed");
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
        private void GetClientTotalPayments(int iClient)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetClientMonthlyPayment";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daGetClientPayment = new SqlDataAdapter();
            DataSet dsGetClientPayment = new DataSet();
            try
            {
                conn.Open();
                //Set the param
                cmd.Parameters.AddWithValue("@ClientId", iClient);
                daGetClientPayment.SelectCommand = cmd;
                daGetClientPayment.Fill(dsGetClientPayment);
                bsClientPayment.DataSource = dsGetClientPayment.Tables[0];
                rtbxTotalInPayments.DataBindings.Add(new Binding("Text", bsClientPayment, "TotalPayments"));
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            finally
            {
                conn.Close();
                rtbxTotalInPayments.DataBindings.Clear();
            }
        }
        private void GetClientRent(int iClient)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetClientMonthlyRent";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daGetClientRent = new SqlDataAdapter();
            DataSet dsGetClientRent = new DataSet();
            try 
            {
                conn.Open();
                //Set the param
                cmd.Parameters.AddWithValue("@ClientId",iClient);
                daGetClientRent.SelectCommand = cmd;
                daGetClientRent.Fill(dsGetClientRent);
                bsClientRent.DataSource = dsGetClientRent.Tables[0];
                rtbxMonthlyRent.DataBindings.Add(new Binding("Text", bsClientRent, "PropertyRent"));
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            finally 
            {
                conn.Close();
                rtbxMonthlyRent.DataBindings.Clear();
            }

        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNationalRealtors.CLIENT' table. You can move, or remove it, as needed.
            this.cLIENTTableAdapter.Fill(this.dsNationalRealtors.CLIENT);

        }

        private void ddlClient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Set controls
            btnAcceptPayment.Enabled = true;
            GetConnetionString();
            int iClientId = int.Parse(ddlClient.SelectedValue.ToString());
            GetClientTotalPayments(iClientId);
            GetClientRent(iClientId);
        }

        private void ddlClient_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["ClientLname"] + " , " + r["ClientFname"];
        }

        private void btnAcceptPayment_Click(object sender, EventArgs e)
        {
            //Set params
            DateTime dtToday = DateTime.Now;
            int iClientId = int.Parse(ddlClient.SelectedValue.ToString());
            decimal dAmount = Convert.ToDecimal(txtAmountReceived.Text);
            //Insert payment
            if (MessageBox.Show("Did you check your data?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                InsertPayment(dtToday, dAmount, iClientId);
        }
    }
}
