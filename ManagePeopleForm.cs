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
using System.IO; // use to save files to folder

namespace Driving_System
{
    public partial class ManagePeopleForm : Form
    {
        private void _LoadPersonsData() { 
        
            dataGridView1.DataSource = clsPersonBusiness.GetAllPersons();
        }
        public ManagePeopleForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form AddNewPerson = new AddNewPerson(-1);
            AddNewPerson.ShowDialog();
            _LoadPersonsData();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {
            _LoadPersonsData();
            comboBox1.SelectedIndex = 0;
            label4.Text = clsPersonBusiness.GetAllPersons().Rows.Count.ToString();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
