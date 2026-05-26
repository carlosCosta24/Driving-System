using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // use to save files to folder

namespace Driving_System
{
    public partial class ManagePeopleForm : Form
    {
        DataTable PersonsData = clsPersonBusiness.GetAllPersons();
        private void _LoadPersonsData() {

            dgvPepoleData.DataSource = PersonsData;
        }
        private void FilterData() {

            tbFilterText.Visible = true;
            if (cbFilterCategory.Text == "Person ID") 
            {
                // prevent the user from typing char
                //set the Filter to the input
                PersonsData.DefaultView.RowFilter = $"Convert(NationalNumberID, 'System.String') PersonID like '%{tbFilterText.Text}%'";
            }
            if (cbFilterCategory.Text == "National No") {
                PersonsData.DefaultView.RowFilter = $"NationalNumberID like '%{tbFilterText.Text}%'";
            }
            if (cbFilterCategory.Text == "First Name") {
                PersonsData.DefaultView.RowFilter = $"FirstName like '%{tbFilterText.Text}%'";
            }
            if (cbFilterCategory.Text == "Middle Name") {
                PersonsData.DefaultView.RowFilter = $"MiddleName like '%{tbFilterText.Text}%'";
            }
            if (cbFilterCategory.Text == "Last Name") {
                PersonsData.DefaultView.RowFilter = $"LastName like '%{tbFilterText.Text}%'";

            }
            if (cbFilterCategory.Text == "Nationality") {
                PersonsData.DefaultView.RowFilter = $"Nationality like '%{tbFilterText.Text}%'";

            }
            if (cbFilterCategory.Text == "Gender") { 
                tbFilterText.Visible = false;
                cbGender.Visible = true;
                PersonsData.DefaultView.RowFilter = $"Gender like '%{tbFilterText.Text}%'";
            }
            if (cbFilterCategory.Text == "Phone") {
                PersonsData.DefaultView.RowFilter = $"Phone like '%{tbFilterText.Text}%'";

            }
            if (cbFilterCategory.Text == "Email") {
                PersonsData.DefaultView.RowFilter = $"Email like '%{tbFilterText.Text}%'";

            }
            
            
            


        }
        public ManagePeopleForm()
        {
            InitializeComponent();
            _LoadPersonsData();
            
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
            
            
        }

        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {
            _LoadPersonsData();
            cbFilterCategory.SelectedIndex = 0;
            tbFilterText.Visible = false;
            cbGender.Visible = false;
            label4.Text = clsPersonBusiness.GetAllPersons().Rows.Count.ToString();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tbFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            FilterData();
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbFilterText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
