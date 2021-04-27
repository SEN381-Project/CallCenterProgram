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
    public partial class Feedback : Form
    {   
        public Feedback()
        {
            InitializeComponent();
        }
        FollowUpBusiness feedback = new FollowUpBusiness();
        FollowUp Set = new FollowUp();
        
        public void datagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridVFeedback.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridVFeedback.CurrentRow.Selected = true;

                txtfeedbackid.Text = dataGridVFeedback.Rows[e.RowIndex].Cells["FeedbackId"].FormattedValue.ToString();
                txtproblem.Text = dataGridVFeedback.Rows[e.RowIndex].Cells["Problem"].FormattedValue.ToString();
                txthelpedontime.Text = dataGridVFeedback.Rows[e.RowIndex].Cells["HelpedOnTime"].FormattedValue.ToString();
                txtfeedbackD.Text = dataGridVFeedback.Rows[e.RowIndex].Cells["FollowUpDate"].FormattedValue.ToString();
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            HomeForm.instance.Show();
            this.Close();
        }
    

        private void FollowUp_Click(object sender, EventArgs e)
        {
            FollowUp_Presentation FollowUp= new FollowUp_Presentation();
            FollowUp.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
             Set.FeedbackId = Convert.ToInt32(txtfeedbackid.Text);
             Set.Problem = txtproblem.Text;
             Set.HelpedOnTime = bool.Parse(txthelpedontime.Text);
             Set.Comment = txtcomment.Text;
             Set.FeedbackDate = DateTime.Parse(txtfeedbackD.Text);

            feedback.AddFeedback(int.Parse(txtfeedbackid.Text), txtproblem.Text, bool.Parse(txthelpedontime.Text), txtcomment.Text, DateTime.Parse(txtfeedbackD.Text));
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            dataGridVFeedback.DataSource = feedback.ViewFeedback();
        }
    }
}
