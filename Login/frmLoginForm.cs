using BusinessLayer;
using Driving_System.Global;
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
    public partial class frmLoginForm : Form
    {
        
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string UserName = "";
            string Password = "";
            if (clsGlobal.GetCredentials(ref UserName, ref Password))
            {
                tbUserName.Text = UserName;
                tbPassword.Text = Password;
                chbRemeberMe.Checked = true;
            }
            else 
            {
                chbRemeberMe.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUserBusiness User = clsUserBusiness.FindByUserNameAndPassword(tbUserName.Text.Trim(), tbPassword.Text.Trim());

            if (User != null)
            {
                if (chbRemeberMe.Checked)
                {
                    clsGlobal.SaveCredentials(tbUserName.Text.Trim(), tbPassword.Text.Trim());
                }
                else
                {
                    clsGlobal.SaveCredentials("", "");
                }

                if (!User.IsActive)
                {
                    tbUserName.Focus();
                    MessageBox.Show("Yor account is disabled, contact your admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                clsGlobal._User = User;
                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();
            }
            else 
            {
                tbUserName.Focus();
                MessageBox.Show("Not valid Username / Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

    
    }
}
