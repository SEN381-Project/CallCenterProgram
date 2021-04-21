using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;
using CallCenterProgram;

namespace CallCenterProgram.Bussiness_Logic
{
    class FollowUp : Call
    {
            private int followUpId;
            private int feedbackId;
            private string status;
            private DateTime followUpDate;
            private string problem;
            private string helpedOnTime;
            private string comment;
            private DateTime feedbackDate;

            public int FollowupId { get => followUpId; set => followUpId = value; }
            public int FeedbackId { get => feedbackId; set => feedbackId = value; }
            public string Status { get => status; set => status = value; }
            public DateTime FollowUpDate { get => followUpDate; set => followUpDate = value; }
            public string Problem { get => problem; set => problem = value; }
            public string HelpedOnTime { get => helpedOnTime; set => helpedOnTime = value; }
            public string Comment { get => comment; set => comment = value; }
            public DateTime FeedbackDate { get => feedbackDate; set => feedbackDate = value; }
           

        public FollowUp()
            {
                
            }

        

        public FollowUp(int feedbackId, string problem, string helpedOnTime, string comment)
        {
            this.feedbackId = feedbackId;
            this.problem = problem;
            this.helpedOnTime = helpedOnTime;
            this.comment = comment;
        }

        public FollowUp(int followupId, string status, DateTime followUpDate)
        {
            followUpId = followupId;
            this.status = status;
            this.followUpDate = followUpDate;
        }

        public void SetReminder()
            {


            }
     }
}
