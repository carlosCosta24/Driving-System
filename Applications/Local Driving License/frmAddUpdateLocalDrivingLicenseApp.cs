using Driving_System.Global;
using System;
using System.Windows.Forms;

namespace Driving_System.Applications.Local_Driving_License
{
    public partial class frmAddUpdateLocalDrivingLicenseApp : Form
    {
        public enum enMode { Add = 0, Update = 1 };
        private enMode _Mode;
        private int _LocalDrivingLicenseAppID = -1;
        private int _SelectedPersonID = -1;
        private clsLocalDrivingLicenseAppBusiness _LocalDrivingLicenseApp;

        public frmAddUpdateLocalDrivingLicenseApp()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAddUpdateLocalDrivingLicenseApp(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
        }

        private void _FillLicenseClassComboBox()
        {
            //DataTable Class 
        }
        private void _RestDefaultValues()
        {
            _FillLicenseClassComboBox();

            if (_Mode == enMode.Add)
            {
                this.Text = "New Local Driving License Application";
                lbFormName.Text = "New Local Driving License Application";
                _LocalDrivingLicenseApp = new clsLocalDrivingLicenseAppBusiness();
                crtlPersonCardWithFilter1.FilterFocus();
                tbAppInfo.Enabled = false;

                //cbLicenseClass.SelectedIndex = 2;
                lbvFees.Text = clsAppTypesBusiness.FindApp((int)clsApplicationBusiness.enAppType.NewDrivingLicense).Fees.ToString();
                lbvAppDate.Text = DateTime.Now.ToShortDateString();
                lbvUserID.Text = clsGlobal._User.UserName;
            }
            else
            {
                this.Text = "Update Local Driving License Application";
                lbFormName.Text = "Update Local Driving License Application";

                tbAppInfo.Enabled = true;
                btnSave.Enabled = true;

            }
        }
        private void _LoadData()
        {
            crtlPersonCardWithFilter1.FilterEnabled = false;
            _LocalDrivingLicenseApp = clsLocalDrivingLicenseAppBusiness.FindbyLocalDrivingLicenseAppID(_LocalDrivingLicenseAppID);

            if (_LocalDrivingLicenseApp != null)
            {
                MessageBox.Show("No application with ID: " + _LocalDrivingLicenseApp,
                    "Application not found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            crtlPersonCardWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApp.ApplicantPersonID);
            lbvDLAppID.Text = _LocalDrivingLicenseApp.LocalDrivingLicenseAppID.ToString();
            lbvAppDate.Text = clsFormat.DateToShort(_LocalDrivingLicenseApp.ApplicationDate);
            //cbLicenseClass.SelectedIndex =
            lbvFees.Text = _LocalDrivingLicenseApp.PaidFees.ToString();
            lbvUserID.Text = clsUserBusiness.FindByUserID(_LocalDrivingLicenseApp.CreatedByUserID).UserName;
        }
        private void DataBackEvent(object sender, int PersonID)
        {
            _SelectedPersonID = PersonID;
            crtlPersonCardWithFilter1.LoadPersonInfo(PersonID);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUpdateLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {
            _RestDefaultValues();
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tbAppInfo.Enabled = true;
                tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpApplicationInfo"];
                return;
            }

            if (_Mode == enMode.Add)
            {
                btnSave.Enabled = true;
                tbAppInfo.Enabled = true;
                tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpApplicationInfo"];
            }
            else
            {
                MessageBox.Show("Please select a person", "Select a person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                crtlPersonCardWithFilter1.FilterFocus();
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("All fields must be valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //int LicenseClassID
            //int ActiveAppID = clsApplicationBusiness.GetActiveAppIDForLicenseClass(_SelectedPersonID, clsApplicationBusiness.enAppType.NewDrivingLicense, LicenseClassID);

        }
        private void crtlPersonCardWithFilter1_OnPersonSelected(int obj)
        {

            _SelectedPersonID = obj;
        }

        private void frmAddUpdateLocalDrivingLicenseApp_Activated(object sender, EventArgs e)
        {
            crtlPersonCardWithFilter1.FilterFocus();
        }
    }
}
