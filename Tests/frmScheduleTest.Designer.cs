namespace Driving_System.Tests
{
    partial class frmScheduleTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.crtlScheduleTest1 = new Driving_System.Tests.Controls.crtlScheduleTest();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Driving_System.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(187, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crtlScheduleTest1
            // 
            this.crtlScheduleTest1.BackColor = System.Drawing.Color.White;
            this.crtlScheduleTest1.Location = new System.Drawing.Point(13, 14);
            this.crtlScheduleTest1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crtlScheduleTest1.Name = "crtlScheduleTest1";
            this.crtlScheduleTest1.Size = new System.Drawing.Size(495, 602);
            this.crtlScheduleTest1.TabIndex = 0;
            this.crtlScheduleTest1.TestTypeID = BusinessLayer.clsTestTypesBusiness.enTestTypes.Vision;
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crtlScheduleTest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmScheduleTest";
            this.Text = "frmScheduleTest";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.crtlScheduleTest crtlScheduleTest1;
        private System.Windows.Forms.Button button1;
    }
}