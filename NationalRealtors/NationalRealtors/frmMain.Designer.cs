namespace NationalRealtors
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbxNR = new System.Windows.Forms.PictureBox();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpgHome = new System.Windows.Forms.TabPage();
            this.btnLeaseAgreement = new System.Windows.Forms.Button();
            this.btnAcceptPayment = new System.Windows.Forms.Button();
            this.btnViewing = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpbxClients = new System.Windows.Forms.GroupBox();
            this.btnRegisterClient = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.grpbxProperties = new System.Windows.Forms.GroupBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ddlForRent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegisterProperty = new System.Windows.Forms.Button();
            this.dgvPropertyForRent = new System.Windows.Forms.DataGridView();
            this.tbpgManagement = new System.Windows.Forms.TabPage();
            this.grpbxStaff = new System.Windows.Forms.GroupBox();
            this.btnStaffClass = new System.Windows.Forms.Button();
            this.btnRegisterStaff = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.staffIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffSupervisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffClassIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.gpbxBranches = new System.Windows.Forms.GroupBox();
            this.btnRegisterBranch = new System.Windows.Forms.Button();
            this.dgvBranches = new System.Windows.Forms.DataGridView();
            this.branchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchPostCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRANCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbpgReports = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbxReports = new System.Windows.Forms.GroupBox();
            this.btnRentalDistrib = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnPropertyViewings = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnPropertyForRent = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.CLIENTTableAdapter();
            this.bRANCHTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.BRANCHTableAdapter();
            this.sTAFFTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.STAFFTableAdapter();
            this.btnComments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNR)).BeginInit();
            this.tbcMain.SuspendLayout();
            this.tbpgHome.SuspendLayout();
            this.grpbxClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.grpbxProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyForRent)).BeginInit();
            this.tbpgManagement.SuspendLayout();
            this.grpbxStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            this.gpbxBranches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHBindingSource)).BeginInit();
            this.tbpgReports.SuspendLayout();
            this.gpbxReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxNR
            // 
            this.pbxNR.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxNR.Image = ((System.Drawing.Image)(resources.GetObject("pbxNR.Image")));
            this.pbxNR.Location = new System.Drawing.Point(0, 0);
            this.pbxNR.Name = "pbxNR";
            this.pbxNR.Size = new System.Drawing.Size(135, 613);
            this.pbxNR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNR.TabIndex = 0;
            this.pbxNR.TabStop = false;
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpgHome);
            this.tbcMain.Controls.Add(this.tbpgManagement);
            this.tbcMain.Controls.Add(this.tbpgReports);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbcMain.Location = new System.Drawing.Point(135, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(702, 613);
            this.tbcMain.TabIndex = 1;
            // 
            // tbpgHome
            // 
            this.tbpgHome.Controls.Add(this.btnComments);
            this.tbpgHome.Controls.Add(this.btnLeaseAgreement);
            this.tbpgHome.Controls.Add(this.btnAcceptPayment);
            this.tbpgHome.Controls.Add(this.btnViewing);
            this.tbpgHome.Controls.Add(this.btnLogout);
            this.tbpgHome.Controls.Add(this.btnExit);
            this.tbpgHome.Controls.Add(this.grpbxClients);
            this.tbpgHome.Controls.Add(this.grpbxProperties);
            this.tbpgHome.Location = new System.Drawing.Point(4, 22);
            this.tbpgHome.Name = "tbpgHome";
            this.tbpgHome.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgHome.Size = new System.Drawing.Size(694, 587);
            this.tbpgHome.TabIndex = 0;
            this.tbpgHome.Text = "Home";
            this.tbpgHome.UseVisualStyleBackColor = true;
            // 
            // btnLeaseAgreement
            // 
            this.btnLeaseAgreement.Location = new System.Drawing.Point(114, 486);
            this.btnLeaseAgreement.Name = "btnLeaseAgreement";
            this.btnLeaseAgreement.Size = new System.Drawing.Size(98, 23);
            this.btnLeaseAgreement.TabIndex = 6;
            this.btnLeaseAgreement.Text = "Log a Lease";
            this.btnLeaseAgreement.UseVisualStyleBackColor = true;
            this.btnLeaseAgreement.Click += new System.EventHandler(this.btnLeaseAgreement_Click);
            // 
            // btnAcceptPayment
            // 
            this.btnAcceptPayment.Location = new System.Drawing.Point(218, 486);
            this.btnAcceptPayment.Name = "btnAcceptPayment";
            this.btnAcceptPayment.Size = new System.Drawing.Size(98, 23);
            this.btnAcceptPayment.TabIndex = 5;
            this.btnAcceptPayment.Text = "Accept Payment";
            this.btnAcceptPayment.UseVisualStyleBackColor = true;
            this.btnAcceptPayment.Click += new System.EventHandler(this.btnAcceptPayment_Click);
            // 
            // btnViewing
            // 
            this.btnViewing.Location = new System.Drawing.Point(10, 486);
            this.btnViewing.Name = "btnViewing";
            this.btnViewing.Size = new System.Drawing.Size(98, 23);
            this.btnViewing.TabIndex = 4;
            this.btnViewing.Text = "Log a Viewing";
            this.btnViewing.UseVisualStyleBackColor = true;
            this.btnViewing.Click += new System.EventHandler(this.btnViewing_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(524, 561);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(605, 561);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // grpbxClients
            // 
            this.grpbxClients.Controls.Add(this.btnRegisterClient);
            this.grpbxClients.Controls.Add(this.dgvClients);
            this.grpbxClients.Location = new System.Drawing.Point(7, 246);
            this.grpbxClients.Name = "grpbxClients";
            this.grpbxClients.Size = new System.Drawing.Size(679, 233);
            this.grpbxClients.TabIndex = 1;
            this.grpbxClients.TabStop = false;
            this.grpbxClients.Text = "Clients wishing to Rent";
            // 
            // btnRegisterClient
            // 
            this.btnRegisterClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterClient.Location = new System.Drawing.Point(576, 17);
            this.btnRegisterClient.Name = "btnRegisterClient";
            this.btnRegisterClient.Size = new System.Drawing.Size(97, 23);
            this.btnRegisterClient.TabIndex = 2;
            this.btnRegisterClient.Text = "Register Client";
            this.btnRegisterClient.UseVisualStyleBackColor = true;
            this.btnRegisterClient.Click += new System.EventHandler(this.btnRegisterClient_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClients.Location = new System.Drawing.Point(3, 48);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.Size = new System.Drawing.Size(673, 182);
            this.dgvClients.TabIndex = 0;
            // 
            // grpbxProperties
            // 
            this.grpbxProperties.Controls.Add(this.btnAll);
            this.grpbxProperties.Controls.Add(this.btnSearch);
            this.grpbxProperties.Controls.Add(this.ddlForRent);
            this.grpbxProperties.Controls.Add(this.label2);
            this.grpbxProperties.Controls.Add(this.txtCity);
            this.grpbxProperties.Controls.Add(this.label1);
            this.grpbxProperties.Controls.Add(this.btnRegisterProperty);
            this.grpbxProperties.Controls.Add(this.dgvPropertyForRent);
            this.grpbxProperties.Location = new System.Drawing.Point(7, 7);
            this.grpbxProperties.Name = "grpbxProperties";
            this.grpbxProperties.Size = new System.Drawing.Size(679, 233);
            this.grpbxProperties.TabIndex = 0;
            this.grpbxProperties.TabStop = false;
            this.grpbxProperties.Text = "Properties for Rent";
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(378, 19);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 7;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(297, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ddlForRent
            // 
            this.ddlForRent.FormattingEnabled = true;
            this.ddlForRent.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.ddlForRent.Location = new System.Drawing.Point(191, 21);
            this.ddlForRent.Name = "ddlForRent";
            this.ddlForRent.Size = new System.Drawing.Size(100, 21);
            this.ddlForRent.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "For rent";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(36, 22);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "City";
            // 
            // btnRegisterProperty
            // 
            this.btnRegisterProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterProperty.Location = new System.Drawing.Point(576, 19);
            this.btnRegisterProperty.Name = "btnRegisterProperty";
            this.btnRegisterProperty.Size = new System.Drawing.Size(97, 23);
            this.btnRegisterProperty.TabIndex = 1;
            this.btnRegisterProperty.Text = "Register Property";
            this.btnRegisterProperty.UseVisualStyleBackColor = true;
            this.btnRegisterProperty.Click += new System.EventHandler(this.btnRegisterProperty_Click);
            // 
            // dgvPropertyForRent
            // 
            this.dgvPropertyForRent.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPropertyForRent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPropertyForRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertyForRent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPropertyForRent.Location = new System.Drawing.Point(3, 48);
            this.dgvPropertyForRent.Name = "dgvPropertyForRent";
            this.dgvPropertyForRent.ReadOnly = true;
            this.dgvPropertyForRent.Size = new System.Drawing.Size(673, 182);
            this.dgvPropertyForRent.TabIndex = 0;
            // 
            // tbpgManagement
            // 
            this.tbpgManagement.Controls.Add(this.grpbxStaff);
            this.tbpgManagement.Controls.Add(this.gpbxBranches);
            this.tbpgManagement.Location = new System.Drawing.Point(4, 22);
            this.tbpgManagement.Name = "tbpgManagement";
            this.tbpgManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgManagement.Size = new System.Drawing.Size(694, 587);
            this.tbpgManagement.TabIndex = 1;
            this.tbpgManagement.Text = "Manage";
            this.tbpgManagement.UseVisualStyleBackColor = true;
            // 
            // grpbxStaff
            // 
            this.grpbxStaff.Controls.Add(this.btnStaffClass);
            this.grpbxStaff.Controls.Add(this.btnRegisterStaff);
            this.grpbxStaff.Controls.Add(this.dgvStaff);
            this.grpbxStaff.Location = new System.Drawing.Point(3, 284);
            this.grpbxStaff.Name = "grpbxStaff";
            this.grpbxStaff.Size = new System.Drawing.Size(679, 272);
            this.grpbxStaff.TabIndex = 2;
            this.grpbxStaff.TabStop = false;
            this.grpbxStaff.Text = "Staff";
            // 
            // btnStaffClass
            // 
            this.btnStaffClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStaffClass.Location = new System.Drawing.Point(473, 19);
            this.btnStaffClass.Name = "btnStaffClass";
            this.btnStaffClass.Size = new System.Drawing.Size(97, 23);
            this.btnStaffClass.TabIndex = 2;
            this.btnStaffClass.Text = "Classifications";
            this.btnStaffClass.UseVisualStyleBackColor = true;
            this.btnStaffClass.Click += new System.EventHandler(this.btnStaffClass_Click);
            // 
            // btnRegisterStaff
            // 
            this.btnRegisterStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterStaff.Location = new System.Drawing.Point(576, 19);
            this.btnRegisterStaff.Name = "btnRegisterStaff";
            this.btnRegisterStaff.Size = new System.Drawing.Size(97, 23);
            this.btnRegisterStaff.TabIndex = 1;
            this.btnRegisterStaff.Text = "Register Staff";
            this.btnRegisterStaff.UseVisualStyleBackColor = true;
            this.btnRegisterStaff.Click += new System.EventHandler(this.btnRegisterStaff_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AutoGenerateColumns = false;
            this.dgvStaff.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIdDataGridViewTextBoxColumn,
            this.staffNumberDataGridViewTextBoxColumn,
            this.staffTitleDataGridViewTextBoxColumn,
            this.staffLnameDataGridViewTextBoxColumn,
            this.staffFnameDataGridViewTextBoxColumn,
            this.staffGenderDataGridViewTextBoxColumn,
            this.staffDOBDataGridViewTextBoxColumn,
            this.staffStartDateDataGridViewTextBoxColumn,
            this.staffSupervisorDataGridViewTextBoxColumn,
            this.staffClassIdDataGridViewTextBoxColumn,
            this.branchIdDataGridViewTextBoxColumn1});
            this.dgvStaff.DataSource = this.sTAFFBindingSource;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStaff.Location = new System.Drawing.Point(3, 48);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.Size = new System.Drawing.Size(673, 221);
            this.dgvStaff.TabIndex = 0;
            // 
            // staffIdDataGridViewTextBoxColumn
            // 
            this.staffIdDataGridViewTextBoxColumn.DataPropertyName = "StaffId";
            this.staffIdDataGridViewTextBoxColumn.HeaderText = "StaffId";
            this.staffIdDataGridViewTextBoxColumn.Name = "staffIdDataGridViewTextBoxColumn";
            this.staffIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // staffNumberDataGridViewTextBoxColumn
            // 
            this.staffNumberDataGridViewTextBoxColumn.DataPropertyName = "StaffNumber";
            this.staffNumberDataGridViewTextBoxColumn.HeaderText = "Staff No";
            this.staffNumberDataGridViewTextBoxColumn.Name = "staffNumberDataGridViewTextBoxColumn";
            this.staffNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffTitleDataGridViewTextBoxColumn
            // 
            this.staffTitleDataGridViewTextBoxColumn.DataPropertyName = "StaffTitle";
            this.staffTitleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.staffTitleDataGridViewTextBoxColumn.Name = "staffTitleDataGridViewTextBoxColumn";
            this.staffTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffLnameDataGridViewTextBoxColumn
            // 
            this.staffLnameDataGridViewTextBoxColumn.DataPropertyName = "StaffLname";
            this.staffLnameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.staffLnameDataGridViewTextBoxColumn.Name = "staffLnameDataGridViewTextBoxColumn";
            this.staffLnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffFnameDataGridViewTextBoxColumn
            // 
            this.staffFnameDataGridViewTextBoxColumn.DataPropertyName = "StaffFname";
            this.staffFnameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.staffFnameDataGridViewTextBoxColumn.Name = "staffFnameDataGridViewTextBoxColumn";
            this.staffFnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffGenderDataGridViewTextBoxColumn
            // 
            this.staffGenderDataGridViewTextBoxColumn.DataPropertyName = "StaffGender";
            this.staffGenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.staffGenderDataGridViewTextBoxColumn.Name = "staffGenderDataGridViewTextBoxColumn";
            this.staffGenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffDOBDataGridViewTextBoxColumn
            // 
            this.staffDOBDataGridViewTextBoxColumn.DataPropertyName = "StaffDOB";
            this.staffDOBDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.staffDOBDataGridViewTextBoxColumn.Name = "staffDOBDataGridViewTextBoxColumn";
            this.staffDOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffStartDateDataGridViewTextBoxColumn
            // 
            this.staffStartDateDataGridViewTextBoxColumn.DataPropertyName = "StaffStartDate";
            this.staffStartDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.staffStartDateDataGridViewTextBoxColumn.Name = "staffStartDateDataGridViewTextBoxColumn";
            this.staffStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffSupervisorDataGridViewTextBoxColumn
            // 
            this.staffSupervisorDataGridViewTextBoxColumn.DataPropertyName = "StaffSupervisor";
            this.staffSupervisorDataGridViewTextBoxColumn.HeaderText = "StaffSupervisor";
            this.staffSupervisorDataGridViewTextBoxColumn.Name = "staffSupervisorDataGridViewTextBoxColumn";
            this.staffSupervisorDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffSupervisorDataGridViewTextBoxColumn.Visible = false;
            // 
            // staffClassIdDataGridViewTextBoxColumn
            // 
            this.staffClassIdDataGridViewTextBoxColumn.DataPropertyName = "StaffClassId";
            this.staffClassIdDataGridViewTextBoxColumn.HeaderText = "StaffClassId";
            this.staffClassIdDataGridViewTextBoxColumn.Name = "staffClassIdDataGridViewTextBoxColumn";
            this.staffClassIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffClassIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // branchIdDataGridViewTextBoxColumn1
            // 
            this.branchIdDataGridViewTextBoxColumn1.DataPropertyName = "BranchId";
            this.branchIdDataGridViewTextBoxColumn1.HeaderText = "BranchId";
            this.branchIdDataGridViewTextBoxColumn1.Name = "branchIdDataGridViewTextBoxColumn1";
            this.branchIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.branchIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.dsNationalRealtors;
            // 
            // dsNationalRealtors
            // 
            this.dsNationalRealtors.DataSetName = "dsNationalRealtors";
            this.dsNationalRealtors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gpbxBranches
            // 
            this.gpbxBranches.Controls.Add(this.btnRegisterBranch);
            this.gpbxBranches.Controls.Add(this.dgvBranches);
            this.gpbxBranches.Location = new System.Drawing.Point(3, 6);
            this.gpbxBranches.Name = "gpbxBranches";
            this.gpbxBranches.Size = new System.Drawing.Size(679, 272);
            this.gpbxBranches.TabIndex = 1;
            this.gpbxBranches.TabStop = false;
            this.gpbxBranches.Text = "Branches";
            // 
            // btnRegisterBranch
            // 
            this.btnRegisterBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterBranch.Location = new System.Drawing.Point(576, 19);
            this.btnRegisterBranch.Name = "btnRegisterBranch";
            this.btnRegisterBranch.Size = new System.Drawing.Size(97, 23);
            this.btnRegisterBranch.TabIndex = 1;
            this.btnRegisterBranch.Text = "Register Branch";
            this.btnRegisterBranch.UseVisualStyleBackColor = true;
            this.btnRegisterBranch.Click += new System.EventHandler(this.btnRegisterBranch_Click);
            // 
            // dgvBranches
            // 
            this.dgvBranches.AllowUserToAddRows = false;
            this.dgvBranches.AllowUserToDeleteRows = false;
            this.dgvBranches.AutoGenerateColumns = false;
            this.dgvBranches.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBranches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.branchIdDataGridViewTextBoxColumn,
            this.branchNumberDataGridViewTextBoxColumn,
            this.branchStreetDataGridViewTextBoxColumn,
            this.branchCityDataGridViewTextBoxColumn,
            this.branchPostCodeDataGridViewTextBoxColumn});
            this.dgvBranches.DataSource = this.bRANCHBindingSource;
            this.dgvBranches.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBranches.Location = new System.Drawing.Point(3, 48);
            this.dgvBranches.Name = "dgvBranches";
            this.dgvBranches.ReadOnly = true;
            this.dgvBranches.Size = new System.Drawing.Size(673, 221);
            this.dgvBranches.TabIndex = 0;
            // 
            // branchIdDataGridViewTextBoxColumn
            // 
            this.branchIdDataGridViewTextBoxColumn.DataPropertyName = "BranchId";
            this.branchIdDataGridViewTextBoxColumn.HeaderText = "BranchId";
            this.branchIdDataGridViewTextBoxColumn.Name = "branchIdDataGridViewTextBoxColumn";
            this.branchIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // branchNumberDataGridViewTextBoxColumn
            // 
            this.branchNumberDataGridViewTextBoxColumn.DataPropertyName = "BranchNumber";
            this.branchNumberDataGridViewTextBoxColumn.HeaderText = "Branch No";
            this.branchNumberDataGridViewTextBoxColumn.Name = "branchNumberDataGridViewTextBoxColumn";
            this.branchNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchStreetDataGridViewTextBoxColumn
            // 
            this.branchStreetDataGridViewTextBoxColumn.DataPropertyName = "BranchStreet";
            this.branchStreetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.branchStreetDataGridViewTextBoxColumn.Name = "branchStreetDataGridViewTextBoxColumn";
            this.branchStreetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchCityDataGridViewTextBoxColumn
            // 
            this.branchCityDataGridViewTextBoxColumn.DataPropertyName = "BranchCity";
            this.branchCityDataGridViewTextBoxColumn.HeaderText = "City";
            this.branchCityDataGridViewTextBoxColumn.Name = "branchCityDataGridViewTextBoxColumn";
            this.branchCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchPostCodeDataGridViewTextBoxColumn
            // 
            this.branchPostCodeDataGridViewTextBoxColumn.DataPropertyName = "BranchPostCode";
            this.branchPostCodeDataGridViewTextBoxColumn.HeaderText = "Postal Code";
            this.branchPostCodeDataGridViewTextBoxColumn.Name = "branchPostCodeDataGridViewTextBoxColumn";
            this.branchPostCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bRANCHBindingSource
            // 
            this.bRANCHBindingSource.DataMember = "BRANCH";
            this.bRANCHBindingSource.DataSource = this.dsNationalRealtors;
            // 
            // tbpgReports
            // 
            this.tbpgReports.Controls.Add(this.label4);
            this.tbpgReports.Controls.Add(this.label3);
            this.tbpgReports.Controls.Add(this.gpbxReports);
            this.tbpgReports.Location = new System.Drawing.Point(4, 22);
            this.tbpgReports.Name = "tbpgReports";
            this.tbpgReports.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgReports.Size = new System.Drawing.Size(694, 587);
            this.tbpgReports.TabIndex = 2;
            this.tbpgReports.Text = "Reports";
            this.tbpgReports.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reports";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "National Realtors";
            // 
            // gpbxReports
            // 
            this.gpbxReports.Controls.Add(this.btnRentalDistrib);
            this.gpbxReports.Controls.Add(this.btnRental);
            this.gpbxReports.Controls.Add(this.btnPropertyViewings);
            this.gpbxReports.Controls.Add(this.btnProperty);
            this.gpbxReports.Controls.Add(this.btnPropertyForRent);
            this.gpbxReports.Controls.Add(this.btnClients);
            this.gpbxReports.Location = new System.Drawing.Point(137, 69);
            this.gpbxReports.Name = "gpbxReports";
            this.gpbxReports.Size = new System.Drawing.Size(421, 278);
            this.gpbxReports.TabIndex = 0;
            this.gpbxReports.TabStop = false;
            // 
            // btnRentalDistrib
            // 
            this.btnRentalDistrib.Location = new System.Drawing.Point(213, 157);
            this.btnRentalDistrib.Name = "btnRentalDistrib";
            this.btnRentalDistrib.Size = new System.Drawing.Size(104, 23);
            this.btnRentalDistrib.TabIndex = 5;
            this.btnRentalDistrib.Text = "Rental distribution";
            this.btnRentalDistrib.UseVisualStyleBackColor = true;
            this.btnRentalDistrib.Click += new System.EventHandler(this.btnRentalDistrib_Click);
            // 
            // btnRental
            // 
            this.btnRental.Location = new System.Drawing.Point(213, 128);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(104, 23);
            this.btnRental.TabIndex = 4;
            this.btnRental.Text = "Rental";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // btnPropertyViewings
            // 
            this.btnPropertyViewings.Location = new System.Drawing.Point(213, 99);
            this.btnPropertyViewings.Name = "btnPropertyViewings";
            this.btnPropertyViewings.Size = new System.Drawing.Size(104, 23);
            this.btnPropertyViewings.TabIndex = 3;
            this.btnPropertyViewings.Text = "Property viewings";
            this.btnPropertyViewings.UseVisualStyleBackColor = true;
            this.btnPropertyViewings.Click += new System.EventHandler(this.btnPropertyViewings_Click);
            // 
            // btnProperty
            // 
            this.btnProperty.Location = new System.Drawing.Point(103, 157);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(104, 23);
            this.btnProperty.TabIndex = 2;
            this.btnProperty.Text = "Property";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnPropertyForRent
            // 
            this.btnPropertyForRent.Location = new System.Drawing.Point(103, 128);
            this.btnPropertyForRent.Name = "btnPropertyForRent";
            this.btnPropertyForRent.Size = new System.Drawing.Size(104, 23);
            this.btnPropertyForRent.TabIndex = 1;
            this.btnPropertyForRent.Text = "Property for Rent";
            this.btnPropertyForRent.UseVisualStyleBackColor = true;
            this.btnPropertyForRent.Click += new System.EventHandler(this.btnPropertyForRent_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(103, 99);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(104, 23);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
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
            // bRANCHTableAdapter
            // 
            this.bRANCHTableAdapter.ClearBeforeFill = true;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // btnComments
            // 
            this.btnComments.Location = new System.Drawing.Point(10, 515);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(98, 23);
            this.btnComments.TabIndex = 7;
            this.btnComments.Text = "Comments";
            this.btnComments.UseVisualStyleBackColor = true;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 613);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.pbxNR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NR Management System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNR)).EndInit();
            this.tbcMain.ResumeLayout(false);
            this.tbpgHome.ResumeLayout(false);
            this.grpbxClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.grpbxProperties.ResumeLayout(false);
            this.grpbxProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyForRent)).EndInit();
            this.tbpgManagement.ResumeLayout(false);
            this.grpbxStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            this.gpbxBranches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRANCHBindingSource)).EndInit();
            this.tbpgReports.ResumeLayout(false);
            this.tbpgReports.PerformLayout();
            this.gpbxReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxNR;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpgHome;
        private System.Windows.Forms.TabPage tbpgManagement;
        private System.Windows.Forms.GroupBox grpbxProperties;
        private System.Windows.Forms.DataGridView dgvPropertyForRent;
        private System.Windows.Forms.GroupBox grpbxClients;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnRegisterClient;
        private System.Windows.Forms.Button btnRegisterProperty;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAcceptPayment;
        private System.Windows.Forms.Button btnViewing;
        private System.Windows.Forms.GroupBox grpbxStaff;
        private System.Windows.Forms.Button btnRegisterStaff;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.GroupBox gpbxBranches;
        private System.Windows.Forms.Button btnRegisterBranch;
        private System.Windows.Forms.DataGridView dgvBranches;
        private System.Windows.Forms.Button btnLeaseAgreement;
        private System.Windows.Forms.Button btnStaffClass;
        private System.Windows.Forms.TabPage tbpgReports;
        private System.Windows.Forms.GroupBox gpbxReports;
        private System.Windows.Forms.Button btnRentalDistrib;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnPropertyViewings;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnPropertyForRent;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox ddlForRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label1;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private dsNationalRealtorsTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.BindingSource bRANCHBindingSource;
        private dsNationalRealtorsTableAdapters.BRANCHTableAdapter bRANCHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchPostCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private dsNationalRealtorsTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffSupervisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffClassIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComments;


    }
}

