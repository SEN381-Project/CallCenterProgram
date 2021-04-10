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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
           
        }
        FollowUp_DataAccess handler = new FollowUp_DataAccess();

        private void Form4_Load(object sender, EventArgs e)
        {
            string connect = "Data Sourse =.; Initial Catalog = CallCenterDatabase; Integrated Security = SSPI";

            SqlConnection Conn = new SqlConnection(connect);

            string query = @"SELECT * FollowUp";

            SqlDataAdapter da = new SqlDataAdapter(query, Conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }
        public void datagridView_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                txtfollowupid.Text = dataGridView1.Rows[e.RowIndex].Cells["FollowUpId"].FormattedValue.ToString();
                txtstatus.Text = dataGridView1.Rows[e.RowIndex].Cells["FollowUpId"].FormattedValue.ToString();
                txtfollupD.Text = dataGridView1.Rows[e.RowIndex].Cells["FollowUpId"].FormattedValue.ToString();
            }
        }
   
        private void MainMenu_Click(object sender, EventArgs e)
        {
            Form1 MainMenu = new Form1();
            MainMenu.Show();
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            Feedback Feedback = new Feedback();
            Feedback.Show();

        }

        private void Exits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            handler.InsertFollowUp(int.Parse(txtfollowupid.Text), txtstatus.Text, txtfollupD.Text);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            handler.UpdateFollowUp(int.Parse(txtfollowupid.Text), txtstatus.Text, txtfollupD.Text);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            handler.DeleteFollowUp(int.Parse(txtfollowupid.Text), txtstatus.Text, txtfollupD.Text);
        }

    }
}
