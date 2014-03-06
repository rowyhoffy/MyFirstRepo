namespace NationalRealtors.Reports
{
    partial class frmReportPropertiesForRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportPropertiesForRent));
            this.label1 = new System.Windows.Forms.Label();
            this.ddlCity = new System.Windows.Forms.ComboBox();
            this.bRANCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.pnlPropertiesForRent = new System.Windows.Forms.Panel();
            this.dgvPropertiesForRent = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bRANCHTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.BRANCHTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            this.pnlPropertiesForRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertiesForRent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select a branch";
            // 
            // ddlCity
            // 
            this.ddlCity.DataSource = this.bRANCHBindingSource;
            this.ddlCity.DisplayMember = "BranchCity";
            this.ddlCity.FormattingEnabled = true;
            this.ddlCity.Location = new System.Drawing.Point(322, 66);
            this.ddlCity.Name = "ddlCity";
            this.ddlCity.Size = new System.Drawing.Size(121, 21);
            this.ddlCity.TabIndex = 1;
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
            // pnlPropertiesForRent
            // 
            this.pnlPropertiesForRent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlPropertiesForRent.Controls.Add(this.label3);
            this.pnlPropertiesForRent.Controls.Add(this.dgvPropertiesForRent);
            this.pnlPropertiesForRent.Controls.Add(this.ddlCity);
            this.pnlPropertiesForRent.Controls.Add(this.label2);
            this.pnlPropertiesForRent.Controls.Add(this.label1);
            this.pnlPropertiesForRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPropertiesForRent.Location = new System.Drawing.Point(0, 0);
            this.pnlPropertiesForRent.Name = "pnlPropertiesForRent";
            this.pnlPropertiesForRent.Size = new System.Drawing.Size(673, 378);
            this.pnlPropertiesForRent.TabIndex = 2;
            // 
            // dgvPropertiesForRent
            // 
            this.dgvPropertiesForRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertiesForRent.Location = new System.Drawing.Point(12, 93);
            this.dgvPropertiesForRent.Name = "dgvPropertiesForRent";
            this.dgvPropertiesForRent.Size = new System.Drawing.Size(646, 273);
            this.dgvPropertiesForRent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "National Realtors";
            // 
            // bRANCHTableAdapter
            // 
            this.bRANCHTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Properties for Rent Report";
            // 
            // frmReportPropertiesForRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 378);
            this.Controls.Add(this.pnlPropertiesForRent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportPropertiesForRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Properties for Rent";
            this.Load += new System.EventHandler(this.frmReportPropertiesForRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            this.pnlPropertiesForRent.ResumeLayout(false);
            this.pnlPropertiesForRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertiesForRent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlCity;
        private System.Windows.Forms.Panel pnlPropertiesForRent;
        private System.Windows.Forms.DataGridView dgvPropertiesForRent;
        private System.Windows.Forms.Label label2;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource bRANCHBindingSource;
        private dsNationalRealtorsTableAdapters.BRANCHTableAdapter bRANCHTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}