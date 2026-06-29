using BusinessLayer;
using Driving_System.Global;
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
    public partial class frmTakingTest : Form
    {
        private int _TestID = -1;
        private int _AppontID;
        private clsTestTypesBusiness.enTestTypes _TestType;
        private clsTestBusiness _Test;
        public frmTakingTest(int TestAppontID, clsTestTypesBusiness.enTestTypes TestType)
        {
            InitializeComponent();
            _AppontID = TestAppontID;
            _TestType = TestType; 
        }

        private void frmTakingTest_Load(object sender, EventArgs e)
        {
            ctrlScheduledTest1.TestTypeID = _TestType;
            ctrlScheduledTest1.LoadInfo(_AppontID);

            if (ctrlScheduledTest1.TestAppontID == -1)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
            int _TestID = ctrlScheduledTest1.TestID;
            if (_TestID != -1)
            {
                _Test = clsTestBusiness.Find(_TestID);
                if (_Test.TestResult)
                {
                    rbPass.Checked = true;
                }
                else
                {
                    rbFail.Checked = true;
                }
                tbNotes.Text = _Test.Notes;
                lbUserMessage.Visible = true;
                rbFail.Enabled = false;
                rbPass.Enabled = false;
            }
            else
            {
                _Test = new clsTestBusiness();
            }
    }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) 
                == DialogResult.No)
            {
                return;
            }
            _Test.TestAppontID = _AppontID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = tbNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal._User.UserID;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error: Data Not Saved .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
        }
    }
}
