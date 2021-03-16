using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class Incident
    {
        private string reportInfo;
        private DateTime timeIssued;
        private int priority;


        public string ReportInfo
        {
            get { return reportInfo; }
            set { reportInfo = value; }
        }

        public date TimeIssued
        {
            get { return timeIssued; }
            set { timeIssued = value; }
        }

        public int Priority
        {
            get { return priority; }
        }

        public void Incedent()
        {
        }

        public void Incident(string reportInfo, DateTime timeIssued, int priority)
        {
            reportInfo = this.reportInfo;
            timeIssued = this.timeIssued;
            priority = this.priority;
        }
    }
}