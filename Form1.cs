using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallCenterProgram.Presentation;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Bussiness_Logic;

namespace CallCenterProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTesting_Click(object sender, EventArgs e)
        {
            callForm callForm = new callForm();
            this.Hide();
            callForm.Show();
        }

        private void btnClientHome_Click(object sender, EventArgs e)
        {
            Client_Home clienthomeform = new Client_Home();
            clienthomeform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
