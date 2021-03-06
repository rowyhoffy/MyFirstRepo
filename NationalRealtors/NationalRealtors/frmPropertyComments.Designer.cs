﻿namespace NationalRealtors
{
    partial class frmPropertyComments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropertyComments));
            this.label1 = new System.Windows.Forms.Label();
            this.ddlProperty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtComments = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dsNationalRealtors = new NationalRealtors.dsNationalRealtors();
            this.pROPERTYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROPERTYTableAdapter = new NationalRealtors.dsNationalRealtorsTableAdapters.PROPERTYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPERTYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property viewed";
            // 
            // ddlProperty
            // 
            this.ddlProperty.DataSource = this.pROPERTYBindingSource;
            this.ddlProperty.DisplayMember = "PropertyStreet";
            this.ddlProperty.FormattingEnabled = true;
            this.ddlProperty.Location = new System.Drawing.Point(112, 12);
            this.ddlProperty.Name = "ddlProperty";
            this.ddlProperty.Size = new System.Drawing.Size(267, 21);
            this.ddlProperty.TabIndex = 1;
            this.ddlProperty.ValueMember = "PropertyId";
            this.ddlProperty.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ddlProperty_Format);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comments";
            // 
            // rtxtComments
            // 
            this.rtxtComments.Location = new System.Drawing.Point(112, 39);
            this.rtxtComments.Name = "rtxtComments";
            this.rtxtComments.Size = new System.Drawing.Size(267, 84);
            this.rtxtComments.TabIndex = 3;
            this.rtxtComments.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(223, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dsNationalRealtors
            // 
            this.dsNationalRealtors.DataSetName = "dsNationalRealtors";
            this.dsNationalRealtors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmPropertyComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 168);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtComments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlProperty);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPropertyComments";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Property comments";
            this.Load += new System.EventHandler(this.frmPropertyComments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsNationalRealtors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROPERTYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlProperty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtComments;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private dsNationalRealtors dsNationalRealtors;
        private System.Windows.Forms.BindingSource pROPERTYBindingSource;
        private dsNationalRealtorsTableAdapters.PROPERTYTableAdapter pROPERTYTableAdapter;
    }
}