using BusinessLayer;
using Driving_System.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if(_Mode == enMode.Add)
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUpdateLocalDrivingLicenseApp_Load(object sender, EventArgs e)
        {

        }
    }
}
