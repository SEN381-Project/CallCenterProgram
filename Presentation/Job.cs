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
    public partial class job : Form
    {
        JobBussinessLogic jobObj = new JobBussinessLogic();

        public job()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtJobID.Text != "")
            {
                jobObj.CloseJob(int.Parse(txtJobID.Text));
            }
            else
            {
                MessageBox.Show("Please enter the jobs ID!", "Wrong Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtJobID.Text != "")
            {
                dgvIncident.DataSource = jobObj.ViewJob(int.Parse(txtJobID.Text));
            }
            else
            {
                dgvIncident.DataSource = jobObj.ViewJob();
            }
        }
    }
}
