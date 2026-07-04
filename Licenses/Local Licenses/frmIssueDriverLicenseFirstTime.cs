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

namespace Driving_System.Licenses.Local_Licenses
{
    public partial class frmIssueDriverLicenseFirstTime : Form
    {
        private int _LocalDrivingLicenseAppID;
        private clsLocalDrivingLicenseAppBusiness _LocalDrivingLicenseApp;
        public frmIssueDriverLicenseFirstTime(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlDrivingLicenseAppInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        {
            tbNotes.Focus();
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseAppBusiness.FindbyLocalDrivingLicenseAppID(_LocalDrivingLicenseAppID);

            if(_LocalDrivingLicenseApp == null)
            {
                MessageBox.Show("No Application With ID: " + _LocalDrivingLicenseAppID.ToString(), 
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }
            if (!_LocalDrivingLicenseApp.PassedAllTests()) 
            {
                MessageBox.Show("Person Should Pass ALl Test First: ",
                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }
            int LicenseID = _LocalDrivingLicenseApp.GetActiveLicenseID();
            if(LicenseID != -1)
            {
                MessageBox.Show("Person Allready Hase License, License ID: " + LicenseID.ToString(),
                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }
            ctrlDrivingLicenseAppInfo1.LoadAppInfoByLocalDrivingAppID(_LocalDrivingLicenseAppID);

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
           // int LicenseID = _LocalDrivingLicenseApp.IssueLicenseForTheFirstTime(tbNotes.Text)
        }
    }
}
