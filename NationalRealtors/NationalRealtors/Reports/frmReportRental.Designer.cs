namespace NationalRealtors.Reports
{
    partial class frmReportRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportRental));
            this.pnlRentalReport = new System.Windows.Forms.Panel();
            this.dgvRentalReport = new System.Windows.Forms.DataGridView();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPaymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vReportRentalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vReportRentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vReportRentalTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.vReportRentalTableAdapter();
            this.pnlRentalReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vReportRentalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vReportRentalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRentalReport
            // 
            this.pnlRentalReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlRentalReport.Controls.Add(this.dgvRentalReport);
            this.pnlRentalReport.Controls.Add(this.label2);
            this.pnlRentalReport.Controls.Add(this.label1);
            this.pnlRentalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRentalReport.Location = new System.Drawing.Point(0, 0);
            this.pnlRentalReport.Name = "pnlRentalReport";
            this.pnlRentalReport.Size = new System.Drawing.Size(673, 303);
            this.pnlRentalReport.TabIndex = 0;
            // 
            // dgvRentalReport
            // 
            this.dgvRentalReport.AllowUserToAddRows = false;
            this.dgvRentalReport.AllowUserToDeleteRows = false;
            this.dgvRentalReport.AutoGenerateColumns = false;
            this.dgvRentalReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.clientNumberDataGridViewTextBoxColumn,
            this.clientLnameDataGridViewTextBoxColumn,
            this.clientFnameDataGridViewTextBoxColumn,
            this.propertyRentDataGridViewTextBoxColumn,
            this.totalPaymentsDataGridViewTextBoxColumn});
            this.dgvRentalReport.DataSource = this.vReportRentalBindingSource1;
            this.dgvRentalReport.Location = new System.Drawing.Point(12, 54);
            this.dgvRentalReport.Name = "dgvRentalReport";
            this.dgvRentalReport.ReadOnly = true;
            this.dgvRentalReport.Size = new System.Drawing.Size(645, 233);
            this.dgvRentalReport.TabIndex = 4;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNumberDataGridViewTextBoxColumn
            // 
            this.clientNumberDataGridViewTextBoxColumn.DataPropertyName = "ClientNumber";
            this.clientNumberDataGridViewTextBoxColumn.HeaderText = "ClientNumber";
            this.clientNumberDataGridViewTextBoxColumn.Name = "clientNumberDataGridViewTextBoxColumn";
            this.clientNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientLnameDataGridViewTextBoxColumn
            // 
            this.clientLnameDataGridViewTextBoxColumn.DataPropertyName = "ClientLname";
            this.clientLnameDataGridViewTextBoxColumn.HeaderText = "ClientLname";
            this.clientLnameDataGridViewTextBoxColumn.Name = "clientLnameDataGridViewTextBoxColumn";
            this.clientLnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientFnameDataGridViewTextBoxColumn
            // 
            this.clientFnameDataGridViewTextBoxColumn.DataPropertyName = "ClientFname";
            this.clientFnameDataGridViewTextBoxColumn.HeaderText = "ClientFname";
            this.clientFnameDataGridViewTextBoxColumn.Name = "clientFnameDataGridViewTextBoxColumn";
            this.clientFnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // propertyRentDataGridViewTextBoxColumn
            // 
            this.propertyRentDataGridViewTextBoxColumn.DataPropertyName = "PropertyRent";
            this.propertyRentDataGridViewTextBoxColumn.HeaderText = "PropertyRent";
            this.propertyRentDataGridViewTextBoxColumn.Name = "propertyRentDataGridViewTextBoxColumn";
            this.propertyRentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPaymentsDataGridViewTextBoxColumn
            // 
            this.totalPaymentsDataGridViewTextBoxColumn.DataPropertyName = "TotalPayments";
            this.totalPaymentsDataGridViewTextBoxColumn.HeaderText = "TotalPayments";
            this.totalPaymentsDataGridViewTextBoxColumn.Name = "totalPaymentsDataGridViewTextBoxColumn";
            this.totalPaymentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vReportRentalBindingSource1
            // 
            this.vReportRentalBindingSource1.DataMember = "vReportRental";
            this.vReportRentalBindingSource1.DataSource = this.dsNationalRealtors;
            // 
            // dsNationalRealtors
            // 
            this.dsNationalRealtors.DataSetName = "dsNationalRealtors";
            this.dsNationalRealtors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "National Realtors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rental Report";
            // 
            // vReportRentalBindingSource
            // 
            this.vReportRentalBindingSource.DataMember = "vReportRental";
            this.vReportRentalBindingSource.DataSource = this.dsNationalRealtors;
            // 
            // vReportRentalTableAdapter
            // 
            this.vReportRentalTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 303);
            this.Controls.Add(this.pnlRentalReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportRental";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rental Report";
            this.Load += new System.EventHandler(this.frmReportRental_Load);
            this.pnlRentalReport.ResumeLayout(false);
            this.pnlRentalReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vReportRentalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vReportRentalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRentalReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRentalReport;
        private System.Windows.Forms.Label label2;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource vReportRentalBindingSource;
        private dsNationalRealtorsTableAdapters.vReportRentalTableAdapter vReportRentalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vReportRentalBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPaymentsDataGridViewTextBoxColumn;
    }
}