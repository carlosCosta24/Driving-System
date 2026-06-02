namespace Driving_System.Users
{
    partial class crtlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crtlPersonCard1 = new Driving_System.crtlPersonCard();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbvUserID = new System.Windows.Forms.Label();
            this.lbvUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbvIsActive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crtlPersonCard1
            // 
            this.crtlPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.crtlPersonCard1.Name = "crtlPersonCard1";
            this.crtlPersonCard1.Size = new System.Drawing.Size(949, 315);
            this.crtlPersonCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbvIsActive);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbvUserName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbvUserID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID";
            // 
            // lbvUserID
            // 
            this.lbvUserID.AutoSize = true;
            this.lbvUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvUserID.Location = new System.Drawing.Point(143, 18);
            this.lbvUserID.Name = "lbvUserID";
            this.lbvUserID.Size = new System.Drawing.Size(23, 32);
            this.lbvUserID.TabIndex = 1;
            this.lbvUserID.Text = "-";
            // 
            // lbvUserName
            // 
            this.lbvUserName.AutoSize = true;
            this.lbvUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvUserName.Location = new System.Drawing.Point(493, 18);
            this.lbvUserName.Name = "lbvUserName";
            this.lbvUserName.Size = new System.Drawing.Size(23, 32);
            this.lbvUserName.TabIndex = 3;
            this.lbvUserName.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(339, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "UserName";
            // 
            // lbvIsActive
            // 
            this.lbvIsActive.AutoSize = true;
            this.lbvIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvIsActive.Location = new System.Drawing.Point(752, 18);
            this.lbvIsActive.Name = "lbvIsActive";
            this.lbvIsActive.Size = new System.Drawing.Size(23, 32);
            this.lbvIsActive.TabIndex = 5;
            this.lbvIsActive.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(633, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "IsActive";
            // 
            // crtlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crtlPersonCard1);
            this.Name = "crtlUserCard";
            this.Size = new System.Drawing.Size(962, 422);
            this.Load += new System.EventHandler(this.crtlUserCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private crtlPersonCard crtlPersonCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbvIsActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbvUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbvUserID;
        private System.Windows.Forms.Label label1;
    }
}
