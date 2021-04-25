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
    }
}
