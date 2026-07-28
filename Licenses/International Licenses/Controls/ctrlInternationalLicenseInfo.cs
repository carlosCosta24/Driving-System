using BusinessLayer;
using Driving_System.Global;
using Driving_System.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Driving_System.Licenses.International_Licenses.Controls
{
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        private int _InternationalLicenseID;
        private clsInternationalLicenseBusiness _License;
        public int InternationalLicenseID { get { return _InternationalLicenseID; } }
        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        private void _LoadImage()
        {
            if (_License.DriverInfo.PersonInfo.Gender == 0)
            {
                pbPerson.Image = Resources.Male_512;
            }
            else
            {
                pbPerson.Image = Resources.Female_512;
            }
            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;
            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                {
                    pbPerson.Load(ImagePath);
                }
                else
                {
                    MessageBox.Show("Couldn't Load Person Image" + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
        public void LoadInfo(int InternationalLicensID)
        {
            _InternationalLicenseID = InternationalLicensID;
            _License = clsInternationalLicenseBusiness.Find(_InternationalLicenseID);
            if(_License == null)
            {
                MessageBox.Show("No License found with ID: " + _InternationalLicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;

            }
            lbvInternationalLicenseID.Text = _License.LicenseID.ToString();
            lbvAppID.Text = _License.ApplicationID.ToString();
            lbvActive.Text = _License.Active ? "Yes" : "No";

            lbvLicenseID.Text = _License.LocalLicenseID.ToString();
            lbvName.Text = _License.DriverInfo.PersonInfo.FullName;
            lbvNationalNumber.Text = _License.DriverInfo.PersonInfo.NationalNumber;

            lbvGender.Text = _License.DriverInfo.PersonInfo.Gender == 0 ? "M" : "F";
            lbvDateOfBirth.Text = clsFormat.DateToShort(_License.DriverInfo.PersonInfo.BirthDate);
            lbvDriverID.Text = _License.DriverID.ToString();

            lbvIssueDate.Text = clsFormat.DateToShort(_License.IssueDate);
            lbvExpirationDate.Text = clsFormat.DateToShort(_License.ExpirationDate);
            _LoadImage();


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
