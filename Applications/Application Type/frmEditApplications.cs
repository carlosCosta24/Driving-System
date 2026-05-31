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
    public partial class frmEditApplications : Form
    {
        private int _ApplicationsID = -1;
        private clsApplications _Aplications;
        public frmEditApplications(int ApplicationsID)
        {
            InitializeComponent();
            _ApplicationsID = ApplicationsID;
        }

        private void frmEditApplications_Load(object sender, EventArgs e)
        {
            lbvID.Text = _ApplicationsID.ToString();
            _Aplications = clsApplications.Find(_ApplicationsID);
            if (_Aplications != null) 
            {
                
            
            }
        }
    }
}
