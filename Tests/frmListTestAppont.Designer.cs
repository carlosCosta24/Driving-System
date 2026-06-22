namespace Driving_System.Tests
{
    partial class frmListTestAppont
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
            this.ctrlDrivingLicenseAppInfo1 = new Driving_System.Applications.Local_Driving_License.ctrlDrivingLicenseAppInfo();
            this.dgvTestAppontList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbvRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddAppont = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbTestImage = new System.Windows.Forms.PictureBox();
            this.lbvTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppontList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDrivingLicenseAppInfo1
            // 
            this.ctrlDrivingLicenseAppInfo1.Location = new System.Drawing.Point(12, 116);
            this.ctrlDrivingLicenseAppInfo1.Name = "ctrlDrivingLicenseAppInfo1";
            this.ctrlDrivingLicenseAppInfo1.Size = new System.Drawing.Size(781, 436);
            this.ctrlDrivingLicenseAppInfo1.TabIndex = 0;
            // 
            // dgvTestAppontList
            // 
            this.dgvTestAppontList.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestAppontList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppontList.Location = new System.Drawing.Point(12, 595);
            this.dgvTestAppontList.Name = "dgvTestAppontList";
            this.dgvTestAppontList.RowHeadersWidth = 51;
            this.dgvTestAppontList.RowTemplate.Height = 24;
            this.dgvTestAppontList.Size = new System.Drawing.Size(781, 156);
            this.dgvTestAppontList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 763);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Record: ";
            // 
            // lbvRecord
            // 
            this.lbvRecord.AutoSize = true;
            this.lbvRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvRecord.Location = new System.Drawing.Point(103, 764);
            this.lbvRecord.Name = "lbvRecord";
            this.lbvRecord.Size = new System.Drawing.Size(19, 25);
            this.lbvRecord.TabIndex = 3;
            this.lbvRecord.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Appointments:";
            // 
            // btnAddAppont
            // 
            this.btnAddAppont.BackColor = System.Drawing.Color.White;
            this.btnAddAppont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppont.Image = global::Driving_System.Properties.Resources.AddAppointment_32;
            this.btnAddAppont.Location = new System.Drawing.Point(758, 558);
            this.btnAddAppont.Name = "btnAddAppont";
            this.btnAddAppont.Size = new System.Drawing.Size(35, 31);
            this.btnAddAppont.TabIndex = 6;
            this.btnAddAppont.UseVisualStyleBackColor = false;
            this.btnAddAppont.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Driving_System.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(679, 757);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAppointmentToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // editAppointmentToolStripMenuItem
            // 
            this.editAppointmentToolStripMenuItem.Name = "editAppointmentToolStripMenuItem";
            this.editAppointmentToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.editAppointmentToolStripMenuItem.Text = "Edit ";
            this.editAppointmentToolStripMenuItem.Click += new System.EventHandler(this.editAppointmentToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // pbTestImage
            // 
            this.pbTestImage.Image = global::Driving_System.Properties.Resources.Vision_512;
            this.pbTestImage.Location = new System.Drawing.Point(318, 44);
            this.pbTestImage.Name = "pbTestImage";
            this.pbTestImage.Size = new System.Drawing.Size(114, 69);
            this.pbTestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestImage.TabIndex = 8;
            this.pbTestImage.TabStop = false;
            // 
            // lbvTitle
            // 
            this.lbvTitle.AutoSize = true;
            this.lbvTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvTitle.ForeColor = System.Drawing.Color.Red;
            this.lbvTitle.Location = new System.Drawing.Point(297, 9);
            this.lbvTitle.Name = "lbvTitle";
            this.lbvTitle.Size = new System.Drawing.Size(155, 32);
            this.lbvTitle.TabIndex = 9;
            this.lbvTitle.Text = "Vision Test";
            // 
            // frmListTestAppont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 800);
            this.Controls.Add(this.lbvTitle);
            this.Controls.Add(this.pbTestImage);
            this.Controls.Add(this.btnAddAppont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbvRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTestAppontList);
            this.Controls.Add(this.ctrlDrivingLicenseAppInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListTestAppont";
            this.Text = "frmListTestAppont";
            this.Load += new System.EventHandler(this.frmListTestAppont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppontList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.Local_Driving_License.ctrlDrivingLicenseAppInfo ctrlDrivingLicenseAppInfo1;
        private System.Windows.Forms.DataGridView dgvTestAppontList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbvRecord;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAppont;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbTestImage;
        private System.Windows.Forms.Label lbvTitle;
    }
}