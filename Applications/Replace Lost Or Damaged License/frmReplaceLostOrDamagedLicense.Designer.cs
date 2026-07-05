namespace Driving_System.Applications.Replace_Lost_Or_Damaged_License
{
    partial class frmReplaceLostOrDamagedLicense
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
            this.ctrlLicenseInfoWithFilter1 = new Driving_System.Licenses.Local_Licenses.Controls.ctrlLicenseInfoWithFilter();
            this.gbReplacement = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.llLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.llNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.gbAppInfoForReplacement = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbvCreatedByUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbvOldLicenseID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbvReplacementLicenseID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbvFees = new System.Windows.Forms.Label();
            this.lbvAppFees = new System.Windows.Forms.Label();
            this.lbvDate = new System.Windows.Forms.Label();
            this.lbvAppDate = new System.Windows.Forms.Label();
            this.lbvReplacementAppID = new System.Windows.Forms.Label();
            this.lable9 = new System.Windows.Forms.Label();
            this.gbReplacement.SuspendLayout();
            this.gbAppInfoForReplacement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLicenseInfoWithFilter1
            // 
            this.ctrlLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 127);
            this.ctrlLicenseInfoWithFilter1.Name = "ctrlLicenseInfoWithFilter1";
            this.ctrlLicenseInfoWithFilter1.Size = new System.Drawing.Size(825, 409);
            this.ctrlLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlLicenseInfoWithFilter1.OnLicenseSelect += new System.Action<int>(this.ctrlLicenseInfoWithFilter1_OnLicenseSelect);
            // 
            // gbReplacement
            // 
            this.gbReplacement.Controls.Add(this.label2);
            this.gbReplacement.Controls.Add(this.rbLost);
            this.gbReplacement.Controls.Add(this.rbDamaged);
            this.gbReplacement.Location = new System.Drawing.Point(12, 44);
            this.gbReplacement.Name = "gbReplacement";
            this.gbReplacement.Size = new System.Drawing.Size(394, 77);
            this.gbReplacement.TabIndex = 1;
            this.gbReplacement.TabStop = false;
            this.gbReplacement.Text = "Replacement Reason ";
            this.gbReplacement.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reason:";
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLost.Location = new System.Drawing.Point(267, 32);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(70, 29);
            this.rbLost.TabIndex = 1;
            this.rbLost.TabStop = true;
            this.rbLost.Text = "Lost";
            this.rbLost.UseVisualStyleBackColor = true;
            this.rbLost.CheckedChanged += new System.EventHandler(this.rbLost_CheckedChanged);
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDamaged.Location = new System.Drawing.Point(131, 32);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(118, 29);
            this.rbDamaged.TabIndex = 0;
            this.rbDamaged.TabStop = true;
            this.rbDamaged.Text = "Damaged";
            this.rbDamaged.UseVisualStyleBackColor = true;
            this.rbDamaged.CheckedChanged += new System.EventHandler(this.rbDamaged_CheckedChanged);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(345, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(288, 32);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "License Replacement";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Driving_System.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(625, 687);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Image = global::Driving_System.Properties.Resources.License_Type_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(724, 687);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(93, 33);
            this.btnIssue.TabIndex = 4;
            this.btnIssue.Text = "Isuue";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // llLicenseHistory
            // 
            this.llLicenseHistory.AutoSize = true;
            this.llLicenseHistory.Enabled = false;
            this.llLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLicenseHistory.Location = new System.Drawing.Point(15, 695);
            this.llLicenseHistory.Name = "llLicenseHistory";
            this.llLicenseHistory.Size = new System.Drawing.Size(200, 25);
            this.llLicenseHistory.TabIndex = 5;
            this.llLicenseHistory.TabStop = true;
            this.llLicenseHistory.Text = "Show License History";
            this.llLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLicenseHistory_LinkClicked);
            // 
            // llNewLicenseInfo
            // 
            this.llNewLicenseInfo.AutoSize = true;
            this.llNewLicenseInfo.Enabled = false;
            this.llNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llNewLicenseInfo.Location = new System.Drawing.Point(249, 695);
            this.llNewLicenseInfo.Name = "llNewLicenseInfo";
            this.llNewLicenseInfo.Size = new System.Drawing.Size(216, 25);
            this.llNewLicenseInfo.TabIndex = 6;
            this.llNewLicenseInfo.TabStop = true;
            this.llNewLicenseInfo.Text = "Show New License Info";
            this.llNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNewLicenseInfo_LinkClicked);
            // 
            // gbAppInfoForReplacement
            // 
            this.gbAppInfoForReplacement.Controls.Add(this.pictureBox1);
            this.gbAppInfoForReplacement.Controls.Add(this.pictureBox4);
            this.gbAppInfoForReplacement.Controls.Add(this.pictureBox5);
            this.gbAppInfoForReplacement.Controls.Add(this.lbvCreatedByUser);
            this.gbAppInfoForReplacement.Controls.Add(this.label4);
            this.gbAppInfoForReplacement.Controls.Add(this.lbvOldLicenseID);
            this.gbAppInfoForReplacement.Controls.Add(this.label6);
            this.gbAppInfoForReplacement.Controls.Add(this.lbvReplacementLicenseID);
            this.gbAppInfoForReplacement.Controls.Add(this.label8);
            this.gbAppInfoForReplacement.Controls.Add(this.pictureBox8);
            this.gbAppInfoForReplacement.Controls.Add(this.pictureBox3);
            this.gbAppInfoForReplacement.Controls.Add(this.pictureBox2);
            this.gbAppInfoForReplacement.Controls.Add(this.lbvFees);
            this.gbAppInfoForReplacement.Controls.Add(this.lbvAppFees);
            this.gbAppInfoForReplacement.Controls.Add(this.lbvDate);
            this.gbAppInfoForReplacement.Controls.Add(this.lbvAppDate);
            this.gbAppInfoForReplacement.Controls.Add(this.lbvReplacementAppID);
            this.gbAppInfoForReplacement.Controls.Add(this.lable9);
            this.gbAppInfoForReplacement.Location = new System.Drawing.Point(20, 524);
            this.gbAppInfoForReplacement.Name = "gbAppInfoForReplacement";
            this.gbAppInfoForReplacement.Size = new System.Drawing.Size(797, 157);
            this.gbAppInfoForReplacement.TabIndex = 7;
            this.gbAppInfoForReplacement.TabStop = false;
            this.gbAppInfoForReplacement.Text = "Replacement App Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Driving_System.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(567, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Driving_System.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(567, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Driving_System.Properties.Resources.Number_32;
            this.pictureBox5.Location = new System.Drawing.Point(567, 65);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // lbvCreatedByUser
            // 
            this.lbvCreatedByUser.AutoSize = true;
            this.lbvCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvCreatedByUser.Location = new System.Drawing.Point(640, 98);
            this.lbvCreatedByUser.Name = "lbvCreatedByUser";
            this.lbvCreatedByUser.Size = new System.Drawing.Size(19, 25);
            this.lbvCreatedByUser.TabIndex = 38;
            this.lbvCreatedByUser.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Created By:";
            // 
            // lbvOldLicenseID
            // 
            this.lbvOldLicenseID.AutoSize = true;
            this.lbvOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvOldLicenseID.Location = new System.Drawing.Point(640, 65);
            this.lbvOldLicenseID.Name = "lbvOldLicenseID";
            this.lbvOldLicenseID.Size = new System.Drawing.Size(19, 25);
            this.lbvOldLicenseID.TabIndex = 36;
            this.lbvOldLicenseID.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Old License ID:";
            // 
            // lbvReplacementLicenseID
            // 
            this.lbvReplacementLicenseID.AutoSize = true;
            this.lbvReplacementLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvReplacementLicenseID.Location = new System.Drawing.Point(640, 32);
            this.lbvReplacementLicenseID.Name = "lbvReplacementLicenseID";
            this.lbvReplacementLicenseID.Size = new System.Drawing.Size(19, 25);
            this.lbvReplacementLicenseID.TabIndex = 34;
            this.lbvReplacementLicenseID.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Replacement License ID:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Driving_System.Properties.Resources.money_32;
            this.pictureBox8.Location = new System.Drawing.Point(199, 100);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 23);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 32;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Driving_System.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(199, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Driving_System.Properties.Resources.Calendar_32;
            this.pictureBox2.Location = new System.Drawing.Point(199, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // lbvFees
            // 
            this.lbvFees.AutoSize = true;
            this.lbvFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvFees.Location = new System.Drawing.Point(272, 98);
            this.lbvFees.Name = "lbvFees";
            this.lbvFees.Size = new System.Drawing.Size(19, 25);
            this.lbvFees.TabIndex = 29;
            this.lbvFees.Text = "-";
            // 
            // lbvAppFees
            // 
            this.lbvAppFees.AutoSize = true;
            this.lbvAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvAppFees.Location = new System.Drawing.Point(81, 98);
            this.lbvAppFees.Name = "lbvAppFees";
            this.lbvAppFees.Size = new System.Drawing.Size(103, 25);
            this.lbvAppFees.TabIndex = 28;
            this.lbvAppFees.Text = "App Fees:";
            // 
            // lbvDate
            // 
            this.lbvDate.AutoSize = true;
            this.lbvDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvDate.Location = new System.Drawing.Point(272, 65);
            this.lbvDate.Name = "lbvDate";
            this.lbvDate.Size = new System.Drawing.Size(19, 25);
            this.lbvDate.TabIndex = 27;
            this.lbvDate.Text = "-";
            // 
            // lbvAppDate
            // 
            this.lbvAppDate.AutoSize = true;
            this.lbvAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvAppDate.Location = new System.Drawing.Point(81, 65);
            this.lbvAppDate.Name = "lbvAppDate";
            this.lbvAppDate.Size = new System.Drawing.Size(100, 25);
            this.lbvAppDate.TabIndex = 26;
            this.lbvAppDate.Text = "App Date:";
            // 
            // lbvReplacementAppID
            // 
            this.lbvReplacementAppID.AutoSize = true;
            this.lbvReplacementAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvReplacementAppID.Location = new System.Drawing.Point(272, 32);
            this.lbvReplacementAppID.Name = "lbvReplacementAppID";
            this.lbvReplacementAppID.Size = new System.Drawing.Size(19, 25);
            this.lbvReplacementAppID.TabIndex = 25;
            this.lbvReplacementAppID.Text = "-";
            // 
            // lable9
            // 
            this.lable9.AutoSize = true;
            this.lable9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable9.Location = new System.Drawing.Point(81, 32);
            this.lable9.Name = "lable9";
            this.lable9.Size = new System.Drawing.Size(112, 25);
            this.lable9.TabIndex = 24;
            this.lable9.Text = "L.R.App ID:";
            // 
            // frmReplaceLostOrDamagedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 729);
            this.Controls.Add(this.gbAppInfoForReplacement);
            this.Controls.Add(this.llNewLicenseInfo);
            this.Controls.Add(this.llLicenseHistory);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gbReplacement);
            this.Controls.Add(this.ctrlLicenseInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplaceLostOrDamagedLicense";
            this.Text = "License Replacement";
            this.Activated += new System.EventHandler(this.frmReplaceLostOrDamagedLicense_Activated);
            this.Load += new System.EventHandler(this.frmReplaceLostOrDamagedLicense_Load);
            this.gbReplacement.ResumeLayout(false);
            this.gbReplacement.PerformLayout();
            this.gbAppInfoForReplacement.ResumeLayout(false);
            this.gbAppInfoForReplacement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Local_Licenses.Controls.ctrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbReplacement;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbLost;
        private System.Windows.Forms.RadioButton rbDamaged;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.LinkLabel llLicenseHistory;
        private System.Windows.Forms.LinkLabel llNewLicenseInfo;
        private System.Windows.Forms.GroupBox gbAppInfoForReplacement;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbvFees;
        private System.Windows.Forms.Label lbvAppFees;
        private System.Windows.Forms.Label lbvDate;
        private System.Windows.Forms.Label lbvAppDate;
        private System.Windows.Forms.Label lbvReplacementAppID;
        private System.Windows.Forms.Label lable9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbvCreatedByUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbvOldLicenseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbvReplacementLicenseID;
        private System.Windows.Forms.Label label8;
    }
}