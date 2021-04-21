using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenterProgram
{
    public partial class SetReminder_PresantationLayer : Form
    {
        public SetReminder_PresantationLayer()
        {
            InitializeComponent();
        }

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

    }
}
