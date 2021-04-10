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


namespace CallCenterProgram
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        Employee_DataAccess handler = new Employee_DataAccess();

        private void Form5_Load(object sender, EventArgs e)
        {
            //adding colo in the form
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);

            //connecting an showing tables in the datagridview
            string connect = "Data Sourse =.; Initial Catalog = CallCenterDatabase; Integrated Security = SSPI";

            SqlConnection Conn = new SqlConnection(connect);

            string query = @"SELECT * Employee";

            SqlDataAdapter da = new SqlDataAdapter(query, Conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            //connecting an showing tables in the datagridview
            

            query = @"SELECT * Department";

            SqlDataAdapter da1 = new SqlDataAdapter(query, Conn);

            DataTable dt1 = new DataTable();

            da1.Fill(dt1);

            dataGridView2.DataSource = dt1;
        }

        public void datagridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                txtEmployeeId.Text= dataGridView1.Rows[e.RowIndex].Cells["EmployeeId"].FormattedValue.ToString();
                txtEmployeename.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtEmployeesurname.Text = dataGridView1.Rows[e.RowIndex].Cells["Surname"].FormattedValue.ToString();
                txtEmployeeAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                txtContactDetails.Text = dataGridView1.Rows[e.RowIndex].Cells["ContactDetails"].FormattedValue.ToString();
                txtMjobtitle.Text = dataGridView1.Rows[e.RowIndex].Cells["JobTitle"].FormattedValue.ToString();
                txtMjobDespription.Text = dataGridView1.Rows[e.RowIndex].Cells["JobDescription"].FormattedValue.ToString();
            }
        }

    public void datagridView2_CellClick(object sender, DataGridViewCellEventArgs e)
    {

        if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        {
            dataGridView2.CurrentRow.Selected = true;

            txtidDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells["DepartmentId"].FormattedValue.ToString();
            txtNameDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells["DepartmentName"].FormattedValue.ToString();
            txtSationNo.Text = dataGridView1.Rows[e.RowIndex].Cells["StationNumber"].FormattedValue.ToString();
          
        }
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
            Form2 Employee = new Form2();
            Employee.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
