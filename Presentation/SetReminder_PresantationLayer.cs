using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallCenterProgram.Business_Logic;

namespace CallCenterProgram.Presentation
{
    public partial class SetReminder_PresantationLayer : Form
    {
        public SetReminder_PresantationLayer()
        {
            InitializeComponent();
        }

        FollowUp Reminder = new FollowUp();

        private void SetReminder_PresantationLayer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExitReminder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFollowUpReminder_Click(object sender, EventArgs e)
        {
            FollowUp_PresantationLayer FollowUp = new FollowUp_PresantationLayer();
            FollowUp.Show();
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            Reminder.InsertReminder(int.Parse(txtReminderId.Text), TxtReminder.Text, DateTime.Parse(txtTime.Text));
        }

        private void btbUpdateR_Click(object sender, EventArgs e)
        {
            Reminder.UpdateReminder(int.Parse(txtReminderId.Text), TxtReminder.Text, DateTime.Parse(txtTime.Text));
        }

        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            Reminder.RemoveReminder(int.Parse(txtReminderId.Text), TxtReminder.Text, DateTime.Parse(txtTime.Text));
        }
    }
}
