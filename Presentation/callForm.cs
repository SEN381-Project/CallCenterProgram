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
    public partial class callForm : System.Windows.Forms.Form
    {
        //classes
        colors RGB = new colors();
        //constructor
        public callForm()
        {
            InitializeComponent();
        }
        //methods
        private void colorButtons()
        {
            btnInsertIntoDB.ForeColor = RGB.accentColorLighterColor;
            btnGenerateReports.ForeColor = RGB.accentColorLighterColor;
            btnHome.ForeColor = RGB.accentColor;
            btnHome.FlatAppearance.BorderColor = RGB.accentColorLighterColor;
        }

        private void colorPanels()
        {
            pnlReports.BackColor = RGB.bgLighterColor;
            pnlClientInfo.BackColor = RGB.bgLighterColor;
            pnlTitleBar.BackColor = RGB.bgColor;
            pnlRightSide.BackColor = RGB.bgColor;
        }

        private void colorLabels()
        {
            lblTitle.ForeColor = RGB.accentColor;
            lblReports.ForeColor = RGB.accentColor;
            lblClientCallHistory.ForeColor = RGB.accentColor;
        }

        //form components
        private void call_Load(object sender, EventArgs e)
        {
            this.BackColor = RGB.bgColor;
            colorButtons();
            colorPanels();
            colorLabels();
        }
    }
}
