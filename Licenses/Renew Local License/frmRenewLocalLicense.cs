using Driving_System.Global;
using Driving_System.Licenses.Local_Licenses;
using System;
using System.Windows.Forms;

namespace Driving_System.Licenses.Renew_Local_License
{
    public partial class frmRenewLocalLicense : Form
    {
        private int _NewLicenseID = -1;
        public frmRenewLocalLicense()
        {
            InitializeComponent();
        }

        private void frmRenewLocalLicense_Load(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter1.TbLicenseIDFoucus();

            lbvAppDate.Text = clsFormat.DateToShort(DateTime.Now);
            lbvIssueDate.Text = lbvAppDate.Text;
            lbvExpirationDate.Text = "-";
            lbvAppFees.Text = clsAppTypesBusiness.FindApp((int)clsApplicationBusiness.enAppType.RenewDrivingLicense).Fees.ToString();
            lbvCreatedByUser.Text = clsGlobal._User.UserName;

        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelect(int obj)
        {
            int SelectedLicenseID = obj;

            lbvOldLicenseID.Text = SelectedLicenseID.ToString();
            llLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)
            {
                return;
            }
            int DefValidityLength = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.DefaultValidityLenght;
            lbvExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(DefValidityLength));
            lbvLicensFees.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.ClassFees.ToString();
            lbvTotalFees.Text = (Convert.ToString(lbvAppFees.Text) + Convert.ToString(lbvLicensFees.Text)).ToString();
            tbNotes.Text = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.Notes;

            if (!ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show("License isn't expired yet!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnRenew.Enabled = false;
                return;
            }
            if (!ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.Active)
            {

                MessageBox.Show("License isn't Active!", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnRenew.Enabled = false;
                return;

            }
            btnRenew.Enabled = true;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to renew this license!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
            {
                return;
            }
            clsLicenseBusiness NewLicense = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.Renew(tbNotes.Text, clsGlobal._User.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Failed to renew the license, contact you admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbvRLAppID.Text = NewLicense.AppID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lbvRenewLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("License renewed successfully, with ID: " + _NewLicenseID.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenew.Enabled = false;
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            llNewLicensInfo.Enabled = true;
        }

        private void frmRenewLocalLicense_Activated(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter1.TbLicenseIDFoucus();
        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llNewLicensInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
