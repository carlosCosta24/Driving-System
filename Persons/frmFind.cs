using System;
using System.Windows.Forms;

namespace Driving_System.Persons
{
    public partial class frmFind : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;
        public frmFind()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, crtlPersonCardWithFilter1.PersonID);
        }
    }
}
