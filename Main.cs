using System.Windows.Forms;

namespace Driving_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form ManagePeople = new ManagePeopleForm();
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
            Form Account = new UserInfoForm();
            Account.ShowDialog();
        }
    }
}
