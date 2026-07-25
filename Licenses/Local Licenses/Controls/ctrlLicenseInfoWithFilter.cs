using BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Driving_System.Licenses.Local_Licenses.Controls
{
    public partial class ctrlLicenseInfoWithFilter : UserControl
    {
        //event handler
        public event Action<int> OnLicenseSelect;
        protected virtual void LicenseSelected(int licenseID)
        {
            Action<int> Handler = OnLicenseSelect;
            if (Handler != null)
            {
                Handler(licenseID);
            }
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;

            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }
        private int _LicenseID = -1;
        public int LicenseID
        {
            get
            {
                return ctrlDriverLicenseInfo1.LicenseID;
            }
        }
        public clsLicenseBusiness SelectedLicenseInfo
        {
            get
            {
                return ctrlDriverLicenseInfo1.SelectedLicenseInfo;
            }
        }

        public ctrlLicenseInfoWithFilter()
        {
            InitializeComponent();
        }
        public void LoadLicenseInfo(int LicenseID)
        {
            tbLicenseID.Text = LicenseID.ToString();
            ctrlDriverLicenseInfo1.LoadInfo(LicenseID);
            _LicenseID = ctrlDriverLicenseInfo1.LicenseID;
            if (OnLicenseSelect != null && FilterEnabled)
            {
                OnLicenseSelect(_LicenseID);
            }

        }

        private void ctrlLicenseInfoWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void tbLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("All fields are required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbLicenseID.Focus();
                return;
            }
            _LicenseID = int.Parse(tbLicenseID.Text);
            LoadLicenseInfo(_LicenseID);
        }
        public void TbLicenseIDFoucus()
        {
            tbLicenseID.Focus();
        }

        private void tbLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLicenseID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbLicenseID, "This field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbLicenseID, null);
            }
        }

        private void ctrlDriverLicenseInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
