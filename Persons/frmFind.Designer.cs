namespace Driving_System.Persons
{
    partial class frmFind
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.crtlPersonCardWithFilter2 = new Driving_System.Persons.controls.crtlPersonCardWithFilter();
            this.crtlPersonCardWithFilter1 = new Driving_System.Persons.controls.crtlPersonCardWithFilter();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(337, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(70, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Find";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Driving_System.Properties.Resources.closeBlack32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(817, 494);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // crtlPersonCardWithFilter2
            // 
            this.crtlPersonCardWithFilter2.FilterEnabled = true;
            this.crtlPersonCardWithFilter2.Location = new System.Drawing.Point(12, 44);
            this.crtlPersonCardWithFilter2.Name = "crtlPersonCardWithFilter2";
            this.crtlPersonCardWithFilter2.ShowAddPerson = true;
            this.crtlPersonCardWithFilter2.Size = new System.Drawing.Size(956, 444);
            this.crtlPersonCardWithFilter2.TabIndex = 3;
            // 
            // crtlPersonCardWithFilter1
            // 
            this.crtlPersonCardWithFilter1.FilterEnabled = true;
            this.crtlPersonCardWithFilter1.Location = new System.Drawing.Point(6, 44);
            this.crtlPersonCardWithFilter1.Name = "crtlPersonCardWithFilter1";
            this.crtlPersonCardWithFilter1.ShowAddPerson = true;
            this.crtlPersonCardWithFilter1.Size = new System.Drawing.Size(798, 444);
            this.crtlPersonCardWithFilter1.TabIndex = 1;
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.crtlPersonCardWithFilter2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmFind";
            this.Text = "frmFind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private controls.crtlPersonCardWithFilter crtlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnClose;
        private controls.crtlPersonCardWithFilter crtlPersonCardWithFilter2;
    }
}