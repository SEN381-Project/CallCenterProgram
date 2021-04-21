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


namespace CallCenterProgram.Presentation
{
    public partial class Manager_PresantationLayer : Form
    {
        public Manager_PresantationLayer()
        {
            InitializeComponent();
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            //adding colo in the form
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);

         
        }

        public void datagridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void datagridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

       
        }

        private void UpdateEm_Click(object sender, EventArgs e)
        {
            handler.UpdateEmployee(int.Parse(txtEmployeeId.Text), txtEmployeename.Text, txtEmployeesurname.Text, txtEmployeeAddress.Text, txtContactDetails.Text, txtMjobtitle.Text, txtMjobDespription.Text);

        }

        private void DeleteEm_Click(object sender, EventArgs e)
        {
            handler.DeleteEmployee(int.Parse(txtEmployeeId.Text), txtEmployeename.Text, txtEmployeesurname.Text, txtEmployeeAddress.Text, txtContactDetails.Text, txtMjobtitle.Text, txtMjobDespription.Text);

        }

        private void UpdateDp_Click(object sender, EventArgs e)
        {
            handler.UpdatetDepartMent(int.Parse(txtidDepartment.Text), txtNameDepartment.Text, int.Parse(txtSationNo.Text));
        }

        private void DeleteDp_Click(object sender, EventArgs e)
        {
            handler.DeleteDepartment(int.Parse(txtidDepartment.Text), txtNameDepartment.Text, int.Parse(txtSationNo.Text));
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Form1 MainMenu = new Form1();
            MainMenu.Show();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Emploee_PresantationLayer Employee = new Emploee_PresantationLayer();
            Employee.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {

        }
    }
}
