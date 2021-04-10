using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenterProgram
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Employee_DataAccess handler = new Employee_DataAccess();

        private void Employee_Click(object sender, EventArgs e)
        {
            Form2 employee = new Form2();
            employee.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Form1 MainMenu = new Form1();
            MainMenu.Show();
        }

        private void InsertT_Click(object sender, EventArgs e)
        {
            handler.InsertTechnicians(txtability.Text, txtq.Text);
        }

        private void UpdateT_Click(object sender, EventArgs e)
        {
            handler.InsertTechnicians(txtability.Text, txtq.Text);
        }

        private void DeleteT_Click(object sender, EventArgs e)
        {
            handler.DeleteTechnicians(txtability.Text, txtq.Text);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //adding colo in the form
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);
        }
    }
}
