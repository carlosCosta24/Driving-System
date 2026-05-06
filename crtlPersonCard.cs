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
        clsPersonBusiness Person;
        private void _LoadPersonInfo() { 
        
            lbvPersonID.Text = Person.PersonID.ToString();
            lbvName.Text = Person.FullName;
            lbvNationalNo.Text = Person.NationalNumber;
            lbvGender.Text = Person.Gender.ToString();
            lbvAddress.Text = Person.Address;
            lbvDate.Text = Person.BirthDate.ToString();
            lbvPhone.Text = Person.Phone;
            lbvCountry.Text = clsCountryBusiness.GetCountry(Person.CountryID).ToString();

        
        }
        public crtlPersonCard(int ID)
        {
            InitializeComponent();
            Person = clsPersonBusiness.GetPerson(ID);
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
