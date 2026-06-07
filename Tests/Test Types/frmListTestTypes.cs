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

namespace Driving_System.Tests.Test_Types
{
    public partial class frmListTestTypes : Form
    {
        private DataTable _TestsList;
        public frmListTestTypes()
        {
            InitializeComponent();
        }

        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            _TestsList = clsTestTypesBusiness.GetAllTest();

            dgvTestsList.DataSource = _TestsList;
            lbvRecords.Text = dgvTestsList.Rows.Count.ToString();

            if (dgvTestsList.Rows.Count > 0) 
            {
                dgvTestsList.Columns[0].HeaderText = "ID";
                dgvTestsList.Columns[0].Width = 50;

                dgvTestsList.Columns[1].HeaderText = "Title";
                dgvTestsList.Columns[1].Width = 150;

                dgvTestsList.Columns[2].HeaderText = "Description";
                dgvTestsList.Columns[2].Width = 180;

                dgvTestsList.Columns[0].HeaderText = "Fees";
                dgvTestsList.Columns[0].Width = 50;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType((clsTestTypesBusiness.enTestTypes)dgvTestsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListTestTypes_Load(null, null);

        }
    }
}
