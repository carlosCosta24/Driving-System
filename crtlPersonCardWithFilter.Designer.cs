namespace Driving_System
{
    partial class crtlPersonCardWithFilter
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbFilter = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crtlPersonCard1
            // 
            this.crtlPersonCard1.Location = new System.Drawing.Point(55, 117);
            this.crtlPersonCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crtlPersonCard1.Name = "crtlPersonCard1";
            this.crtlPersonCard1.Size = new System.Drawing.Size(795, 321);
            this.crtlPersonCard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(52, 59);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(55, 16);
            this.lbFilter.TabIndex = 2;
            this.lbFilter.Text = "Filter By";
            // 
            // cbFilter
            // 
            this.cbFilter.AllowDrop = true;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Person ID",
            "National ID"});
            this.cbFilter.Location = new System.Drawing.Point(117, 53);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(182, 24);
            this.cbFilter.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 24);
            this.textBox1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Driving_System.Properties.Resources.add__1_;
            this.btnAdd.Location = new System.Drawing.Point(701, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Driving_System.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(572, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // crtlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crtlPersonCard1);
            this.Name = "crtlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(924, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private crtlPersonCard crtlPersonCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
    }
}
