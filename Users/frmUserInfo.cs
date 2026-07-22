using System;
using System.Windows.Forms;

namespace Driving_System.Users
{
    public partial class frmUserInfo : Form
    {
        private int _UserID;
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            crtlUserCard1.LoadUserInfo(_UserID);
        }

        private void crtlUserCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
