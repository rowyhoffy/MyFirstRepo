namespace NationalRealtors
{
    partial class frmOwnerTelNum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOwnerTelNum));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpbxAdditionalTelNum = new System.Windows.Forms.GroupBox();
            this.gpbxTelNum = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlOwner = new System.Windows.Forms.ComboBox();
            this.lblAreaCode = new System.Windows.Forms.Label();
            this.txtAreaCode = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtTelNum = new System.Windows.Forms.TextBox();
            this.lblTelId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplayOwnerId = new System.Windows.Forms.Label();
            this.gpbxOwner = new System.Windows.Forms.GroupBox();
            this.lblIndividu = new System.Windows.Forms.Label();
            this.txtBusiness = new System.Windows.Forms.TextBox();
            this.lblBusiness = new System.Windows.Forms.Label();
            this.txtIndividual = new System.Windows.Forms.TextBox();
            this.bnOwnerTelNum = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsbtnAddAdditional = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblOwnerId = new System.Windows.Forms.Label();
            this.grpbxAdditionalTelNum.SuspendLayout();
            this.gpbxTelNum.SuspendLayout();
            this.gpbxOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOwnerTelNum)).BeginInit();
            this.bnOwnerTelNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(335, 45);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpbxAdditionalTelNum
            // 
            this.grpbxAdditionalTelNum.Controls.Add(this.gpbxTelNum);
            this.grpbxAdditionalTelNum.Controls.Add(this.lblTelId);
            this.grpbxAdditionalTelNum.Controls.Add(this.label1);
            this.grpbxAdditionalTelNum.Controls.Add(this.lblDisplayOwnerId);
            this.grpbxAdditionalTelNum.Controls.Add(this.gpbxOwner);
            this.grpbxAdditionalTelNum.Controls.Add(this.bnOwnerTelNum);
            this.grpbxAdditionalTelNum.Controls.Add(this.lblOwnerId);
            this.grpbxAdditionalTelNum.Location = new System.Drawing.Point(12, 12);
            this.grpbxAdditionalTelNum.Name = "grpbxAdditionalTelNum";
            this.grpbxAdditionalTelNum.Size = new System.Drawing.Size(516, 237);
            this.grpbxAdditionalTelNum.TabIndex = 13;
            this.grpbxAdditionalTelNum.TabStop = false;
            // 
            // gpbxTelNum
            // 
            this.gpbxTelNum.Controls.Add(this.btnDone);
            this.gpbxTelNum.Controls.Add(this.btnSave);
            this.gpbxTelNum.Controls.Add(this.btnUpdate);
            this.gpbxTelNum.Controls.Add(this.label2);
            this.gpbxTelNum.Controls.Add(this.ddlOwner);
            this.gpbxTelNum.Controls.Add(this.lblAreaCode);
            this.gpbxTelNum.Controls.Add(this.txtAreaCode);
            this.gpbxTelNum.Controls.Add(this.lblNumber);
            this.gpbxTelNum.Controls.Add(this.txtTelNum);
            this.gpbxTelNum.Location = new System.Drawing.Point(6, 117);
            this.gpbxTelNum.Name = "gpbxTelNum";
            this.gpbxTelNum.Size = new System.Drawing.Size(503, 88);
            this.gpbxTelNum.TabIndex = 26;
            this.gpbxTelNum.TabStop = false;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDone.Location = new System.Drawing.Point(414, 45);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 14;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Owner";
            // 
            // ddlOwner
            // 
            this.ddlOwner.Enabled = false;
            this.ddlOwner.FormattingEnabled = true;
            this.ddlOwner.Location = new System.Drawing.Point(74, 47);
            this.ddlOwner.Name = "ddlOwner";
            this.ddlOwner.Size = new System.Drawing.Size(173, 21);
            this.ddlOwner.TabIndex = 18;
            this.ddlOwner.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ddlOwner_Format);
            // 
            // lblAreaCode
            // 
            this.lblAreaCode.AutoSize = true;
            this.lblAreaCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaCode.Location = new System.Drawing.Point(6, 16);
            this.lblAreaCode.Name = "lblAreaCode";
            this.lblAreaCode.Size = new System.Drawing.Size(62, 15);
            this.lblAreaCode.TabIndex = 13;
            this.lblAreaCode.Text = "Area code";
            // 
            // txtAreaCode
            // 
            this.txtAreaCode.Location = new System.Drawing.Point(74, 15);
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.Size = new System.Drawing.Size(173, 20);
            this.txtAreaCode.TabIndex = 5;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(258, 16);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 15);
            this.lblNumber.TabIndex = 17;
            this.lblNumber.Text = "Number";
            // 
            // txtTelNum
            // 
            this.txtTelNum.Location = new System.Drawing.Point(316, 15);
            this.txtTelNum.Name = "txtTelNum";
            this.txtTelNum.Size = new System.Drawing.Size(173, 20);
            this.txtTelNum.TabIndex = 6;
            // 
            // lblTelId
            // 
            this.lblTelId.AutoSize = true;
            this.lblTelId.Enabled = false;
            this.lblTelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelId.Location = new System.Drawing.Point(94, 99);
            this.lblTelId.Name = "lblTelId";
            this.lblTelId.Size = new System.Drawing.Size(19, 15);
            this.lblTelId.TabIndex = 27;
            this.lblTelId.Text = "....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Owner Tel Id";
            // 
            // lblDisplayOwnerId
            // 
            this.lblDisplayOwnerId.AutoSize = true;
            this.lblDisplayOwnerId.Enabled = false;
            this.lblDisplayOwnerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayOwnerId.Location = new System.Drawing.Point(77, 19);
            this.lblDisplayOwnerId.Name = "lblDisplayOwnerId";
            this.lblDisplayOwnerId.Size = new System.Drawing.Size(19, 15);
            this.lblDisplayOwnerId.TabIndex = 25;
            this.lblDisplayOwnerId.Text = "....";
            // 
            // gpbxOwner
            // 
            this.gpbxOwner.Controls.Add(this.lblIndividu);
            this.gpbxOwner.Controls.Add(this.txtBusiness);
            this.gpbxOwner.Controls.Add(this.lblBusiness);
            this.gpbxOwner.Controls.Add(this.txtIndividual);
            this.gpbxOwner.Location = new System.Drawing.Point(6, 37);
            this.gpbxOwner.Name = "gpbxOwner";
            this.gpbxOwner.Size = new System.Drawing.Size(503, 48);
            this.gpbxOwner.TabIndex = 25;
            this.gpbxOwner.TabStop = false;
            // 
            // lblIndividu
            // 
            this.lblIndividu.AutoSize = true;
            this.lblIndividu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndividu.Location = new System.Drawing.Point(6, 20);
            this.lblIndividu.Name = "lblIndividu";
            this.lblIndividu.Size = new System.Drawing.Size(59, 15);
            this.lblIndividu.TabIndex = 18;
            this.lblIndividu.Text = "Individual";
            // 
            // txtBusiness
            // 
            this.txtBusiness.Location = new System.Drawing.Point(316, 19);
            this.txtBusiness.Name = "txtBusiness";
            this.txtBusiness.ReadOnly = true;
            this.txtBusiness.Size = new System.Drawing.Size(173, 20);
            this.txtBusiness.TabIndex = 23;
            // 
            // lblBusiness
            // 
            this.lblBusiness.AutoSize = true;
            this.lblBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusiness.Location = new System.Drawing.Point(253, 20);
            this.lblBusiness.Name = "lblBusiness";
            this.lblBusiness.Size = new System.Drawing.Size(57, 15);
            this.lblBusiness.TabIndex = 22;
            this.lblBusiness.Text = "Business";
            // 
            // txtIndividual
            // 
            this.txtIndividual.Location = new System.Drawing.Point(74, 19);
            this.txtIndividual.Name = "txtIndividual";
            this.txtIndividual.ReadOnly = true;
            this.txtIndividual.Size = new System.Drawing.Size(173, 20);
            this.txtIndividual.TabIndex = 21;
            // 
            // bnOwnerTelNum
            // 
            this.bnOwnerTelNum.AddNewItem = this.tsbtnAddAdditional;
            this.bnOwnerTelNum.CountItem = this.bindingNavigatorCountItem;
            this.bnOwnerTelNum.DeleteItem = null;
            this.bnOwnerTelNum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnOwnerTelNum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbtnAddAdditional});
            this.bnOwnerTelNum.Location = new System.Drawing.Point(3, 209);
            this.bnOwnerTelNum.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnOwnerTelNum.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnOwnerTelNum.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnOwnerTelNum.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnOwnerTelNum.Name = "bnOwnerTelNum";
            this.bnOwnerTelNum.PositionItem = this.bindingNavigatorPositionItem;
            this.bnOwnerTelNum.Size = new System.Drawing.Size(510, 25);
            this.bnOwnerTelNum.TabIndex = 20;
            this.bnOwnerTelNum.Text = "bindingNavigator1";
            // 
            // tsbtnAddAdditional
            // 
            this.tsbtnAddAdditional.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnAddAdditional.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddAdditional.Image")));
            this.tsbtnAddAdditional.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddAdditional.Name = "tsbtnAddAdditional";
            this.tsbtnAddAdditional.Size = new System.Drawing.Size(89, 22);
            this.tsbtnAddAdditional.Text = "Add additional";
            this.tsbtnAddAdditional.Click += new System.EventHandler(this.tsbtnAddAdditional_Click);
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
            // lblOwnerId
            // 
            this.lblOwnerId.AutoSize = true;
            this.lblOwnerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerId.Location = new System.Drawing.Point(12, 19);
            this.lblOwnerId.Name = "lblOwnerId";
            this.lblOwnerId.Size = new System.Drawing.Size(56, 15);
            this.lblOwnerId.TabIndex = 24;
            this.lblOwnerId.Text = "Owner Id";
            // 
            // frmOwnerTelNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 258);
            this.Controls.Add(this.grpbxAdditionalTelNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOwnerTelNum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Telephone numbers";
            this.Load += new System.EventHandler(this.frmOwnerTelNum_Load);
            this.grpbxAdditionalTelNum.ResumeLayout(false);
            this.grpbxAdditionalTelNum.PerformLayout();
            this.gpbxTelNum.ResumeLayout(false);
            this.gpbxTelNum.PerformLayout();
            this.gpbxOwner.ResumeLayout(false);
            this.gpbxOwner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOwnerTelNum)).EndInit();
            this.bnOwnerTelNum.ResumeLayout(false);
            this.bnOwnerTelNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpbxAdditionalTelNum;
        private System.Windows.Forms.Label lblIndividu;
        private System.Windows.Forms.TextBox txtTelNum;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtAreaCode;
        private System.Windows.Forms.Label lblAreaCode;
        private System.Windows.Forms.BindingNavigator bnOwnerTelNum;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox txtIndividual;
        private System.Windows.Forms.GroupBox gpbxTelNum;
        private System.Windows.Forms.GroupBox gpbxOwner;
        private System.Windows.Forms.Label lblDisplayOwnerId;
        private System.Windows.Forms.TextBox txtBusiness;
        private System.Windows.Forms.Label lblOwnerId;
        private System.Windows.Forms.Label lblBusiness;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblTelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbtnAddAdditional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlOwner;
    }
}