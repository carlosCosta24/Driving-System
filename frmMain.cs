using Driving_System.Applications.Application_Type;
using Driving_System.Applications.International_Licenses;
using Driving_System.Applications.Local_Driving_License;
using Driving_System.Applications.Release_Detained;
using Driving_System.Applications.Replace_Lost_Or_Damaged_License;
using Driving_System.Drivers;
using Driving_System.Global;
using Driving_System.Licenses.Detain_Licenses;
using Driving_System.Licenses.Renew_Local_License;
using Driving_System.Tests;
using Driving_System.Tests.Test_Types;
using Driving_System.Users;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_System
{
    public partial class frmMain : Form

    {
        frmLoginForm _Login;
        public frmMain(frmLoginForm frm)
        {
            InitializeComponent();
            _Login = frm;

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.BackColor = Color.White;
            


        }

        private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form ManagePeople = new frmManagePeopleForm();
            ManagePeople.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, System.EventArgs e)
        {
            Form Drivers = new frmDriversList();
            Drivers.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form Users = new frmListUsers();
            Users.ShowDialog();
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, System.EventArgs e)
        {
            frmUserInfo Account = new frmUserInfo(clsGlobal._User.UserID);
            Account.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApp frm = new frmAddUpdateLocalDrivingLicenseApp();
            frm.ShowDialog();
        }

        private void internationalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmNewInternationalLicenseApp frm = new frmNewInternationalLicenseApp();
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmRenewLocalLicense frm = new frmRenewLocalLicense();
            frm.ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmReplaceLostOrDamagedLicense frm = new frmReplaceLostOrDamagedLicense();
            frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmReleasDetainedLicense frm = new frmReleasDetainedLicense();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmListLocalDrivingLicenseApps frm = new frmListLocalDrivingLicenseApps();
            frm.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, System.EventArgs e)
        {
            clsGlobal._User = null;
            _Login.Show();
            this.Close();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmListLocalDrivingLicenseApps frm = new frmListLocalDrivingLicenseApps();
            frm.ShowDialog();
        }

        private void inernationalLicenseApplicationsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmListInternationalLicenses frm = new frmListInternationalLicenses();
            frm.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmListDetainedLicenses frm = new frmListDetainedLicenses();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void relToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmReleasDetainedLicense frm = new frmReleasDetainedLicense();
            frm.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, System.EventArgs e)
        {
            frmListaApplicationTypes frm = new frmListaApplicationTypes();
            frm.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, System.EventArgs e)
        {
            frmListTestTypes frm = new frmListTestTypes();
            frm.ShowDialog();

        }

        private void toolStripMenuItem8_Click(object sender, System.EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal._User.UserID);
            frm.ShowDialog();
        }
    }
}
