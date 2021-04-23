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
using CallCenterProgram.Data_Access;
using CallCenterProgram;

namespace CallCenterProgram.Presentation
{
    public partial class Client_Home : Form
    {
        public Client_Home()
        {
            InitializeComponent();
        }

        private void Client_Home_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);
        }

        private void btnViewBusinessClients_Click(object sender, EventArgs e)
        {
            Business_Client_Info businessform = new Business_Client_Info();
            businessform.Show();
            this.Close();
        }

        private void btnViewIndividualClients_Click(object sender, EventArgs e)
        {
            Individual_Client_Info individualform = new Individual_Client_Info();
            individualform.Show();
            this.Close();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
