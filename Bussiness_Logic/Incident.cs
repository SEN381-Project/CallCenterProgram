using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class Incident : FaultInfo
    {
        private string reportInfo;
        private DateTime timeIssued;
        private Double cost;
        private int clientID;
        private int priority;
        private string[] abilityReq;
        private int callWorkerID;


        public string ReportInfo
        {
            get { return reportInfo; }
            set { reportInfo = value; }
        }

        public DateTime TimeIssued
        {
            get { return timeIssued; }
            set { timeIssued = value; }
        }

        public Double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public string[] AbilityReq
        {
            get { return abilityReq; }
            set { abilityReq = value; }
        }

        public int CallWorkerID
        {
            get { return callWorkerID; }
            set { callWorkerID = value; }
        }

        public Incident()
        {
        }

        public Incident(string reportInfo, DateTime timeIssued, Double cost, int clientID, int priority, string[] abilityReq, int callWorkerID)
        {
            this.reportInfo = reportInfo;
            this.timeIssued = timeIssued;
            this.cost = cost;
            this.clientID = clientID;
            this.priority = priority;
            this.abilityReq = abilityReq;
            this.callWorkerID = callWorkerID;
        }
    }
}