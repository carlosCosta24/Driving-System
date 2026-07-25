using BusinessLayer;
using Driving_System.Global;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Driving_System.Tests.Test_Types
{
    public partial class frmEditTestType : Form
    {
        private clsTestTypesBusiness.enTestTypes _ID = clsTestTypesBusiness.enTestTypes.Vision;
        private clsTestTypesBusiness _TestTypes;
        public frmEditTestType(clsTestTypesBusiness.enTestTypes TestTypeID)
        {
            InitializeComponent();
            _ID = TestTypeID;
        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _TestTypes = clsTestTypesBusiness.Find(_ID);
            if (_TestTypes == null)
            {
                MessageBox.Show("Error while getting test data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lbID.Text = ((int)_ID).ToString();
            tbTitle.Text = _TestTypes.Title;
            tbDescription.Text = _TestTypes.Description;
            tbFees.Text = _TestTypes.Fees.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("All field are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _TestTypes.Title = tbTitle.Text;
            _TestTypes.Description = tbDescription.Text;
            _TestTypes.Fees = Convert.ToSingle(tbFees.Text.Trim());

            if (_TestTypes.Save())
            {
                MessageBox.Show("Data saved successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data not saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTitle, "Title Cant be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbTitle, null);
            }
        }

        private void tbDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbDescription, "Description Cant be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbDescription, null);
            }

        }

        private void tbFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFees, "Fees Cant be Empty");
                return;
            }

            if (!clsValidating.IsNumber(tbFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFees, "Invalid number!");
                return;

            }

            e.Cancel = false;
            errorProvider1.SetError(tbFees, null);


        }
    }
}
