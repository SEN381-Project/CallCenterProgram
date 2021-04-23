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
    public partial class Emploee_PresantationLayer : Form
    {
        public Emploee_PresantationLayer()
        {
            InitializeComponent();
        }

        Manager employee = new Manager();

        private void Insert_Click(object sender, EventArgs e)
        {
            employee.InsertEnployee(int.Parse(txtiD.Text), txtName.Text, txtSurname.Text, txtAddress.Text, txtContact.Text, txtjob.Text, txtjobdescription.Text);
           
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            HomeForm MainMenu = new HomeForm();
            MainMenu.Show();
        }
    

        private void Techician_Click(object sender, EventArgs e)
        {
            Technician_PresantationLayer technician = new Technician_PresantationLayer();
            technician.Show();
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            Manager_PresantationLayer Manager = new Manager_PresantationLayer();
            Manager.Show();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InsertDepartment_Click(object sender, EventArgs e)
        {
            employee.InsertDepartment(int.Parse(txtdepartmentid.Text), txtdepartmentname.Text, int.Parse(txtstationnumber.Text));
        }

        private void Emploee_PresantationLayer_Load(object sender, EventArgs e)
        {

        }
    }
}
