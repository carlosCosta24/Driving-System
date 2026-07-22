using Driving_System.Persons;
using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_System
{
    public partial class frmManagePeopleForm : Form
    {
        private static DataTable _PersonsData = clsPersonBusiness.GetAllPersons();
        private void _RefreshList()
        {

            _PersonsData = clsPersonBusiness.GetAllPersons();
            dgvPepoleData.DataSource = _PersonsData;
            lbCount.Text = dgvPepoleData.Rows.Count.ToString();

        }
        public frmManagePeopleForm()
        {
            InitializeComponent();


        }
        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {
            dgvPepoleData.DataSource = _PersonsData;
            cbFilterCategory.SelectedIndex = 0;
            lbCount.Text = dgvPepoleData.Rows.Count.ToString();
            if (dgvPepoleData.Rows.Count > 0)
            {
                dgvPepoleData.Columns[0].HeaderText = "Person ID";
                dgvPepoleData.Columns[0].Width = 110;

                dgvPepoleData.Columns[1].HeaderText = "National No.";
                dgvPepoleData.Columns[1].Width = 120;


                dgvPepoleData.Columns[2].HeaderText = "First Name";
                dgvPepoleData.Columns[2].Width = 120;

                dgvPepoleData.Columns[3].HeaderText = "Middle Name";
                dgvPepoleData.Columns[3].Width = 140;


                dgvPepoleData.Columns[5].HeaderText = "Last Name";
                dgvPepoleData.Columns[5].Width = 120;

                dgvPepoleData.Columns[6].HeaderText = "Gender";
                dgvPepoleData.Columns[6].Width = 120;

                dgvPepoleData.Columns[7].HeaderText = "Date Of Birth";
                dgvPepoleData.Columns[7].Width = 140;

                dgvPepoleData.Columns[8].HeaderText = "Nationality";
                dgvPepoleData.Columns[8].Width = 120;


                dgvPepoleData.Columns[9].HeaderText = "Phone";
                dgvPepoleData.Columns[9].Width = 120;


                dgvPepoleData.Columns[10].HeaderText = "Email";
                dgvPepoleData.Columns[10].Width = 170;
            }

        }
        private void _LoadPersonsData()
        {

            dgvPepoleData.DataSource = _PersonsData;
        }
        private void FilterData()
        {

            string FilterColumn = "";
            switch (cbFilterCategory.Text)
            {

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
                case "First Name":
                    FilterColumn = "FirstName";
                    break;
                case "Middle Name":
                    FilterColumn = "MiddleName";
                    break;
                case "Last Name":
                    FilterColumn = "LastName";
                    break;
                case "Country":
                    FilterColumn = "Country";
                    break;
                case "Gender":
                    FilterColumn = "Gender";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
                    break;
                case "Email":
                    FilterColumn = "Email";
                    break;
                default:
                    FilterColumn = "None";
                    break;

            }
            if (tbFilterText.Text.Trim() == "" || FilterColumn == "None")
            {

                _PersonsData.DefaultView.RowFilter = "";
                lbCount.Text = _PersonsData.Rows.Count.ToString();
                return;
            }
            if (FilterColumn == "PersonID")
            {

                _PersonsData.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilterText.Text.Trim());

            }
            else
            {
                _PersonsData.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterColumn, tbFilterText.Text.Trim());


            }
            lbCount.Text = _PersonsData.Rows.Count.ToString();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form AddNewPerson = new frmAddUpdatePerson();
            AddNewPerson.ShowDialog();
            _LoadPersonsData();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterText.Visible = (cbFilterCategory.Text != "None");
            if (tbFilterText.Visible)
            {
                tbFilterText.Text = "";
                tbFilterText.Focus();
            }

        }


        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPepoleData.CurrentRow.Cells[0].Value;
            Form frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void tbFilterText_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dgvPepoleData.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshList();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete person [ " + dgvPepoleData.CurrentRow.Cells[0].Value + "]",
                "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsPersonBusiness.DeletePerson((int)dgvPepoleData.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("Person Deleted Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshList();
                }
                else
                {
                    MessageBox.Show("Person was not deleted due to linking data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshList();
        }

        private void tbFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterCategory.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            }

        }
    }
}
