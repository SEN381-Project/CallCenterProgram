using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class Job : ServiceRequest
    {
        private int workerID;
        private bool jobStatus;
        private int incidentID;

        JobDataAccess jobData = new JobDataAccess();

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

        public List<Job> ViewJob()
        {
            List<Job> jobs = jobData.DisplayJob();
            return jobs;
        }

        public List<Job> ViewJob(int jobID)
        {
            List<Job> jobs = jobData.DisplayJob(jobID);
            return jobs;
        }

        public void CloseJob(int jobID)
        {
            jobData.CloseJob(jobID);
        }
    }
}