using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class ServiceRequest : Incident
    {
        public void AssignJob(int incidentID)
        {
        }

        public void ReassignJob(int jobID, int incidentID)
        {
        }

        public void EscalateJob(int jobID, int incidentID)
        {
        }

        private string[] getAvailableWorkers(string[] abilityReq)
        {
        }
    }
}
