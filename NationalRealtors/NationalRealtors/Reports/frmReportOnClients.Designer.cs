namespace NationalRealtors.Reports
{
    partial class frmReportOnClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportOnClients));
            this.pnlClientsLookingToRent = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvClientsLookingToRent = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlClientsLookingToRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsLookingToRent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlClientsLookingToRent
            // 
            this.pnlClientsLookingToRent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlClientsLookingToRent.Controls.Add(this.label3);
            this.pnlClientsLookingToRent.Controls.Add(this.dgvClientsLookingToRent);
            this.pnlClientsLookingToRent.Controls.Add(this.label2);
            this.pnlClientsLookingToRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClientsLookingToRent.Location = new System.Drawing.Point(0, 0);
            this.pnlClientsLookingToRent.Name = "pnlClientsLookingToRent";
            this.pnlClientsLookingToRent.Size = new System.Drawing.Size(470, 267);
            this.pnlClientsLookingToRent.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Report on Clients";
            // 
            // dgvClientsLookingToRent
            // 
            this.dgvClientsLookingToRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsLookingToRent.Location = new System.Drawing.Point(12, 54);
            this.dgvClientsLookingToRent.Name = "dgvClientsLookingToRent";
            this.dgvClientsLookingToRent.Size = new System.Drawing.Size(445, 198);
            this.dgvClientsLookingToRent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "National Realtors";
            // 
            // frmReportOnClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 267);
            this.Controls.Add(this.pnlClientsLookingToRent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportOnClients";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clients Looking for Accommodation";
            this.Load += new System.EventHandler(this.frmReportOnClients_Load);
            this.pnlClientsLookingToRent.ResumeLayout(false);
            this.pnlClientsLookingToRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsLookingToRent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClientsLookingToRent;
        private System.Windows.Forms.DataGridView dgvClientsLookingToRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}