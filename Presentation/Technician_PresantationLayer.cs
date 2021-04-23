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
    public partial class Technician_PresantationLayer : Form
    {
        public Technician_PresantationLayer()
        {
            InitializeComponent();
        }

        Technicians technicians = new Technicians();

        private void Employee_Click(object sender, EventArgs e)
        {
            Emploee_PresantationLayer employee = new Emploee_PresantationLayer();
            employee.Show();
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
            technicians.InsertTechnicians(txtability.Text, txtq.Text);
        }

        private void UpdateT_Click(object sender, EventArgs e)
        {
            technicians.InsertTechnicians(txtability.Text, txtq.Text);
        }

        private void DeleteT_Click(object sender, EventArgs e)
        {
            technicians.DeleteTechnicians(txtability.Text, txtq.Text);
        }

        private void Technician_PresantationLayer_Load(object sender, EventArgs e)
        {

        }
    }
}
