using System;
using System.Windows.Forms;

namespace Driving_System.Persons
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            crtlPersonCard1.LoadPersonInfo(PersonID);
        }
        public frmShowPersonInfo(string NationalNo)
        {
            InitializeComponent();
            crtlPersonCard1.LoadPersonInfo(NationalNo);
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {

        }

        private void crtlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
