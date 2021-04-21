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
    public partial class Feedback_PresantationLayer : Form
    {   
        public Feedback_PresantationLayer()
        {
            InitializeComponent();
        }
        FollowUp_DataAccess handler = new FollowUp_DataAccess();
        private void Form5_Load(object sender, EventArgs e)
        {
            //adding colo in the form
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);

            //connecting an showing tables in the datagridview
            string connect = "Data Sourse =.; Initial Catalog = CallCenterDatabase; Integrated Security = SSPI";

            SqlConnection Conn = new SqlConnection(connect);

            string query = @"SELECT * Feedback";

            SqlDataAdapter da = new SqlDataAdapter(query, Conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        public void datagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                txtfeedbackid.Text = dataGridView1.Rows[e.RowIndex].Cells["FeedbackId"].FormattedValue.ToString();
                txtproblem.Text = dataGridView1.Rows[e.RowIndex].Cells["Problem"].FormattedValue.ToString();
                txthelpedontime.Text = dataGridView1.Rows[e.RowIndex].Cells["HelpedOnTime"].FormattedValue.ToString();
                txtfeedbackD.Text = dataGridView1.Rows[e.RowIndex].Cells["FollowUpDate"].FormattedValue.ToString();
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Form1 MainMenu = new Form1();
            MainMenu.Show();
        }
    

        private void FollowUp_Click(object sender, EventArgs e)
        {
            FollowUp_PresantationLayer FollowUp= new FollowUp_PresantationLayer();
            FollowUp.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            handler.InsertFeedback(int.Parse(txtfeedbackid.Text), txtproblem.Text, bool.Parse(txthelpedontime.Text), txtcomment.Text, DateTime.Parse(txtfeedbackD.Text));
        }

       
    }
}
