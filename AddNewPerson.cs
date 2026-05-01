using BusinessLayer;
using Driving_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_System
{
    public partial class AddNewPerson : Form
    {
        public enum enMode { Add = 0 , Update = 1}
        enMode _Mode;
        clsPersonBusiness _Person;
        int _PersonID;
        private void FillPersonObject(clsPersonBusiness NewPerson)
        {

            NewPerson.FirstName = tbFirstName.Text;
            NewPerson.MiddleName = tbMiddleName.Text;
            NewPerson.LastName = tbLastName.Text;
            NewPerson.NationalNumber = tbNationalNo.Text;
            NewPerson.Address = tbAddress.Text;
            NewPerson.Phone = tbPhone.Text;
            NewPerson.CountryID = cbCountry.SelectedIndex + 1;
            if (!string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                NewPerson.Email = tbEmail.Text;
            }
            if (!string.IsNullOrEmpty(pbUserPicture.ImageLocation))
            {
                NewPerson.ImagePath = pbUserPicture.ImageLocation;
            }
            if (rbMale.Checked)
            {
                NewPerson.Gender = 'M';
            }
            else
            {
                NewPerson.Gender = 'F';
            }


        }
        private void _LoadData() {

            if (_Mode == enMode.Add) {
                _Person = new clsPersonBusiness();
                lbTitle.Text = "Add New Person"; 
                return;
            }
            _Person = clsPersonBusiness.GetPerson(_PersonID);
            if (_Person == null) {
                MessageBox.Show("This person dosent exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            tbFirstName.Text = _Person.FirstName;
            tbMiddleName.Text = _Person.MiddleName;
            tbLastName.Text = _Person.LastName;
            tbNationalNo.Text = _Person.NationalNumber;
            dtpBirthDate.Value = _Person.BirthDate;
            tbEmail.Text = _Person.Email;
            tbPhone.Text = _Person.Phone;
            cbCountry.SelectedIndex = _Person.CountryID;
            tbAddress.Text = _Person.Address;
            if(_Person.ImagePath != "")
            {
                pbUserPicture.Load(_Person.ImagePath);

            }
            if (_Person.Gender == 'M')
            {
                rbMale.Checked = true;
            }
            else {
                rbFemale.Checked = true;
            }
        }
        private void _LoadCountries() {
            dtpBirthDate.MaxDate = DateTime.Today.AddYears(-18);
            DataTable Countries = clsCountryBusiness.GetAllCountries();
            cbCountry.DataSource = Countries;
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
            cbCountry.SelectedIndex = 0;
        }
        public AddNewPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            if (_PersonID == -1)
            {
                _Mode = enMode.Add;
                lbTitle.Text = "Add New Person";
            }
            else {
                _Mode = enMode.Update;
                lbTitle.Text = "Edit Persond Information";
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void AddNewPerson_Load(object sender, EventArgs e)
        {
            _LoadData();
            _LoadCountries();

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                _Person.FirstName     = tbFirstName.Text ;
                _Person.MiddleName    = tbMiddleName.Text ;
                _Person.LastName      = tbLastName.Text ;
                _Person.NationalNumber= tbNationalNo.Text ;
                _Person.BirthDate     = dtpBirthDate.Value ;
                _Person.Email         = tbEmail.Text ;
                _Person.Phone         = tbPhone.Text ;
                _Person.CountryID     = (int)cbCountry.SelectedValue;
                _Person.Address       = tbAddress.Text;
                if (pbUserPicture.ImageLocation != null)
                {
                    _Person.ImagePath = pbUserPicture.ImageLocation;

                }
                else {
                    _Person.ImagePath = "";
                }

                if (rbMale.Checked)
                {
                    _Person.Gender = 'M';
                }
                else
                {
                    _Person.Gender = 'F';
                }


                if (_Person.Save())
                {
                    if (MessageBox.Show("New person added successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        == DialogResult.OK) 
                    {
                        _Mode = enMode.Update;
                        lbTitle.Text = "Edit Person Information ";
                        lbID.Text = _Person.PersonID.ToString();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Error while adding new person !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else {
                MessageBox.Show("All field should be field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                e.Cancel = true;
                epFirstName.SetError(tbFirstName, "First name can't be empty");
            }
            else
            {
                e.Cancel = false;
                epFirstName.SetError(tbFirstName, "");
            }

        }

        private void tbMiddleName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMiddleName.Text))
            {
                e.Cancel = true;
                epMiddleName.SetError(tbMiddleName, "Middle name can't be empty");
            }
            else
            {
                e.Cancel = false;
                epMiddleName.SetError(tbMiddleName, "");
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                e.Cancel = true;
                epLastName.SetError(tbLastName, "Last name can't be empty");
            }
            else
            {
                e.Cancel = false;
                epLastName.SetError(tbLastName, "");
            }
        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                e.Cancel = true;
                epPhone.SetError(tbPhone, "Phone number can't be empty");
            }
            else
            {
                e.Cancel = false;
                epPhone.SetError(tbPhone, "");


            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Title = "Select a photo";
            File.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp ";
            string ImageLocation = "";
            if (File.ShowDialog() == DialogResult.OK)
            {
                ImageLocation = File.FileName;

            }
            pbUserPicture.Load(ImageLocation);
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbUserPicture.Image = Resources.user;
        }

        private void tbNationalNo_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (clsPersonBusiness.IsExist(tbNationalNo.Text))
            {
                epNationalNo.SetError(tbNationalNo, "National number already exist");
            }
            else { 
                epNationalNo.SetError(tbNationalNo, "");

            }
        }
    }
}
