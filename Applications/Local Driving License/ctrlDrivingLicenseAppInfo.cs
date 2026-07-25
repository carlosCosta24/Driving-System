using BusinessLayer;
using System;
using System.Windows.Forms;

namespace Driving_System.Applications.Local_Driving_License
{
    public partial class ctrlDrivingLicenseAppInfo : UserControl
    {
        private clsLocalDrivingLicenseAppBusiness _LocalDrivingLicenseApp;
        private int _LocalDrivingLicenseAppID = -1;
        private int _LicenseID;
        public int LocalDrivingLicenseAppID
        {
            get
            {
                return _LocalDrivingLicenseAppID;
            }
        }
        public ctrlDrivingLicenseAppInfo()
        {
            InitializeComponent();
        }
        public void LoadAppInfoByLocalDrivingAppID(int LocalDrivingLicenseAppID)
        {
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseAppBusiness.FindbyLocalDrivingLicenseAppID(LocalDrivingLicenseAppID);
            if (_LocalDrivingLicenseApp == null)
            {
                _RestLocalDrivingLicenseAppInfo();
                MessageBox.Show("No application found with ID: " + LocalDrivingLicenseAppID.ToString(), "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            _FillLocalDrivingLicenseAppInfo();

        }
        public void LoadAppInfoByAppID(int AppID)
        {
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseAppBusiness.FindByAppID(AppID);
            if (_LocalDrivingLicenseApp == null)
            {
                _RestLocalDrivingLicenseAppInfo();
                MessageBox.Show("No application found with ID: " + LocalDrivingLicenseAppID.ToString(), "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            _FillLocalDrivingLicenseAppInfo();

        }
        private void _FillLocalDrivingLicenseAppInfo()
        {
            //_LicenseID = _LocalDrivingLicenseApp.GetActiveAppID();
            llLicenseInfo.Enabled = (_LicenseID != -1);
            lbvDLAppID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID.ToString();
            //lbvAppliedForLicesns.Text = clsLicenseClass.Find();
            //lbvPassedTests.Text = _LocalDrivingLicenseApp.GetPassedTestCount();
            crtlAppBasicInfo1.LoadAppInfo(_LocalDrivingLicenseApp.ApplicationID);
        }
        private void _RestLocalDrivingLicenseAppInfo()
        {
            _LocalDrivingLicenseAppID = -1;
            crtlAppBasicInfo1.RestAppInfo();
            lbvDLAppID.Text = "-";
            lbvAppliedForLicesns.Text = "-";


        }
        private void ctrlDrivingLicenseAppInfo_Load(object sender, EventArgs e)
        {

        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmShowLicenseInfo frm = new frmShowLicenseInfo(_LocalDrivingLicenseApp.GetActiveLicenseID());
            //frm.showDialog();
        }
    }
}
