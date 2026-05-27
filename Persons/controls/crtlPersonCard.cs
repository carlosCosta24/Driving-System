using BusinessLayer;
using Driving_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_System
{
    public partial class crtlPersonCard : UserControl
    {
        private clsPersonBusiness _Person;
        private int _PersonID = -1;
        public int PersonID 
        {
            get {return _PersonID;}
        }
        public clsPersonBusiness SelectedPerson 
        {
            get { return _Person; }
        
        }
        public crtlPersonCard()
        {
            InitializeComponent();
            
        }
        public void LoadPersonInfo(int PersonID) {
            _Person = clsPersonBusiness.GetPerson(PersonID);
            if (_Person == null) 
            {
                RestPersonInfo();
                MessageBox.Show("No Person With ID: " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();


        
        }
        public void LoadPersonInfo(string NationalID)
        {
            _Person = clsPersonBusiness.GetPerson(NationalID);
            if (_Person == null)
            {
                RestPersonInfo();
                MessageBox.Show("No Person With NationalID: " + NationalID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();



        }
        private void _LoadPersonImage() {
            if (_Person.Gender == 'M') {
                pictureBox1.Image = Resources.Male_512;

            }
            else 
            {
                pictureBox1.Image = Resources.Female_512;
            }
            string ImagePath = _Person.ImagePath;

            if (ImagePath != "") {
                if (File.Exists(ImagePath)) { 
                    pictureBox1.ImageLocation = ImagePath;
                }
                else 
                {
                    MessageBox.Show("Could not find this image: " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void _FillPersonInfo() {

            llEditPersonInfo.Visible = true;
            _PersonID = _Person.PersonID;
            lbvPersonID.Text = _Person.PersonID.ToString();
            lbvName.Text = _Person.FullName;
            lbvNationalNo.Text = _Person.NationalNumber;
            lbvGender.Text = _Person.Gender.ToString();
            lbvAddress.Text = _Person.Address;
            lbvDate.Text = _Person.BirthDate.ToShortDateString();
            lbvPhone.Text = _Person.Phone;
            lbvCountry.Text = clsCountryBusiness.GetCountry(_Person.CountryID).CountryName;
            _LoadPersonImage();
        }
        private void RestPersonInfo() {

            _PersonID = -1;
            lbvPersonID.Text = "-";
            lbvNationalNo.Text = "-";
            lbvName.Text = "-";
            pictureBox1.Image = Resources.Male_512;
            lbvGender.Text = "-";
            lbvEmail.Text = "-";
            lbvPhone.Text = "-";
            lbvDate.Text = "-";
            lbvCountry.Text = "-";
            lbvAddress.Text = "-";




        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

            LoadPersonInfo(_PersonID);
        }

        private void gbPersonCard_Enter(object sender, EventArgs e)
        {

        }
    }
}
