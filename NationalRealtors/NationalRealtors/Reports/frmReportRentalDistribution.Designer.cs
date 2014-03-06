namespace NationalRealtors.Reports
{
    partial class frmReportRentalDistribution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportRentalDistribution));
            this.pnlDistributionReport = new System.Windows.Forms.Panel();
            this.dgvRentalDistribution = new System.Windows.Forms.DataGridView();
            this.ddlCity = new System.Windows.Forms.ComboBox();
            this.bRANCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bRANCHTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.BRANCHTableAdapter();
            this.pnlDistributionReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDistributionReport
            // 
            this.pnlDistributionReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDistributionReport.Controls.Add(this.dgvRentalDistribution);
            this.pnlDistributionReport.Controls.Add(this.ddlCity);
            this.pnlDistributionReport.Controls.Add(this.label3);
            this.pnlDistributionReport.Controls.Add(this.label1);
            this.pnlDistributionReport.Controls.Add(this.label2);
            this.pnlDistributionReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDistributionReport.Location = new System.Drawing.Point(0, 0);
            this.pnlDistributionReport.Name = "pnlDistributionReport";
            this.pnlDistributionReport.Size = new System.Drawing.Size(484, 398);
            this.pnlDistributionReport.TabIndex = 0;
            // 
            // dgvRentalDistribution
            // 
            this.dgvRentalDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalDistribution.Location = new System.Drawing.Point(12, 111);
            this.dgvRentalDistribution.Name = "dgvRentalDistribution";
            this.dgvRentalDistribution.Size = new System.Drawing.Size(459, 276);
            this.dgvRentalDistribution.TabIndex = 8;
            // 
            // ddlCity
            // 
            this.ddlCity.DataSource = this.bRANCHBindingSource;
            this.ddlCity.DisplayMember = "BranchCity";
            this.ddlCity.FormattingEnabled = true;
            this.ddlCity.Location = new System.Drawing.Point(249, 67);
            this.ddlCity.Name = "ddlCity";
            this.ddlCity.Size = new System.Drawing.Size(121, 21);
            this.ddlCity.TabIndex = 7;
            this.ddlCity.ValueMember = "BranchCity";
            this.ddlCity.SelectionChangeCommitted += new System.EventHandler(this.ddlCity_SelectionChangeCommitted);
            // 
            // bRANCHBindingSource
            // 
            this.bRANCHBindingSource.DataMember = "BRANCH";
            this.bRANCHBindingSource.DataSource = this.dsNationalRealtors;
            // 
            // dsNationalRealtors
            // 
            this.dsNationalRealtors.DataSetName = "dsNationalRealtors";
            this.dsNationalRealtors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select a city/branch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rental Distribution Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "National Realtors";
            // 
            // bRANCHTableAdapter
            // 
            this.bRANCHTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportRentalDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 398);
            this.Controls.Add(this.pnlDistributionReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportRentalDistribution";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rental Distribution Report";
            this.Load += new System.EventHandler(this.frmReportRentalDistribution_Load);
            this.pnlDistributionReport.ResumeLayout(false);
            this.pnlDistributionReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDistributionReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRentalDistribution;
        private System.Windows.Forms.ComboBox ddlCity;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource bRANCHBindingSource;
        private dsNationalRealtorsTableAdapters.BRANCHTableAdapter bRANCHTableAdapter;
    }
}