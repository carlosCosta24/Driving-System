namespace Driving_System
{
    partial class AddNewPerson
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
            this.userControl11 = new Driving_System.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl11.Location = new System.Drawing.Point(13, 14);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1370, 749);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // AddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 786);
            this.Controls.Add(this.userControl11);
            this.Name = "AddNewPerson";
            this.Text = "AddNewPerson";
            this.Load += new System.EventHandler(this.AddNewPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
    }
}