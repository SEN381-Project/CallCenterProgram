using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenterProgram.Presentation
{
    public partial class Insert_Business_Client : Form
    {
        public Insert_Business_Client()
        {
            InitializeComponent();
        }

        private void txtBack_Click(object sender, EventArgs e)
        {
            Client_Home client = new Client_Home();
            client.Show();
            this.Hide();
        }
    }
}
