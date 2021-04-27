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
    public partial class Package : Form
    {
        public Package()
        {
            InitializeComponent();
        }
        BindingSource bsPackages = new BindingSource();
        BindingSource bsServices = new BindingSource();
        BindingSource bsServiceLevels = new BindingSource();
        BindingSource bsSecurityLevels = new BindingSource();
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.Show();
        }

        private void Package_Load(object sender, EventArgs e)
        {
            bsServices.DataSource = dataAccess.GetAllServices();
            bsServiceLevels.DataSource = dataAccess.GetAllServiceLevels();
            bsSecurityLevels.DataSource = dataAccess.GetAllSecurityLevels();
            bsPackages.DataSource = dataAccess.GetAllPackages();
            dgvServices.DataSource = bsServices;
            dgvServiceLevels.DataSource = bsServiceLevels;
            dgvSecurityLevels.DataSource = bsSecurityLevels;
            dgvPackages.DataSource = bsPackages;
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            string serviceIDs = txtServiceIDs.Text;
            string serviceLevelIds = txtServiceLevelsIDs.Text;
            string name = txtPackageName.Text;
            Bussiness_Logic.Package package = new Bussiness_Logic.Package();
            package.AddPackage(name, serviceIDs, serviceLevelIds);
            txtServiceIDs.Clear();
            txtServiceLevelsIDs.Clear();
            txtPackageName.Clear();
            bsPackages.DataSource = dataAccess.GetAllPackages();
            bsPackages.ResetBindings(true);
        }

        private void dgvPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUpdateID.Text = dgvPackages.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtUpdateName.Text = dgvPackages.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtUpdateServiceIDs.Text = dgvPackages.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtUPdateServiceLevelIDs.Text = dgvPackages.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            }
        }

        private void btnUpdatePackage_Click(object sender, EventArgs e)
        {
            int packageID = int.Parse(txtUpdateID.Text);
            string serviceIDs = txtUpdateServiceIDs.Text;
            string serviceLevelIDs = txtUPdateServiceLevelIDs.Text;
            string name = txtUpdateName.Text;
            Bussiness_Logic.Package package = new Bussiness_Logic.Package();
            package.UpdatePackage(packageID, name, serviceIDs, serviceLevelIDs);
            bsPackages.DataSource = dataAccess.GetAllPackages();
            bsPackages.ResetBindings(true);
        }
    }
}
