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

        private void button1_Click(object sender, EventArgs e)
        {
            string desc = txtAddDesc.Text;
            string email = txtAddEmail.Text;
            string phone = txtAddPhone.Text;
            int availability = cmbAdd.Text == "Available" ? 1 : 0;
            dataAccess.InsertSecuriyLevel(desc, availability, email, phone);
            txtAddDesc.Clear();
            txtAddEmail.Clear();
            txtAddPhone.Clear();
            bs.DataSource = dataAccess.GetAllSecurityLevels();
            bs.ResetBindings(true);
        }

        private void dgvExistingSecurityLevels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUpdateAllID.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtUpdateAllDesc.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtUpdateAllEmail.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtUpdateAllPhone.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                cmbUpdateAll.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "True" ? "Available" : "Not-Available";

                txtIDUpdate1.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                cmbUpdate1.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "True" ? "Available" : "Not-Available";
            }
        }

        private void btnUpdateSecurityLevel_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtUpdateAllID.Text);
            string desc = txtUpdateAllDesc.Text;
            string email = txtUpdateAllEmail.Text;
            string phone = txtUpdateAllPhone.Text;
            int availability = cmbUpdateAll.Text == "Available" ? 1 : 0;
            dataAccess.UpdateSecurityLevel(ID, desc, email, phone, availability);
            bs.DataSource = dataAccess.GetAllSecurityLevels();
            bs.ResetBindings(true);
        }

        private void btnUpdateAvailability_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDUpdate1.Text);
            int availability = cmbUpdate1.Text == "Available" ? 1 : 0;
            dataAccess.UpdateSecurityLevel(ID, availability);
            bs.DataSource = dataAccess.GetAllSecurityLevels();
            bs.ResetBindings(true);
        }
    }
}
