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
using System.Runtime.InteropServices;


namespace CallCenterProgram.Presentation
{
    public partial class Feedback : Form
    {
        bool Maximized = false;
        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Feedback()
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

        FollowUpBusiness feedback = new FollowUpBusiness();
        FollowUp Set = new FollowUp();
        
        public void datagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridVFeedback.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridVFeedback.CurrentRow.Selected = true;

                txtfeedbackid.Text = dataGridVFeedback.Rows[e.RowIndex].Cells["FeedbackId"].FormattedValue.ToString();
                txtproblem.Text = dataGridVFeedback.Rows[e.RowIndex].Cells["Problem"].FormattedValue.ToString();
                if (dataGridVFeedback.CurrentRow.Cells["FeedbackDate"].Value.ToString().Length > 0)
                    dtpFeebback.Value = Convert.ToDateTime(dataGridVFeedback.CurrentRow.Cells["FeedbackDate"].Value.ToString());
            }
        }

        private void showForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Client_Satisfaction form = new Client_Satisfaction();
            showForm(form);
        }

        private void Insert_Click(object sender, EventArgs e)
        {
             Set.FeedbackId = Convert.ToInt32(txtfeedbackid.Text);
             Set.Problem = txtproblem.Text;
            
            if (checkBox1.CheckState == CheckState.Checked )
            {
                Set.HelpedOnTime = true;
            }
            else
            {
                Set.HelpedOnTime = false;
            }
             Set.Comment = txtcomment.Text;
             Set.FeedbackDate = dtpFeebback.Value;

            feedback.AddFeedback(Set.FeedbackId, Set.Problem, Set.HelpedOnTime, Set.Comment, Set.FeedbackDate);
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = feedback.ViewFeedback();
            dataGridVFeedback.DataSource = source;
             
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void ClearData()
        {
            txtfeedbackid.Clear();
            txtproblem.Clear(); 
            //txthelpedontime.Clear(); 
            txtcomment.Clear();
            

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
