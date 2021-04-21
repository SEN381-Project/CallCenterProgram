using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram.Business_Logic
{
    class Manager : Employee
    {

       
        public void FireEmployee()
        {

        }

        public void ShowStats()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Display()
        {
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


            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                txtEmployeeId.Text = dataGridView1.Rows[e.RowIndex].Cells["EmployeeId"].FormattedValue.ToString();
                txtEmployeename.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtEmployeesurname.Text = dataGridView1.Rows[e.RowIndex].Cells["Surname"].FormattedValue.ToString();
                txtEmployeeAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                txtContactDetails.Text = dataGridView1.Rows[e.RowIndex].Cells["ContactDetails"].FormattedValue.ToString();
                txtMjobtitle.Text = dataGridView1.Rows[e.RowIndex].Cells["JobTitle"].FormattedValue.ToString();
                txtMjobDespription.Text = dataGridView1.Rows[e.RowIndex].Cells["JobDescription"].FormattedValue.ToString();
            }

            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;

                txtidDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells["DepartmentId"].FormattedValue.ToString();
                txtNameDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells["DepartmentName"].FormattedValue.ToString();
                txtSationNo.Text = dataGridView1.Rows[e.RowIndex].Cells["StationNumber"].FormattedValue.ToString();

            }
        }

    }
}
