using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_System.Users
{
    public partial class frmListUsers : Form
    {
        private static DataTable _UsersList = clsUserBusiness.GetAllUsers();
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            dgvUsersList.DataSource = _UsersList;
            cbFilter.SelectedIndex = 0;
            lbvCount.Text = dgvUsersList.Rows.Count.ToString();

            if (dgvUsersList.Rows.Count > 0)
            {
                dgvUsersList.Columns[0].HeaderText = "User ID";
                dgvUsersList.Columns[0].Width = 20;

                dgvUsersList.Columns[1].HeaderText = "Person ID";
                dgvUsersList.Columns[1].Width = 20;

                dgvUsersList.Columns[2].HeaderText = "Full Name";
                dgvUsersList.Columns[2].Width = 150;

                dgvUsersList.Columns[3].HeaderText = "User Name";
                dgvUsersList.Columns[3].Width = 100;

                dgvUsersList.Columns[4].HeaderText = "Is Active";
                dgvUsersList.Columns[4].Width = 20;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsers frm = new frmAddUpdateUsers();
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsers frm = new frmAddUpdateUsers();
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsers frm = new frmAddUpdateUsers();
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsersList.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete :" +
                clsUserBusiness.FindByUserID(UserID).UserName,
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsUserBusiness.DeleteUser(UserID))
                {
                    MessageBox.Show("User deleted successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListUsers_Load(null, null);

                }
                else
                {
                    MessageBox.Show("User Not deleted !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality is not available yet", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality is not available yet", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "IsActive")
            {
                tbFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                tbFilterValue.Visible = (cbFilter.Text != "None");
                cbIsActive.Visible = false;

                tbFilterValue.Text = "";
                tbFilterValue.Focus();

            }
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterCategory;

            switch (cbFilter.Text)
            {
                case "User ID":
                    FilterCategory = "UserID";
                    break;
                case "User Name":
                    FilterCategory = "UserName";
                    break;
                case "Person ID":
                    FilterCategory = "PersonID";
                    break;
                case "Full Name":
                    FilterCategory = "FullName";
                    break;
                case "IsActive":
                    FilterCategory = "IS Active";
                    break;
                default:
                    FilterCategory = "None";
                    break;


            }
            if (FilterCategory == "None" || tbFilterValue.Text.Trim() == "")
            {
                _UsersList.DefaultView.RowFilter = "";
                lbvCount.Text = _UsersList.Rows.Count.ToString();
                return;

            }
            if (FilterCategory != "FullName" || FilterCategory != "UserName")
            {
                _UsersList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterCategory, tbFilterValue.Text.Trim());
            }
            else
            {
                _UsersList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterCategory, tbFilterValue.Text.Trim());

            }
            lbvCount.Text = _UsersList.Rows.Count.ToString();

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterCategory = cbIsActive.Text;
            string FilterColumn = "IsActive";

            switch (FilterCategory)
            {
                case "All":
                    break;
                case "Yes":
                    FilterCategory = "1";
                    break;
                case "No":
                    FilterCategory = "0";
                    break;

            }
            if (FilterColumn == "All")
            {
                _UsersList.DefaultView.RowFilter = "";

            }
            else
            {
                _UsersList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterCategory);
            }
        }
    }
}
