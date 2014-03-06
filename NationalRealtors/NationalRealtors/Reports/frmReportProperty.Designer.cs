namespace NationalRealtors.Reports
{
    partial class frmReportProperty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportProperty));
            this.pnlPropertyReport = new System.Windows.Forms.Panel();
            this.dgvPropertyReport = new System.Windows.Forms.DataGridView();
            this.leaseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaseStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaseExpiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyRoomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vReportPropertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.label2 = new System.Windows.Forms.Label();
            this.vReportPropertyTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.vReportPropertyTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPropertyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vReportPropertyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPropertyReport
            // 
            this.pnlPropertyReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlPropertyReport.Controls.Add(this.label3);
            this.pnlPropertyReport.Controls.Add(this.dgvPropertyReport);
            this.pnlPropertyReport.Controls.Add(this.label2);
            this.pnlPropertyReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPropertyReport.Location = new System.Drawing.Point(0, 0);
            this.pnlPropertyReport.Name = "pnlPropertyReport";
            this.pnlPropertyReport.Size = new System.Drawing.Size(868, 364);
            this.pnlPropertyReport.TabIndex = 0;
            // 
            // dgvPropertyReport
            // 
            this.dgvPropertyReport.AutoGenerateColumns = false;
            this.dgvPropertyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leaseNumberDataGridViewTextBoxColumn,
            this.leaseStartDateDataGridViewTextBoxColumn,
            this.leaseExpiryDateDataGridViewTextBoxColumn,
            this.propertyNumberDataGridViewTextBoxColumn,
            this.propertyStreetDataGridViewTextBoxColumn,
            this.propertyCityDataGridViewTextBoxColumn,
            this.propertyRentDataGridViewTextBoxColumn,
            this.propertyRoomsDataGridViewTextBoxColumn});
            this.dgvPropertyReport.DataSource = this.vReportPropertyBindingSource;
            this.dgvPropertyReport.Location = new System.Drawing.Point(12, 54);
            this.dgvPropertyReport.Name = "dgvPropertyReport";
            this.dgvPropertyReport.Size = new System.Drawing.Size(844, 298);
            this.dgvPropertyReport.TabIndex = 3;
            // 
            // leaseNumberDataGridViewTextBoxColumn
            // 
            this.leaseNumberDataGridViewTextBoxColumn.DataPropertyName = "LeaseNumber";
            this.leaseNumberDataGridViewTextBoxColumn.HeaderText = "LeaseNumber";
            this.leaseNumberDataGridViewTextBoxColumn.Name = "leaseNumberDataGridViewTextBoxColumn";
            // 
            // leaseStartDateDataGridViewTextBoxColumn
            // 
            this.leaseStartDateDataGridViewTextBoxColumn.DataPropertyName = "LeaseStartDate";
            this.leaseStartDateDataGridViewTextBoxColumn.HeaderText = "LeaseStartDate";
            this.leaseStartDateDataGridViewTextBoxColumn.Name = "leaseStartDateDataGridViewTextBoxColumn";
            // 
            // leaseExpiryDateDataGridViewTextBoxColumn
            // 
            this.leaseExpiryDateDataGridViewTextBoxColumn.DataPropertyName = "LeaseExpiryDate";
            this.leaseExpiryDateDataGridViewTextBoxColumn.HeaderText = "LeaseExpiryDate";
            this.leaseExpiryDateDataGridViewTextBoxColumn.Name = "leaseExpiryDateDataGridViewTextBoxColumn";
            // 
            // propertyNumberDataGridViewTextBoxColumn
            // 
            this.propertyNumberDataGridViewTextBoxColumn.DataPropertyName = "PropertyNumber";
            this.propertyNumberDataGridViewTextBoxColumn.HeaderText = "PropertyNumber";
            this.propertyNumberDataGridViewTextBoxColumn.Name = "propertyNumberDataGridViewTextBoxColumn";
            // 
            // propertyStreetDataGridViewTextBoxColumn
            // 
            this.propertyStreetDataGridViewTextBoxColumn.DataPropertyName = "PropertyStreet";
            this.propertyStreetDataGridViewTextBoxColumn.HeaderText = "PropertyStreet";
            this.propertyStreetDataGridViewTextBoxColumn.Name = "propertyStreetDataGridViewTextBoxColumn";
            // 
            // propertyCityDataGridViewTextBoxColumn
            // 
            this.propertyCityDataGridViewTextBoxColumn.DataPropertyName = "PropertyCity";
            this.propertyCityDataGridViewTextBoxColumn.HeaderText = "PropertyCity";
            this.propertyCityDataGridViewTextBoxColumn.Name = "propertyCityDataGridViewTextBoxColumn";
            // 
            // propertyRentDataGridViewTextBoxColumn
            // 
            this.propertyRentDataGridViewTextBoxColumn.DataPropertyName = "PropertyRent";
            this.propertyRentDataGridViewTextBoxColumn.HeaderText = "PropertyRent";
            this.propertyRentDataGridViewTextBoxColumn.Name = "propertyRentDataGridViewTextBoxColumn";
            // 
            // propertyRoomsDataGridViewTextBoxColumn
            // 
            this.propertyRoomsDataGridViewTextBoxColumn.DataPropertyName = "PropertyRooms";
            this.propertyRoomsDataGridViewTextBoxColumn.HeaderText = "PropertyRooms";
            this.propertyRoomsDataGridViewTextBoxColumn.Name = "propertyRoomsDataGridViewTextBoxColumn";
            // 
            // vReportPropertyBindingSource
            // 
            this.vReportPropertyBindingSource.DataMember = "vReportProperty";
            this.vReportPropertyBindingSource.DataSource = this.dsNationalRealtors;
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
            this.label2.Location = new System.Drawing.Point(346, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "National Realtors";
            // 
            // vReportPropertyTableAdapter
            // 
            this.vReportPropertyTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Property Report";
            // 
            // frmReportProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 364);
            this.Controls.Add(this.pnlPropertyReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Property Report";
            this.Load += new System.EventHandler(this.frmReportProperty_Load);
            this.pnlPropertyReport.ResumeLayout(false);
            this.pnlPropertyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vReportPropertyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPropertyReport;
        private System.Windows.Forms.DataGridView dgvPropertyReport;
        private System.Windows.Forms.Label label2;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource vReportPropertyBindingSource;
        private dsNationalRealtorsTableAdapters.vReportPropertyTableAdapter vReportPropertyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaseStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaseExpiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyRoomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}