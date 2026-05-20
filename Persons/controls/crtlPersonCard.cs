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

namespace Driving_System
{
    public partial class crtlPersonCard : UserControl
    {
        private clsPersonBusiness _Person;
        private int _PersonId;
        private void _LoadPersonInfo() { 
        
            lbvPersonID.Text = _Person.PersonID.ToString();
            lbvName.Text = _Person.FullName;
            lbvNationalNo.Text = _Person.NationalNumber;
            lbvGender.Text = _Person.Gender.ToString();
            lbvAddress.Text = _Person.Address;
            lbvDate.Text = _Person.BirthDate.ToString();
            lbvPhone.Text = _Person.Phone;
            lbvCountry.Text = clsCountryBusiness.GetCountry(_Person.CountryID).ToString();

        
        }
        public crtlPersonCard(int ID)
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {


        }

        private void crtlPersonCard_Load(object sender, EventArgs e)
        {

        }
    }
}
