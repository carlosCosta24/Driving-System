using BusinessLayer;
using Driving_System.Global;
using Driving_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_System.Tests.Controls
{
    public partial class ctrlScheduledTest : UserControl
    {
        private clsTestTypesBusiness.enTestTypes _TestTypeID;
        private int _TestID =-1;
        private clsLocalDrivingLicenseAppBusiness _LocalDrivingLicenseApp;
        private int _TestAppontID = -1;
        private int _LocalDrivingLicenseAppID = -1;
        private clsTestAppointmentBusiness _TestAppont;
        public clsTestTypesBusiness.enTestTypes TestTypeID
        {
            get { return _TestTypeID; }
            set
            {
                _TestTypeID = value;
                switch (_TestTypeID)
                {
                    case clsTestTypesBusiness.enTestTypes.Vision:
                        gbTestTypeTitle.Text = "Vision Test";
                        pbTestImage.Image = Resources.Vision_512;
                        break;
                    case clsTestTypesBusiness.enTestTypes.Written:
                        gbTestTypeTitle.Text = "Written Test";
                        pbTestImage.Image = Resources.Written_Test_512;
                        break;
                    case clsTestTypesBusiness.enTestTypes.Practical:
                        gbTestTypeTitle.Text = "Practical Test";
                        pbTestImage.Image = Resources.driving_test_512;
                        break;

                }
            }
        }
        public int TestAppontID { get
            {
                return _TestAppontID;
            } }
         public int TestID { get
            {
                return _TestID;
            } 
        }

        public ctrlScheduledTest()
        {
            InitializeComponent();
        }
        public void LoadInfo(int TestAppontID) 
        {
            _TestAppontID = TestAppontID;
            _TestAppont = clsTestAppointmentBusiness.Find(_TestAppontID);

            if(_TestAppont == null)
            {
                MessageBox.Show("Error: No Appontment whit ID: " + _TestAppontID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppontID = -1;
                return;
            }

            _TestID = _TestAppont.TestID;
            _LocalDrivingLicenseAppID = _TestAppont.LocalDrivingLicenseAppID;
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseAppBusiness.FindbyLocalDrivingLicenseAppID(_LocalDrivingLicenseAppID);

            if(_LocalDrivingLicenseApp == null)
            {
                MessageBox.Show("Error: No Local Driving License Application Linked To This ID: " + _LocalDrivingLicenseAppID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbvDrivingLicenseAppID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID.ToString();
            //get License class from licenseClassinfo.className
            lbvDrivingClass.Text = _LocalDrivingLicenseApp.LicenseClassID.ToString();
            lbvName.Text = _LocalDrivingLicenseApp.PersonInfo.FullName;
            //Get Trails from TotalTrailPerTest Method in LocalDrivingLicenseApp
            lbvTrails.Text = _LocalDrivingLicenseApp.ToString();

            lbvDate.Text = clsFormat.DateToShort(_TestAppont.AppontDate);
            lbvFees.Text = _TestAppont.PaidFees.ToString();
            //lbvTestID.Text = (_TestAppont.TestID == -1) ? "Not Taken Yet" : _TestAppont.TestID.ToString();

        }
        private void gbTestTypeTitle_Enter(object sender, EventArgs e)
        {

        }

        private void ctrlScheduledTest_Load(object sender, EventArgs e)
        {

        }
    }
}
