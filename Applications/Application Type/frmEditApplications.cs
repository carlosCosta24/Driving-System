using BusinessLayer;
using Driving_System.Global;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Driving_System.Applications.Application_Type
{
    public partial class frmEditApplications : Form
    {
        private int _ApplicationsID = -1;
        private clsAppTypesBusiness _Aplication;
        public frmEditApplications(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationsID = ApplicationID;
        }

        private void frmEditApplications_Load(object sender, EventArgs e)
        {
            lbvID.Text = _ApplicationsID.ToString();
            _Aplication = clsAppTypesBusiness.FindApp(_ApplicationsID);
            if (_Aplication != null)
            {
                tbTitle.Text = _Aplication.Title;
                tbFees.Text = _Aplication.Fees.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field are not valide!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Aplication.Title = tbTitle.Text;
            _Aplication.Fees = Convert.ToSingle(tbFees.Text);

            if (_Aplication.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data not Saved!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTitle, "Can't be empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbTitle, null);
            }
        }

        private void tbFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFees, "Fees can't be empty");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbFees, null);

            }
            if (!clsValidating.IsNumber(tbFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFees, "Fees is not valid number");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbFees, null);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
