namespace NationalRealtors
{
    partial class frmRegisterProperty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterProperty));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpbxOwnerDetails = new System.Windows.Forms.GroupBox();
            this.ddlOwnerType = new System.Windows.Forms.ComboBox();
            this.lblOwnerType = new System.Windows.Forms.Label();
            this.lblOwnerId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnOwner = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dgvOwnerTelNum = new System.Windows.Forms.DataGridView();
            this.grpbxBusiness = new System.Windows.Forms.GroupBox();
            this.lblCntctFName = new System.Windows.Forms.Label();
            this.lblCntctLName = new System.Windows.Forms.Label();
            this.txtContactFirstName = new System.Windows.Forms.TextBox();
            this.txtContactLastName = new System.Windows.Forms.TextBox();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.lblBusName = new System.Windows.Forms.Label();
            this.txtBusinessType = new System.Windows.Forms.TextBox();
            this.lblBusType = new System.Windows.Forms.Label();
            this.grpbxIndividual = new System.Windows.Forms.GroupBox();
            this.txtIndividualFirstName = new System.Windows.Forms.TextBox();
            this.lblIndividualFirstName = new System.Windows.Forms.Label();
            this.txtIndividualLastName = new System.Windows.Forms.TextBox();
            this.lblIndividualLastName = new System.Windows.Forms.Label();
            this.lblOwnerPostCode = new System.Windows.Forms.Label();
            this.lblOwnerCity = new System.Windows.Forms.Label();
            this.txtOwnerPostCode = new System.Windows.Forms.TextBox();
            this.txtOwnerCity = new System.Windows.Forms.TextBox();
            this.txtOwnerStreet = new System.Windows.Forms.TextBox();
            this.lblOwnerStreet = new System.Windows.Forms.Label();
            this.txtOwnerNumber = new System.Windows.Forms.TextBox();
            this.lblOwnerNumber = new System.Windows.Forms.Label();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnUpdateOwner = new System.Windows.Forms.Button();
            this.btnSaveOwner = new System.Windows.Forms.Button();
            this.btnTelephoneNumbers = new System.Windows.Forms.Button();
            this.btnManagePropertyTypes = new System.Windows.Forms.Button();
            this.btnPropertyDetails = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.AreaCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbxOwnerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOwner)).BeginInit();
            this.bnOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerTelNum)).BeginInit();
            this.grpbxBusiness.SuspendLayout();
            this.grpbxIndividual.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxOwnerDetails
            // 
            this.grpbxOwnerDetails.Controls.Add(this.ddlOwnerType);
            this.grpbxOwnerDetails.Controls.Add(this.lblOwnerType);
            this.grpbxOwnerDetails.Controls.Add(this.lblOwnerId);
            this.grpbxOwnerDetails.Controls.Add(this.label1);
            this.grpbxOwnerDetails.Controls.Add(this.bnOwner);
            this.grpbxOwnerDetails.Controls.Add(this.dgvOwnerTelNum);
            this.grpbxOwnerDetails.Controls.Add(this.grpbxBusiness);
            this.grpbxOwnerDetails.Controls.Add(this.grpbxIndividual);
            this.grpbxOwnerDetails.Controls.Add(this.lblOwnerPostCode);
            this.grpbxOwnerDetails.Controls.Add(this.lblOwnerCity);
            this.grpbxOwnerDetails.Controls.Add(this.txtOwnerPostCode);
            this.grpbxOwnerDetails.Controls.Add(this.txtOwnerCity);
            this.grpbxOwnerDetails.Controls.Add(this.txtOwnerStreet);
            this.grpbxOwnerDetails.Controls.Add(this.lblOwnerStreet);
            this.grpbxOwnerDetails.Controls.Add(this.txtOwnerNumber);
            this.grpbxOwnerDetails.Controls.Add(this.lblOwnerNumber);
            this.grpbxOwnerDetails.Location = new System.Drawing.Point(12, 42);
            this.grpbxOwnerDetails.Name = "grpbxOwnerDetails";
            this.grpbxOwnerDetails.Size = new System.Drawing.Size(521, 276);
            this.grpbxOwnerDetails.TabIndex = 8;
            this.grpbxOwnerDetails.TabStop = false;
            // 
            // ddlOwnerType
            // 
            this.ddlOwnerType.FormattingEnabled = true;
            this.ddlOwnerType.Items.AddRange(new object[] {
            "Individual",
            "Business"});
            this.ddlOwnerType.Location = new System.Drawing.Point(114, 152);
            this.ddlOwnerType.Name = "ddlOwnerType";
            this.ddlOwnerType.Size = new System.Drawing.Size(130, 21);
            this.ddlOwnerType.TabIndex = 27;
            this.ddlOwnerType.SelectedValueChanged += new System.EventHandler(this.ddlOwnerType_SelectedValueChanged);
            // 
            // lblOwnerType
            // 
            this.lblOwnerType.AutoSize = true;
            this.lblOwnerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerType.Location = new System.Drawing.Point(7, 152);
            this.lblOwnerType.Name = "lblOwnerType";
            this.lblOwnerType.Size = new System.Drawing.Size(68, 15);
            this.lblOwnerType.TabIndex = 26;
            this.lblOwnerType.Text = "Owner type";
            // 
            // lblOwnerId
            // 
            this.lblOwnerId.AutoSize = true;
            this.lblOwnerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerId.Location = new System.Drawing.Point(125, 16);
            this.lblOwnerId.Name = "lblOwnerId";
            this.lblOwnerId.Size = new System.Drawing.Size(19, 15);
            this.lblOwnerId.TabIndex = 25;
            this.lblOwnerId.Text = "....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Owner ID";
            // 
            // bnOwner
            // 
            this.bnOwner.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnOwner.CountItem = this.bindingNavigatorCountItem;
            this.bnOwner.DeleteItem = null;
            this.bnOwner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnOwner.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnOwner.Location = new System.Drawing.Point(3, 248);
            this.bnOwner.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnOwner.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnOwner.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnOwner.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnOwner.Name = "bnOwner";
            this.bnOwner.PositionItem = this.bindingNavigatorPositionItem;
            this.bnOwner.Size = new System.Drawing.Size(515, 25);
            this.bnOwner.TabIndex = 23;
            this.bnOwner.Text = "bindingNavigator1";
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
            // dgvOwnerTelNum
            // 
            this.dgvOwnerTelNum.AllowUserToAddRows = false;
            this.dgvOwnerTelNum.AllowUserToDeleteRows = false;
            this.dgvOwnerTelNum.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvOwnerTelNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwnerTelNum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AreaCode,
            this.Number});
            this.dgvOwnerTelNum.Location = new System.Drawing.Point(254, 16);
            this.dgvOwnerTelNum.Name = "dgvOwnerTelNum";
            this.dgvOwnerTelNum.ReadOnly = true;
            this.dgvOwnerTelNum.Size = new System.Drawing.Size(259, 98);
            this.dgvOwnerTelNum.TabIndex = 22;
            // 
            // grpbxBusiness
            // 
            this.grpbxBusiness.Controls.Add(this.lblCntctFName);
            this.grpbxBusiness.Controls.Add(this.lblCntctLName);
            this.grpbxBusiness.Controls.Add(this.txtContactFirstName);
            this.grpbxBusiness.Controls.Add(this.txtContactLastName);
            this.grpbxBusiness.Controls.Add(this.txtBusinessName);
            this.grpbxBusiness.Controls.Add(this.lblBusName);
            this.grpbxBusiness.Controls.Add(this.txtBusinessType);
            this.grpbxBusiness.Controls.Add(this.lblBusType);
            this.grpbxBusiness.Enabled = false;
            this.grpbxBusiness.Location = new System.Drawing.Point(253, 116);
            this.grpbxBusiness.Name = "grpbxBusiness";
            this.grpbxBusiness.Size = new System.Drawing.Size(260, 126);
            this.grpbxBusiness.TabIndex = 12;
            this.grpbxBusiness.TabStop = false;
            // 
            // lblCntctFName
            // 
            this.lblCntctFName.AutoSize = true;
            this.lblCntctFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCntctFName.Location = new System.Drawing.Point(6, 95);
            this.lblCntctFName.Name = "lblCntctFName";
            this.lblCntctFName.Size = new System.Drawing.Size(105, 15);
            this.lblCntctFName.TabIndex = 18;
            this.lblCntctFName.Text = "Contact first name";
            // 
            // lblCntctLName
            // 
            this.lblCntctLName.AutoSize = true;
            this.lblCntctLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCntctLName.Location = new System.Drawing.Point(6, 69);
            this.lblCntctLName.Name = "lblCntctLName";
            this.lblCntctLName.Size = new System.Drawing.Size(105, 15);
            this.lblCntctLName.TabIndex = 17;
            this.lblCntctLName.Text = "Contact last name";
            // 
            // txtContactFirstName
            // 
            this.txtContactFirstName.Location = new System.Drawing.Point(117, 94);
            this.txtContactFirstName.Name = "txtContactFirstName";
            this.txtContactFirstName.Size = new System.Drawing.Size(128, 20);
            this.txtContactFirstName.TabIndex = 16;
            // 
            // txtContactLastName
            // 
            this.txtContactLastName.Location = new System.Drawing.Point(117, 68);
            this.txtContactLastName.Name = "txtContactLastName";
            this.txtContactLastName.Size = new System.Drawing.Size(128, 20);
            this.txtContactLastName.TabIndex = 15;
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Location = new System.Drawing.Point(117, 42);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(128, 20);
            this.txtBusinessName.TabIndex = 14;
            // 
            // lblBusName
            // 
            this.lblBusName.AutoSize = true;
            this.lblBusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusName.Location = new System.Drawing.Point(6, 43);
            this.lblBusName.Name = "lblBusName";
            this.lblBusName.Size = new System.Drawing.Size(92, 15);
            this.lblBusName.TabIndex = 13;
            this.lblBusName.Text = "Business name";
            // 
            // txtBusinessType
            // 
            this.txtBusinessType.Location = new System.Drawing.Point(117, 16);
            this.txtBusinessType.Name = "txtBusinessType";
            this.txtBusinessType.Size = new System.Drawing.Size(128, 20);
            this.txtBusinessType.TabIndex = 12;
            // 
            // lblBusType
            // 
            this.lblBusType.AutoSize = true;
            this.lblBusType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusType.Location = new System.Drawing.Point(6, 17);
            this.lblBusType.Name = "lblBusType";
            this.lblBusType.Size = new System.Drawing.Size(82, 15);
            this.lblBusType.TabIndex = 9;
            this.lblBusType.Text = "Business type";
            // 
            // grpbxIndividual
            // 
            this.grpbxIndividual.Controls.Add(this.txtIndividualFirstName);
            this.grpbxIndividual.Controls.Add(this.lblIndividualFirstName);
            this.grpbxIndividual.Controls.Add(this.txtIndividualLastName);
            this.grpbxIndividual.Controls.Add(this.lblIndividualLastName);
            this.grpbxIndividual.Enabled = false;
            this.grpbxIndividual.Location = new System.Drawing.Point(6, 170);
            this.grpbxIndividual.Name = "grpbxIndividual";
            this.grpbxIndividual.Size = new System.Drawing.Size(244, 72);
            this.grpbxIndividual.TabIndex = 11;
            this.grpbxIndividual.TabStop = false;
            // 
            // txtIndividualFirstName
            // 
            this.txtIndividualFirstName.Location = new System.Drawing.Point(108, 37);
            this.txtIndividualFirstName.Name = "txtIndividualFirstName";
            this.txtIndividualFirstName.Size = new System.Drawing.Size(130, 20);
            this.txtIndividualFirstName.TabIndex = 11;
            // 
            // lblIndividualFirstName
            // 
            this.lblIndividualFirstName.AutoSize = true;
            this.lblIndividualFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndividualFirstName.Location = new System.Drawing.Point(1, 38);
            this.lblIndividualFirstName.Name = "lblIndividualFirstName";
            this.lblIndividualFirstName.Size = new System.Drawing.Size(65, 15);
            this.lblIndividualFirstName.TabIndex = 10;
            this.lblIndividualFirstName.Text = "First name";
            // 
            // txtIndividualLastName
            // 
            this.txtIndividualLastName.Location = new System.Drawing.Point(108, 11);
            this.txtIndividualLastName.Name = "txtIndividualLastName";
            this.txtIndividualLastName.Size = new System.Drawing.Size(130, 20);
            this.txtIndividualLastName.TabIndex = 9;
            // 
            // lblIndividualLastName
            // 
            this.lblIndividualLastName.AutoSize = true;
            this.lblIndividualLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndividualLastName.Location = new System.Drawing.Point(1, 12);
            this.lblIndividualLastName.Name = "lblIndividualLastName";
            this.lblIndividualLastName.Size = new System.Drawing.Size(65, 15);
            this.lblIndividualLastName.TabIndex = 8;
            this.lblIndividualLastName.Text = "Last name";
            // 
            // lblOwnerPostCode
            // 
            this.lblOwnerPostCode.AutoSize = true;
            this.lblOwnerPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerPostCode.Location = new System.Drawing.Point(7, 117);
            this.lblOwnerPostCode.Name = "lblOwnerPostCode";
            this.lblOwnerPostCode.Size = new System.Drawing.Size(71, 15);
            this.lblOwnerPostCode.TabIndex = 7;
            this.lblOwnerPostCode.Text = "Postal code";
            // 
            // lblOwnerCity
            // 
            this.lblOwnerCity.AutoSize = true;
            this.lblOwnerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerCity.Location = new System.Drawing.Point(7, 87);
            this.lblOwnerCity.Name = "lblOwnerCity";
            this.lblOwnerCity.Size = new System.Drawing.Size(26, 15);
            this.lblOwnerCity.TabIndex = 6;
            this.lblOwnerCity.Text = "City";
            // 
            // txtOwnerPostCode
            // 
            this.txtOwnerPostCode.Location = new System.Drawing.Point(114, 112);
            this.txtOwnerPostCode.Name = "txtOwnerPostCode";
            this.txtOwnerPostCode.Size = new System.Drawing.Size(130, 20);
            this.txtOwnerPostCode.TabIndex = 5;
            // 
            // txtOwnerCity
            // 
            this.txtOwnerCity.Location = new System.Drawing.Point(114, 86);
            this.txtOwnerCity.Name = "txtOwnerCity";
            this.txtOwnerCity.Size = new System.Drawing.Size(130, 20);
            this.txtOwnerCity.TabIndex = 4;
            // 
            // txtOwnerStreet
            // 
            this.txtOwnerStreet.Location = new System.Drawing.Point(114, 60);
            this.txtOwnerStreet.Name = "txtOwnerStreet";
            this.txtOwnerStreet.Size = new System.Drawing.Size(130, 20);
            this.txtOwnerStreet.TabIndex = 3;
            // 
            // lblOwnerStreet
            // 
            this.lblOwnerStreet.AutoSize = true;
            this.lblOwnerStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerStreet.Location = new System.Drawing.Point(7, 61);
            this.lblOwnerStreet.Name = "lblOwnerStreet";
            this.lblOwnerStreet.Size = new System.Drawing.Size(39, 15);
            this.lblOwnerStreet.TabIndex = 2;
            this.lblOwnerStreet.Text = "Street";
            // 
            // txtOwnerNumber
            // 
            this.txtOwnerNumber.Location = new System.Drawing.Point(114, 34);
            this.txtOwnerNumber.Name = "txtOwnerNumber";
            this.txtOwnerNumber.Size = new System.Drawing.Size(130, 20);
            this.txtOwnerNumber.TabIndex = 1;
            // 
            // lblOwnerNumber
            // 
            this.lblOwnerNumber.AutoSize = true;
            this.lblOwnerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerNumber.Location = new System.Drawing.Point(7, 34);
            this.lblOwnerNumber.Name = "lblOwnerNumber";
            this.lblOwnerNumber.Size = new System.Drawing.Size(89, 15);
            this.lblOwnerNumber.TabIndex = 0;
            this.lblOwnerNumber.Text = "Owner number";
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Location = new System.Drawing.Point(196, 318);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(86, 23);
            this.btnDeleteOwner.TabIndex = 20;
            this.btnDeleteOwner.Text = "Delete";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_Click);
            // 
            // btnUpdateOwner
            // 
            this.btnUpdateOwner.Location = new System.Drawing.Point(104, 318);
            this.btnUpdateOwner.Name = "btnUpdateOwner";
            this.btnUpdateOwner.Size = new System.Drawing.Size(86, 23);
            this.btnUpdateOwner.TabIndex = 19;
            this.btnUpdateOwner.Text = "Update";
            this.btnUpdateOwner.UseVisualStyleBackColor = true;
            this.btnUpdateOwner.Click += new System.EventHandler(this.btnUpdateOwner_Click);
            // 
            // btnSaveOwner
            // 
            this.btnSaveOwner.Enabled = false;
            this.btnSaveOwner.Location = new System.Drawing.Point(12, 318);
            this.btnSaveOwner.Name = "btnSaveOwner";
            this.btnSaveOwner.Size = new System.Drawing.Size(86, 23);
            this.btnSaveOwner.TabIndex = 11;
            this.btnSaveOwner.Text = "Save";
            this.btnSaveOwner.UseVisualStyleBackColor = true;
            this.btnSaveOwner.Click += new System.EventHandler(this.btnSaveOwner_Click);
            // 
            // btnTelephoneNumbers
            // 
            this.btnTelephoneNumbers.Location = new System.Drawing.Point(301, 13);
            this.btnTelephoneNumbers.Name = "btnTelephoneNumbers";
            this.btnTelephoneNumbers.Size = new System.Drawing.Size(109, 23);
            this.btnTelephoneNumbers.TabIndex = 18;
            this.btnTelephoneNumbers.Text = "Telephone number";
            this.btnTelephoneNumbers.UseVisualStyleBackColor = true;
            this.btnTelephoneNumbers.Click += new System.EventHandler(this.btnTelephoneNumbers_Click);
            // 
            // btnManagePropertyTypes
            // 
            this.btnManagePropertyTypes.Location = new System.Drawing.Point(12, 13);
            this.btnManagePropertyTypes.Name = "btnManagePropertyTypes";
            this.btnManagePropertyTypes.Size = new System.Drawing.Size(133, 23);
            this.btnManagePropertyTypes.TabIndex = 10;
            this.btnManagePropertyTypes.Text = "Manage Property Types";
            this.btnManagePropertyTypes.UseVisualStyleBackColor = true;
            this.btnManagePropertyTypes.Click += new System.EventHandler(this.btnManagePropertyTypes_Click);
            // 
            // btnPropertyDetails
            // 
            this.btnPropertyDetails.Location = new System.Drawing.Point(416, 13);
            this.btnPropertyDetails.Name = "btnPropertyDetails";
            this.btnPropertyDetails.Size = new System.Drawing.Size(109, 23);
            this.btnPropertyDetails.TabIndex = 11;
            this.btnPropertyDetails.Text = "Property details";
            this.btnPropertyDetails.UseVisualStyleBackColor = true;
            this.btnPropertyDetails.Click += new System.EventHandler(this.btnPropertyDetails_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(439, 318);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(86, 23);
            this.btnDone.TabIndex = 21;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // AreaCode
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AreaCode.DefaultCellStyle = dataGridViewCellStyle1;
            this.AreaCode.Frozen = true;
            this.AreaCode.HeaderText = "Area code";
            this.AreaCode.Name = "AreaCode";
            this.AreaCode.ReadOnly = true;
            this.AreaCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AreaCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Number
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Number.DefaultCellStyle = dataGridViewCellStyle2;
            this.Number.Frozen = true;
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmRegisterProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 351);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnPropertyDetails);
            this.Controls.Add(this.btnTelephoneNumbers);
            this.Controls.Add(this.btnManagePropertyTypes);
            this.Controls.Add(this.grpbxOwnerDetails);
            this.Controls.Add(this.btnSaveOwner);
            this.Controls.Add(this.btnUpdateOwner);
            this.Controls.Add(this.btnDeleteOwner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegisterProperty";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Property Registration";
            this.Load += new System.EventHandler(this.frmRegisterProperty_Load);
            this.grpbxOwnerDetails.ResumeLayout(false);
            this.grpbxOwnerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOwner)).EndInit();
            this.bnOwner.ResumeLayout(false);
            this.bnOwner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwnerTelNum)).EndInit();
            this.grpbxBusiness.ResumeLayout(false);
            this.grpbxBusiness.PerformLayout();
            this.grpbxIndividual.ResumeLayout(false);
            this.grpbxIndividual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxOwnerDetails;
        private System.Windows.Forms.GroupBox grpbxBusiness;
        private System.Windows.Forms.Label lblCntctFName;
        private System.Windows.Forms.Label lblCntctLName;
        private System.Windows.Forms.TextBox txtContactFirstName;
        private System.Windows.Forms.TextBox txtContactLastName;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.Label lblBusName;
        private System.Windows.Forms.TextBox txtBusinessType;
        private System.Windows.Forms.Label lblBusType;
        private System.Windows.Forms.GroupBox grpbxIndividual;
        private System.Windows.Forms.TextBox txtIndividualFirstName;
        private System.Windows.Forms.Label lblIndividualFirstName;
        private System.Windows.Forms.TextBox txtIndividualLastName;
        private System.Windows.Forms.Label lblIndividualLastName;
        private System.Windows.Forms.Label lblOwnerPostCode;
        private System.Windows.Forms.Label lblOwnerCity;
        private System.Windows.Forms.TextBox txtOwnerPostCode;
        private System.Windows.Forms.TextBox txtOwnerCity;
        private System.Windows.Forms.TextBox txtOwnerStreet;
        private System.Windows.Forms.Label lblOwnerStreet;
        private System.Windows.Forms.TextBox txtOwnerNumber;
        private System.Windows.Forms.Label lblOwnerNumber;
        private System.Windows.Forms.Button btnTelephoneNumbers;
        private System.Windows.Forms.Button btnManagePropertyTypes;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.Button btnUpdateOwner;
        private System.Windows.Forms.Button btnSaveOwner;
        private System.Windows.Forms.Button btnPropertyDetails;
        private System.Windows.Forms.BindingNavigator bnOwner;
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
        private System.Windows.Forms.DataGridView dgvOwnerTelNum;
        private System.Windows.Forms.Label lblOwnerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ComboBox ddlOwnerType;
        private System.Windows.Forms.Label lblOwnerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
    }
}