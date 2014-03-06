namespace NationalRealtors
{
    partial class frmLogViewing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogViewing));
            this.lblViewDate = new System.Windows.Forms.Label();
            this.dtpViewDate = new System.Windows.Forms.DateTimePicker();
            this.lblClient = new System.Windows.Forms.Label();
            this.ddlClient = new System.Windows.Forms.ComboBox();
            this.lblPropViewed = new System.Windows.Forms.Label();
            this.ddlProperty = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.CLIENTTableAdapter();
            this.pROPERTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROPERTYTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.PROPERTYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPERTYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewDate
            // 
            this.lblViewDate.AutoSize = true;
            this.lblViewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewDate.Location = new System.Drawing.Point(10, 12);
            this.lblViewDate.Name = "lblViewDate";
            this.lblViewDate.Size = new System.Drawing.Size(33, 15);
            this.lblViewDate.TabIndex = 0;
            this.lblViewDate.Text = "Date";
            // 
            // dtpViewDate
            // 
            this.dtpViewDate.Location = new System.Drawing.Point(125, 12);
            this.dtpViewDate.Name = "dtpViewDate";
            this.dtpViewDate.Size = new System.Drawing.Size(198, 20);
            this.dtpViewDate.TabIndex = 1;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(10, 39);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(38, 15);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client";
            // 
            // ddlClient
            // 
            this.ddlClient.DataSource = this.cLIENTBindingSource;
            this.ddlClient.DisplayMember = "ClientLname";
            this.ddlClient.FormattingEnabled = true;
            this.ddlClient.Location = new System.Drawing.Point(125, 38);
            this.ddlClient.Name = "ddlClient";
            this.ddlClient.Size = new System.Drawing.Size(198, 21);
            this.ddlClient.TabIndex = 3;
            this.ddlClient.ValueMember = "ClientId";
            this.ddlClient.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ddlClient_Format);
            // 
            // lblPropViewed
            // 
            this.lblPropViewed.AutoSize = true;
            this.lblPropViewed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropViewed.Location = new System.Drawing.Point(10, 66);
            this.lblPropViewed.Name = "lblPropViewed";
            this.lblPropViewed.Size = new System.Drawing.Size(93, 15);
            this.lblPropViewed.TabIndex = 4;
            this.lblPropViewed.Text = "Property viewed";
            // 
            // ddlProperty
            // 
            this.ddlProperty.FormattingEnabled = true;
            this.ddlProperty.Location = new System.Drawing.Point(125, 65);
            this.ddlProperty.Name = "ddlProperty";
            this.ddlProperty.Size = new System.Drawing.Size(198, 21);
            this.ddlProperty.TabIndex = 5;
            this.ddlProperty.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ddlProperty_Format);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 88);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dsNationalRealtors
            // 
            this.dsNationalRealtors.DataSetName = "dsNationalRealtors";
            this.dsNationalRealtors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.dsNationalRealtors;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
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
            // frmLogViewing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 113);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ddlProperty);
            this.Controls.Add(this.lblPropViewed);
            this.Controls.Add(this.ddlClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.dtpViewDate);
            this.Controls.Add(this.lblViewDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogViewing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log a Viewing";
            this.Load += new System.EventHandler(this.frmLogViewing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPERTYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewDate;
        private System.Windows.Forms.DateTimePicker dtpViewDate;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox ddlClient;
        private System.Windows.Forms.Label lblPropViewed;
        private System.Windows.Forms.ComboBox ddlProperty;
        private System.Windows.Forms.Button btnSave;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private dsNationalRealtorsTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.BindingSource pROPERTYBindingSource;
        private dsNationalRealtorsTableAdapters.PROPERTYTableAdapter pROPERTYTableAdapter;
    }
}