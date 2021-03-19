using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class FollowUp
    {

        private string status;
        private DateTime followUpDate;
        private string problem;
        private bool helpedOnTime;
        private string comment;

        public string Status
        {
            get { return status; }
            set { status = value}
        }


        public bool FollowUpDate
        {
            get { return followUpDate; }
            set { status = followUpDate}
        }

        public string Problem
        {
            get { return problem; }
            set { problem = value}
        }


        public bool HelpedOnTime
        {
            get { return helpedOnTime; }
            set { status = helpedOnTime}
        }

        public string Comment
        {
            get { return coment; }
            set { comment = value}
        }

        public vois  FollowUp(string status, DateTime followUpDate, string problem, bool helpedOnTime, string comment)
        {
            this.status = status;
            this.followUpDate = followUpDate;
            this.problem = problem;
            this.helpedOnTime = helpedOnTime;
            this.comment = comment;
        }

        public void SetReminder()
        {


        }

    }
}
