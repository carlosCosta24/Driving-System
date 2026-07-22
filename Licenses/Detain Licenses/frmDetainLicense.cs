using Driving_System.Global;
using Driving_System.Licenses.Local_Licenses;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Driving_System.Licenses.Detain_Licenses
{
    public partial class frmDetainLicense : Form
    {
        private int _DetainID = -1;
        private int _SelectedLicenseID = -1;
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            lbvDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            lbvCreatedBy.Text = clsGlobal._User.UserName;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {


        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelect(int obj)
        {
            _SelectedLicenseID = obj;
            lbvLicenseID.Text = _SelectedLicenseID.ToString();

            llLicenseHistory.Enabled = (_SelectedLicenseID != -1);

            if (_SelectedLicenseID == -1)
            {
                return;
            }
            if (ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.Detained)
            {
                MessageBox.Show("This License is already detained", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            tbFineFees.Focus();
            btnDetain.Enabled = true;
        }

        private void frmDetainLicense_Activated(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter1.TbLicenseIDFoucus();
        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory
                (ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void tbFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFineFees, "Fees can't be empty");
                return;
            }
            else
            {
                errorProvider1.SetError(tbFineFees, null);
            }
            if (clsValidating.IsNumber(tbFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFineFees, "Only number is allowed");

            }
            else
            {
                errorProvider1.SetError(tbFineFees, null);
            }
        }
    }
}
