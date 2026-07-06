using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_System.Licenses
{
    public partial class frmPersonLicenseHistory : Form
    {
        private int _PersonID = -1;
        public frmPersonLicenseHistory()
        {
            InitializeComponent();
        }
        public frmPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            if(_PersonID != -1)
            {
                crtlPersonCardWithFilter1.LoadPersonInfo(_PersonID);
                crtlPersonCardWithFilter1.FilterEnabled = false;
                ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
            }
            else
            {
                crtlPersonCardWithFilter1.Enabled = true;
                crtlPersonCardWithFilter1.FilterFocus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crtlPersonCardWithFilter1_PersonSelected(int obj)
        {
            _PersonID = obj;
            if (_PersonID == -1)
            {
                ctrlDriverLicenses1.Clear();
            }
            else
            {
                ctrlDriverLicenses1.LoadInfoByPersonID(_PersonID);
            }
        }
    }
}
