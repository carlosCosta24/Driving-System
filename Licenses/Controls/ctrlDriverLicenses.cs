using BusinessLayer;
using Driving_System.Licenses.Local_Licenses;
using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_System.Licenses.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID;
        private clsDriverBusiness _Driver;
        private DataTable _LocalLicenseHistoryList;
        private DataTable _InternationalLicenseHistoryList;
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }
        private void _LoadLocalLicenseInfo()
        {
            _LocalLicenseHistoryList = clsDriverBusiness.GetLicenses(_DriverID);
            dgvLocalLicenses.DataSource = _LocalLicenseHistoryList;
            lbvLocalRecord.Text = dgvLocalLicenses.Rows.Count.ToString();

            if (dgvLocalLicenses.Rows.Count > 0)
            {
                dgvLocalLicenses.Columns[0].HeaderText = "License ID";
                dgvLocalLicenses.Columns[0].Width = 100;

                dgvLocalLicenses.Columns[0].HeaderText = "App ID";
                dgvLocalLicenses.Columns[0].Width = 100;

                dgvLocalLicenses.Columns[0].HeaderText = "Class Name";
                dgvLocalLicenses.Columns[0].Width = 100;

                dgvLocalLicenses.Columns[0].HeaderText = "Issue Date";
                dgvLocalLicenses.Columns[0].Width = 100;

                dgvLocalLicenses.Columns[0].HeaderText = "Expiration Date";
                dgvLocalLicenses.Columns[0].Width = 100;

                dgvLocalLicenses.Columns[0].HeaderText = "Is Active";
                dgvLocalLicenses.Columns[0].Width = 100;

            }

        }
        //private void _LoadInternationalLicenseInfo()
        //{
        //    _LocalLicenseHistoryList = clsDriverBusiness.GetLicenses(_DriverID);
        //    dgvLocalLicenses.DataSource = _LocalLicenseHistoryList;
        //    lbvLocalRecord.Text = dgvLocalLicenses.Rows.Count.ToString();

        //    if (dgvLocalLicenses.Rows.Count > 0)
        //    {
        //        dgvLocalLicenses.Columns[0].HeaderText = "License ID";
        //        dgvLocalLicenses.Columns[0].Width = 100;

        //        dgvLocalLicenses.Columns[0].HeaderText = "App ID";
        //        dgvLocalLicenses.Columns[0].Width = 100;

        //        dgvLocalLicenses.Columns[0].HeaderText = "Class Name";
        //        dgvLocalLicenses.Columns[0].Width = 100;

        //        dgvLocalLicenses.Columns[0].HeaderText = "Issue Date";
        //        dgvLocalLicenses.Columns[0].Width = 100;

        //        dgvLocalLicenses.Columns[0].HeaderText = "Expiration Date";
        //        dgvLocalLicenses.Columns[0].Width = 100;

        //        dgvLocalLicenses.Columns[0].HeaderText = "Is Active";
        //        dgvLocalLicenses.Columns[0].Width = 100;

        //    }

        //}

        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDriverBusiness.FindByDriverID(_DriverID);
            _LoadLocalLicenseInfo();
            //_LoadInternationalLicenseInfo();
        }
        public void LoadInfoByPersonID(int PersonID)
        {
            _Driver = clsDriverBusiness.FindByPersonID(PersonID);
            if (_Driver == null)
            {
                MessageBox.Show("There is no Driver Connected with this person ID: " +
                    PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadLocalLicenseInfo();
            //_LoadLocalLicenseInfo();
        }

        private void ctrlDriverLicenses_Load(object sender, EventArgs e)
        {

        }

        private void dgvLocalLicenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLocalLicenses.CurrentRow.Cells[0].Value;
            frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvInternationalLicenses.CurrentRow.Cells[0].Value;
            frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
            frm.ShowDialog();

        }
        public void Clear()
        {
            _LocalLicenseHistoryList.Clear();
            _InternationalLicenseHistoryList.Clear();
        }
    }
}
