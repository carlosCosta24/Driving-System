using System;
using System.Windows.Forms;

namespace Driving_System.Applications.Local_Driving_License
{
    public partial class frmLocalDrivingLicenseAppInfo : Form
    {
        private int _AppID = -1;
        public frmLocalDrivingLicenseAppInfo(int AppID)
        {
            InitializeComponent();
            _AppID = AppID;
        }

        private void frmLocalDrivingLicenseAppInfo_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseAppInfo1.LoadAppInfoByLocalDrivingAppID(_AppID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
