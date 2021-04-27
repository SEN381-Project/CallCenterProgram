using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Bussiness_Logic;
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

        private void btnInsertClient_Click(object sender, EventArgs e)
        {
            //assign values to variables

            int id = Convert.ToInt32(nudID.Value);
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string cellphone = txtCellphone.Text;
            string status = rtbStatus.Text;
            string role = txtRole.Text;
            int streetnumber = Convert.ToInt32(nudStreetNumber.Value);
            string streetname = txtStreetName.Text;
            string city = txtCity.Text;
            string country = lstCountries.SelectedItem.ToString();

            BusinessClient client = new BusinessClient(id, name, surname, email, cellphone, status, role, streetnumber, streetname, city, country);
            client.SendClientToDataAccess(client);

            Business_Client_Info client_Info = new Business_Client_Info();
            client_Info.Show();
            this.Close();
        }

        private void Insert_Business_Client_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);

            nudID.Value = 0;
            nudStreetNumber.Value = 0;
            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtCellphone.Clear();
            txtStreetName.Clear();
            txtCity.Clear();
            lstCountries.ClearSelected();
            rtbStatus.Clear();
            txtRole.Clear();
            nudID.Focus();
        }
    }
}
