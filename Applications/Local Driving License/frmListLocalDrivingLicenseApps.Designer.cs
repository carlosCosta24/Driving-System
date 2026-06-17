namespace Driving_System.Applications.Local_Driving_License
{
    partial class frmListLocalDrivingLicenseApps
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocalDrivingAppList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterCategory = new System.Windows.Forms.ComboBox();
            this.tbFilterText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbvRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingAppList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local Driving License";
            // 
            // dgvLocalDrivingAppList
            // 
            this.dgvLocalDrivingAppList.AllowUserToAddRows = false;
            this.dgvLocalDrivingAppList.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingAppList.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalDrivingAppList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingAppList.Location = new System.Drawing.Point(12, 267);
            this.dgvLocalDrivingAppList.Name = "dgvLocalDrivingAppList";
            this.dgvLocalDrivingAppList.ReadOnly = true;
            this.dgvLocalDrivingAppList.RowHeadersWidth = 51;
            this.dgvLocalDrivingAppList.RowTemplate.Height = 24;
            this.dgvLocalDrivingAppList.Size = new System.Drawing.Size(776, 210);
            this.dgvLocalDrivingAppList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By";
            // 
            // cbFilterCategory
            // 
            this.cbFilterCategory.FormattingEnabled = true;
            this.cbFilterCategory.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No.",
            "Full Name",
            "Status "});
            this.cbFilterCategory.Location = new System.Drawing.Point(100, 232);
            this.cbFilterCategory.Name = "cbFilterCategory";
            this.cbFilterCategory.Size = new System.Drawing.Size(141, 24);
            this.cbFilterCategory.TabIndex = 4;
            this.cbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cbFilterCategory_SelectedIndexChanged);
            // 
            // tbFilterText
            // 
            this.tbFilterText.Location = new System.Drawing.Point(247, 232);
            this.tbFilterText.Multiline = true;
            this.tbFilterText.Name = "tbFilterText";
            this.tbFilterText.Size = new System.Drawing.Size(153, 24);
            this.tbFilterText.TabIndex = 5;
            this.tbFilterText.TextChanged += new System.EventHandler(this.tbFilterText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Records";
            // 
            // lbvRecords
            // 
            this.lbvRecords.AutoSize = true;
            this.lbvRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvRecords.Location = new System.Drawing.Point(95, 525);
            this.lbvRecords.Name = "lbvRecords";
            this.lbvRecords.Size = new System.Drawing.Size(19, 25);
            this.lbvRecords.TabIndex = 9;
            this.lbvRecords.Text = "-";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Driving_System.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(668, 510);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 31);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddApp
            // 
            this.btnAddApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApp.Image = global::Driving_System.Properties.Resources.AddPerson_32;
            this.btnAddApp.Location = new System.Drawing.Point(734, 213);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(54, 43);
            this.btnAddApp.TabIndex = 6;
            this.btnAddApp.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Driving_System.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(312, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.sechduleTestsToolStripMenuItem,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(293, 224);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            // 
            // sechduleTestsToolStripMenuItem
            // 
            this.sechduleTestsToolStripMenuItem.Name = "sechduleTestsToolStripMenuItem";
            this.sechduleTestsToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.sechduleTestsToolStripMenuItem.Text = "Schedule Tests";
            this.sechduleTestsToolStripMenuItem.Click += new System.EventHandler(this.sechduleTestsToolStripMenuItem_Click);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History ";
            // 
            // frmListLocalDrivingLicenseApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.lbvRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.tbFilterText);
            this.Controls.Add(this.cbFilterCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLocalDrivingAppList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListLocalDrivingLicenseApps";
            this.Text = "frmListLocalDrivingLicenseApps";
            this.Load += new System.EventHandler(this.frmListLocalDrivingLicenseApps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingAppList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocalDrivingAppList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterCategory;
        private System.Windows.Forms.TextBox tbFilterText;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbvRecords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}