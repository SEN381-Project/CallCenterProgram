using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class ServiceRequest : Incident
    {
        IncidentDataAccess incidentData = new IncidentDataAccess();
        JobDataAccess jobData = new JobDataAccess();

        public void CreateServiceRequest(string reportInfo, DateTime timeIssued, int priority, decimal cost, string[] abilityReq, int clientID, int callEmplpoyeeID)
        {
            incidentData.InsertWorkRequest(reportInfo, timeIssued, priority, cost, abilityReq, clientID, callEmplpoyeeID);
        }

        public void UpdateServiceRequest(int incidentID, string reportInfo, DateTime timeIssued, int priority, decimal cost, string[] abilityReq)
        {
            incidentData.UpdateWorkRequest(incidentID, reportInfo, timeIssued, priority, cost, abilityReq);
        }

        public List<Incident> ViewRequest()
        {
            List<Incident> incidents = incidentData.DisplayIncident();
            return incidents;
        }

        public List<Incident> ViewRequest(int incidentID)
        {
            List<Incident> incidents = incidentData.DisplayIncident(incidentID);
            return incidents;
        }

        public void AssignJob(int incidentID)
        {
            jobData.InsertJob(0, incidentID, getAvailableWorkers());
        }

        public void ReassignJob(int jobID, int incidentID)
        {
            jobData.CloseJob(jobID);
            AssignJob(incidentID);
        }

        public void EscalateJob(int jobID, int jobStatus, int assignedWorkerID)
        {
            jobData.UpdateJob(jobID, jobStatus, assignedWorkerID);
        }

        private int getAvailableWorkers(string[] abilityReq)
        {
            int workerID = 5;
            return workerID;
        }
    }
}
