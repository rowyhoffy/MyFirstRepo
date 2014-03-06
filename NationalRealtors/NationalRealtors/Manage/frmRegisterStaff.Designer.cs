namespace NationalRealtors
{
    partial class frmRegisterStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterStaff));
            this.grpbxStaffDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.bnStaff = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.gpbxInsertUpdate = new System.Windows.Forms.GroupBox();
            this.ddlBranchIU = new System.Windows.Forms.ComboBox();
            this.bRANCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.lblBranchInsert = new System.Windows.Forms.Label();
            this.ddlSupervisorIU = new System.Windows.Forms.ComboBox();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSupervisorInsert = new System.Windows.Forms.Label();
            this.ddlPositionIU = new System.Windows.Forms.ComboBox();
            this.sTAFFCLASSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPositionInsert = new System.Windows.Forms.Label();
            this.dtpStartDateIU = new System.Windows.Forms.DateTimePicker();
            this.lblStartDateInsert = new System.Windows.Forms.Label();
            this.dtpStaffDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtStaffGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtStaffFirstName = new System.Windows.Forms.TextBox();
            this.lblStaffFname = new System.Windows.Forms.Label();
            this.txtStaffLname = new System.Windows.Forms.TextBox();
            this.lblStaffLastName = new System.Windows.Forms.Label();
            this.txtStaffTitle = new System.Windows.Forms.TextBox();
            this.lblStaffTitle = new System.Windows.Forms.Label();
            this.txtStaffNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.sTAFFTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.STAFFTableAdapter();
            this.sTAFF_CLASSTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.STAFF_CLASSTableAdapter();
            this.bRANCHTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.BRANCHTableAdapter();
            this.grpbxStaffDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnStaff)).BeginInit();
            this.bnStaff.SuspendLayout();
            this.gpbxInsertUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFCLASSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxStaffDetails
            // 
            this.grpbxStaffDetails.Controls.Add(this.label1);
            this.grpbxStaffDetails.Controls.Add(this.lblStaffId);
            this.grpbxStaffDetails.Controls.Add(this.bnStaff);
            this.grpbxStaffDetails.Controls.Add(this.gpbxInsertUpdate);
            this.grpbxStaffDetails.Controls.Add(this.dtpStaffDOB);
            this.grpbxStaffDetails.Controls.Add(this.lblDateOfBirth);
            this.grpbxStaffDetails.Controls.Add(this.txtStaffGender);
            this.grpbxStaffDetails.Controls.Add(this.lblGender);
            this.grpbxStaffDetails.Controls.Add(this.txtStaffFirstName);
            this.grpbxStaffDetails.Controls.Add(this.lblStaffFname);
            this.grpbxStaffDetails.Controls.Add(this.txtStaffLname);
            this.grpbxStaffDetails.Controls.Add(this.lblStaffLastName);
            this.grpbxStaffDetails.Controls.Add(this.txtStaffTitle);
            this.grpbxStaffDetails.Controls.Add(this.lblStaffTitle);
            this.grpbxStaffDetails.Controls.Add(this.txtStaffNumber);
            this.grpbxStaffDetails.Controls.Add(this.lblNumber);
            this.grpbxStaffDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxStaffDetails.Location = new System.Drawing.Point(13, 12);
            this.grpbxStaffDetails.Name = "grpbxStaffDetails";
            this.grpbxStaffDetails.Size = new System.Drawing.Size(493, 229);
            this.grpbxStaffDetails.TabIndex = 1;
            this.grpbxStaffDetails.TabStop = false;
            this.grpbxStaffDetails.Text = "Member details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Staff Id";
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Location = new System.Drawing.Point(446, 20);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(41, 15);
            this.lblStaffId.TabIndex = 24;
            this.lblStaffId.Text = "label1";
            // 
            // bnStaff
            // 
            this.bnStaff.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnStaff.CountItem = this.bindingNavigatorCountItem;
            this.bnStaff.DeleteItem = null;
            this.bnStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnStaff.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.tsbtnEdit});
            this.bnStaff.Location = new System.Drawing.Point(3, 201);
            this.bnStaff.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnStaff.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnStaff.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnStaff.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnStaff.Name = "bnStaff";
            this.bnStaff.PositionItem = this.bindingNavigatorPositionItem;
            this.bnStaff.Size = new System.Drawing.Size(487, 25);
            this.bnStaff.TabIndex = 26;
            this.bnStaff.Text = "bindingNavigator1";
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
            // tsbtnEdit
            // 
            this.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.Image")));
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Size = new System.Drawing.Size(31, 22);
            this.tsbtnEdit.Text = "Edit";
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
            // 
            // gpbxInsertUpdate
            // 
            this.gpbxInsertUpdate.Controls.Add(this.ddlBranchIU);
            this.gpbxInsertUpdate.Controls.Add(this.lblBranchInsert);
            this.gpbxInsertUpdate.Controls.Add(this.ddlSupervisorIU);
            this.gpbxInsertUpdate.Controls.Add(this.lblSupervisorInsert);
            this.gpbxInsertUpdate.Controls.Add(this.ddlPositionIU);
            this.gpbxInsertUpdate.Controls.Add(this.lblPositionInsert);
            this.gpbxInsertUpdate.Controls.Add(this.dtpStartDateIU);
            this.gpbxInsertUpdate.Controls.Add(this.lblStartDateInsert);
            this.gpbxInsertUpdate.Enabled = false;
            this.gpbxInsertUpdate.Location = new System.Drawing.Point(243, 39);
            this.gpbxInsertUpdate.Name = "gpbxInsertUpdate";
            this.gpbxInsertUpdate.Size = new System.Drawing.Size(244, 152);
            this.gpbxInsertUpdate.TabIndex = 2;
            this.gpbxInsertUpdate.TabStop = false;
            // 
            // ddlBranchIU
            // 
            this.ddlBranchIU.DataSource = this.bRANCHBindingSource;
            this.ddlBranchIU.DisplayMember = "BranchCity";
            this.ddlBranchIU.FormattingEnabled = true;
            this.ddlBranchIU.Location = new System.Drawing.Point(89, 85);
            this.ddlBranchIU.Name = "ddlBranchIU";
            this.ddlBranchIU.Size = new System.Drawing.Size(146, 23);
            this.ddlBranchIU.TabIndex = 27;
            this.ddlBranchIU.ValueMember = "BranchId";
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
            // lblBranchInsert
            // 
            this.lblBranchInsert.AutoSize = true;
            this.lblBranchInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchInsert.Location = new System.Drawing.Point(4, 86);
            this.lblBranchInsert.Name = "lblBranchInsert";
            this.lblBranchInsert.Size = new System.Drawing.Size(46, 15);
            this.lblBranchInsert.TabIndex = 26;
            this.lblBranchInsert.Text = "Branch";
            // 
            // ddlSupervisorIU
            // 
            this.ddlSupervisorIU.DataSource = this.sTAFFBindingSource;
            this.ddlSupervisorIU.DisplayMember = "StaffLname";
            this.ddlSupervisorIU.FormattingEnabled = true;
            this.ddlSupervisorIU.Location = new System.Drawing.Point(89, 52);
            this.ddlSupervisorIU.Name = "ddlSupervisorIU";
            this.ddlSupervisorIU.Size = new System.Drawing.Size(146, 23);
            this.ddlSupervisorIU.TabIndex = 25;
            this.ddlSupervisorIU.ValueMember = "StaffId";
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.dsNationalRealtors;
            // 
            // lblSupervisorInsert
            // 
            this.lblSupervisorInsert.AutoSize = true;
            this.lblSupervisorInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisorInsert.Location = new System.Drawing.Point(4, 54);
            this.lblSupervisorInsert.Name = "lblSupervisorInsert";
            this.lblSupervisorInsert.Size = new System.Drawing.Size(83, 15);
            this.lblSupervisorInsert.TabIndex = 24;
            this.lblSupervisorInsert.Text = "Supervised by";
            // 
            // ddlPositionIU
            // 
            this.ddlPositionIU.DataSource = this.sTAFFCLASSBindingSource;
            this.ddlPositionIU.DisplayMember = "StaffPosition";
            this.ddlPositionIU.FormattingEnabled = true;
            this.ddlPositionIU.Location = new System.Drawing.Point(89, 19);
            this.ddlPositionIU.Name = "ddlPositionIU";
            this.ddlPositionIU.Size = new System.Drawing.Size(146, 23);
            this.ddlPositionIU.TabIndex = 23;
            this.ddlPositionIU.ValueMember = "StaffClassId";
            // 
            // sTAFFCLASSBindingSource
            // 
            this.sTAFFCLASSBindingSource.DataMember = "STAFF_CLASS";
            this.sTAFFCLASSBindingSource.DataSource = this.dsNationalRealtors;
            // 
            // lblPositionInsert
            // 
            this.lblPositionInsert.AutoSize = true;
            this.lblPositionInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionInsert.Location = new System.Drawing.Point(4, 22);
            this.lblPositionInsert.Name = "lblPositionInsert";
            this.lblPositionInsert.Size = new System.Drawing.Size(51, 15);
            this.lblPositionInsert.TabIndex = 22;
            this.lblPositionInsert.Text = "Position";
            // 
            // dtpStartDateIU
            // 
            this.dtpStartDateIU.Location = new System.Drawing.Point(89, 118);
            this.dtpStartDateIU.Name = "dtpStartDateIU";
            this.dtpStartDateIU.Size = new System.Drawing.Size(146, 21);
            this.dtpStartDateIU.TabIndex = 21;
            // 
            // lblStartDateInsert
            // 
            this.lblStartDateInsert.AutoSize = true;
            this.lblStartDateInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDateInsert.Location = new System.Drawing.Point(6, 118);
            this.lblStartDateInsert.Name = "lblStartDateInsert";
            this.lblStartDateInsert.Size = new System.Drawing.Size(59, 15);
            this.lblStartDateInsert.TabIndex = 20;
            this.lblStartDateInsert.Text = "Start date";
            // 
            // dtpStaffDOB
            // 
            this.dtpStaffDOB.Enabled = false;
            this.dtpStaffDOB.Location = new System.Drawing.Point(86, 170);
            this.dtpStaffDOB.Name = "dtpStaffDOB";
            this.dtpStaffDOB.Size = new System.Drawing.Size(151, 21);
            this.dtpStaffDOB.TabIndex = 25;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(7, 173);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(73, 15);
            this.lblDateOfBirth.TabIndex = 10;
            this.lblDateOfBirth.Text = "Date of birth";
            // 
            // txtStaffGender
            // 
            this.txtStaffGender.Location = new System.Drawing.Point(86, 140);
            this.txtStaffGender.Name = "txtStaffGender";
            this.txtStaffGender.Size = new System.Drawing.Size(151, 21);
            this.txtStaffGender.TabIndex = 9;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(7, 143);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender";
            // 
            // txtStaffFirstName
            // 
            this.txtStaffFirstName.Location = new System.Drawing.Point(86, 110);
            this.txtStaffFirstName.Name = "txtStaffFirstName";
            this.txtStaffFirstName.Size = new System.Drawing.Size(151, 21);
            this.txtStaffFirstName.TabIndex = 7;
            // 
            // lblStaffFname
            // 
            this.lblStaffFname.AutoSize = true;
            this.lblStaffFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffFname.Location = new System.Drawing.Point(7, 113);
            this.lblStaffFname.Name = "lblStaffFname";
            this.lblStaffFname.Size = new System.Drawing.Size(65, 15);
            this.lblStaffFname.TabIndex = 6;
            this.lblStaffFname.Text = "First name";
            // 
            // txtStaffLname
            // 
            this.txtStaffLname.Location = new System.Drawing.Point(86, 80);
            this.txtStaffLname.Name = "txtStaffLname";
            this.txtStaffLname.Size = new System.Drawing.Size(151, 21);
            this.txtStaffLname.TabIndex = 5;
            // 
            // lblStaffLastName
            // 
            this.lblStaffLastName.AutoSize = true;
            this.lblStaffLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffLastName.Location = new System.Drawing.Point(7, 83);
            this.lblStaffLastName.Name = "lblStaffLastName";
            this.lblStaffLastName.Size = new System.Drawing.Size(65, 15);
            this.lblStaffLastName.TabIndex = 4;
            this.lblStaffLastName.Text = "Last name";
            // 
            // txtStaffTitle
            // 
            this.txtStaffTitle.Location = new System.Drawing.Point(86, 50);
            this.txtStaffTitle.Name = "txtStaffTitle";
            this.txtStaffTitle.Size = new System.Drawing.Size(151, 21);
            this.txtStaffTitle.TabIndex = 3;
            // 
            // lblStaffTitle
            // 
            this.lblStaffTitle.AutoSize = true;
            this.lblStaffTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffTitle.Location = new System.Drawing.Point(7, 53);
            this.lblStaffTitle.Name = "lblStaffTitle";
            this.lblStaffTitle.Size = new System.Drawing.Size(30, 15);
            this.lblStaffTitle.TabIndex = 2;
            this.lblStaffTitle.Text = "Title";
            // 
            // txtStaffNumber
            // 
            this.txtStaffNumber.Location = new System.Drawing.Point(86, 20);
            this.txtStaffNumber.Name = "txtStaffNumber";
            this.txtStaffNumber.Size = new System.Drawing.Size(151, 21);
            this.txtStaffNumber.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(7, 23);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 15);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(431, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Done";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 247);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(94, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // sTAFF_CLASSTableAdapter
            // 
            this.sTAFF_CLASSTableAdapter.ClearBeforeFill = true;
            // 
            // bRANCHTableAdapter
            // 
            this.bRANCHTableAdapter.ClearBeforeFill = true;
            // 
            // frmRegisterStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 276);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpbxStaffDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegisterStaff";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Staff Registration";
            this.Load += new System.EventHandler(this.frmRegisterStaff_Load);
            this.grpbxStaffDetails.ResumeLayout(false);
            this.grpbxStaffDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnStaff)).EndInit();
            this.bnStaff.ResumeLayout(false);
            this.bnStaff.PerformLayout();
            this.gpbxInsertUpdate.ResumeLayout(false);
            this.gpbxInsertUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFCLASSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxStaffDetails;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtStaffGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtStaffFirstName;
        private System.Windows.Forms.Label lblStaffFname;
        private System.Windows.Forms.TextBox txtStaffLname;
        private System.Windows.Forms.Label lblStaffLastName;
        private System.Windows.Forms.TextBox txtStaffTitle;
        private System.Windows.Forms.Label lblStaffTitle;
        private System.Windows.Forms.TextBox txtStaffNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpStaffDOB;
        private System.Windows.Forms.GroupBox gpbxInsertUpdate;
        private System.Windows.Forms.ComboBox ddlBranchIU;
        private System.Windows.Forms.Label lblBranchInsert;
        private System.Windows.Forms.ComboBox ddlSupervisorIU;
        private System.Windows.Forms.Label lblSupervisorInsert;
        private System.Windows.Forms.ComboBox ddlPositionIU;
        private System.Windows.Forms.Label lblPositionInsert;
        private System.Windows.Forms.DateTimePicker dtpStartDateIU;
        private System.Windows.Forms.Label lblStartDateInsert;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.BindingNavigator bnStaff;
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
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private dsNationalRealtorsTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.BindingSource sTAFFCLASSBindingSource;
        private dsNationalRealtorsTableAdapters.STAFF_CLASSTableAdapter sTAFF_CLASSTableAdapter;
        private System.Windows.Forms.BindingSource bRANCHBindingSource;
        private dsNationalRealtorsTableAdapters.BRANCHTableAdapter bRANCHTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}