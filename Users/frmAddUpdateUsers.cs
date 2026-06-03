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

namespace Driving_System.Users
{
    public partial class frmAddUpdateUsers : Form
    {
        public enum enMode {Add=0, Update=1};
        private enMode _Mode;
        private int _UserID = -1;
        private clsUserBusiness _User;

        public frmAddUpdateUsers()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAddUpdateUsers(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }
        private void _RestValues() {
            if (_Mode == enMode.Add)
            {
                lbTitle.Text = "Add New User";
                this.Text = "Add New";
                _User = new clsUserBusiness();
                tbLogin.Enabled = false;
                crtlPersonCardWithFilter1.FilterFocus();
            }
            else 
            {
                lbTitle.Text = "Update User Info";
                this.Text = "Update";
                tbLogin.Enabled = true;
                btnSave.Enabled = true;
            }
            lbvUserID.Text = "-";
            tbUserName.Text = "-"; 
            tbPassword.Text = "-";
            tbConfirmPassword.Text = "-";
            chbIsActive.Checked = true;

        }
        private void _LoadData() {
            _User = clsUserBusiness.FindByUserID(_UserID);
            crtlPersonCardWithFilter1.FilterEnabled = false;

            if(_User == null) 
            {
                MessageBox.Show("User Dose not exist! ","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lbvUserID.Text = _UserID.ToString();
            tbUserName.Text = _User.UserName;
            tbPassword.Text = _User.Password;
            tbConfirmPassword.Text = _User.Password;
            chbIsActive.Checked = _User.IsActive;
            crtlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update) 
            { 
                btnNext.Enabled = true;
                tbLogin.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tbLogin"];
                return;
            }
            if (crtlPersonCardWithFilter1.PersonID != -1)
            {
                if (clsUserBusiness.IsUserExistForPersonID(crtlPersonCardWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected person already a user, choose another person", "Select another person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    crtlPersonCardWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tbLogin.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tbLogin"];
                }

            }
            else 
            {
                MessageBox.Show("Please select a person", "Select a person", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                crtlPersonCardWithFilter1.FilterFocus();
            }
        }

        private void frmAddUpdateUsers_Load(object sender, EventArgs e)
        {
            _RestValues();
            if (_Mode == enMode.Update) 
            {
                _LoadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) 
            {
                MessageBox.Show("Some field is not valid! Refrence the error icon!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            
            }
            _User.PersonID = crtlPersonCardWithFilter1.PersonID;
            _User.UserName = tbUserName.Text.Trim();
            _User.Password = tbPassword.Text.Trim();
            _User.IsActive = chbIsActive.Checked;

            if (_User.Save())
            {
                lbvUserID.Text = _UserID.ToString();
                _Mode = enMode.Update;
                lbTitle.Text = "Update User";
                this.Text = "Update";

                MessageBox.Show("User info saved", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else 
            { 
                MessageBox.Show("User info Not saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text.Trim() != tbPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Passord should match");
            }
            else 
            { 
                e.Cancel = false;
                errorProvider1.SetError(tbConfirmPassword, null);
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text.Trim()) || tbPassword.Text.Trim().Length < 8)
            {

                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "Password cant be null / at least 8 charachters");
            }
            else 
            {
                e.Cancel= false;
                errorProvider1.SetError(tbPassword, null);
            }
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUserName, "Username Cant be empty");
                return;
            }
            else 
            {
                e.Cancel = false;
                errorProvider1.SetError(tbUserName, null);
            }
            if (_Mode == enMode.Add)
            {
                if (clsUserBusiness.IsUserExist(tbUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbUserName, "Username already exist, choose another Username");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbUserName, null);
                }

            }
            else 
            {
                if (_User.UserName != tbUserName.Text.Trim()) 
                {
                    if (clsUserBusiness.IsUserExist(tbUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(tbUserName, "Username already exist, choose another Username");
                        return;
                    }
                    else 
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(tbUserName, null);
                    }
                
                }
            }
        }

        private void frmAddUpdateUsers_Activated(object sender, EventArgs e)
        {
            crtlPersonCardWithFilter1.FilterFocus();
        }
    }
}
