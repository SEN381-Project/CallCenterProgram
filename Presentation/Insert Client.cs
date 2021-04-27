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
    public partial class Insert_Client : Form
    {
        public Insert_Client()
        {
            InitializeComponent();
        }

        private void Insert_Client_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);
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

            int currentclient = lstCurrentClient.SelectedIndex;
            if (currentclient == 0)
            {
                currentclient = 1;
            }
            else
            {
                currentclient = 0;
            }

            int streetnumber = Convert.ToInt32(nudStreetNumber.Value);
            string streetname = txtStreetName.Text;
            string city = txtCity.Text;
            string country = lstCountries.SelectedItem.ToString();
            

            IndividualClient client = new IndividualClient(id, name, surname, email, cellphone, status, currentclient, streetnumber, streetname, city, country);
            client.SendClientToDataAccess(client);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBack_Click(object sender, EventArgs e)
        {
            Client_Home home = new Client_Home();
            home.Show();
            this.Close();
        }
    }
}
