using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_System.Applications.Local_Driving_License
{
    public partial class frmListLocalDrivingLicenseApps : Form
    {
        private DataTable _DrivingLicenseAppList;

        public frmListLocalDrivingLicenseApps()
        {
            InitializeComponent();
        }

        private void sechduleTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmListLocalDrivingLicenseApps_Load(object sender, EventArgs e)
        {
            //_DrivingLicenseAppList = clsLocalDrivingLicenseAppBusiness.GetAllLocalDrivingLicenseApps();
            dgvLocalDrivingAppList.DataSource = _DrivingLicenseAppList;

            if (dgvLocalDrivingAppList.Rows.Count > 0)
            {
                dgvLocalDrivingAppList.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLocalDrivingAppList.Columns[0].Width = 100;

                dgvLocalDrivingAppList.Columns[1].HeaderText = "Driving Class";
                dgvLocalDrivingAppList.Columns[1].Width = 100;

                dgvLocalDrivingAppList.Columns[2].HeaderText = "National No.";
                dgvLocalDrivingAppList.Columns[2].Width = 100;

                dgvLocalDrivingAppList.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingAppList.Columns[3].Width = 100;

                dgvLocalDrivingAppList.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingAppList.Columns[4].Width = 100;

                dgvLocalDrivingAppList.Columns[5].HeaderText = "Passed Tests";
                dgvLocalDrivingAppList.Columns[5].Width = 100;

            }
            lbvRecords.Text = _DrivingLicenseAppList.Rows.Count.ToString();
            cbFilterCategory.SelectedIndex = 0;

        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseAppID = (int)dgvLocalDrivingAppList.CurrentRow.Cells[0].Value;
            frmLocalDrivingLicenseAppInfo frm = new frmLocalDrivingLicenseAppInfo(LocalDrivingLicenseAppID);
            frm.ShowDialog();
            frmListLocalDrivingLicenseApps_Load(null, null);

        }

        private void cbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterText.Visible = (cbFilterCategory.Text != "None");
            if (tbFilterText.Visible)
            {
                tbFilterText.Text = "";
                tbFilterText.Focus();
            }
            _DrivingLicenseAppList.DefaultView.RowFilter = "";
            lbvRecords.Text = dgvLocalDrivingAppList.Rows.Count.ToString();
        }

        private void tbFilterText_TextChanged(object sender, EventArgs e)
        {
            string FilterBy = "";

            switch (cbFilterCategory.Text)
            {
                case "L.D.L.AppID":
                    FilterBy = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No.":
                    FilterBy = "NationalNo";
                    break;
                case "Full Name":
                    FilterBy = "FullName";
                    break;
                case "Status":
                    FilterBy = "Status";
                    break;
                default:
                    FilterBy = "None";
                    break;

            }

            if (FilterBy == "None" || tbFilterText.Text.Trim() == "")
            {
                _DrivingLicenseAppList.DefaultView.RowFilter = "";
                lbvRecords.Text = _DrivingLicenseAppList.Rows.Count.ToString();
                return;
            }
            if (FilterBy == "LocalDrivingLicenseApplicationID")
            {
                _DrivingLicenseAppList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterBy, tbFilterText.Text.Trim());
            }
            else
            {
                _DrivingLicenseAppList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%' ", FilterBy, tbFilterText.Text.Trim());
            }
            lbvRecords.Text = dgvLocalDrivingAppList.Rows.Count.ToString();

        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseAppID = (int)dgvLocalDrivingAppList.CurrentRow.Cells[0].Value;
            frmAddUpdateLocalDrivingLicenseApp frm = new frmAddUpdateLocalDrivingLicenseApp(LocalDrivingLicenseAppID);
            frm.ShowDialog();
            frmListLocalDrivingLicenseApps_Load(null, null);
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppID = (int)dgvLocalDrivingAppList.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete this app with ID " + AppID,
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clsLocalDrivingLicenseAppBusiness LocalDrivingLicenseApp =
                    clsLocalDrivingLicenseAppBusiness.FindbyLocalDrivingLicenseAppID(AppID);
                if (LocalDrivingLicenseApp != null)
                {
                    if (LocalDrivingLicenseApp.Delete())
                    {
                        MessageBox.Show("Application has been deleted successfully", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmListLocalDrivingLicenseApps_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Application has not been deleted, This application has linked date",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalAppID = (int)dgvLocalDrivingAppList.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to cancel application with ID: " + LocalAppID, "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            clsLocalDrivingLicenseAppBusiness LocalApp = clsLocalDrivingLicenseAppBusiness.FindbyLocalDrivingLicenseAppID(LocalAppID);

            if (LocalApp != null)
            {

                if (LocalApp.Cancel())
                {
                    MessageBox.Show("App has been cancelled successfully !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListLocalDrivingLicenseApps_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Somthing went wrong !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void sechduleTestsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {

        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApp frm = new frmAddUpdateLocalDrivingLicenseApp();
            frm.ShowDialog();
            frmListLocalDrivingLicenseApps_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseAppID = (int)dgvLocalDrivingAppList.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseAppBusiness LocalApp = 
                clsLocalDrivingLicenseAppBusiness.FindbyLocalDrivingLicenseAppID(LocalDrivingLicenseAppID);
            if (LocalApp != null)
            {

            }

        }

        private void tbFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterCategory.Text == "L.D.L.AppID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
