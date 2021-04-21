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
    class SecurityLevel
    {
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        // Security Level Table
        private int securityLevelId;
        private string levelDescription;
        private bool availability;
        private string emailSupport;
        private string phoneSupport;


        public int SecurityLevelId { get => securityLevelId; set => securityLevelId = value; }
        public string LevelDescription { get => levelDescription; set => levelDescription = value; }
        public bool Availability { get => availability; set => availability = value; }
        public string EmailSupport { get => emailSupport; set => emailSupport = value; }
        public string PhoneSupport { get => phoneSupport; set => phoneSupport = value; }

        public void ChangeAvailability(int securityLevelID, int newAvailability)
        {
            dataAccess.UpdateSecurityLevel(securityLevelID, newAvailability);

            // local update
            if (newAvailability == 0)
            {
                this.availability = false;
            }
            else
            {
                this.availability = true;
            }
        }
    }
}
