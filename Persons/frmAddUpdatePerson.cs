using BusinessLayer;
using Driving_System.Global;
using Driving_System.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Driving_System
{
    public partial class frmAddUpdatePerson : Form
    {
        //delegation
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        public enum enMode { Add = 0, Update = 1 }
        private enMode _Mode;
        private int _PersonID = -1;
        clsPersonBusiness _Person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;
        }
        private void _RestValues()
        {

            _LoadCountries();
            cbCountry.SelectedIndex = cbCountry.FindString("Canada");
            if (_Mode == enMode.Add)
            {
                lbTitle.Text = "Add New Person";
                _Person = new clsPersonBusiness();
            }
            else
            {
                lbTitle.Text = "Update Person";
            }
            if (rbMale.Checked)
            {
                pbUserPicture.Image = Resources.Male_512;
            }
            else
            {
                pbUserPicture.Image = Resources.Female_512;
            }
            llRemoveImage.Visible = (pbUserPicture.ImageLocation != null);
            _SetDateLimmits();

            tbFirstName.Text = "";
            tbMiddleName.Text = "";
            tbLastName.Text = "";
            tbNationalNo.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
            rbMale.Checked = true;
        }
        private void _LoadData()
        {
            _Person = clsPersonBusiness.GetPerson(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID: " + _PersonID, "Not found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lbID.Text = _Person.PersonID.ToString();
            tbFirstName.Text = _Person.FirstName;
            tbMiddleName.Text = _Person.MiddleName;
            tbLastName.Text = _Person.LastName;
            tbNationalNo.Text = _Person.NationalNumber;
            dtpBirthDate.Value = _Person.BirthDate;
            tbEmail.Text = _Person.Email;
            tbPhone.Text = _Person.Phone;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.CountryName);
            tbAddress.Text = _Person.Address;
            if (_Person.ImagePath != "")
            {
                pbUserPicture.ImageLocation = _Person.ImagePath;

            }
            if (_Person.Gender == 'M')
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            llRemoveImage.Visible = (_Person.ImagePath != "");
        }
        private void _LoadCountries()
        {

            DataTable Countries = clsCountryBusiness.GetAllCountries();
            foreach (DataRow Row in Countries.Rows)
            {

                cbCountry.Items.Add(Row["CountryName"]);

            }


        }
        private void _SetDateLimmits()
        {
            dtpBirthDate.MaxDate = DateTime.Today.AddYears(-18);
            dtpBirthDate.MinDate = DateTime.Today.AddYears(-100);
        }
        private void AddNewPerson_Load(object sender, EventArgs e)
        {
            _RestValues();
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
        }
        private bool _HandelImage()
        {

            if (_Person.ImagePath != pbUserPicture.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        //log in erros
                    }

                }

            }
            if (pbUserPicture.ImageLocation != null)
            {
                string ImageFileSource = pbUserPicture.ImageLocation.ToString();
                if (clsUtil.CopyImageToProjectFolder(ref ImageFileSource))
                {
                    pbUserPicture.ImageLocation = ImageFileSource;
                    return true;
                }
                else
                {
                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_HandelImage())
            {
                return;
            }

            int CountryID = clsCountryBusiness.GetCountry(cbCountry.Text).CountryID;
            _Person.FirstName = tbFirstName.Text.Trim();
            _Person.MiddleName = tbMiddleName.Text.Trim();
            _Person.LastName = tbLastName.Text.Trim();
            _Person.NationalNumber = tbNationalNo.Text.Trim();
            _Person.BirthDate = dtpBirthDate.Value;
            _Person.Email = tbEmail.Text.Trim();
            _Person.Phone = tbPhone.Text.Trim();
            _Person.Address = tbAddress.Text.Trim();
            _Person.CountryID = CountryID;

            if (pbUserPicture.ImageLocation != null)
            {
                _Person.ImagePath = pbUserPicture.ImageLocation;

            }
            else
            {
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

                lbID.Text = _Person.PersonID.ToString();
                _Mode = enMode.Update;
                lbTitle.Text = "Update Person";
                MessageBox.Show("Person Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
            {
                MessageBox.Show("Error while adding new person !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                epGeneral.SetError(tbNationalNo, "National Number is Requird!");
                return;
            }
            else
            {
                epGeneral.SetError(tbNationalNo, null);
            }
            if (tbNationalNo.Text.Trim() != _Person.NationalNumber && clsPersonBusiness.IsExist(tbNationalNo.Text.Trim()))
            {

                e.Cancel = true;
                epGeneral.SetError(tbNationalNo, "This National Number Already Exist!");

            }
            else
            {
                epGeneral.SetError(tbNationalNo, null);
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ofdChooseImage.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp ";
            ofdChooseImage.FilterIndex = 1;
            ofdChooseImage.RestoreDirectory = true;


            if (ofdChooseImage.ShowDialog() == DialogResult.OK)
            {
                string SelectedFilePath = ofdChooseImage.FileName;
                pbUserPicture.Load(SelectedFilePath);
                llRemoveImage.Visible = true;
            }

        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbUserPicture.ImageLocation = null;
            if (rbMale.Checked)
            {
                pbUserPicture.Image = Resources.Male_512;
            }
            else
            {
                pbUserPicture.Image = Resources.Female_512;
            }

            llRemoveImage.Visible = false;
        }

        private void tbNationalNo_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (clsPersonBusiness.IsExist(tbNationalNo.Text))
            {
                epGeneral.SetError(tbNationalNo, "National number already exist");
            }
            else
            {
                epGeneral.SetError(tbNationalNo, "");

            }
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbUserPicture.ImageLocation == null)
            {
                pbUserPicture.Image = Resources.Male_512;
            }
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbUserPicture.ImageLocation == null)
            {
                pbUserPicture.Image = Resources.Female_512;
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text.Trim() == "")
                return;
            if (!clsValidating.ValidateEmail(tbEmail.Text))
            {
                e.Cancel = true;
                epGeneral.SetError(tbEmail, "Invalid Email Address Format!");
            }
            else
            {
                epGeneral.SetError(tbEmail, null);
            }
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {

                e.Cancel = true;
                epGeneral.SetError(Temp, "This Fiels Is Requird!");
            }
            else {
                epGeneral.SetError(Temp, null);
            }


        }
    }
}
