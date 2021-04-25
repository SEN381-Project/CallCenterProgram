using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallCenterProgram.Bussiness_Logic;
using CallCenterProgram.Data_Access;
using CallCenterProgram;

namespace CallCenterProgram.Presentation
{
    public partial class frmServiceRequest : Form
    {
        ServiceRequest serviceReqObj = new ServiceRequest();

        public frmServiceRequest()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtIncidentID.Text != "")
            {
                dgvIncident.DataSource = serviceReqObj.ViewRequest(int.Parse(txtIncidentID.Text));
            }
            else
            {
                dgvIncident.DataSource = serviceReqObj.ViewRequest();
            }
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            frmIncident incidentForm = new frmIncident();
            incidentForm.Show();
        }

        private void btnReassignJob_Click(object sender, EventArgs e)
        {
            frmIncident incidentForm = new frmIncident();
            incidentForm.Show();
        }

        private void btnEscalateJob_Click(object sender, EventArgs e)
        {
            frmIncident incidentForm = new frmIncident();
            incidentForm.Show();
        }
    }
}
