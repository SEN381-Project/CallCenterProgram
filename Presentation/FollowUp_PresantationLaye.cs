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
using CallCenterProgram.Bussiness_Logic;



namespace CallCenterProgram.Presentation
{
    public partial class FollowUp_PresantationLayer : Form
    {
        public FollowUp_PresantationLayer()
        {
            InitializeComponent();
           
        }

        FollowUp followUp = new FollowUp();
        public void datagridView_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                txtfollowupid.Text = dataGridView1.Rows[e.RowIndex].Cells["FollowUpId"].FormattedValue.ToString();
                txtstatus.Text = dataGridView1.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                txtfollupD.Text = dataGridView1.Rows[e.RowIndex].Cells["FolloUpDate"].FormattedValue.ToString();
            }
        }
   
        private void MainMenu_Click(object sender, EventArgs e)
        {
            HomeForm MainMenu = new HomeForm();
            MainMenu.Show();
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            Feedback_PresantationLayer Feedback = new Feedback_PresantationLayer();
            Feedback.Show();

        }

        private void Exits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            followUp.AddFollowUp(int.Parse(txtfollowupid.Text), txtstatus.Text, DateTime.Parse(txtfollupD.Text));
        }

        private void Update_Click(object sender, EventArgs e)
        {
            followUp.UpdateFollowUp(int.Parse(txtfollowupid.Text), txtstatus.Text, DateTime.Parse(txtfollupD.Text));
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            followUp.RemoveFollowUp(int.Parse(txtfollowupid.Text), txtstatus.Text, DateTime.Parse(txtfollupD.Text));
        }

        private void btnSetReminder_Click(object sender, EventArgs e)
        {
            SetReminder_PresantationLayer Reminder = new SetReminder_PresantationLayer();
            Reminder.Show();
        }

        private void FollowUp_PresantationLayer_Load(object sender, EventArgs e)
        {
            followUp.ViewFollowUps();
        }
    }
}
