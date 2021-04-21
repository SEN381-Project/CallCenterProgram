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
    class Service
    {
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        private string serviceName;
        private int serviceId;
        private string workExpenses;
        private string equipmentType;
        private bool state;

        public Service()
        {
        }

        public Service(string serviceName, int serviceId, string workExpenses, string equipmentType, bool state)
        {
            this.serviceName = serviceName;
            this.serviceId = serviceId;
            this.workExpenses = workExpenses;
            this.equipmentType = equipmentType;
            this.state = state;
        }

        public string ServiceName { get => serviceName; set => serviceName = value; }
        public int ServiceId { get => serviceId; set => serviceId = value; }
        public string WorkExpenses { get => workExpenses; set => workExpenses = value; }
        public string EquipmentType { get => equipmentType; set => equipmentType = value; }
        public bool State { get => state; set => state = value; }

        public Service AddService(string name, string equipmentType, string workExpenses, int state)
        {
            // 1. from presentation layer: get the data 
            // 2. pass it as parameters 
            // tid can be caused maybe by button push etc. 

            // send data to database
            dataAccess.InsertService(name, equipmentType, workExpenses, state);

            // create service object and return it 
            // gonna use these to build a list of services that will go into the package.
            Service service = new Service(); // create constructor with appropriate parameters 
            // major issue ?? GETTING THE SERVICE ID to create a complete service object  
            return service;
        }

        public void ChangeState(int serviceID, int newState)
        {
            // Change the state of a service from active to active (vice versa)
            // from presentation find out which service should be updated 
            // and what the new state should be then use that here
            // most likey to be used in the form: amanger side when asked to make changes ?

            // database update 
            dataAccess.UpdateService(serviceID, newState);

            // local update
            if (newState == 0)
            {
                this.state = false;
            }
            else
            {
                this.state = true;
            }
             
        }
    }
}
