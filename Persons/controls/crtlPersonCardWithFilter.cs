using System;
using System.Windows.Forms;

namespace Driving_System.Persons.controls
{
    public partial class crtlPersonCardWithFilter : UserControl
    {
        public event Action<int> PersonSelected;

        protected virtual void OnPersonSelected(int PersonID)
        {

            Action<int> Handler = PersonSelected;
            if (Handle != null)
            {

                Handler(PersonID);
            }

        }
        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {

            get { return _ShowAddPerson; }
            set
            {
                _ShowAddPerson = value;
                btnAdd.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {

            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;

            }
        }
        public crtlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private int _PersonID = -1;
        public int PersonID
        {
            get { return crtlPersonCard1.PersonID; }
        }

        public clsPersonBusiness SelectedPersonInfo
        {
            get { return crtlPersonCard1.SelectedPerson; }
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFindBy.SelectedIndex = 1;
            tbFilterValue.Text = PersonID.ToString();
            Find();
        }
        private void Find()
        {
            switch (cbFindBy.Text)
            {
                case "Person ID":
                    crtlPersonCard1.LoadPersonInfo(int.Parse(tbFilterValue.Text));
                    break;
                case "National No.":
                    crtlPersonCard1.LoadPersonInfo(int.Parse(tbFilterValue.Text));
                    break;
                default:
                    break;


            }
            if (PersonSelected != null && FilterEnabled)
            {

                PersonSelected(crtlPersonCard1.PersonID);
            }

        }

        private void cbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Text = "";
            tbFilterValue.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                MessageBox.Show("Some fields are not valid!, Hover over the red icons to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Find();
        }

        private void crtlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFindBy.SelectedIndex = 0;
            tbFilterValue.Focus();
        }

        private void tbFilterValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilterValue.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(tbFilterValue, "Invalid value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbFilterValue, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += DataBack;
            frm.ShowDialog();
        }
        private void DataBack(object sender, int PersonID)
        {
            cbFindBy.SelectedIndex = 1;
            tbFilterValue.Text = PersonID.ToString();
            crtlPersonCard1.LoadPersonInfo(PersonID);

        }
        public void FilterFocus()
        {
            tbFilterValue.Focus();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }
            if (cbFindBy.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void crtlPersonCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
