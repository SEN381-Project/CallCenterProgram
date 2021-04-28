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
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
        }
        BindingSource bsPackages = new BindingSource();
        BindingSource bsContracts = new BindingSource();
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();


        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.Show();
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            int packageId = int.Parse(txtPackageID.Text);
            int clientID = int.Parse(txtClientID.Text);
            int state = cmbAdd.Text == "Active" ? 1 : 0;
            Bussiness_Logic.Contract contract = new Bussiness_Logic.Contract();
            contract.CreateContract(packageId,clientID,state);  
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchID = int.Parse(txtSearchContract.Text);
            Bussiness_Logic.Contract contract = new Bussiness_Logic.Contract();
            bsContracts.DataSource = contract.SearchContract(searchID);
            dgvClientContract.DataSource = bsContracts;
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            bsPackages.DataSource = dataAccess.GetAllPackages();
            dgvPackages.DataSource = bsPackages;
        }

        private void btnUpdateContract_Click(object sender, EventArgs e)
        {
            int contractID = int.Parse(txtContractID.Text);
            int state = cmbUpdate.Text == "Active" ? 1 : 0;
            Bussiness_Logic.Contract contract = new Bussiness_Logic.Contract();
            contract.UpdateContract(contractID, state);
            int searchID = int.Parse(txtSearchContract.Text);
            bsContracts.DataSource = contract.SearchContract(searchID);
            bsContracts.ResetBindings(true);
        }

        private void dgvClientContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtContractID.Text = dgvClientContract.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                cmbUpdate.Text = dgvClientContract.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "True" ? "Active" : "Not-Active";

            }
        }
    }
}
