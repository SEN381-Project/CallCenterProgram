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
using CallCenterProgram;


namespace CallCenterProgram.Presentation
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        ManagerBusiness employee = new ManagerBusiness();

        private void Insert_Click(object sender, EventArgs e)
        {
            employee.AddEmployee(int.Parse(txtiD.Text), txtName.Text, txtSurname.Text, txtAddress.Text, txtContact.Text, txtjob.Text, txtjobdescription.Text);
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            HomeForm MainMenu = new HomeForm();
            MainMenu.Show();
        }
    

        private void Techician_Click(object sender, EventArgs e)
        {
            Technician technician = new Technician();
            technician.Show();
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            Manager_Presentation Manager = new Manager_Presentation();
            Manager.Show();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InsertDepartment_Click(object sender, EventArgs e)
        {
           
            employee.AddDepartment(int.Parse(txtdepartmentid.Text), txtdepartmentname.Text, int.Parse(txtstationnumber.Text));
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
