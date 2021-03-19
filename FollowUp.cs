using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class FollowUp : Call
    {

        private string status;
        private DateTime followUpDate;
        private string problem;
        private bool helpedOnTime;
        private string comment;

        public string Status { get => status; set => status = value; }
        public DateTime FollowUpDate { get => followUpDate; set => followUpDate = value; }
        public string Problem { get => problem; set => problem = value; }
        public bool HelpedOnTime { get => helpedOnTime; set => helpedOnTime = value; }
        public string Comment { get => comment; set => comment = value; }


        public FollowUp(string status, DateTime followUpDate, string problem, bool helpedOnTime, string comment)
        {
            this.Status = status;
            this.FollowUpDate = followUpDate;
            this.Problem = problem;
            this.HelpedOnTime = helpedOnTime;
            this.Comment = comment;
        }

        public void SetReminder()
        {


        }

    }
}
