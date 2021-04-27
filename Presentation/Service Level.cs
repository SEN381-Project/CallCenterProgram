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
    public partial class Service_Level : Form
    {
        public Service_Level()
        {
            InitializeComponent();
        }
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        BindingSource bsSecurity = new BindingSource();
        BindingSource bsService = new BindingSource();
        private void Service_Level_Load(object sender, EventArgs e)
        {
            bsSecurity.DataSource = dataAccess.GetAllSecurityLevels();
            dgvExistingSecurityLevels.DataSource = bsSecurity;

            bsService.DataSource = dataAccess.GetAllServiceLevels();
            dgvExistingServiceLevels.DataSource = bsService;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            HomeForm main = new HomeForm();
            this.Hide();
            main.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int security = int.Parse(txtAddSecurityID.Text);
            decimal late = decimal.Parse(txtAddLateWork.Text);
            decimal noPerformance = decimal.Parse(txtAddNonPerformance.Text);
            string name = txtAddName.Text;
            string optOut = txtAddOptOut.Text;
            int state = cmbAdd.Text == "Active" ? 1 : 0;
            ServiceLevel service = new ServiceLevel();
            service.AddServiceLevel(name, optOut, late, noPerformance, state, security);
            txtAddSecurityID.Clear();
            txtAddLateWork.Clear();
            txtAddNonPerformance.Clear();
            txtAddName.Clear();
            txtAddOptOut.Clear();
            bsService.DataSource = dataAccess.GetAllServiceLevels();
            bsService.ResetBindings(true);
        }

        private void dgvExistingServiceLevels_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txtUpdateServiceID.Text = dgvExistingServiceLevels.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtUpdateSecurityID.Text = dgvExistingServiceLevels.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                txtUpdateName.Text = dgvExistingServiceLevels.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtUpdateOptOut.Text = dgvExistingServiceLevels.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtUpdateLate.Text = dgvExistingServiceLevels.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtUpdatePerformance.Text = dgvExistingServiceLevels.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                cmbUpdateAll.Text = dgvExistingServiceLevels.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "True" ? "Active" : "Not-Active";

                txtUpdate1.Text = dgvExistingServiceLevels.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cmbUpdate1.Text = dgvExistingServiceLevels.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "True" ? "Active" : "Not-Active";
            }
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            int security = int.Parse(txtUpdateSecurityID.Text);
            int ServiceLevelID = int.Parse(txtUpdateServiceID.Text);
            decimal late = decimal.Parse(txtUpdateLate.Text);
            decimal noPerformance = decimal.Parse(txtUpdatePerformance.Text);
            string name = txtUpdateName.Text;
            string optOut = txtUpdateOptOut.Text;
            int state = cmbUpdateAll.Text == "Active" ? 1 : 0;
            ServiceLevel service = new ServiceLevel();
            service.UpdateServiceLevel(ServiceLevelID, name, optOut, late, noPerformance, security, state);
            bsService.DataSource = dataAccess.GetAllServiceLevels();
            bsService.ResetBindings(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.Show();
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            int serviceLevelID = int.Parse(txtUpdate1.Text);
            int state = cmbUpdate1.Text == "Active" ? 1 : 0;
            ServiceLevel service = new ServiceLevel();
            service.UpdateServiceLevelAvailability(serviceLevelID, state);
            bsService.DataSource = dataAccess.GetAllServiceLevels();
            bsService.ResetBindings(true);
        }
    }
}
