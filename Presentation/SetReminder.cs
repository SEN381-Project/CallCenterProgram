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
        
        private void SetReminder_Load(object sender, EventArgs e)
        {
            dataGridVReminder.DataSource = setReminder.ViewSetReminder();

        }

        private void btnExitReminder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFollowUpReminder_Click(object sender, EventArgs e)
        {
            FollowUp_Presentation FollowUpForm = new FollowUp_Presentation();
            FollowUpForm.Show();
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            setReminder.InsertReminder(int.Parse(txtReminderId.Text), txtReminder.Text, DateTime.Parse(txtTime.Text));
        }

        private void btbUpdateR_Click(object sender, EventArgs e)
        {
            setReminder.UpdateReminder(int.Parse(txtReminderId.Text), txtReminder.Text, DateTime.Parse(txtTime.Text));
        }

        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            setReminder.RemoveReminder(int.Parse(txtReminderId.Text), txtReminder.Text, DateTime.Parse(txtTime.Text));
        }
    }
}
