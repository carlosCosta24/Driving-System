using Driving_System.Global;
using Driving_System.Properties;
using System;
using System.Windows.Forms;

namespace Driving_System.Tests.Controls
{
    public partial class crtlScheduleTest : UserControl
    {
        public enum enMode { Add = 0, Update = 1 };
        private enMode _Mode = enMode.Add;

        public enum enCreation { FirstTime = 0, Reapplay = 1 };
        private enCreation _CreationMode = enCreation.FirstTime;

        private clsTestTypesBusiness.enTestTypes _TestTypeID = clsTestTypesBusiness.enTestTypes.Vision;
        private clsLocalDrivingLicenseAppBusiness _LocalDrivingLicenseApp;
        private int _LocalDrivingLicenseAppID = -1;
        private clsTestAppointmentBusiness _TestAppont;
        private int _TestAppontID = -1;

        public clsTestTypesBusiness.enTestTypes TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;
                switch (_TestTypeID)
                {
                    case clsTestTypesBusiness.enTestTypes.Vision:
                        gbTestType.Text = "Vision Test";
                        pbTestImage.Image = Resources.Vision_512;
                        break;
                    case clsTestTypesBusiness.enTestTypes.Written:
                        gbTestType.Text = "Written Test";
                        pbTestImage.Image = Resources.Written_Test_512;
                        break;
                    case clsTestTypesBusiness.enTestTypes.Practical:
                        gbTestType.Text = "Practical test";
                        pbTestImage.Image = Resources.driving_test_512;
                        break;


                }
            }
        }
        private bool _LoadTestAppontDate()
        {
            _TestAppont = clsTestAppointmentBusiness.Find(_TestAppontID);
            if (_TestAppont == null)
            {
                MessageBox.Show("No appointment with ID: " + _TestAppontID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;

            }
            lbvFees.Text = _TestAppont.PaidFees.ToString();

            if (DateTime.Compare(DateTime.Now, _TestAppont.AppontDate) < 0)
            {
                dtpTestDate.MinDate = DateTime.Now;
            }
            else
            {
                dtpTestDate.MinDate = _TestAppont.AppontDate;
            }

            if (_TestAppont.RetakeTestAppID == -1)
            {
                lbvRetakeTestFees.Text = "0";
                lbvRetakeTestID.Text = "N/A";
            }
            else
            {
                lbvRetakeTestFees.Text = _TestAppont.RetakeTestAppInfo.PaidFees.ToString();
                gbRetakeInfo.Enabled = true;
                lbvTitle.Text = "Schdule Tetake Test";
                lbvRetakeTestID.Text = _TestAppont.RetakeTestAppID.ToString();
            }
            return true;
        }
        public void LoadInfo(int LocalDrivingLicenseID, int AppontID = -1)
        {
            if (AppontID == -1)
            {
                _Mode = enMode.Add;
            }
            else
            {
                _Mode = enMode.Update;
            }
            _LocalDrivingLicenseAppID = LocalDrivingLicenseID;
            _TestAppontID = AppontID;
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseAppBusiness.FindbyLocalDrivingLicenseAppID(_LocalDrivingLicenseAppID);

            if (_LocalDrivingLicenseApp == null)
            {
                MessageBox.Show("Application with ID: " + _LocalDrivingLicenseAppID.ToString() + "Can't be found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            // check for the creation mode by checking test status;
            // add method to LocalDrivingLicense class

            if (_CreationMode == enCreation.Reapplay)
            {
                lbvRetakeTestFees.Text = clsAppTypesBusiness.FindApp((int)clsApplicationBusiness.enAppType.RetakeTest).Fees.ToString();
                gbRetakeInfo.Enabled = true;
                lbvTitle.Text = "Schedule Retake Test";
                lbvRetakeTestID.Text = "0";

            }
            else
            {
                gbRetakeInfo.Enabled = false;
                lbvTitle.Text = "Schedule Test";
                lbvRetakeTestFees.Text = "0";
                lbvRetakeTestID.Text = "N/A";

            }
            lbvDrivingLicenseAppID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID.ToString();
            //lbvDrivingClass.Text = _LocalDrivingLicenseApp.ApplicationTypeInfo.LicenseClassInfo.className;
            lbvName.Text = _LocalDrivingLicenseApp.fullName;
            //lbvTrails.Text = _LocalDrivingLicenseApp.TrailsperTest();
            if (_Mode == enMode.Add)
            {
                lbvFees.Text = clsTestTypesBusiness.Find(_TestTypeID).Fees.ToString();
                dtpTestDate.MinDate = DateTime.Now;
                lbvRetakeTestID.Text = "N/A";
                _TestAppont = new clsTestAppointmentBusiness();
            }
            else
            {
                if (!_LoadTestAppontDate())
                {
                    return;
                }
            }
            lbvTotalFees.Text = (Convert.ToSingle(lbvFees.Text) + Convert.ToSingle(lbvRetakeTestFees.Text)).ToString();

            if (!_HandelActiveTestAppontConstraints())
            {
                return;
            }
            if (!_HandleAppontLockedConstrains())
            {
                return;
            }
            /*if (_HandlePrviousTestConstrains())
            {
                return;
            }*/

        }
        private bool _HandelActiveTestAppontConstraints()
        {
            /*if (_Mode == enMode.Add && clsLocalDrivingLicenseAppBusinessl.IsThereAnActiveScheuledTest(_LocalDrivingLicenseAppID, TestTypeID))
            {
                lbvUserMessage.Visible = true;
                lbvUserMessage.Text = "Person already have an active appointment for this test";
                btnSave.Enabled = false;
                dtpTestDate.Enabled = false;
                return false;
            }*/
            return true;
        }
        private bool _HandleAppontLockedConstrains()
        {
            if (_TestAppont.Locked)
            {
                lbvUserMessage.Visible = true;
                lbvUserMessage.Text = "Person Already sat for this test, Appointment Is Locked";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }
            else
            {

                lbvUserMessage.Visible = false;
            }
            return true;

        }
        /* private bool _HandlePrviousTestConstrains()
         {
             switch (TestTypeID)
             {
                 case clsTestTypesBusiness.enTestTypes.Vision:
                     lbvUserMessage.Visible = false;
                     return true;
                 case clsTestTypesBusiness.enTestTypes.Written:
                     if (!_LocalDrivingLicenseApp.PassTestType(clsTestTypesBusiness.enTestTypes.Written))
                     {
                         lbvUserMessage.Visible = true;
                         lbvUserMessage.Text = "Cannot Schdeul The Written Test Before Passing Viosion Test";
                         btnSave.Enabled = false;
                         dtpTestDate.Enabled = false;
                         return false;
                     }
                     else
                     {
                         lbvUserMessage.Visible = false;
                         btnSave.Enabled = true;
                         dtpTestDate.Enabled = true;
                     }
                     return true;
                 case clsTestTypesBusiness.enTestTypes.Practical:
                     if (!_LocalDrivingLicenseApp.PassTestType(clsTestTypesBusiness.enTestTypes.Practical))
                     {
                         lbvUserMessage.Visible = true;
                         lbvUserMessage.Text = "Cannot Schdeul The Practical Test Before Passing Written Test";
                         btnSave.Enabled = false;
                         dtpTestDate.Enabled = false;
                         return false;

                     }
                     else
                     {
                         lbvUserMessage.Visible = false;
                         btnSave.Enabled = true;
                         dtpTestDate.Enabled = true;
                     }
                     return true;
             }
             return true;
         }*/
        private bool _HandleRetakeApp()
        {
            if (_Mode == enMode.Add && _CreationMode == enCreation.Reapplay)
            {
                clsApplicationBusiness App = new clsApplicationBusiness();
                App.ApplicantPersonID = _LocalDrivingLicenseApp.ApplicantPersonID;
                App.ApplicationDate = DateTime.Now;
                App.ApplicationTypeID = (int)clsApplicationBusiness.enAppType.RetakeTest;
                App.ApplicationStatus = clsApplicationBusiness.enStatus.Completed;
                App.LastStatusDate = DateTime.Now;
                App.PaidFees = clsAppTypesBusiness.FindApp((int)clsApplicationBusiness.enAppType.RetakeTest).Fees;
                App.CreatedByUserID = clsGlobal._User.UserID;

                if (!App.Save())
                {
                    _TestAppont.RetakeTestAppID = -1;
                    MessageBox.Show("Faild to create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _TestAppont.RetakeTestAppID = App.ApplicationID;
            }
            return true;
        }
        public crtlScheduleTest()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApp())
            {
                return;
            }
            _TestAppont.TestTypeID = _TestTypeID;
            _TestAppont.LocalDrivingLicenseAppID = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID;
            _TestAppont.AppontDate = dtpTestDate.Value;
            _TestAppont.PaidFees = Convert.ToSingle(lbvFees.Text);
            _TestAppont.CreatedByUserID = clsGlobal._User.UserID;
            if (_TestAppont.Save())
            {
                _Mode = enMode.Update;
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data not saved! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
