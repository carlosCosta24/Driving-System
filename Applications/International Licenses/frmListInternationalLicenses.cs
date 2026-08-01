using BusinessLayer;
using Driving_System.Licenses;
using Driving_System.Licenses.International_Licenses;
using Driving_System.Persons;
using System;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;

namespace Driving_System.Applications.International_Licenses
{
    public partial class frmListInternationalLicenses : Form
    {
        private DataTable _List;
        public frmListInternationalLicenses()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListInternationalLicenses_Load(object sender, EventArgs e)
        {
            _List = clsInternationalLicenseBusiness.GetAllLicenses();
            cbFilterCatigory.SelectedIndex = 0;
            dgvInternationalLicenses.DataSource = _List;
            lbvRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Int. License ID";
                dgvInternationalLicenses.Columns[0].Width = 50;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 50;

                dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                dgvInternationalLicenses.Columns[2].Width = 50;

                dgvInternationalLicenses.Columns[0].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[0].Width = 50;

                dgvInternationalLicenses.Columns[0].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[0].Width = 150;

                dgvInternationalLicenses.Columns[0].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[0].Width = 150;

                dgvInternationalLicenses.Columns[0].HeaderText = "Active";
                dgvInternationalLicenses.Columns[0].Width = 50;

            }


        }

        private void btnAddNewInternationlLicense_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApp frm = new frmNewInternationalLicenseApp();
            frm.ShowDialog();
            frmListInternationalLicenses_Load(null, null);

        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvInternationalLicenses.CurrentRow.Cells[2].Value;
            int PersonID = clsDriverBusiness.FindByDriverID(DriverID).PersonID;
            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvInternationalLicenses.CurrentRow.Cells[0].Value;
            frmInternationalLicensInfo frm = new frmInternationalLicensInfo(LicenseID);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvInternationalLicenses.CurrentRow.Cells[2].Value;
            int PersonID = clsDriverBusiness.FindByDriverID(DriverID).PersonID;
            frmPersonLicenseHistory frm = new frmPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void cbFilterCatigory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSubCatigory.Text == "Active")
            {
                cbFilterCatigory.Visible = false;
                cbSubCatigory.Visible = true;
                cbSubCatigory.Focus();
                cbSubCatigory.SelectedIndex = 0;
            }
            else
            {
                tbFilter.Visible = (cbSubCatigory.Text != "None");
                cbSubCatigory.Visible = false;
                if (cbFilterCatigory.Text == "None")
                {
                    tbFilter.Enabled = false;
                }else
                {
                    tbFilter.Enabled =true;
                }
                tbFilter.Text = "";
                tbFilter.Focus();
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterBy = "";
            switch (cbFilterCatigory.Text) 
            {
                case "International License ID":
                    FilterBy = "InternationalLicenseID";
                    break;
                case "Application ID":
                    FilterBy = "ApplicationID";
                    break;
                case "Driver ID":
                    FilterBy = "DriverID";
                    break;
                case "Local License ID":
                    FilterBy = "LocalLicenseID";
                    break;
                case "Active":
                    FilterBy = "Active";
                    break;
                default:
                    FilterBy = "None";
                    break;

            }
            if(tbFilter.Text.Trim() == "" || FilterBy == "None")
            {
                _List.DefaultView.RowFilter = "";
                lbvRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
                return;
            }

            _List.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterBy, tbFilter.Text.Trim());
            lbvRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbSubCatigory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterBy = "Active";
            string FilterValue = cbSubCatigory.Text;

            switch(FilterValue)
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
            if(FilterValue == "All")
            {
                _List.DefaultView.RowFilter = "";
            }else
            {
                _List.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterBy, FilterValue);

            }
            lbvRecords.Text = _List.Rows.Count.ToString();
        }
    }
}
