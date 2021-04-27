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



namespace CallCenterProgram.Presentation
{
    public partial class SetReminder : Form
    {
        public SetReminder()
        {
            InitializeComponent();
        }

        FollowUpBusiness setReminder = new FollowUpBusiness();
        FollowUp Set = new FollowUp();
        
        private void SetReminder_Load(object sender, EventArgs e)
        {
            dataGridVReminder.DataSource = setReminder.ViewSetReminder();
            if (Set.ReminderDate == DateTime.Now)
            {
                MessageBox.Show("Reminder For: " +Set.Reminder);
            }
        }

        private void btnExitReminder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFollowUpReminder_Click(object sender, EventArgs e)
        {
            FollowUp_Presentation FollowUpForm = new FollowUp_Presentation();
            FollowUpForm.Show();
            this.Close();
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            Set.ReminderId = Convert.ToInt32(txtReminderId.Text);
            Set.Reminder = txtReminder.Text;
            Set.ReminderDate = DateTime.Parse(txtTime.Text);

            setReminder.InsertReminder(int.Parse(txtReminderId.Text), txtReminder.Text, DateTime.Parse(txtTime.Text));
        }

        private void btbUpdateR_Click(object sender, EventArgs e)
        {
            Set.ReminderId = Convert.ToInt32(txtReminderId.Text);
            Set.Reminder = txtReminder.Text;
            Set.ReminderDate = DateTime.Parse(txtTime.Text);

            setReminder.UpdateReminder(int.Parse(txtReminderId.Text), txtReminder.Text, DateTime.Parse(txtTime.Text));
        }

        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            Set.ReminderId = Convert.ToInt32(txtReminderId.Text);
            Set.Reminder = txtReminder.Text;
            Set.ReminderDate = DateTime.Parse(txtTime.Text);

            setReminder.RemoveReminder(int.Parse(txtReminderId.Text), txtReminder.Text, DateTime.Parse(txtTime.Text));
        }
    }
}
