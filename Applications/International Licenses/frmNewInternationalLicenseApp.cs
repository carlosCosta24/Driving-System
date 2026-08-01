using BusinessLayer;
using Driving_System.Global;
using Driving_System.Licenses;
using Driving_System.Licenses.International_Licenses;
using System;
using System.Windows.Forms;

namespace Driving_System.Applications.International_Licenses
{
    public partial class frmNewInternationalLicenseApp : Form
    {
        private int _InternationalLicenseID = -1;
        public frmNewInternationalLicenseApp()
        {
            InitializeComponent();
        }

        private void frmNewInternationalLicenseApp_Load(object sender, EventArgs e)
        {
            lbvAppDate.Text = clsFormat.DateToShort(DateTime.Now);
            lbvIssueDate.Text = lbvAppDate.Text;
            lbvExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(10));
            lbvFees.Text = clsAppTypesBusiness.FindApp((int)clsApplicationBusiness.enAppType.NewInternationalLicense).Fees.ToString();
            lbvUserID.Text = clsGlobal._User.UserName;

        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelect(int obj)
        {
            int SelectedLicenseID = obj;
            lbvLocalLicenseID.Text = SelectedLicenseID.ToString();
            llLicenseHistory.Enabled = (SelectedLicenseID != -1);
            if (SelectedLicenseID == -1)
            {
                return;
            }

            if (ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClass != 3)
            {
                MessageBox.Show("Only License Of Class 3 Can Be Selected", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ActiveInternationalLicenseID = clsInternationalLicenseBusiness.
            GetActiveIntLicenseIDByDriverID(ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID);
            if (ActiveInternationalLicenseID != -1)
            {
                MessageBox.Show("Person Is Already Has An Active International License With ID: "
                + ActiveInternationalLicenseID.ToString()
                , "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llLicenseInfo.Enabled = true;
                _InternationalLicenseID = ActiveInternationalLicenseID;
                btnIssue.Enabled = false;
                return;
            }
            btnIssue.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsInternationalLicenseBusiness NewInternationalLicense = new clsInternationalLicenseBusiness();

            NewInternationalLicense.ApplicantPersonID = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            NewInternationalLicense.ApplicationDate = DateTime.Now;
            NewInternationalLicense.ApplicationStatus = clsApplicationBusiness.enStatus.Completed;
            NewInternationalLicense.LastStatusDate = DateTime.Now;
            NewInternationalLicense.PaidFees = clsAppTypesBusiness.FindApp((int)clsApplicationBusiness.enAppType.NewInternationalLicense).Fees;
            NewInternationalLicense.CreatedByUserID = clsGlobal._User.UserID;
            NewInternationalLicense.DriverID = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID;
            NewInternationalLicense.LocalLicenseID = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID;
            NewInternationalLicense.IssueDate = DateTime.Now;
            NewInternationalLicense.ExpirationDate = DateTime.Now.AddYears(10);
            NewInternationalLicense.CreatedByUserID = clsGlobal._User.UserID;

            if (!NewInternationalLicense.Save())
            {
                MessageBox.Show("Error While Issue the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbvInternationalLicenseApp.Text = NewInternationalLicense.ApplicationID.ToString();
            _InternationalLicenseID = NewInternationalLicense.LicenseID;
            lbvInternationalLicenseID.Text = NewInternationalLicense.LicenseID.ToString();
            MessageBox.Show("International License Issue Successfully, ID: " + NewInternationalLicense.LicenseID.ToString(),
            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssue.Enabled = false;
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            llLicenseInfo.Enabled = true;


        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicenseHistory frm =
            new frmPersonLicenseHistory(ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();

        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicensInfo frm = new frmInternationalLicensInfo(_InternationalLicenseID);
            frm.ShowDialog();

        }

        private void frmNewInternationalLicenseApp_Activated(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter1.TbLicenseIDFoucus();
        }
    }
}
