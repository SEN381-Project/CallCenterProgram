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
    class Contract
    {
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        private bool onGoing;
        private int packageID;
        private int clientID;

        public bool OnGoing { get => onGoing; set => onGoing = value; }
        public int PackageID { get => packageID; set => packageID = value; }
        public int ClientID { get => clientID; set => clientID = value; }

        public void CreateContract(Package package, int clientID)
        {
            // gotta use package name as the identifier of a contract so we can be able to collect the different services and stuff
            // 
        }

        public void TerminateContract(int contractID, int newOnGoing)
        {
            //dataAccess.UpdateContract();
            // add onGoing to database (aka the state so it can be changed)
            if (true)
            {

            }
        }
    }
}
