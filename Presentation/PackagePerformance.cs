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
        BindingSource bsBestSellers = new BindingSource();
        BindingSource bsByCity = new BindingSource();
        private void btnBackToPackage_Click(object sender, EventArgs e)
        {
            Presentation.Package package = new Package();
            this.Hide();
            package.Show();
        }

        private void PackagePerformance_Load(object sender, EventArgs e)
        {
            Bussiness_Logic.Package package = new Bussiness_Logic.Package();
            lblTotalPackages.Text =  package.PackagesInLast30Days().ToString();
            bsBestSellers.DataSource = package.BestPackageOrPackagesOfTheMonth();
            dgvBestPackageOfTheMonth.DataSource = bsBestSellers;
            lblBestNumbersSold.Text = package.MostSoldPackageQuantity().ToString();
        }

        private void btnSearchPackage_Click(object sender, EventArgs e)
        {
            int packageID = int.Parse(txtSearchPackage.Text);
            Bussiness_Logic.Package package = new Bussiness_Logic.Package();
            List<string> data = package.PackagePerfromance(packageID);
            for (int i = 0; i < data.Count; i++)
            {
                string[] saleAndCity = data[i].Split(',');
                dgvPackageByCity.Rows.Add(saleAndCity);
            }
        }
    }
}
