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
    class Job
    {
        private int workerID;
        private bool jobStatus;
        private int incidentID;

        public int WorkerID
        {
            get { return workerID; }
            set { workerID = value; }
        }

        public bool JobStatus
        {
            get { return jobStatus; }
            set { jobStatus = value; }
        }

        public int IncedentID
        {
            get { return incidentID; }
            set { incidentID = value; }
        }

        public Job()
        {
        }

        public Job(int workerID, bool jobStatus, int incidentID)
        {
            this.workerID = workerID;
            this.jobStatus = jobStatus;
            this.incidentID = incidentID;
        }
    }
}