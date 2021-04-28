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
    public partial class PackagePerformance : Form
    {
        public PackagePerformance()
        {
            InitializeComponent();
        }

        private void btnBackToPackage_Click(object sender, EventArgs e)
        {
            Presentation.Package package = new Package();
            this.Hide();
            package.Show();
        }
    }
}
