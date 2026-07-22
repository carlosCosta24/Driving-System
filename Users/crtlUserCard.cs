using System;
using System.Windows.Forms;

namespace Driving_System.Users
{
    public partial class crtlUserCard : UserControl
    {
        private clsUserBusiness _User;
        private int _UserID = -1;

        public int UserID { get { return _UserID; } }

        public crtlUserCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;
            _User = clsUserBusiness.FindByUserID(UserID);
            if (_User == null)
            {
                _RestPersonInfo();
                MessageBox.Show("No User With ID = [ " + UserID.ToString() + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _FillUserInfo();
        }

        private void _FillUserInfo()
        {

            crtlPersonCard1.LoadPersonInfo(_User.PersonID);
            lbvUserID.Text = _User.UserID.ToString();
            lbvUserName.Text = _User.UserName.ToString();
            if (_User.IsActive)
            {
                lbvIsActive.Text = "Yes";
            }
            else
            {
                lbvIsActive.Text = "No";
            }
        }

        private void _RestPersonInfo()
        {

            crtlPersonCard1.RestPersonInfo();
            lbvUserID.Text = "-";
            lbvUserName.Text = "-";
            lbvIsActive.Text = "-";

        }

        private void crtlUserCard_Load(object sender, EventArgs e)
        {

        }
    }
}
