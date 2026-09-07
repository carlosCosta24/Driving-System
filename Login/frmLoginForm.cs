using BusinessLayer;
using Driving_System.Global;
using System;
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
            clsUserBusiness User = clsUserBusiness.FindByUserNameAndPassword(tbUserName.Text.Trim(), clsUtil.HashPassword( tbPassword.Text.Trim()));

            if (User != null)
            {
                if (chbRemeberMe.Checked)
                {
                    clsGlobal.SaveCredentials(tbUserName.Text.Trim(),clsUtil.HashPassword (tbPassword.Text.Trim()));
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

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chbRemeberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
