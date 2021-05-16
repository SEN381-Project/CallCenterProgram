using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CallCenterProgram.Presentation;

namespace CallCenterProgram
{
    public partial class Client_Satisfaction : Form
    {
        bool Maximized = false;

        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Client_Satisfaction()
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

        private void btnMaximizeToggle_Click(object sender, EventArgs e)
        {
            if (Maximized == false)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizeToggle.Text = "Normal";
                Maximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximizeToggle.Text = "Maximize";
                Maximized = false;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void showForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void btnFollowUpCS_Click(object sender, EventArgs e)
        {
            FollowUp_Presentation form = new FollowUp_Presentation();
            showForm(form);
        }

        private void btnFeedbackCS_Click(object sender, EventArgs e)
        {
            Feedback form = new Feedback();
            showForm(form);
        }

        private void btnSetReminderCS_Click(object sender, EventArgs e)
        {
            SetReminder form = new SetReminder();
            showForm(form);
        }

        private void btnHomePageCS_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            showForm(form);
        }
    }
}
