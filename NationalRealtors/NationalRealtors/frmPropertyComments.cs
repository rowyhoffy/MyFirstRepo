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
    public partial class frmPropertyComments : Form
    {
        SqlConnection conn = new SqlConnection();
        public frmPropertyComments()
        {
            InitializeComponent();
        }
        private void GetConnectionString()
        {
            conn.ConnectionString = @"Data Source=csi.ufs.ac.za; Initial Catalog=RIS314_HoffmannRW; Integrated Security=false; User Id=HoffmannRW; Password=rw8707075103087h;";
        }
        private void InsertPropertyComments(int iPropertyId, string sComments)
        {
            //Set command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UpdatePropertyOnView";
            cmd.CommandType = CommandType.StoredProcedure;
            //Set adapter
            SqlDataAdapter daInsertComments = new SqlDataAdapter(cmd);
            try 
            {
                conn.Open();
                //Set params
                cmd.Parameters.AddWithValue("@PropertyId",iPropertyId);
                cmd.Parameters.AddWithValue("@PropertyComments",sComments);
                //Execution
                int iReturnVlaue = cmd.ExecuteNonQuery();
                if (iReturnVlaue < 0)
                    MessageBox.Show("Comment added successfully","Property comments",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    MessageBox.Show("Comment not added", "Property comments", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void frmPropertyComments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNationalRealtors.PROPERTY' table. You can move, or remove it, as needed.
            this.pROPERTYTableAdapter.Fill(this.dsNationalRealtors.PROPERTY);
            GetConnectionString();

        }

        private void ddlProperty_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow r = ((DataRowView)e.ListItem).Row;
            e.Value = r["PropertyStreet"] + " , " + r["PropertyCity"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                //set params
                int iPropertyId = int.Parse(ddlProperty.SelectedValue.ToString());
                string sComment = rtxtComments.Text;
                InsertPropertyComments(iPropertyId, sComment);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
