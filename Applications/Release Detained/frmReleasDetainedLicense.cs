using Driving_System.Global;
using Driving_System.Licenses;
using Driving_System.Licenses.Local_Licenses;
using System;
using System.Windows.Forms;

namespace Driving_System.Applications.Release_Detained
{
    public partial class frmReleasDetainedLicense : Form
    {
        private int _SelectedLicenseID = -1;
        public frmReleasDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleasDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = LicenseID;
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            ctrlLicenseInfoWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
        }

        private void gbDetainInfo_Enter(object sender, EventArgs e)
        {

        }

        private void frmReleasDetainedLicense_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

            if (!ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.Detained)
            {
                MessageBox.Show("This Lincens Is Not Detained", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            lbvAppFees.Text = clsAppTypesBusiness.
                FindApp((int)clsApplicationBusiness.enAppType.ReleaseDetainedDrivingLicsense).Fees.ToString();


            lbvDetainID.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainInfo.DetainID.ToString();
            lbvLicenseID.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();

            lbvCreatedBy.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainInfo.CreatedByUserInfo.UserName;
            lbvDetainDate.Text = clsFormat.DateToShort(ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainInfo.DetainDate);
            lbvFineFees.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DetainInfo.FineFees.ToString();
            lbvTotalFees.Text = (Convert.ToSingle(lbvAppFees.Text) + Convert.ToSingle(lbvFineFees.Text)).ToString();

            btnRelease.Enabled = true;

        }

        private void frmReleasDetainedLicense_Activated(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter1.TbLicenseIDFoucus();
        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frm = new
                frmPersonLicenseHistory(ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this License", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int AppID = -1;

            bool Released = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.ReleaseDetained(clsGlobal._User.UserID, ref AppID);

            lbvAppID.Text = AppID.ToString();

            if (!Released)
            {
                MessageBox.Show("Failed to release lincense", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Detained licnense released successfully", "Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRelease.Enabled = false;
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            llLicenseInfo.Enabled = true;

        }
    }
}
