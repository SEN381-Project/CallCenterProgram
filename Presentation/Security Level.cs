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
using System.Data.SqlClient;

namespace CallCenterProgram.Presentation
{
    public partial class Security_Level : Form
    {
        public Security_Level()
        {
            InitializeComponent();
        }
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        BindingSource bs = new BindingSource();

        private void button3_Click(object sender, EventArgs e)
        {
            HomeForm main = new HomeForm();
            this.Hide();
            main.Show();
        }

        private void Security_Level_Load(object sender, EventArgs e)
        {
            bs.DataSource = dataAccess.GetAllSecurityLevels();
            dgvExistingSecurityLevels.DataSource = bs;
        }
    }
}
