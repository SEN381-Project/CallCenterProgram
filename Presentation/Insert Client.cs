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
using System.Runtime.InteropServices;

namespace CallCenterProgram.Presentation
{
    public partial class Insert_Client : Form
    {

        bool Maximized = false;

        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Insert_Client()
        {
            InitializeComponent();
            Maximized = false;
            CreateMyBorderlessWindow();
        }

        public void CreateMyBorderlessWindow()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area.
            this.ControlBox = false;
        }

        private void Insert_Client_Load(object sender, EventArgs e)
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
            lstCurrentClient.ClearSelected();
            rtbStatus.Clear();
            nudID.Focus();
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

            Individual_Client_Info clientform= new Individual_Client_Info();
            clientform.Show();
            this.Close();
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

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (Maximized == false)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMax.Text = "Normal";
                Maximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMax.Text = "Maximize";
                Maximized = false;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Insert_Client_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
