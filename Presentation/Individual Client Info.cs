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
    public partial class Individual_Client_Info : Form
    {
        public Individual_Client_Info()
        {
            InitializeComponent();
        }

        private void Individual_Client_Info_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);
        }
    }
}
