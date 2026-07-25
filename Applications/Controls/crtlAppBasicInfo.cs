using BusinessLayer;
using Driving_System.Global;
using Driving_System.Persons;
using System;
using System.Windows.Forms;

namespace Driving_System.Applications.Controls
{
    public partial class crtlAppBasicInfo : UserControl
    {
        private clsApplicationBusiness _App;
        private int _AppID = -1;
        public int AppID
        {
            get
            {
                return _AppID;
            }
        }
        public crtlAppBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadAppInfo(int AppID)
        {
            _App = clsApplicationBusiness.FindBaseApp(AppID);
            if (_App == null)
            {
                RestAppInfo();
                MessageBox.Show("No application with this ID: " + _AppID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _FillAppInfo();
            }

        }
        private void _FillAppInfo()
        {
            _AppID = _App.ApplicationID;
            lbvID.Text = _App.ApplicationID.ToString();
            lbvStatus.Text = _App.StatusText;
            lbvType.Text = _App.ApplicationTypeInfo.Title;
            lbvFees.Text = _App.PaidFees.ToString();
            lbvApplicant.Text = _App.ApplicatnFullName;
            lbvDate.Text = clsFormat.DateToShort(_App.ApplicationDate);
            lbvStatusDate.Text = clsFormat.DateToShort(_App.LastStatusDate);
            lbvUser.Text = _App.UserInfo.UserName;


        }
        public void RestAppInfo()
        {
            _AppID = -1;
            lbvID.Text = "-";
            lbvStatus.Text = "-";
            lbvType.Text = "-";
            lbvFees.Text = "-";
            lbvApplicant.Text = "-";
            lbvDate.Text = "-";
            lbvStatusDate.Text = "-";
            lbvUser.Text = "-";

        }
        private void gbAppBasicInfo_Enter(object sender, EventArgs e)
        {

        }

        private void llPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(_App.ApplicantPersonID);
            frm.ShowDialog();

            LoadAppInfo(_AppID);
        }
    }
}
