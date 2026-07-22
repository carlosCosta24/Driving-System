using Driving_System.Global;
using Driving_System.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Driving_System.Licenses.Local_Licenses.Controls
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LicenseID;
        private clsLicenseBusiness _License;
        public int LicenseID
        {
            get { return _LicenseID; }
        }
        public clsLicenseBusiness License
        {
            get { return _License; }
        }
        public clsLicenseBusiness SelectedLicenseInfo
        {
            get
            {
                return _License;
            }
        }
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }
        private void _LoadDriverImage()
        {
            if (_License.DriverInfo.PersonInfo.Gender == 0)
            {
                pbDriverImage.Image = Resources.Male_512;
            }
            else
            {
                pbDriverImage.Image = Resources.Female_512;
            }

            string ImagePathe = _License.DriverInfo.PersonInfo.ImagePath;
            if (ImagePathe != "")
            {
                if (File.Exists(ImagePathe))
                {
                    pbDriverImage.Load(ImagePathe);

                }
                else
                {
                    MessageBox.Show("Can not Load Image:" + ImagePathe, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void LoadInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicenseBusiness.Find(_LicenseID);

            if (_LicenseID == null)
            {
                MessageBox.Show("License with ID: " + _LicenseID.ToString() + " doesn't exist!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }
            lbvLicenseID.Text = _License.LicenseID.ToString();
            lbvActive.Text = _License.Active ? "Yes" : "No";
            //lbvDetained.Text = _License.Detained
            lbvClass.Text = _License.LicenseClassInfo.ClassName;
            lbvName.Text = _License.DriverInfo.PersonInfo.FullName;
            lbvNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNumber;
            lbvGender.Text = _License.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
            lbvDateOfBirth.Text = clsFormat.DateToShort(_License.DriverInfo.PersonInfo.BirthDate);
            lbvDriverID.Text = _License.DriverID.ToString();
            lbvIssueDate.Text = clsFormat.DateToShort(_License.IssueDate);
            lbvExpirationDate.Text = clsFormat.DateToShort(_License.ExpirationDate);
            lbvIssueReason.Text = _License.Reason;
            lbvNote.Text = _License.Notes == "" ? "No notes" : _License.Notes;
            _LoadDriverImage();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
