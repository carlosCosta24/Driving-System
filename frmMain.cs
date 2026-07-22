using Driving_System.Global;
using Driving_System.Users;
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
            Form Login = new frmLoginForm();
            // Login.ShowDialog();
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
            Form Drivers = new DriversForm();
            Drivers.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form Users = new ManageUsersForm();
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

        }
    }
}
