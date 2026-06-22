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

namespace Driving_System.Tests
{
    public partial class frmListTestAppont : Form
    {
        private DataTable _testAppontsList;
        private int _LocalDrivingLicenseAppID;
        private clsTestTypesBusiness.enTestTypes _TestType = clsTestTypesBusiness.enTestTypes.Vision;
        public frmListTestAppont(int LocalDrivingLicenseAppID, clsTestTypesBusiness.enTestTypes TestType)
        {
            InitializeComponent();
            _TestType = TestType;
            _LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
        }
        private void _LoadTestTypeDetails()
        {
            switch (_TestType)
            {
                case clsTestTypesBusiness.enTestTypes.Vision:
                    lbvTitle.Text = "Vision Test Appointment";
                    this.Text = "Vision Test";
                    pbTestImage.Image = Resources.Vision_512;
                    break;
                case clsTestTypesBusiness.enTestTypes.Written:
                    lbvTitle.Text = "Written test Appointment";
                    this.Text = "Written Test";
                    pbTestImage.Image = Resources.Written_Test_512;
                    break;
                case clsTestTypesBusiness.enTestTypes.Practical:
                    lbvTitle.Text = "Practical test Appointment";
                    this.Text = "Practical Test";
                    pbTestImage.Image = Resources.driving_test_512;
                    break;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseAppBusiness LocalDrivingLicenseApp = clsLocalDrivingLicenseAppBusiness.FindbyLocalDrivingLicenseAppID(_LocalDrivingLicenseAppID);
            // check if the person already have an active test scheduled
            if(LocalDrivingLicenseApp != null)
            {
                MessageBox.Show("Person already have an active appointment for this tes, you can't add another", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            //check if the last test was passed 
            //clsTest LastTest = LocalDrivingLicenseApp.GetLastTestPerType(_TestType);
            bool LastTest = false;
            if(LastTest == null)
            {
                frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseAppID, _TestType);
                frm.ShowDialog();
                frmListTestAppont_Load(null,null);
                return;
            }
            if (LastTest)
            {
                MessageBox.Show("This person already passed the test", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //frmScheduleTest frm2 = new frmScheduleTest(LastTest.ListAppontInfo.LocalDrivingLicenseAppID, _TestType);
            //frm2.ShowDialog();
            frmListTestAppont_Load(null, null);
        }

        private void editAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppontID = (int)dgvTestAppontList.CurrentRow.Cells[0].Value;
            frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseAppID, _TestType, TestAppontID);
            frm.ShowDialog();
            frmListTestAppont_Load(null, null);
        }

        private void frmListTestAppont_Load(object sender, EventArgs e)
        {
            _LoadTestTypeDetails();

            ctrlDrivingLicenseAppInfo1.LoadAppInfoByLocalDrivingAppID(_LocalDrivingLicenseAppID);
            _testAppontsList = clsTestAppointmentBusiness.GetAppTestAppontPerTestType(_LocalDrivingLicenseAppID, _TestType);

            dgvTestAppontList.DataSource = _testAppontsList;
            lbvRecord.Text = dgvTestAppontList.Rows.Count.ToString();

            if(dgvTestAppontList.Rows.Count > 0)
            {
                dgvTestAppontList.Columns[0].HeaderText = "Appointment ID";
                dgvTestAppontList.Columns[0].Width = 150;

                dgvTestAppontList.Columns[0].HeaderText = "Appointment Date";
                dgvTestAppontList.Columns[0].Width = 200;

                dgvTestAppontList.Columns[0].HeaderText = "Paid Fees";
                dgvTestAppontList.Columns[0].Width = 100;

                dgvTestAppontList.Columns[0].HeaderText = "Locked";
                dgvTestAppontList.Columns[0].Width = 180;
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppontID = (int)dgvTestAppontList.CurrentRow.Cells[0].Value;
            // create new instanse from take list form 
            // show it then reload this form 

        }
    }
}
