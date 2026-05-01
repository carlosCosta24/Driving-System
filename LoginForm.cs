using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_System
{
    public partial class LoginForm : Form
    {
        clsUserBusiness User = new clsUserBusiness();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUserName.Text) && !string.IsNullOrEmpty(tbPassword.Text) && User.IsValid(tbUserName.Text, tbPassword.Text).UserID != -1)
            {
                MessageBox.Show("Success", "Welecom in ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else {
                MessageBox.Show("Username/Password is inncorect??", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
