namespace NationalRealtors
{
    partial class frmLogLease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogLease));
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.lblDepositPaid = new System.Windows.Forms.Label();
            this.ddlDepositPaid = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.ddlClient = new System.Windows.Forms.ComboBox();
            this.lblProperty = new System.Windows.Forms.Label();
            this.ddlProperty = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditLease = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpbxLease = new System.Windows.Forms.GroupBox();
            this.bnLease = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblLeaseNumber = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.gpbxUpdateLease = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpStartDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpExpiryDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayMethodUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlDepositPaidUpdate = new System.Windows.Forms.ComboBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.CLIENTTableAdapter();
            this.gpbxLease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnLease)).BeginInit();
            this.bnLease.SuspendLayout();
            this.gpbxUpdateLease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(12, 19);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(59, 15);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(139, 19);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(188, 20);
            this.dtpStartDate.TabIndex = 1;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.Location = new System.Drawing.Point(12, 45);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(67, 15);
            this.lblExpiryDate.TabIndex = 2;
            this.lblExpiryDate.Text = "Expiry date";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(139, 45);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(188, 20);
            this.dtpExpiryDate.TabIndex = 3;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(12, 72);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(100, 15);
            this.lblPaymentMethod.TabIndex = 4;
            this.lblPaymentMethod.Text = "Payment method";
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Location = new System.Drawing.Point(139, 71);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.Size = new System.Drawing.Size(188, 20);
            this.txtPaymentMethod.TabIndex = 5;
            // 
            // lblDepositPaid
            // 
            this.lblDepositPaid.AutoSize = true;
            this.lblDepositPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositPaid.Location = new System.Drawing.Point(12, 98);
            this.lblDepositPaid.Name = "lblDepositPaid";
            this.lblDepositPaid.Size = new System.Drawing.Size(76, 15);
            this.lblDepositPaid.TabIndex = 6;
            this.lblDepositPaid.Text = "Deposit paid";
            // 
            // ddlDepositPaid
            // 
            this.ddlDepositPaid.FormattingEnabled = true;
            this.ddlDepositPaid.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.ddlDepositPaid.Location = new System.Drawing.Point(139, 97);
            this.ddlDepositPaid.Name = "ddlDepositPaid";
            this.ddlDepositPaid.Size = new System.Drawing.Size(188, 21);
            this.ddlDepositPaid.TabIndex = 7;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(12, 125);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(38, 15);
            this.lblClient.TabIndex = 8;
            this.lblClient.Text = "Client";
            // 
            // ddlClient
            // 
            this.ddlClient.DataSource = this.cLIENTBindingSource;
            this.ddlClient.DisplayMember = "ClientLname";
            this.ddlClient.Enabled = false;
            this.ddlClient.FormattingEnabled = true;
            this.ddlClient.Location = new System.Drawing.Point(139, 124);
            this.ddlClient.Name = "ddlClient";
            this.ddlClient.Size = new System.Drawing.Size(188, 21);
            this.ddlClient.TabIndex = 9;
            this.ddlClient.ValueMember = "ClientId";
            this.ddlClient.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ddlClient_Format);
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperty.Location = new System.Drawing.Point(12, 152);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(52, 15);
            this.lblProperty.TabIndex = 10;
            this.lblProperty.Text = "Property";
            // 
            // ddlProperty
            // 
            this.ddlProperty.Enabled = false;
            this.ddlProperty.FormattingEnabled = true;
            this.ddlProperty.Location = new System.Drawing.Point(139, 151);
            this.ddlProperty.Name = "ddlProperty";
            this.ddlProperty.Size = new System.Drawing.Size(188, 21);
            this.ddlProperty.TabIndex = 11;
            this.ddlProperty.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ddlProperty_Format);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(12, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditLease
            // 
            this.btnEditLease.Location = new System.Drawing.Point(93, 234);
            this.btnEditLease.Name = "btnEditLease";
            this.btnEditLease.Size = new System.Drawing.Size(75, 23);
            this.btnEditLease.TabIndex = 13;
            this.btnEditLease.Text = "Edit lease";
            this.btnEditLease.UseVisualStyleBackColor = true;
            this.btnEditLease.Click += new System.EventHandler(this.btnEditLease_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(264, 234);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gpbxLease
            // 
            this.gpbxLease.Controls.Add(this.bnLease);
            this.gpbxLease.Controls.Add(this.dtpStartDate);
            this.gpbxLease.Controls.Add(this.lblStartDate);
            this.gpbxLease.Controls.Add(this.lblExpiryDate);
            this.gpbxLease.Controls.Add(this.dtpExpiryDate);
            this.gpbxLease.Controls.Add(this.ddlProperty);
            this.gpbxLease.Controls.Add(this.lblPaymentMethod);
            this.gpbxLease.Controls.Add(this.lblProperty);
            this.gpbxLease.Controls.Add(this.txtPaymentMethod);
            this.gpbxLease.Controls.Add(this.ddlClient);
            this.gpbxLease.Controls.Add(this.lblDepositPaid);
            this.gpbxLease.Controls.Add(this.lblClient);
            this.gpbxLease.Controls.Add(this.ddlDepositPaid);
            this.gpbxLease.Location = new System.Drawing.Point(12, 24);
            this.gpbxLease.Name = "gpbxLease";
            this.gpbxLease.Size = new System.Drawing.Size(333, 208);
            this.gpbxLease.TabIndex = 15;
            this.gpbxLease.TabStop = false;
            // 
            // bnLease
            // 
            this.bnLease.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnLease.CountItem = this.bindingNavigatorCountItem;
            this.bnLease.DeleteItem = null;
            this.bnLease.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnLease.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.bnLease.Location = new System.Drawing.Point(3, 180);
            this.bnLease.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnLease.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnLease.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnLease.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnLease.Name = "bnLease";
            this.bnLease.PositionItem = this.bindingNavigatorPositionItem;
            this.bnLease.Size = new System.Drawing.Size(327, 25);
            this.bnLease.TabIndex = 12;
            this.bnLease.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(58, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblLeaseNumber
            // 
            this.lblLeaseNumber.AutoSize = true;
            this.lblLeaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaseNumber.Location = new System.Drawing.Point(12, 9);
            this.lblLeaseNumber.Name = "lblLeaseNumber";
            this.lblLeaseNumber.Size = new System.Drawing.Size(87, 15);
            this.lblLeaseNumber.TabIndex = 16;
            this.lblLeaseNumber.Text = "Lease number";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Enabled = false;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(225, 9);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(19, 15);
            this.lblNumber.TabIndex = 17;
            this.lblNumber.Text = "...";
            // 
            // gpbxUpdateLease
            // 
            this.gpbxUpdateLease.Controls.Add(this.btnUpdate);
            this.gpbxUpdateLease.Controls.Add(this.dtpStartDateUpdate);
            this.gpbxUpdateLease.Controls.Add(this.label1);
            this.gpbxUpdateLease.Controls.Add(this.label2);
            this.gpbxUpdateLease.Controls.Add(this.dtpExpiryDateUpdate);
            this.gpbxUpdateLease.Controls.Add(this.label3);
            this.gpbxUpdateLease.Controls.Add(this.txtPayMethodUpdate);
            this.gpbxUpdateLease.Controls.Add(this.label5);
            this.gpbxUpdateLease.Controls.Add(this.ddlDepositPaidUpdate);
            this.gpbxUpdateLease.Enabled = false;
            this.gpbxUpdateLease.Location = new System.Drawing.Point(351, 24);
            this.gpbxUpdateLease.Name = "gpbxUpdateLease";
            this.gpbxUpdateLease.Size = new System.Drawing.Size(279, 208);
            this.gpbxUpdateLease.TabIndex = 18;
            this.gpbxUpdateLease.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 176);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpStartDateUpdate
            // 
            this.dtpStartDateUpdate.Location = new System.Drawing.Point(139, 19);
            this.dtpStartDateUpdate.Name = "dtpStartDateUpdate";
            this.dtpStartDateUpdate.Size = new System.Drawing.Size(132, 20);
            this.dtpStartDateUpdate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Start date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Expiry date";
            // 
            // dtpExpiryDateUpdate
            // 
            this.dtpExpiryDateUpdate.Location = new System.Drawing.Point(139, 55);
            this.dtpExpiryDateUpdate.Name = "dtpExpiryDateUpdate";
            this.dtpExpiryDateUpdate.Size = new System.Drawing.Size(132, 20);
            this.dtpExpiryDateUpdate.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment method";
            // 
            // txtPayMethodUpdate
            // 
            this.txtPayMethodUpdate.Location = new System.Drawing.Point(139, 91);
            this.txtPayMethodUpdate.Name = "txtPayMethodUpdate";
            this.txtPayMethodUpdate.Size = new System.Drawing.Size(132, 20);
            this.txtPayMethodUpdate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Deposit paid";
            // 
            // ddlDepositPaidUpdate
            // 
            this.ddlDepositPaidUpdate.FormattingEnabled = true;
            this.ddlDepositPaidUpdate.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.ddlDepositPaidUpdate.Location = new System.Drawing.Point(139, 127);
            this.ddlDepositPaidUpdate.Name = "ddlDepositPaidUpdate";
            this.ddlDepositPaidUpdate.Size = new System.Drawing.Size(132, 21);
            this.ddlDepositPaidUpdate.TabIndex = 7;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(466, 234);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 19;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(547, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // frmLogLease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 263);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.gpbxUpdateLease);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblLeaseNumber);
            this.Controls.Add(this.gpbxLease);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditLease);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogLease";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lease Agreement";
            this.Load += new System.EventHandler(this.frmLogLease_Load);
            this.gpbxLease.ResumeLayout(false);
            this.gpbxLease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnLease)).EndInit();
            this.bnLease.ResumeLayout(false);
            this.bnLease.PerformLayout();
            this.gpbxUpdateLease.ResumeLayout(false);
            this.gpbxUpdateLease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.Label lblDepositPaid;
        private System.Windows.Forms.ComboBox ddlDepositPaid;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox ddlClient;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.ComboBox ddlProperty;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditLease;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gpbxLease;
        private System.Windows.Forms.Label lblLeaseNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox gpbxUpdateLease;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPayMethodUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlDepositPaidUpdate;
        private System.Windows.Forms.BindingNavigator bnLease;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpStartDateUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpExpiryDateUpdate;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnExit;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private dsNationalRealtorsTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
    }
}