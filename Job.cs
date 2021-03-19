using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class Job
    {
        private int workerID;
        private bool jobStatus;
        private int incidentID;


        public int JobRef
        {
            get { return workerID; }
            set { workerID = value; }
        }

        public bool JobStatus
        {
            get { return jobStatus; }
            set { jobStatus = value; }
        }

        public string[] IncedentID
        {
            get { return incidentID; }
        }

        public void Job()
        {
        }

        public void Job(int workerID, bool jobStatus, int incidentID)
        {
            this.workerID = workerID;
            this.jobStatus = jobStatus;
            this.incidentID = incidentID;
        }

        public void CheckRequirements()
        {
        }
    }
}