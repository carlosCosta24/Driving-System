using Driving_System.Global;
using Driving_System.Licenses.Local_Licenses;
using System;
using System.Windows.Forms;

namespace Driving_System.Applications.Replace_Lost_Or_Damaged_License
{
    public partial class frmReplaceLostOrDamagedLicense : Form
    {
        private int _NewLicenseID = -1;
        public frmReplaceLostOrDamagedLicense()
        {
            InitializeComponent();
        }
        private int _GetAppTypeID()
        {
            if (rbDamaged.Checked)
            {
                return (int)clsApplicationBusiness.enAppType.ReplaceDamagedDrivingLicense;
            }
            else
            {
                return (int)clsApplicationBusiness.enAppType.ReplaceLostDrivingLicense;
            }
        }
        private enIssueReason _GetIssueReason()
        {
            if (rbDamaged.Checked)
            {
                return enIssueReason.Damaged;
            }
            else
            {
                return enIssueReason.Lost;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmReplaceLostOrDamagedLicense_Load(object sender, EventArgs e)
        {
            lbvAppDate.Text = clsFormat.DateToShort(DateTime.Now);
            lbvCreatedByUser.Text = clsGlobal._User.UserName;
            rbDamaged.Checked = true;
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            lbTitle.Text = "Replacement for Damaged License";
            this.Text = lbTitle.Text;
            lbvAppFees.Text = clsAppTypesBusiness.FindApp(_GetAppTypeID()).Fees.ToString();

        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            lbTitle.Text = "Replacement for Lost License";
            this.Text = lbTitle.Text;
            lbvAppFees.Text = clsAppTypesBusiness.FindApp(_GetAppTypeID()).Fees.ToString();
        }

        private void frmReplaceLostOrDamagedLicense_Activated(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter1.TbLicenseIDFoucus();
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
            if (!ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.Active)
            {
                MessageBox.Show("Selected license is not acteive", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }
            btnIssue.Enabled = true;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Issue New License",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicenseBusiness NewLicense =
                ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.Replace(_GetIssueReason(), clsGlobal._User.UserID);
            if (NewLicense == null)
            {
                MessageBox.Show("Error while Renewing the license ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbvReplacementAppID.Text = NewLicense.AppID.ToString();
            _NewLicenseID = NewLicense.LicenseID;


            lbvReplacementLicenseID.Text = _NewLicenseID.ToString();
            MessageBox.Show("New License Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssue.Enabled = false;
            gbReplacement.Enabled = false;
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            llNewLicenseInfo.Enabled = true;
        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
