using BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Driving_System.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private clsUserBusiness _User;

        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void _RestValues()
        {

            tbNewPassword.Text = "";
            tbCurrentPassword.Text = "";
            tbConfirmPassword.Text = "";
            tbCurrentPassword.Focus();

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _RestValues();
            _User = clsUserBusiness.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("Couldn't find user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            crtlUserCard1.LoadUserInfo(_UserID);

        }

        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "Password can't be empty");
                return;

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCurrentPassword, null);
            }
            if (_User.Password != tbCurrentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "Curretn password is't correct");
                return;
            }
            else
            {
                errorProvider1.SetError(tbCurrentPassword, null);
            }

        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNewPassword, "Password can't be empty");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNewPassword, null);
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPassword.Text.Trim() != tbNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Confirm password don't match");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbConfirmPassword, null);
            }
        }

        private void btnSave_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field aren't valid, check refrence error icon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _User.Password = tbNewPassword.Text.Trim();

            if (_User.Save())
            {
                MessageBox.Show("User info Successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RestValues();
            }
            else
            {
                MessageBox.Show("User info not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
