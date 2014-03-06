namespace NationalRealtors
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.lblSelectClient = new System.Windows.Forms.Label();
            this.ddlClient = new System.Windows.Forms.ComboBox();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.rtbxMonthlyRent = new System.Windows.Forms.RichTextBox();
            this.rtbxTotalInPayments = new System.Windows.Forms.RichTextBox();
            this.lblAmountReceived = new System.Windows.Forms.Label();
            this.txtAmountReceived = new System.Windows.Forms.TextBox();
            this.lblMonthRent = new System.Windows.Forms.Label();
            this.lblTotalPaymentsMade = new System.Windows.Forms.Label();
            this.btnAcceptPayment = new System.Windows.Forms.Button();
            this.cLIENTTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.CLIENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectClient
            // 
            this.lblSelectClient.AutoSize = true;
            this.lblSelectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectClient.Location = new System.Drawing.Point(12, 9);
            this.lblSelectClient.Name = "lblSelectClient";
            this.lblSelectClient.Size = new System.Drawing.Size(73, 15);
            this.lblSelectClient.TabIndex = 0;
            this.lblSelectClient.Text = "Select client";
            // 
            // ddlClient
            // 
            this.ddlClient.DataSource = this.cLIENTBindingSource;
            this.ddlClient.DisplayMember = "ClientLname";
            this.ddlClient.FormattingEnabled = true;
            this.ddlClient.Location = new System.Drawing.Point(15, 27);
            this.ddlClient.Name = "ddlClient";
            this.ddlClient.Size = new System.Drawing.Size(121, 21);
            this.ddlClient.TabIndex = 1;
            this.ddlClient.ValueMember = "ClientId";
            this.ddlClient.SelectionChangeCommitted += new System.EventHandler(this.ddlClient_SelectionChangeCommitted);
            this.ddlClient.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ddlClient_Format);
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.dsNationalRealtors;
            // 
            // dsNationalRealtors
            // 
            this.dsNationalRealtors.DataSetName = "dsNationalRealtors";
            this.dsNationalRealtors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rtbxMonthlyRent
            // 
            this.rtbxMonthlyRent.BackColor = System.Drawing.Color.RoyalBlue;
            this.rtbxMonthlyRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxMonthlyRent.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.rtbxMonthlyRent.Location = new System.Drawing.Point(142, 27);
            this.rtbxMonthlyRent.Name = "rtbxMonthlyRent";
            this.rtbxMonthlyRent.ReadOnly = true;
            this.rtbxMonthlyRent.Size = new System.Drawing.Size(138, 49);
            this.rtbxMonthlyRent.TabIndex = 2;
            this.rtbxMonthlyRent.Text = "";
            // 
            // rtbxTotalInPayments
            // 
            this.rtbxTotalInPayments.BackColor = System.Drawing.Color.RoyalBlue;
            this.rtbxTotalInPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxTotalInPayments.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.rtbxTotalInPayments.Location = new System.Drawing.Point(142, 93);
            this.rtbxTotalInPayments.Name = "rtbxTotalInPayments";
            this.rtbxTotalInPayments.ReadOnly = true;
            this.rtbxTotalInPayments.Size = new System.Drawing.Size(138, 49);
            this.rtbxTotalInPayments.TabIndex = 3;
            this.rtbxTotalInPayments.Text = "";
            // 
            // lblAmountReceived
            // 
            this.lblAmountReceived.AutoSize = true;
            this.lblAmountReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountReceived.Location = new System.Drawing.Point(12, 75);
            this.lblAmountReceived.Name = "lblAmountReceived";
            this.lblAmountReceived.Size = new System.Drawing.Size(98, 15);
            this.lblAmountReceived.TabIndex = 4;
            this.lblAmountReceived.Text = "Amount received";
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.Location = new System.Drawing.Point(15, 93);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.Size = new System.Drawing.Size(121, 20);
            this.txtAmountReceived.TabIndex = 5;
            // 
            // lblMonthRent
            // 
            this.lblMonthRent.AutoSize = true;
            this.lblMonthRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthRent.Location = new System.Drawing.Point(142, 9);
            this.lblMonthRent.Name = "lblMonthRent";
            this.lblMonthRent.Size = new System.Drawing.Size(74, 15);
            this.lblMonthRent.TabIndex = 6;
            this.lblMonthRent.Text = "Monthly rent";
            // 
            // lblTotalPaymentsMade
            // 
            this.lblTotalPaymentsMade.AutoSize = true;
            this.lblTotalPaymentsMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaymentsMade.Location = new System.Drawing.Point(142, 75);
            this.lblTotalPaymentsMade.Name = "lblTotalPaymentsMade";
            this.lblTotalPaymentsMade.Size = new System.Drawing.Size(138, 15);
            this.lblTotalPaymentsMade.TabIndex = 7;
            this.lblTotalPaymentsMade.Text = "Total in payments made";
            // 
            // btnAcceptPayment
            // 
            this.btnAcceptPayment.Enabled = false;
            this.btnAcceptPayment.Location = new System.Drawing.Point(15, 119);
            this.btnAcceptPayment.Name = "btnAcceptPayment";
            this.btnAcceptPayment.Size = new System.Drawing.Size(121, 23);
            this.btnAcceptPayment.TabIndex = 8;
            this.btnAcceptPayment.Text = "Accept payment";
            this.btnAcceptPayment.UseVisualStyleBackColor = true;
            this.btnAcceptPayment.Click += new System.EventHandler(this.btnAcceptPayment_Click);
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 157);
            this.Controls.Add(this.btnAcceptPayment);
            this.Controls.Add(this.lblTotalPaymentsMade);
            this.Controls.Add(this.lblMonthRent);
            this.Controls.Add(this.txtAmountReceived);
            this.Controls.Add(this.lblAmountReceived);
            this.Controls.Add(this.rtbxTotalInPayments);
            this.Controls.Add(this.rtbxMonthlyRent);
            this.Controls.Add(this.ddlClient);
            this.Controls.Add(this.lblSelectClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectClient;
        private System.Windows.Forms.ComboBox ddlClient;
        private System.Windows.Forms.RichTextBox rtbxMonthlyRent;
        private System.Windows.Forms.RichTextBox rtbxTotalInPayments;
        private System.Windows.Forms.Label lblAmountReceived;
        private System.Windows.Forms.TextBox txtAmountReceived;
        private System.Windows.Forms.Label lblMonthRent;
        private System.Windows.Forms.Label lblTotalPaymentsMade;
        private System.Windows.Forms.Button btnAcceptPayment;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private dsNationalRealtorsTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
    }
}