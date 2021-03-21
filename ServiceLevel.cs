using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class ServiceLevel
    {
        // Security Level Table
        private int securityLevelId;
        private string levelDescription;
        private bool availability;
        private string emailSupport;
        private string phoneSupport;
        // Service Level Table
        private int sericeLevelId;
        private string levelName;
        private string optOutDetails;
        private double penaltiesForLateWork;
        private double penaltiesForNonPerformance;
        private bool state;

        public int SecurityLevelId { get => securityLevelId; set => securityLevelId = value; }
        public string LevelDescription { get => levelDescription; set => levelDescription = value; }
        public bool Availability { get => availability; set => availability = value; }
        public string EmailSupport { get => emailSupport; set => emailSupport = value; }
        public string PhoneSupport { get => phoneSupport; set => phoneSupport = value; }
        public int SericeLevelId { get => sericeLevelId; set => sericeLevelId = value; }
        public string LevelName { get => levelName; set => levelName = value; }
        public string OptOutDetails { get => optOutDetails; set => optOutDetails = value; }
        public double PenaltiesForLateWork { get => penaltiesForLateWork; set => penaltiesForLateWork = value; }
        public double PenaltiesForNonPerformance { get => penaltiesForNonPerformance; set => penaltiesForNonPerformance = value; }
        public bool State { get => state; set => state = value; }

        public void AddServiceLevel()
        {

        }

        public void ChangeState()
        {

        }

        public void ChangeAvailability()
        {

        }
    }
}
