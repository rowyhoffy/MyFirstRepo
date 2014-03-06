namespace NationalRealtors
{
    partial class frmRegisterClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterClient));
            this.lblClientNumber = new System.Windows.Forms.Label();
            this.txtClientNumber = new System.Windows.Forms.TextBox();
            this.lblClientLname = new System.Windows.Forms.Label();
            this.txtClientLname = new System.Windows.Forms.TextBox();
            this.lblClientFirstName = new System.Windows.Forms.Label();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.lblRegisteredBy = new System.Windows.Forms.Label();
            this.ddlRegisteredBy = new System.Windows.Forms.ComboBox();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.grpbxClientPref = new System.Windows.Forms.GroupBox();
            this.lblClientPrefId = new System.Windows.Forms.Label();
            this.ddlPropertyType = new System.Windows.Forms.ComboBox();
            this.pROPERTYTYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPropType = new System.Windows.Forms.Label();
            this.txtMaxRent = new System.Windows.Forms.TextBox();
            this.lblMaxRent = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gpbxClient = new System.Windows.Forms.GroupBox();
            this.bnClient = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lblClientId = new System.Windows.Forms.Label();
            this.sTAFFTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.STAFFTableAdapter();
            this.pROPERTY_TYPETableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.PROPERTY_TYPETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            this.grpbxClientPref.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROPERTYTYPEBindingSource)).BeginInit();
            this.gpbxClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnClient)).BeginInit();
            this.bnClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientNumber
            // 
            this.lblClientNumber.AutoSize = true;
            this.lblClientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNumber.Location = new System.Drawing.Point(6, 16);
            this.lblClientNumber.Name = "lblClientNumber";
            this.lblClientNumber.Size = new System.Drawing.Size(84, 15);
            this.lblClientNumber.TabIndex = 0;
            this.lblClientNumber.Text = "Client number";
            // 
            // txtClientNumber
            // 
            this.txtClientNumber.Location = new System.Drawing.Point(113, 13);
            this.txtClientNumber.Name = "txtClientNumber";
            this.txtClientNumber.Size = new System.Drawing.Size(121, 20);
            this.txtClientNumber.TabIndex = 1;
            // 
            // lblClientLname
            // 
            this.lblClientLname.AutoSize = true;
            this.lblClientLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientLname.Location = new System.Drawing.Point(6, 43);
            this.lblClientLname.Name = "lblClientLname";
            this.lblClientLname.Size = new System.Drawing.Size(65, 15);
            this.lblClientLname.TabIndex = 2;
            this.lblClientLname.Text = "Last name";
            // 
            // txtClientLname
            // 
            this.txtClientLname.Location = new System.Drawing.Point(113, 41);
            this.txtClientLname.Name = "txtClientLname";
            this.txtClientLname.Size = new System.Drawing.Size(121, 20);
            this.txtClientLname.TabIndex = 3;
            // 
            // lblClientFirstName
            // 
            this.lblClientFirstName.AutoSize = true;
            this.lblClientFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientFirstName.Location = new System.Drawing.Point(6, 70);
            this.lblClientFirstName.Name = "lblClientFirstName";
            this.lblClientFirstName.Size = new System.Drawing.Size(65, 15);
            this.lblClientFirstName.TabIndex = 4;
            this.lblClientFirstName.Text = "First name";
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Location = new System.Drawing.Point(113, 69);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtClientFirstName.TabIndex = 5;
            // 
            // lblRegisteredBy
            // 
            this.lblRegisteredBy.AutoSize = true;
            this.lblRegisteredBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredBy.Location = new System.Drawing.Point(6, 97);
            this.lblRegisteredBy.Name = "lblRegisteredBy";
            this.lblRegisteredBy.Size = new System.Drawing.Size(82, 15);
            this.lblRegisteredBy.TabIndex = 6;
            this.lblRegisteredBy.Text = "Registered by";
            // 
            // ddlRegisteredBy
            // 
            this.ddlRegisteredBy.DataSource = this.sTAFFBindingSource;
            this.ddlRegisteredBy.DisplayMember = "StaffLname";
            this.ddlRegisteredBy.Enabled = false;
            this.ddlRegisteredBy.FormattingEnabled = true;
            this.ddlRegisteredBy.Location = new System.Drawing.Point(113, 97);
            this.ddlRegisteredBy.Name = "ddlRegisteredBy";
            this.ddlRegisteredBy.Size = new System.Drawing.Size(121, 21);
            this.ddlRegisteredBy.TabIndex = 7;
            this.ddlRegisteredBy.ValueMember = "StaffId";
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
            // grpbxClientPref
            // 
            this.grpbxClientPref.Controls.Add(this.lblClientPrefId);
            this.grpbxClientPref.Controls.Add(this.ddlPropertyType);
            this.grpbxClientPref.Controls.Add(this.lblPropType);
            this.grpbxClientPref.Controls.Add(this.txtMaxRent);
            this.grpbxClientPref.Controls.Add(this.lblMaxRent);
            this.grpbxClientPref.Enabled = false;
            this.grpbxClientPref.Location = new System.Drawing.Point(240, 13);
            this.grpbxClientPref.Name = "grpbxClientPref";
            this.grpbxClientPref.Size = new System.Drawing.Size(280, 106);
            this.grpbxClientPref.TabIndex = 8;
            this.grpbxClientPref.TabStop = false;
            this.grpbxClientPref.Text = "Client Preferences";
            // 
            // lblClientPrefId
            // 
            this.lblClientPrefId.AutoSize = true;
            this.lblClientPrefId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPrefId.Location = new System.Drawing.Point(92, 88);
            this.lblClientPrefId.Name = "lblClientPrefId";
            this.lblClientPrefId.Size = new System.Drawing.Size(77, 15);
            this.lblClientPrefId.TabIndex = 13;
            this.lblClientPrefId.Text = "Property type";
            // 
            // ddlPropertyType
            // 
            this.ddlPropertyType.DataSource = this.pROPERTYTYPEBindingSource;
            this.ddlPropertyType.DisplayMember = "PropertyType";
            this.ddlPropertyType.FormattingEnabled = true;
            this.ddlPropertyType.Location = new System.Drawing.Point(138, 56);
            this.ddlPropertyType.Name = "ddlPropertyType";
            this.ddlPropertyType.Size = new System.Drawing.Size(121, 21);
            this.ddlPropertyType.TabIndex = 11;
            this.ddlPropertyType.ValueMember = "PropTypeId";
            // 
            // pROPERTYTYPEBindingSource
            // 
            this.pROPERTYTYPEBindingSource.DataMember = "PROPERTY_TYPE";
            this.pROPERTYTYPEBindingSource.DataSource = this.dsNationalRealtors;
            // 
            // lblPropType
            // 
            this.lblPropType.AutoSize = true;
            this.lblPropType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropType.Location = new System.Drawing.Point(12, 52);
            this.lblPropType.Name = "lblPropType";
            this.lblPropType.Size = new System.Drawing.Size(77, 15);
            this.lblPropType.TabIndex = 10;
            this.lblPropType.Text = "Property type";
            // 
            // txtMaxRent
            // 
            this.txtMaxRent.Location = new System.Drawing.Point(138, 30);
            this.txtMaxRent.Name = "txtMaxRent";
            this.txtMaxRent.Size = new System.Drawing.Size(121, 20);
            this.txtMaxRent.TabIndex = 10;
            // 
            // lblMaxRent
            // 
            this.lblMaxRent.AutoSize = true;
            this.lblMaxRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxRent.Location = new System.Drawing.Point(12, 31);
            this.lblMaxRent.Name = "lblMaxRent";
            this.lblMaxRent.Size = new System.Drawing.Size(87, 15);
            this.lblMaxRent.TabIndex = 9;
            this.lblMaxRent.Text = "Maximum rent";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(465, 187);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(172, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(10, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(91, 187);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gpbxClient
            // 
            this.gpbxClient.Controls.Add(this.bnClient);
            this.gpbxClient.Controls.Add(this.lblClientId);
            this.gpbxClient.Controls.Add(this.lblClientNumber);
            this.gpbxClient.Controls.Add(this.txtClientNumber);
            this.gpbxClient.Controls.Add(this.lblClientLname);
            this.gpbxClient.Controls.Add(this.txtClientLname);
            this.gpbxClient.Controls.Add(this.lblClientFirstName);
            this.gpbxClient.Controls.Add(this.grpbxClientPref);
            this.gpbxClient.Controls.Add(this.txtClientFirstName);
            this.gpbxClient.Controls.Add(this.ddlRegisteredBy);
            this.gpbxClient.Controls.Add(this.lblRegisteredBy);
            this.gpbxClient.Location = new System.Drawing.Point(12, 12);
            this.gpbxClient.Name = "gpbxClient";
            this.gpbxClient.Size = new System.Drawing.Size(530, 169);
            this.gpbxClient.TabIndex = 13;
            this.gpbxClient.TabStop = false;
            // 
            // bnClient
            // 
            this.bnClient.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnClient.CountItem = this.bindingNavigatorCountItem;
            this.bnClient.DeleteItem = null;
            this.bnClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnClient.Location = new System.Drawing.Point(3, 141);
            this.bnClient.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnClient.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnClient.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnClient.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnClient.Name = "bnClient";
            this.bnClient.PositionItem = this.bindingNavigatorPositionItem;
            this.bnClient.Size = new System.Drawing.Size(524, 25);
            this.bnClient.TabIndex = 9;
            this.bnClient.Text = "bindingNavigator1";
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
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Enabled = false;
            this.lblClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientId.Location = new System.Drawing.Point(218, 121);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(16, 15);
            this.lblClientId.TabIndex = 12;
            this.lblClientId.Text = "...";
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // pROPERTY_TYPETableAdapter
            // 
            this.pROPERTY_TYPETableAdapter.ClearBeforeFill = true;
            // 
            // frmRegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 222);
            this.Controls.Add(this.gpbxClient);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegisterClient";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client Registration";
            this.Load += new System.EventHandler(this.frmRegisterClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            this.grpbxClientPref.ResumeLayout(false);
            this.grpbxClientPref.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pROPERTYTYPEBindingSource)).EndInit();
            this.gpbxClient.ResumeLayout(false);
            this.gpbxClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnClient)).EndInit();
            this.bnClient.ResumeLayout(false);
            this.bnClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClientNumber;
        private System.Windows.Forms.TextBox txtClientNumber;
        private System.Windows.Forms.Label lblClientLname;
        private System.Windows.Forms.TextBox txtClientLname;
        private System.Windows.Forms.Label lblClientFirstName;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.Label lblRegisteredBy;
        private System.Windows.Forms.ComboBox ddlRegisteredBy;
        private System.Windows.Forms.GroupBox grpbxClientPref;
        private System.Windows.Forms.ComboBox ddlPropertyType;
        private System.Windows.Forms.Label lblPropType;
        private System.Windows.Forms.TextBox txtMaxRent;
        private System.Windows.Forms.Label lblMaxRent;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gpbxClient;
        private System.Windows.Forms.BindingNavigator bnClient;
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
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblClientPrefId;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private dsNationalRealtorsTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.BindingSource pROPERTYTYPEBindingSource;
        private dsNationalRealtorsTableAdapters.PROPERTY_TYPETableAdapter pROPERTY_TYPETableAdapter;
    }
}