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
            //btn Insert Into DB
            btnInsertIntoDB.ForeColor = RGB.accentColorLighterColor;
            btnInsertIntoDB.FlatAppearance.MouseDownBackColor = RGB.accentDarkerColor;
            //btn generate reports
            btnGenerateReports.ForeColor = RGB.accentColorLighterColor;
            btnGenerateReports.FlatAppearance.MouseDownBackColor = RGB.accentDarkerColor;
            //btn home
            btnHome.ForeColor = RGB.accentColor;
            btnHome.FlatAppearance.BorderColor = RGB.accentColorLighterColor;
            btnHome.FlatAppearance.MouseDownBackColor = RGB.accentDarkerColor;
            //btn make call
            btnMakeCall.FlatAppearance.MouseDownBackColor = RGB.green;
            btnTakeCall.FlatAppearance.MouseDownBackColor = RGB.green;
            btnEndCall.FlatAppearance.MouseDownBackColor = RGB.red;

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
            //header labels
            lblTitle.ForeColor = RGB.accentColor;
            lblReports.ForeColor = RGB.accentColor;
            lblClientInfo.ForeColor = RGB.accentColor;

            //labels
            lblFaultReport.ForeColor = RGB.grey;
            lblCallReport.ForeColor = RGB.grey;
            lblProblemInfo.ForeColor = RGB.grey;
            lblWorkRequest.ForeColor = RGB.grey;
            lblClientCallHistory.ForeColor = RGB.grey;
            lblAgreements.ForeColor = RGB.grey;

        }

        private void colorReportRichTextBoxs()
        {
            colorRichTextBox(rtbCallReport);
            colorRichTextBox(rtbFaultReport);
            colorRichTextBox(rtbProblemInfo);
            colorRichTextBox(rtbWorkRequest);
        }

        private void colorRichTextBox(RichTextBox rtb)
        {
            rtb.BackColor = RGB.bgColor;
            rtb.ForeColor = RGB.grey;
        }

        //form components
        private void call_Load(object sender, EventArgs e)
        {
            this.BackColor = RGB.bgColor;
            colorButtons();
            colorPanels();
            colorLabels();
            colorReportRichTextBoxs();
        }
    }
}
