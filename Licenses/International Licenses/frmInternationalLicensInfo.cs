using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_System.Licenses.International_Licenses
{
    public partial class frmInternationalLicensInfo : Form
    {
        private int _LicenseID = -1;
        public frmInternationalLicensInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            _LicenseID = InternationalLicenseID;
        }

        private void frmInternationalLicensInfo_Load(object sender, EventArgs e)
        {
            ctrlInternationalLicenseInfo1.LoadInfo(_LicenseID);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
