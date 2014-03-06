namespace NationalRealtors
{
    partial class frmRegisterBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterBranch));
            this.btnDone = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpbxAddress = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBranchId = new System.Windows.Forms.Label();
            this.txtBranchPostCode = new System.Windows.Forms.TextBox();
            this.bnBranch = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddNew = new System.Windows.Forms.ToolStripButton();
            this.txtBranchCity = new System.Windows.Forms.TextBox();
            this.txtBranchStreet = new System.Windows.Forms.TextBox();
            this.lblBranchPostCode = new System.Windows.Forms.Label();
            this.lblBranchCity = new System.Windows.Forms.Label();
            this.lblBranchStreet = new System.Windows.Forms.Label();
            this.txtBranchNumber = new System.Windows.Forms.TextBox();
            this.lblBranchNumber = new System.Windows.Forms.Label();
            this.btnAddTel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvTelNum = new System.Windows.Forms.DataGridView();
            this.AreaCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbxTelNum = new System.Windows.Forms.GroupBox();
            this.grpbxAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnBranch)).BeginInit();
            this.bnBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelNum)).BeginInit();
            this.gpbxTelNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(508, 220);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpbxAddress
            // 
            this.grpbxAddress.Controls.Add(this.label1);
            this.grpbxAddress.Controls.Add(this.lblBranchId);
            this.grpbxAddress.Controls.Add(this.txtBranchPostCode);
            this.grpbxAddress.Controls.Add(this.bnBranch);
            this.grpbxAddress.Controls.Add(this.txtBranchCity);
            this.grpbxAddress.Controls.Add(this.txtBranchStreet);
            this.grpbxAddress.Controls.Add(this.lblBranchPostCode);
            this.grpbxAddress.Controls.Add(this.lblBranchCity);
            this.grpbxAddress.Controls.Add(this.lblBranchStreet);
            this.grpbxAddress.Controls.Add(this.txtBranchNumber);
            this.grpbxAddress.Controls.Add(this.lblBranchNumber);
            this.grpbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxAddress.Location = new System.Drawing.Point(12, 12);
            this.grpbxAddress.Name = "grpbxAddress";
            this.grpbxAddress.Size = new System.Drawing.Size(316, 202);
            this.grpbxAddress.TabIndex = 10;
            this.grpbxAddress.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Branch Id";
            // 
            // lblBranchId
            // 
            this.lblBranchId.AutoSize = true;
            this.lblBranchId.Location = new System.Drawing.Point(134, 17);
            this.lblBranchId.Name = "lblBranchId";
            this.lblBranchId.Size = new System.Drawing.Size(16, 15);
            this.lblBranchId.TabIndex = 12;
            this.lblBranchId.Text = "...";
            // 
            // txtBranchPostCode
            // 
            this.txtBranchPostCode.Location = new System.Drawing.Point(137, 137);
            this.txtBranchPostCode.Name = "txtBranchPostCode";
            this.txtBranchPostCode.Size = new System.Drawing.Size(173, 21);
            this.txtBranchPostCode.TabIndex = 4;
            // 
            // bnBranch
            // 
            this.bnBranch.AddNewItem = null;
            this.bnBranch.CountItem = this.bindingNavigatorCountItem;
            this.bnBranch.DeleteItem = null;
            this.bnBranch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnBranch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbAddNew});
            this.bnBranch.Location = new System.Drawing.Point(3, 174);
            this.bnBranch.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnBranch.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnBranch.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnBranch.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnBranch.Name = "bnBranch";
            this.bnBranch.PositionItem = this.bindingNavigatorPositionItem;
            this.bnBranch.Size = new System.Drawing.Size(310, 25);
            this.bnBranch.TabIndex = 14;
            this.bnBranch.Text = "bindingNavigator1";
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
            // tsbAddNew
            // 
            this.tsbAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddNew.Image")));
            this.tsbAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNew.Name = "tsbAddNew";
            this.tsbAddNew.Size = new System.Drawing.Size(58, 22);
            this.tsbAddNew.Text = "Add new";
            this.tsbAddNew.Click += new System.EventHandler(this.tsbAddNew_Click);
            // 
            // txtBranchCity
            // 
            this.txtBranchCity.Location = new System.Drawing.Point(137, 103);
            this.txtBranchCity.Name = "txtBranchCity";
            this.txtBranchCity.Size = new System.Drawing.Size(173, 21);
            this.txtBranchCity.TabIndex = 3;
            // 
            // txtBranchStreet
            // 
            this.txtBranchStreet.Location = new System.Drawing.Point(137, 69);
            this.txtBranchStreet.Name = "txtBranchStreet";
            this.txtBranchStreet.Size = new System.Drawing.Size(173, 21);
            this.txtBranchStreet.TabIndex = 2;
            // 
            // lblBranchPostCode
            // 
            this.lblBranchPostCode.AutoSize = true;
            this.lblBranchPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchPostCode.Location = new System.Drawing.Point(13, 140);
            this.lblBranchPostCode.Name = "lblBranchPostCode";
            this.lblBranchPostCode.Size = new System.Drawing.Size(71, 15);
            this.lblBranchPostCode.TabIndex = 12;
            this.lblBranchPostCode.Text = "Postal code";
            // 
            // lblBranchCity
            // 
            this.lblBranchCity.AutoSize = true;
            this.lblBranchCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchCity.Location = new System.Drawing.Point(13, 106);
            this.lblBranchCity.Name = "lblBranchCity";
            this.lblBranchCity.Size = new System.Drawing.Size(26, 15);
            this.lblBranchCity.TabIndex = 11;
            this.lblBranchCity.Text = "City";
            // 
            // lblBranchStreet
            // 
            this.lblBranchStreet.AutoSize = true;
            this.lblBranchStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchStreet.Location = new System.Drawing.Point(13, 72);
            this.lblBranchStreet.Name = "lblBranchStreet";
            this.lblBranchStreet.Size = new System.Drawing.Size(39, 15);
            this.lblBranchStreet.TabIndex = 10;
            this.lblBranchStreet.Text = "Street";
            // 
            // txtBranchNumber
            // 
            this.txtBranchNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBranchNumber.Location = new System.Drawing.Point(137, 35);
            this.txtBranchNumber.MaxLength = 5;
            this.txtBranchNumber.Name = "txtBranchNumber";
            this.txtBranchNumber.Size = new System.Drawing.Size(173, 21);
            this.txtBranchNumber.TabIndex = 1;
            // 
            // lblBranchNumber
            // 
            this.lblBranchNumber.AutoSize = true;
            this.lblBranchNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchNumber.Location = new System.Drawing.Point(13, 41);
            this.lblBranchNumber.Name = "lblBranchNumber";
            this.lblBranchNumber.Size = new System.Drawing.Size(52, 15);
            this.lblBranchNumber.TabIndex = 8;
            this.lblBranchNumber.Text = "Number";
            // 
            // btnAddTel
            // 
            this.btnAddTel.Location = new System.Drawing.Point(76, 175);
            this.btnAddTel.Name = "btnAddTel";
            this.btnAddTel.Size = new System.Drawing.Size(173, 23);
            this.btnAddTel.TabIndex = 19;
            this.btnAddTel.Text = "Add Telephone number";
            this.btnAddTel.UseVisualStyleBackColor = true;
            this.btnAddTel.Click += new System.EventHandler(this.btnAddTel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(508, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvTelNum
            // 
            this.dgvTelNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelNum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AreaCode,
            this.Number});
            this.dgvTelNum.Location = new System.Drawing.Point(6, 19);
            this.dgvTelNum.Name = "dgvTelNum";
            this.dgvTelNum.ReadOnly = true;
            this.dgvTelNum.Size = new System.Drawing.Size(243, 150);
            this.dgvTelNum.TabIndex = 12;
            // 
            // AreaCode
            // 
            this.AreaCode.HeaderText = "Area code";
            this.AreaCode.Name = "AreaCode";
            this.AreaCode.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // gpbxTelNum
            // 
            this.gpbxTelNum.Controls.Add(this.dgvTelNum);
            this.gpbxTelNum.Controls.Add(this.btnAddTel);
            this.gpbxTelNum.Location = new System.Drawing.Point(334, 12);
            this.gpbxTelNum.Name = "gpbxTelNum";
            this.gpbxTelNum.Size = new System.Drawing.Size(255, 202);
            this.gpbxTelNum.TabIndex = 20;
            this.gpbxTelNum.TabStop = false;
            // 
            // frmRegisterBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 252);
            this.Controls.Add(this.gpbxTelNum);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpbxAddress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegisterBranch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Branch Registration";
            this.Load += new System.EventHandler(this.frmRegisterBranch_Load);
            this.grpbxAddress.ResumeLayout(false);
            this.grpbxAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnBranch)).EndInit();
            this.bnBranch.ResumeLayout(false);
            this.bnBranch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelNum)).EndInit();
            this.gpbxTelNum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpbxAddress;
        private System.Windows.Forms.TextBox txtBranchPostCode;
        private System.Windows.Forms.TextBox txtBranchCity;
        private System.Windows.Forms.TextBox txtBranchStreet;
        private System.Windows.Forms.Label lblBranchPostCode;
        private System.Windows.Forms.Label lblBranchCity;
        private System.Windows.Forms.Label lblBranchStreet;
        private System.Windows.Forms.TextBox txtBranchNumber;
        private System.Windows.Forms.Label lblBranchNumber;
        private System.Windows.Forms.Button btnAddTel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblBranchId;
        private System.Windows.Forms.BindingNavigator bnBranch;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripButton tsbAddNew;
        private System.Windows.Forms.DataGridView dgvTelNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbxTelNum;
    }
}