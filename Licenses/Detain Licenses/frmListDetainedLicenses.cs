using BusinessLayer;
using Driving_System.Licenses.Local_Licenses;
using Driving_System.Persons;
using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_System.Licenses.Detain_Licenses
{
    public partial class frmListDetainedLicenses : Form
    {
        private DataTable _DetainedLicensesList;
        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            cbFilterCategory.SelectedIndex = 0;

            _DetainedLicensesList = clsDetainedBusiness.GetAllDetainedLicenses();

            dgvLicenses.DataSource = _DetainedLicensesList;
            lbvRecords.Text = dgvLicenses.Rows.Count.ToString();

            if (dgvLicenses.Rows.Count > 0)
            {
                dgvLicenses.Columns[0].HeaderText = "D.ID";
                dgvLicenses.Columns[0].Width = 50;

                dgvLicenses.Columns[0].HeaderText = "L.ID";
                dgvLicenses.Columns[0].Width = 50;

                dgvLicenses.Columns[0].HeaderText = "D.Date";
                dgvLicenses.Columns[0].Width = 100;

                dgvLicenses.Columns[0].HeaderText = "Released";
                dgvLicenses.Columns[0].Width = 50;

                dgvLicenses.Columns[0].HeaderText = "Fine Fees";
                dgvLicenses.Columns[0].Width = 100;

                dgvLicenses.Columns[0].HeaderText = "Release Date";
                dgvLicenses.Columns[0].Width = 100;

                dgvLicenses.Columns[0].HeaderText = "N.No";
                dgvLicenses.Columns[0].Width = 150;

                dgvLicenses.Columns[0].HeaderText = "Full Name";
                dgvLicenses.Columns[0].Width = 150;

                dgvLicenses.Columns[0].HeaderText = "Release App.ID";
                dgvLicenses.Columns[0].Width = 50;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterBy = "";

            switch (cbFilterCategory.Text)
            {
                case "Detain ID":
                    FilterBy = "DetainID";
                    break;
                case "Released":
                    FilterBy = "IsReleased";
                    break;
                case "National No.":
                    FilterBy = "NationalNo";
                    break;
                case "Full Name":
                    FilterBy = "FullName";
                    break;
                case "Release App ID":
                    FilterBy = "ReleaseAppID";
                    break;
                default:
                    FilterBy = "None";
                    break;

            }
            if (tbFilterValue.Text.Trim() == "" || FilterBy == "None")
            {
                _DetainedLicensesList.DefaultView.RowFilter = "";
                lbvRecords.Text = _DetainedLicensesList.Rows.Count.ToString();
                return;
            }

            if (FilterBy == "DetainID" || FilterBy == "ReleaseAppID")
            {
                _DetainedLicensesList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterBy, tbFilterValue.Text.Trim());

            }
            else
            {
                _DetainedLicensesList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterBy, tbFilterValue.Text.Trim());
            }

            lbvRecords.Text = _DetainedLicensesList.Rows.Count.ToString();
        }

        private void cbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterCategory.Text == "Released")
            {
                tbFilterValue.Visible = false;
                cbYesNo.Visible = true;
                cbYesNo.Focus();
                cbYesNo.SelectedIndex = 0;

            }
            else
            {
                tbFilterValue.Visible = (cbFilterCategory.Text != "None");
                cbYesNo.Visible = false;

                if (cbFilterCategory.Text == "None")
                {
                    tbFilterValue.Enabled = false;
                }
                else
                {
                    tbFilterValue.Enabled = true;
                }
                tbFilterValue.Text = "";
                tbFilterValue.Focus();
            }
        }

        private void cbYesNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterBy = "Released";
            string FilterValue = cbYesNo.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;

            }
            if (FilterValue == "All")
            {
                _DetainedLicensesList.DefaultView.RowFilter = "";
            }
            else
            {
                _DetainedLicensesList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterBy, FilterValue);
            }
            lbvRecords.Text = _DetainedLicensesList.Rows.Count.ToString();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterCategory.Text == "Detain ID" || cbFilterCategory.Text == "Release App ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLicenses.CurrentRow.Cells[1].Value;
            int PersonID = clsLicenseBusiness.Find(LicenseID).DriverInfo.PersonID;
            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLicenses.CurrentRow.Cells[1].Value;
            frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLicenses.CurrentRow.Cells [1].Value;
            int PersonID = clsLicenseBusiness.Find(LicenseID).DriverInfo.PersonID;

            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            releaseToolStripMenuItem.Enabled = !(bool)dgvLicenses.CurrentRow.Cells[3].Value;
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
