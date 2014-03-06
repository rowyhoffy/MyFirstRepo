namespace NationalRealtors
{
    partial class frmPropertyDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropertyDetails));
            this.grpbxPropertyDetails = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateAvailable = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.bnNavigatorProperty = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lblPropertyId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlPropOnView = new System.Windows.Forms.ComboBox();
            this.ddlPropForRent = new System.Windows.Forms.ComboBox();
            this.ddlPropType = new System.Windows.Forms.ComboBox();
            this.lblPropType2 = new System.Windows.Forms.Label();
            this.lblPropOnView = new System.Windows.Forms.Label();
            this.lblPropertyForRent = new System.Windows.Forms.Label();
            this.ddlOwnedBy = new System.Windows.Forms.ComboBox();
            this.lblOwnedBy = new System.Windows.Forms.Label();
            this.ddlManagedBy = new System.Windows.Forms.ComboBox();
            this.lblManagedBy = new System.Windows.Forms.Label();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.lblRent = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtPropertyNumber = new System.Windows.Forms.TextBox();
            this.lblPropertyNumber = new System.Windows.Forms.Label();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnUpdateProperty = new System.Windows.Forms.Button();
            this.btnSaveProperty = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.STAFFTableAdapter();
            this.pROPERTYTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROPERTY_TYPETableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.PROPERTY_TYPETableAdapter();
            this.lblDateListed = new System.Windows.Forms.Label();
            this.grpbxPropertyDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnNavigatorProperty)).BeginInit();
            this.bnNavigatorProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPERTYTYPEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxPropertyDetails
            // 
            this.grpbxPropertyDetails.Controls.Add(this.lblDateListed);
            this.grpbxPropertyDetails.Controls.Add(this.txtComments);
            this.grpbxPropertyDetails.Controls.Add(this.label3);
            this.grpbxPropertyDetails.Controls.Add(this.dtpDateAvailable);
            this.grpbxPropertyDetails.Controls.Add(this.label2);
            this.grpbxPropertyDetails.Controls.Add(this.bnNavigatorProperty);
            this.grpbxPropertyDetails.Controls.Add(this.lblPropertyId);
            this.grpbxPropertyDetails.Controls.Add(this.label1);
            this.grpbxPropertyDetails.Controls.Add(this.ddlPropOnView);
            this.grpbxPropertyDetails.Controls.Add(this.ddlPropForRent);
            this.grpbxPropertyDetails.Controls.Add(this.ddlPropType);
            this.grpbxPropertyDetails.Controls.Add(this.lblPropType2);
            this.grpbxPropertyDetails.Controls.Add(this.lblPropOnView);
            this.grpbxPropertyDetails.Controls.Add(this.lblPropertyForRent);
            this.grpbxPropertyDetails.Controls.Add(this.ddlOwnedBy);
            this.grpbxPropertyDetails.Controls.Add(this.lblOwnedBy);
            this.grpbxPropertyDetails.Controls.Add(this.ddlManagedBy);
            this.grpbxPropertyDetails.Controls.Add(this.lblManagedBy);
            this.grpbxPropertyDetails.Controls.Add(this.txtRooms);
            this.grpbxPropertyDetails.Controls.Add(this.lblRooms);
            this.grpbxPropertyDetails.Controls.Add(this.txtRent);
            this.grpbxPropertyDetails.Controls.Add(this.lblRent);
            this.grpbxPropertyDetails.Controls.Add(this.txtPostCode);
            this.grpbxPropertyDetails.Controls.Add(this.lblPostCode);
            this.grpbxPropertyDetails.Controls.Add(this.txtCity);
            this.grpbxPropertyDetails.Controls.Add(this.lblCity);
            this.grpbxPropertyDetails.Controls.Add(this.txtStreet);
            this.grpbxPropertyDetails.Controls.Add(this.lblStreet);
            this.grpbxPropertyDetails.Controls.Add(this.txtPropertyNumber);
            this.grpbxPropertyDetails.Controls.Add(this.lblPropertyNumber);
            this.grpbxPropertyDetails.Location = new System.Drawing.Point(12, 12);
            this.grpbxPropertyDetails.Name = "grpbxPropertyDetails";
            this.grpbxPropertyDetails.Size = new System.Drawing.Size(537, 312);
            this.grpbxPropertyDetails.TabIndex = 10;
            this.grpbxPropertyDetails.TabStop = false;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(117, 222);
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.Size = new System.Drawing.Size(414, 59);
            this.txtComments.TabIndex = 43;
            this.txtComments.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Comments";
            // 
            // dtpDateAvailable
            // 
            this.dtpDateAvailable.Location = new System.Drawing.Point(117, 196);
            this.dtpDateAvailable.Name = "dtpDateAvailable";
            this.dtpDateAvailable.Size = new System.Drawing.Size(145, 20);
            this.dtpDateAvailable.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Date available";
            // 
            // bnNavigatorProperty
            // 
            this.bnNavigatorProperty.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnNavigatorProperty.CountItem = this.bindingNavigatorCountItem;
            this.bnNavigatorProperty.DeleteItem = null;
            this.bnNavigatorProperty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnNavigatorProperty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnNavigatorProperty.Location = new System.Drawing.Point(3, 284);
            this.bnNavigatorProperty.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnNavigatorProperty.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnNavigatorProperty.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnNavigatorProperty.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnNavigatorProperty.Name = "bnNavigatorProperty";
            this.bnNavigatorProperty.PositionItem = this.bindingNavigatorPositionItem;
            this.bnNavigatorProperty.Size = new System.Drawing.Size(531, 25);
            this.bnNavigatorProperty.TabIndex = 39;
            this.bnNavigatorProperty.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(58, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblPropertyId
            // 
            this.lblPropertyId.AutoSize = true;
            this.lblPropertyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyId.Location = new System.Drawing.Point(114, 22);
            this.lblPropertyId.Name = "lblPropertyId";
            this.lblPropertyId.Size = new System.Drawing.Size(16, 15);
            this.lblPropertyId.TabIndex = 38;
            this.lblPropertyId.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Property Id";
            // 
            // ddlPropOnView
            // 
            this.ddlPropOnView.FormattingEnabled = true;
            this.ddlPropOnView.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.ddlPropOnView.Location = new System.Drawing.Point(376, 170);
            this.ddlPropOnView.Name = "ddlPropOnView";
            this.ddlPropOnView.Size = new System.Drawing.Size(155, 21);
            this.ddlPropOnView.TabIndex = 33;
            // 
            // ddlPropForRent
            // 
            this.ddlPropForRent.FormattingEnabled = true;
            this.ddlPropForRent.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.ddlPropForRent.Location = new System.Drawing.Point(376, 144);
            this.ddlPropForRent.Name = "ddlPropForRent";
            this.ddlPropForRent.Size = new System.Drawing.Size(155, 21);
            this.ddlPropForRent.TabIndex = 32;
            // 
            // ddlPropType
            // 
            this.ddlPropType.DataSource = this.pROPERTYTYPEBindingSource;
            this.ddlPropType.DisplayMember = "PropertyType";
            this.ddlPropType.FormattingEnabled = true;
            this.ddlPropType.Location = new System.Drawing.Point(354, 66);
            this.ddlPropType.Name = "ddlPropType";
            this.ddlPropType.Size = new System.Drawing.Size(177, 21);
            this.ddlPropType.TabIndex = 31;
            this.ddlPropType.ValueMember = "PropTypeId";
            // 
            // lblPropType2
            // 
            this.lblPropType2.AutoSize = true;
            this.lblPropType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropType2.Location = new System.Drawing.Point(268, 67);
            this.lblPropType2.Name = "lblPropType2";
            this.lblPropType2.Size = new System.Drawing.Size(77, 15);
            this.lblPropType2.TabIndex = 16;
            this.lblPropType2.Text = "Property type";
            // 
            // lblPropOnView
            // 
            this.lblPropOnView.AutoSize = true;
            this.lblPropOnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropOnView.Location = new System.Drawing.Point(268, 171);
            this.lblPropOnView.Name = "lblPropOnView";
            this.lblPropOnView.Size = new System.Drawing.Size(96, 15);
            this.lblPropOnView.TabIndex = 28;
            this.lblPropOnView.Text = "Property on view";
            // 
            // lblPropertyForRent
            // 
            this.lblPropertyForRent.AutoSize = true;
            this.lblPropertyForRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyForRent.Location = new System.Drawing.Point(268, 145);
            this.lblPropertyForRent.Name = "lblPropertyForRent";
            this.lblPropertyForRent.Size = new System.Drawing.Size(93, 15);
            this.lblPropertyForRent.TabIndex = 25;
            this.lblPropertyForRent.Text = "Property for rent";
            // 
            // ddlOwnedBy
            // 
            this.ddlOwnedBy.FormattingEnabled = true;
            this.ddlOwnedBy.Location = new System.Drawing.Point(354, 92);
            this.ddlOwnedBy.Name = "ddlOwnedBy";
            this.ddlOwnedBy.Size = new System.Drawing.Size(177, 21);
            this.ddlOwnedBy.TabIndex = 24;
            this.ddlOwnedBy.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ddlOwnedBy_Format);
            // 
            // lblOwnedBy
            // 
            this.lblOwnedBy.AutoSize = true;
            this.lblOwnedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnedBy.Location = new System.Drawing.Point(268, 94);
            this.lblOwnedBy.Name = "lblOwnedBy";
            this.lblOwnedBy.Size = new System.Drawing.Size(61, 15);
            this.lblOwnedBy.TabIndex = 23;
            this.lblOwnedBy.Text = "Owned by";
            // 
            // ddlManagedBy
            // 
            this.ddlManagedBy.DataSource = this.sTAFFBindingSource;
            this.ddlManagedBy.DisplayMember = "StaffLname";
            this.ddlManagedBy.FormattingEnabled = true;
            this.ddlManagedBy.Location = new System.Drawing.Point(354, 40);
            this.ddlManagedBy.Name = "ddlManagedBy";
            this.ddlManagedBy.Size = new System.Drawing.Size(177, 21);
            this.ddlManagedBy.TabIndex = 22;
            this.ddlManagedBy.ValueMember = "StaffId";
            this.ddlManagedBy.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ddlManagedBy_Format);
            // 
            // lblManagedBy
            // 
            this.lblManagedBy.AutoSize = true;
            this.lblManagedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagedBy.Location = new System.Drawing.Point(268, 41);
            this.lblManagedBy.Name = "lblManagedBy";
            this.lblManagedBy.Size = new System.Drawing.Size(75, 15);
            this.lblManagedBy.TabIndex = 21;
            this.lblManagedBy.Text = "Managed by";
            // 
            // txtRooms
            // 
            this.txtRooms.Location = new System.Drawing.Point(117, 170);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(145, 20);
            this.txtRooms.TabIndex = 20;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.Location = new System.Drawing.Point(13, 171);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(47, 15);
            this.lblRooms.TabIndex = 19;
            this.lblRooms.Text = "Rooms";
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(117, 144);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(145, 20);
            this.txtRent.TabIndex = 18;
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.Location = new System.Drawing.Point(13, 149);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(33, 15);
            this.lblRent.TabIndex = 17;
            this.lblRent.Text = "Rent";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(117, 118);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(145, 20);
            this.txtPostCode.TabIndex = 15;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCode.Location = new System.Drawing.Point(13, 119);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(71, 15);
            this.lblPostCode.TabIndex = 14;
            this.lblPostCode.Text = "Postal code";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(117, 92);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(145, 20);
            this.txtCity.TabIndex = 13;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(13, 94);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(26, 15);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(117, 66);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(145, 20);
            this.txtStreet.TabIndex = 11;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(13, 67);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(39, 15);
            this.lblStreet.TabIndex = 10;
            this.lblStreet.Text = "Street";
            // 
            // txtPropertyNumber
            // 
            this.txtPropertyNumber.Location = new System.Drawing.Point(117, 40);
            this.txtPropertyNumber.Name = "txtPropertyNumber";
            this.txtPropertyNumber.Size = new System.Drawing.Size(145, 20);
            this.txtPropertyNumber.TabIndex = 9;
            // 
            // lblPropertyNumber
            // 
            this.lblPropertyNumber.AutoSize = true;
            this.lblPropertyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyNumber.Location = new System.Drawing.Point(13, 41);
            this.lblPropertyNumber.Name = "lblPropertyNumber";
            this.lblPropertyNumber.Size = new System.Drawing.Size(98, 15);
            this.lblPropertyNumber.TabIndex = 8;
            this.lblPropertyNumber.Text = "Property number";
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(216, 324);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(96, 23);
            this.btnDeleteProperty.TabIndex = 36;
            this.btnDeleteProperty.Text = "Delete";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);
            // 
            // btnUpdateProperty
            // 
            this.btnUpdateProperty.Location = new System.Drawing.Point(114, 324);
            this.btnUpdateProperty.Name = "btnUpdateProperty";
            this.btnUpdateProperty.Size = new System.Drawing.Size(96, 23);
            this.btnUpdateProperty.TabIndex = 35;
            this.btnUpdateProperty.Text = "Update";
            this.btnUpdateProperty.UseVisualStyleBackColor = true;
            this.btnUpdateProperty.Click += new System.EventHandler(this.btnUpdateProperty_Click);
            // 
            // btnSaveProperty
            // 
            this.btnSaveProperty.Location = new System.Drawing.Point(12, 324);
            this.btnSaveProperty.Name = "btnSaveProperty";
            this.btnSaveProperty.Size = new System.Drawing.Size(96, 23);
            this.btnSaveProperty.TabIndex = 34;
            this.btnSaveProperty.Text = "Save";
            this.btnSaveProperty.UseVisualStyleBackColor = true;
            this.btnSaveProperty.Click += new System.EventHandler(this.btnSaveProperty_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(453, 324);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(96, 23);
            this.btnDone.TabIndex = 37;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // dsNationalRealtors
            // 
            this.dsNationalRealtors.DataSetName = "dsNationalRealtors";
            this.dsNationalRealtors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.dsNationalRealtors;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // pROPERTYTYPEBindingSource
            // 
            this.pROPERTYTYPEBindingSource.DataMember = "PROPERTY_TYPE";
            this.pROPERTYTYPEBindingSource.DataSource = this.dsNationalRealtors;
            // 
            // pROPERTY_TYPETableAdapter
            // 
            this.pROPERTY_TYPETableAdapter.ClearBeforeFill = true;
            // 
            // lblDateListed
            // 
            this.lblDateListed.AutoSize = true;
            this.lblDateListed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateListed.Location = new System.Drawing.Point(351, 22);
            this.lblDateListed.Name = "lblDateListed";
            this.lblDateListed.Size = new System.Drawing.Size(65, 15);
            this.lblDateListed.TabIndex = 44;
            this.lblDateListed.Text = "Date listed";
            // 
            // frmPropertyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 358);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.grpbxPropertyDetails);
            this.Controls.Add(this.btnSaveProperty);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.btnUpdateProperty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPropertyDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Property Details";
            this.Load += new System.EventHandler(this.frmPropertyDetails_Load);
            this.grpbxPropertyDetails.ResumeLayout(false);
            this.grpbxPropertyDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnNavigatorProperty)).EndInit();
            this.bnNavigatorProperty.ResumeLayout(false);
            this.bnNavigatorProperty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPERTYTYPEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxPropertyDetails;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnUpdateProperty;
        private System.Windows.Forms.Button btnSaveProperty;
        private System.Windows.Forms.ComboBox ddlPropOnView;
        private System.Windows.Forms.ComboBox ddlPropForRent;
        private System.Windows.Forms.ComboBox ddlPropType;
        private System.Windows.Forms.Label lblPropType2;
        private System.Windows.Forms.Label lblPropOnView;
        private System.Windows.Forms.Label lblPropertyForRent;
        private System.Windows.Forms.ComboBox ddlOwnedBy;
        private System.Windows.Forms.Label lblOwnedBy;
        private System.Windows.Forms.ComboBox ddlManagedBy;
        private System.Windows.Forms.Label lblManagedBy;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtPropertyNumber;
        private System.Windows.Forms.Label lblPropertyNumber;
        private System.Windows.Forms.BindingNavigator bnNavigatorProperty;
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
        private System.Windows.Forms.Label lblPropertyId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtComments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateAvailable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDone;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private dsNationalRealtorsTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.BindingSource pROPERTYTYPEBindingSource;
        private dsNationalRealtorsTableAdapters.PROPERTY_TYPETableAdapter pROPERTY_TYPETableAdapter;
        private System.Windows.Forms.Label lblDateListed;
    }
}