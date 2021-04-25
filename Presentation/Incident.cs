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
    public partial class frmIncident : Form
    {
        ServiceRequest serviceReqObj = new ServiceRequest();

        public frmIncident()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            if (rtbReportInfo.Text == "")
            {
                MessageBox.Show("Please enter a report for the incident!", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpDateIssued.Value > DateTime.Today)
            {
                MessageBox.Show("Date cannot be in the future!", "Wrong Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCost.Text == "")
            {
                MessageBox.Show("Please enter the cost!", "Wrong Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCallerID.Text == "")
            {
                MessageBox.Show("Please enter your called ID!", "Wrong Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtClientID.Text == "")
            {
                MessageBox.Show("Please enter the clients ID!", "Wrong Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string abilityReq = string.Empty;

                if (radioButton1.Checked)
                {
                    abilityReq += radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    abilityReq += "," + radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    abilityReq += "," + radioButton3.Text;
                }
                else if (radioButton4.Checked)
                {
                    abilityReq += "," + radioButton4.Text;
                }

                serviceReqObj.CreateServiceRequest(rtbReportInfo.Text, dtpDateIssued.Value, int.Parse(cbxPriority.Text), int.Parse(txtCost.Text), abilityReq.Split(','), int.Parse(txtClientID.Text), int.Parse(txtCallerID.Text));

                //Thread assignJobThread = new Thread(new ThreadStart(AssignJobThread));
                //assignJobThread.Start();
            }
        }

        public void AssignJobThread()
        {
            JobBussinessLogic jobObj = new JobBussinessLogic();

            List<Job> jobs = jobObj.ViewJob();
            List<Incident> incidents = serviceReqObj.ViewRequest();

            bool create = true;
            int incID = 0;

            for (int i = 0; i < jobs.Count; i++)
            {
                for (int j = 0; j < incidents.Count; j++)
                {
                    if (jobs[i].IncedentID == incidents[j].IncidentID)
                    {
                        create = false;
                        incID = incidents[j].IncidentID;
                    }

                    if (create)
                    {
                        serviceReqObj.AssignJob(incID);
                    }
                    create = false;
                    incID = 0;
                }
            }
        }
    }
}
