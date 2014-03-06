namespace NationalRealtors.Reports
{
    partial class frmReportPropertyViewings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportPropertyViewings));
            this.plnPropertyViewings = new System.Windows.Forms.Panel();
            this.dgvPropertyViewings = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlProperties = new System.Windows.Forms.ComboBox();
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.pROPERTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROPERTYTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.PROPERTYTableAdapter();
            this.ClientNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plnPropertyViewings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyViewings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPERTYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // plnPropertyViewings
            // 
            this.plnPropertyViewings.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plnPropertyViewings.Controls.Add(this.ddlProperties);
            this.plnPropertyViewings.Controls.Add(this.label1);
            this.plnPropertyViewings.Controls.Add(this.label3);
            this.plnPropertyViewings.Controls.Add(this.label2);
            this.plnPropertyViewings.Controls.Add(this.dgvPropertyViewings);
            this.plnPropertyViewings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plnPropertyViewings.Location = new System.Drawing.Point(0, 0);
            this.plnPropertyViewings.Name = "plnPropertyViewings";
            this.plnPropertyViewings.Size = new System.Drawing.Size(572, 390);
            this.plnPropertyViewings.TabIndex = 0;
            // 
            // dgvPropertyViewings
            // 
            this.dgvPropertyViewings.AllowUserToAddRows = false;
            this.dgvPropertyViewings.AllowUserToDeleteRows = false;
            this.dgvPropertyViewings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertyViewings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientNumber,
            this.ClientLname,
            this.ClientFname,
            this.ViewDate,
            this.PropertyComments});
            this.dgvPropertyViewings.Location = new System.Drawing.Point(12, 85);
            this.dgvPropertyViewings.Name = "dgvPropertyViewings";
            this.dgvPropertyViewings.ReadOnly = true;
            this.dgvPropertyViewings.Size = new System.Drawing.Size(545, 293);
            this.dgvPropertyViewings.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "National Realtors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Report on Viewings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a property";
            // 
            // ddlProperties
            // 
            this.ddlProperties.DataSource = this.pROPERTYBindingSource;
            this.ddlProperties.DisplayMember = "PropertyStreet";
            this.ddlProperties.FormattingEnabled = true;
            this.ddlProperties.Location = new System.Drawing.Point(278, 58);
            this.ddlProperties.Name = "ddlProperties";
            this.ddlProperties.Size = new System.Drawing.Size(121, 21);
            this.ddlProperties.TabIndex = 6;
            this.ddlProperties.ValueMember = "PropertyId";
            this.ddlProperties.SelectionChangeCommitted += new System.EventHandler(this.ddlProperties_SelectionChangeCommitted);
            // 
            // dsNationalRealtors
            // 
            this.dsNationalRealtors.DataSetName = "dsNationalRealtors";
            this.dsNationalRealtors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROPERTYBindingSource
            // 
            this.pROPERTYBindingSource.DataMember = "PROPERTY";
            this.pROPERTYBindingSource.DataSource = this.dsNationalRealtors;
            // 
            // pROPERTYTableAdapter
            // 
            this.pROPERTYTableAdapter.ClearBeforeFill = true;
            // 
            // ClientNumber
            // 
            this.ClientNumber.HeaderText = "Client No";
            this.ClientNumber.Name = "ClientNumber";
            this.ClientNumber.ReadOnly = true;
            // 
            // ClientLname
            // 
            this.ClientLname.HeaderText = "Last name";
            this.ClientLname.Name = "ClientLname";
            this.ClientLname.ReadOnly = true;
            // 
            // ClientFname
            // 
            this.ClientFname.HeaderText = "First name";
            this.ClientFname.Name = "ClientFname";
            this.ClientFname.ReadOnly = true;
            // 
            // ViewDate
            // 
            this.ViewDate.HeaderText = "Date viewed";
            this.ViewDate.Name = "ViewDate";
            this.ViewDate.ReadOnly = true;
            // 
            // PropertyComments
            // 
            this.PropertyComments.HeaderText = "Comments";
            this.PropertyComments.Name = "PropertyComments";
            this.PropertyComments.ReadOnly = true;
            // 
            // frmReportPropertyViewings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 390);
            this.Controls.Add(this.plnPropertyViewings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportPropertyViewings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report on Property Viewings";
            this.Load += new System.EventHandler(this.frmReportPropertyViewings_Load);
            this.plnPropertyViewings.ResumeLayout(false);
            this.plnPropertyViewings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyViewings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPERTYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plnPropertyViewings;
        private System.Windows.Forms.DataGridView dgvPropertyViewings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlProperties;
        private System.Windows.Forms.Label label1;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource pROPERTYBindingSource;
        private dsNationalRealtorsTableAdapters.PROPERTYTableAdapter pROPERTYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyComments;
    }
}