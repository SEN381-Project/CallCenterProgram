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
    class ServiceLevel
    {
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        // Service Level Table
        private SecurityLevel securityLevel;
        private bool availability;
        private int sericeLevelId;
        private string levelName;
        private string optOutDetails;
        private double penaltiesForLateWork;
        private double penaltiesForNonPerformance;

        public bool Availability { get => availability; set => availability = value; }
        public int SericeLevelId { get => sericeLevelId; set => sericeLevelId = value; }
        public string LevelName { get => levelName; set => levelName = value; }
        public string OptOutDetails { get => optOutDetails; set => optOutDetails = value; }
        public double PenaltiesForLateWork { get => penaltiesForLateWork; set => penaltiesForLateWork = value; }
        public double PenaltiesForNonPerformance { get => penaltiesForNonPerformance; set => penaltiesForNonPerformance = value; }
        public SecurityLevel SecurityLevel { get => securityLevel; set => securityLevel = value; }

        public ServiceLevel AddServiceLevel(string levelName, string optOutDetails, double penaltiesForLateWork, double penaltiesForNonPerformance, int state, int securityLevelID)
        {
            dataAccess.InsertServiceLevel(levelName, optOutDetails, penaltiesForLateWork, penaltiesForNonPerformance, state, securityLevelID);

            ServiceLevel serviceLevel = new ServiceLevel();
            return serviceLevel;
        }

        public void ChangeAvailability(int serviceLevelID, int newAvailability)
        {
            dataAccess.UpdateServiceLevel(serviceLevelID, newAvailability);

            // local update
            this.Availability = newAvailability == 0 ? false : true;
        }
    }
}
