using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CallCenterProgram.Bussiness_Logic;
using CallCenterProgram.Data_Access;
using CallCenterProgram;

namespace CallCenterProgram.Presentation
{
    public partial class Manager_Presentation : Form
    {
        public Manager_Presentation()
        {
            InitializeComponent();
        }

        ManagerBusiness manager = new ManagerBusiness();
        Employee Set = new Manager();
        Authorization authorize = new Authorization();
        public void datagridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridVEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridVEmployee.CurrentRow.Selected = true;

                txtEmployeeId.Text= dataGridVEmployee.Rows[e.RowIndex].Cells["EmployeeId"].FormattedValue.ToString();
                txtEmployeename.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtEmployeesurname.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["Surname"].FormattedValue.ToString();
                txtEmployeeAddress.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                txtContactDetails.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["ContactDetails"].FormattedValue.ToString();
                txtMjobtitle.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["JobTitle"].FormattedValue.ToString();
                txtMjobDespription.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["JobDescription"].FormattedValue.ToString();
                txtidDepartment.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["DepartmentId"].FormattedValue.ToString();
                txtNameDepartment.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["DepartmentName"].FormattedValue.ToString();
                txtSationNo.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["StationNumber"].FormattedValue.ToString();
            }
        }


        private void UpdateEm_Click(object sender, EventArgs e)
        {
            
            Set.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
            Set.Name = txtEmployeename.Text;
            Set.Surname = txtEmployeesurname.Text;
            Set.Address = txtEmployeeAddress.Text;
            Set.ContactDetails = txtContactDetails.Text;
            Set.Jobtitle = txtMjobtitle.Text;
            Set.JobDescription = txtMjobDespription.Text;

            
            authorize.Show();

            if(manager.Authorize == "M145628")
            {
                manager.UpdateEmployeeInf(int.Parse(txtEmployeeId.Text), txtEmployeename.Text, txtEmployeesurname.Text, txtEmployeeAddress.Text, txtContactDetails.Text, txtMjobtitle.Text, txtMjobDespription.Text);
            }
            else
            {
                MessageBox.Show("Invalid Pin!!");
            }
            

        }

        private void DeleteEm_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(txtEmployeeId.Text);
            string name = txtEmployeename.Text;
            string surname = txtEmployeesurname.Text;
            string address = txtEmployeeAddress.Text;
            string contactDetails = txtContactDetails.Text;
            string jobTitle = txtMjobtitle.Text;
            string jobDescription = txtMjobDespription.Text;

            manager.FireEmployee(int.Parse(txtEmployeeId.Text), txtEmployeename.Text, txtEmployeesurname.Text, txtEmployeeAddress.Text, txtContactDetails.Text, txtMjobtitle.Text, txtMjobDespription.Text);

        }

        private void UpdateDp_Click(object sender, EventArgs e)
        {
            int departmentId = Convert.ToInt32(txtidDepartment.Text);
            string derptmentName = txtNameDepartment.Text;
            int stationNumber = Convert.ToInt32(txtSationNo.Text);

            manager.UpdateDepartment(int.Parse(txtidDepartment.Text), txtNameDepartment.Text, int.Parse(txtSationNo.Text));
        }

        private void DeleteDp_Click(object sender, EventArgs e)
        {
            Set.DepartmentId = Convert.ToInt32(txtidDepartment.Text);
            Set.DepartmentName = txtNameDepartment.Text;
            Set.StationNumber = Convert.ToInt32(txtSationNo.Text);

            manager.RemoveDepartment(int.Parse(txtidDepartment.Text), txtNameDepartment.Text, int.Parse(txtSationNo.Text));
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            HomeForm.instance.Show();
            this.Close();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Employee_Presentation EmployeeForm = new Employee_Presentation();
            EmployeeForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            dataGridVEmployee.DataSource = manager.ViewEmployee();

        }
    }
}
