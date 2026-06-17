namespace Driving_System.Applications.Local_Driving_License
{
    partial class frmLocalDrivingLicenseAppInfo
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
            this.ctrlDrivingLicenseAppInfo1 = new Driving_System.Applications.Local_Driving_License.ctrlDrivingLicenseAppInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlDrivingLicenseAppInfo1
            // 
            this.ctrlDrivingLicenseAppInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlDrivingLicenseAppInfo1.Name = "ctrlDrivingLicenseAppInfo1";
            this.ctrlDrivingLicenseAppInfo1.Size = new System.Drawing.Size(806, 442);
            this.ctrlDrivingLicenseAppInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Driving_System.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(673, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLocalDrivingLicenseAppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 497);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlDrivingLicenseAppInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLocalDrivingLicenseAppInfo";
            this.Text = "frmLocalDrivingLicenseAppInfo";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseAppInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDrivingLicenseAppInfo ctrlDrivingLicenseAppInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}