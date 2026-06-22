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

namespace Driving_System.Tests
{
    public partial class frmScheduleTest : Form
    {
        private int _LocalDrivingLicenseAppID = -1;
        private clsTestTypesBusiness.enTestTypes _TestType = clsTestTypesBusiness.enTestTypes.Vision;
        private int _AppontID = -1;

        public frmScheduleTest(int LocalDrivingLicenseAppID, clsTestTypesBusiness.enTestTypes TestType, int AppontID = -1)
        {
            InitializeComponent();
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
            _TestType = TestType;
            _AppontID = AppontID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            crtlScheduleTest1.TestTypeID = _TestType;
            crtlScheduleTest1.LoadInfo(_LocalDrivingLicenseAppID,_AppontID);
        }
    }
}
