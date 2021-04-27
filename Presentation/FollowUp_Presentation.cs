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
using CallCenterProgram.Data_Access;
using CallCenterProgram;


namespace CallCenterProgram.Presentation
{
    public partial class FollowUp_Presentation : Form
    {
        public FollowUp_Presentation()
        {
            InitializeComponent();
           
        }

        FollowUpBusiness followUp = new FollowUpBusiness();
        FollowUp Set = new FollowUp();
        

        public void datagridView_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (dataGridVFollowUp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridVFollowUp.CurrentRow.Selected = true;

                txtfollowupid.Text = dataGridVFollowUp.Rows[e.RowIndex].Cells["FollowUpId"].FormattedValue.ToString();
                txtstatus.Text = dataGridVFollowUp.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                txtfollupD.Text = dataGridVFollowUp.Rows[e.RowIndex].Cells["FolloUpDate"].FormattedValue.ToString();
            }
        }
   
        private void MainMenu_Click(object sender, EventArgs e)
        {
            HomeForm MainMenu = new HomeForm();
            MainMenu.Show();
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            Feedback Feedback = new Feedback();
            Feedback.Show();
            this.Close();
        }

        private void Exits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Set.FollowUpId = Convert.ToInt32(txtfollowupid.Text);
            Set.Status = txtstatus.Text;
            Set.FollowUpDate = DateTime.Parse(txtfollupD.Text);

            followUp.AddFollowUp(int.Parse(txtfollowupid.Text), txtstatus.Text, DateTime.Parse(txtfollupD.Text));
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Set.FollowUpId = Convert.ToInt32(txtfollowupid.Text);
            Set.Status = txtstatus.Text;
            Set.FollowUpDate = DateTime.Parse(txtfollupD.Text);

            followUp.UpdateFollowUp(int.Parse(txtfollowupid.Text), txtstatus.Text, DateTime.Parse(txtfollupD.Text));
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Set.FollowUpId = Convert.ToInt32(txtfollowupid.Text);
            Set.Status = txtstatus.Text;
            Set.FollowUpDate = DateTime.Parse(txtfollupD.Text);

            followUp.RemoveFollowUp(int.Parse(txtfollowupid.Text), txtstatus.Text, DateTime.Parse(txtfollupD.Text));
        }

        private void FollowUp_Load(object sender, EventArgs e)
        {
            dataGridVFollowUp.DataSource = followUp.ViewFollowUps();

        }

        private void btnSetReminder_Click(object sender, EventArgs e)
        {
            SetReminder reminder = new SetReminder();
            reminder.Show();
            this.Close();
        }
    }
}
