namespace Driving_System.Applications.Local_Driving_License
{
    partial class frmAddUpdateLocalDrivingLicenseApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.tbAppInfo = new System.Windows.Forms.TabPage();
            this.crtlPersonCardWithFilter1 = new Driving_System.Persons.controls.crtlPersonCardWithFilter();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbvDLAppID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbvAppDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbvFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbvUserID = new System.Windows.Forms.Label();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbFormName = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbAppInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPersonInfo);
            this.tabControl1.Controls.Add(this.tbAppInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(979, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.btnNext);
            this.tbPersonInfo.Controls.Add(this.crtlPersonCardWithFilter1);
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(971, 508);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Personal Info";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // tbAppInfo
            // 
            this.tbAppInfo.Controls.Add(this.pictureBox5);
            this.tbAppInfo.Controls.Add(this.pictureBox4);
            this.tbAppInfo.Controls.Add(this.pictureBox3);
            this.tbAppInfo.Controls.Add(this.pictureBox2);
            this.tbAppInfo.Controls.Add(this.pictureBox1);
            this.tbAppInfo.Controls.Add(this.cbLicenseClass);
            this.tbAppInfo.Controls.Add(this.lbvUserID);
            this.tbAppInfo.Controls.Add(this.label8);
            this.tbAppInfo.Controls.Add(this.lbvFees);
            this.tbAppInfo.Controls.Add(this.label6);
            this.tbAppInfo.Controls.Add(this.label5);
            this.tbAppInfo.Controls.Add(this.lbvAppDate);
            this.tbAppInfo.Controls.Add(this.label3);
            this.tbAppInfo.Controls.Add(this.lbvDLAppID);
            this.tbAppInfo.Controls.Add(this.label1);
            this.tbAppInfo.Location = new System.Drawing.Point(4, 25);
            this.tbAppInfo.Name = "tbAppInfo";
            this.tbAppInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbAppInfo.Size = new System.Drawing.Size(971, 508);
            this.tbAppInfo.TabIndex = 1;
            this.tbAppInfo.Text = "Application Info";
            this.tbAppInfo.UseVisualStyleBackColor = true;
            // 
            // crtlPersonCardWithFilter1
            // 
            this.crtlPersonCardWithFilter1.FilterEnabled = true;
            this.crtlPersonCardWithFilter1.Location = new System.Drawing.Point(6, 6);
            this.crtlPersonCardWithFilter1.Name = "crtlPersonCardWithFilter1";
            this.crtlPersonCardWithFilter1.ShowAddPerson = true;
            this.crtlPersonCardWithFilter1.Size = new System.Drawing.Size(956, 441);
            this.crtlPersonCardWithFilter1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::Driving_System.Properties.Resources.arrow_right;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(818, 453);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 29);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Driving_System.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(704, 611);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Driving_System.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(834, 611);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driving License App ID: ";
            // 
            // lbvDLAppID
            // 
            this.lbvDLAppID.AutoSize = true;
            this.lbvDLAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvDLAppID.Location = new System.Drawing.Point(395, 66);
            this.lbvDLAppID.Name = "lbvDLAppID";
            this.lbvDLAppID.Size = new System.Drawing.Size(19, 25);
            this.lbvDLAppID.TabIndex = 1;
            this.lbvDLAppID.Text = "-";
            this.lbvDLAppID.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Application Date:";
            // 
            // lbvAppDate
            // 
            this.lbvAppDate.AutoSize = true;
            this.lbvAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvAppDate.Location = new System.Drawing.Point(395, 144);
            this.lbvAppDate.Name = "lbvAppDate";
            this.lbvAppDate.Size = new System.Drawing.Size(19, 25);
            this.lbvAppDate.TabIndex = 3;
            this.lbvAppDate.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "License Class:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Application Fees:";
            // 
            // lbvFees
            // 
            this.lbvFees.AutoSize = true;
            this.lbvFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvFees.Location = new System.Drawing.Point(395, 282);
            this.lbvFees.Name = "lbvFees";
            this.lbvFees.Size = new System.Drawing.Size(19, 25);
            this.lbvFees.TabIndex = 6;
            this.lbvFees.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Created By: ";
            // 
            // lbvUserID
            // 
            this.lbvUserID.AutoSize = true;
            this.lbvUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvUserID.Location = new System.Drawing.Point(395, 357);
            this.lbvUserID.Name = "lbvUserID";
            this.lbvUserID.Size = new System.Drawing.Size(19, 25);
            this.lbvUserID.TabIndex = 8;
            this.lbvUserID.Text = "-";
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(348, 213);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(256, 33);
            this.cbLicenseClass.TabIndex = 9;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Driving_System.Properties.Resources.download__3_;
            this.pictureBox5.Location = new System.Drawing.Point(261, 359);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Driving_System.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(261, 282);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Driving_System.Properties.Resources.License_View_32;
            this.pictureBox3.Location = new System.Drawing.Point(261, 213);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Driving_System.Properties.Resources.Calendar_32;
            this.pictureBox2.Location = new System.Drawing.Point(261, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Driving_System.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(307, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbFormName
            // 
            this.lbFormName.AutoSize = true;
            this.lbFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormName.ForeColor = System.Drawing.Color.Red;
            this.lbFormName.Location = new System.Drawing.Point(243, 9);
            this.lbFormName.Name = "lbFormName";
            this.lbFormName.Size = new System.Drawing.Size(434, 32);
            this.lbFormName.TabIndex = 4;
            this.lbFormName.Text = "Local Driving License Application";
            // 
            // frmAddUpdateLocalDrivingLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 661);
            this.Controls.Add(this.lbFormName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateLocalDrivingLicenseApp";
            this.Text = "frmAddUpdateLocalDrivingLicenseApp";
            this.Load += new System.EventHandler(this.frmAddUpdateLocalDrivingLicenseApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tbAppInfo.ResumeLayout(false);
            this.tbAppInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private System.Windows.Forms.TabPage tbAppInfo;
        private System.Windows.Forms.Button btnNext;
        private Persons.controls.crtlPersonCardWithFilter crtlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbvUserID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbvFees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbvAppDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbvDLAppID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.Label lbFormName;
    }
}