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



namespace CallCenterProgram.Presentation
{
    public partial class Employee_Presentation : Form
    {
        //fields
        bool Maximized = false;
        public Employee_Presentation()
        {
            InitializeComponent();
            Maximized = false;
        }

        ManagerBusiness employee = new ManagerBusiness();
        Employee Set = new Manager();
        
        private void Insert_Click(object sender, EventArgs e)
        {
            Set.EmployeeId = Convert.ToInt32(txtiD.Text);
            Set.Name = txtName.Text;
            Set.Surname = txtSurname.Text;
            Set.Address = txtAddress.Text;
            Set.ContactDetails = txtContact.Text;
            Set.Jobtitle = txtjob.Text;
            Set.JobDescription = txtjobdescription.Text;

            employee.AddEmployee(int.Parse(txtiD.Text), txtName.Text, txtSurname.Text, txtAddress.Text, txtContact.Text, txtjob.Text, txtjobdescription.Text);
        }

        private void showForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Employee_Information form = new Employee_Information();
            showForm(form);
        }

        private void InsertDepartment_Click(object sender, EventArgs e)
        {
            Set.DepartmentId = Convert.ToInt32(txtdepartmentid.Text);
            Set.DepartmentName = txtdepartmentname.Text;
            Set.StationNumber = Convert.ToInt32(txtstationnumber.Text);

            employee.AddDepartment(int.Parse(txtdepartmentid.Text), txtdepartmentname.Text, int.Parse(txtstationnumber.Text));
        }

        private void Employee_Load(object sender, EventArgs e)
        {
        }

        private void btnMaximizeToggle_Click(object sender, EventArgs e)
        {
            if (Maximized == false)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizeToggle.Text = "Normal";
                Maximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximizeToggle.Text = "Maximize";
                Maximized = false;
            }
        }
        public void ClearEmployeeData()
        {
            txtiD.Clear(); 
            txtName.Clear(); 
            txtSurname.Clear(); 
            txtAddress.Clear();
            txtContact.Clear();
            txtjob.Clear();
            txtjobdescription.Clear();

        }
        private void btnClearEmp_Click(object sender, EventArgs e)
        {
            ClearEmployeeData();
        }

        public void ClearDepartmentData()
        {
            txtdepartmentid.Clear();
            txtdepartmentname.Clear();
            txtstationnumber.Clear();
        }

        private void btnClearDp_Click(object sender, EventArgs e)
        {
            ClearDepartmentData();
        }
    }
}
