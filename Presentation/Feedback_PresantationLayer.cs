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
    public partial class Feedback_PresantationLayer : Form
    {   
        public Feedback_PresantationLayer()
        {
            InitializeComponent();
        }

        FollowUp feedback = new FollowUp();

        public void datagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (datagridVFeedback.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                datagridVFeedback.CurrentRow.Selected = true;

                txtfeedbackid.Text = datagridVFeedback.Rows[e.RowIndex].Cells["FeedbackId"].FormattedValue.ToString();
                txtproblem.Text = datagridVFeedback.Rows[e.RowIndex].Cells["Problem"].FormattedValue.ToString();
                txthelpedontime.Text = datagridVFeedback.Rows[e.RowIndex].Cells["HelpedOnTime"].FormattedValue.ToString();
                txtfeedbackD.Text = datagridVFeedback.Rows[e.RowIndex].Cells["FollowUpDate"].FormattedValue.ToString();
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            HomeForm MainMenu = new HomeForm();
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
            feedback.AddFeedback(int.Parse(txtfeedbackid.Text),txtproblem.Text, bool.Parse(txthelpedontime.Text), txtcomment.Text, DateTime.Parse(txtfeedbackD.Text));
        }

        private void Feedback_PresantationLayer_Load(object sender, EventArgs e)
        {
            feedback.ViewFeedback();
        }
    }
}
