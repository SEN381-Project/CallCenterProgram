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
    public partial class Technician : Form
    {
        public Technician()
        {
            InitializeComponent();
        }

        Technicians technicians = new Technicians();

        private void Employee_Click(object sender, EventArgs e)
        {
            Employee_Presentation employee = new Employee_Presentation();
            employee.Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            HomeForm MainMenu = new HomeForm();
            MainMenu.Show();
        }

        private void InsertT_Click(object sender, EventArgs e)
        {
            string abilities = txtability.Text;
            string qualification = txtq.Text;

            technicians.InsertTechnicians(txtability.Text, txtq.Text);
        }

        private void UpdateT_Click(object sender, EventArgs e)
        {
            technicians.Abilities = txtability.Text;
            technicians.Qualification = txtq.Text;

            technicians.InsertTechnicians(txtability.Text, txtq.Text);
        }

        private void DeleteT_Click(object sender, EventArgs e)
        {
            technicians.Abilities = txtability.Text;
            technicians.Qualification = txtq.Text;

            technicians.DeleteTechnicians(txtability.Text, txtq.Text);
        }

        private void Technician_Load(object sender, EventArgs e)
        {

        }
    }
}
