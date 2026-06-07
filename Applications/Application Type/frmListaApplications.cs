using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_System.Applications.Application_Type
{
    public partial class frmListaApplications : Form
    {
        private DataTable _dtApplications;
        public frmListaApplications()
        {
            InitializeComponent();
        }

        private void frmListaApplications_Load(object sender, EventArgs e)
        {
          //  _dtApplications = clsApplicationTypes.GetAll();
            dgvApplications.DataSource = _dtApplications;
            lbvRecords.Text = _dtApplications.Rows.Count.ToString();

            dgvApplications.Columns[0].HeaderText = "ID";
            dgvApplications.Columns[0].Width = 80;

            dgvApplications.Columns[1].HeaderText = "Title";
            dgvApplications.Columns[1].Width = 500;

            dgvApplications.Columns[2].HeaderText = "Fees";
            dgvApplications.Columns[2].Width = 150;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplications frm = new frmEditApplications((int)dgvApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            //Reload the form by calling loading function 
            frmListaApplications_Load(null, null);
        }
    }
}
