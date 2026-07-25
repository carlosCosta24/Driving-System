using BusinessLayer;
using Driving_System.Persons;
using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_System.Drivers
{
    public partial class frmDriversList : Form
    {
        private DataTable _DriversList;
        public frmDriversList()
        {
            InitializeComponent();
        }

        private void frmDriversList_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            _DriversList = clsDriverBusiness.GetAllDrivers();
            dgvDrivers.DataSource = _DriversList;
            lbvRecords.Text = dgvDrivers.Rows.Count.ToString();
            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 120;

                dgvDrivers.Columns[0].HeaderText = "Person ID";
                dgvDrivers.Columns[0].Width = 120;

                dgvDrivers.Columns[0].HeaderText = "National No.";
                dgvDrivers.Columns[0].Width = 120;

                dgvDrivers.Columns[0].HeaderText = "Full Name";
                dgvDrivers.Columns[0].Width = 120;

                dgvDrivers.Columns[0].HeaderText = "Date";
                dgvDrivers.Columns[0].Width = 120;

                dgvDrivers.Columns[0].HeaderText = "Active Licenses";
                dgvDrivers.Columns[0].Width = 120;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Visible = (cbFilter.Text != "None");

            if (cbFilter.Text == "None")
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

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterCategory = "";
            switch (cbFilter.Text)
            {
                case "Driver ID":
                    FilterCategory = "DriverID";
                    break;
                case "Person ID":
                    FilterCategory = "PersonID";
                    break;
                case "National No.":
                    FilterCategory = "NationalNo";
                    break;
                case "Full Name":
                    FilterCategory = "FullName";
                    break;
                default:
                    FilterCategory = "None";
                    break;

            }
            if (tbFilterValue.Text.Trim() == "" || FilterCategory == "None")
            {
                _DriversList.DefaultView.RowFilter = "";
                lbvRecords.Text = dgvDrivers.Rows.Count.ToString();
                return;
            }

            if (FilterCategory != "FullName" && FilterCategory != "NationalNo")
            {
                _DriversList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterCategory, tbFilterValue.Text.Trim());

            }
            else
            {
                _DriversList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterCategory, tbFilterValue.Text.Trim());
            }
            lbvRecords.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Driver ID" || cbFilter.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonId = (int)dgvDrivers.CurrentRow.Cells[1].Value;
            frmShowPersonInfo frm = new frmShowPersonInfo(PersonId);
            frm.ShowDialog();
            frmDriversList_Load(null, null);
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
