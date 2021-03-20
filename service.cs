using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class Service
    {
        private string serviceName;
        private int serviceId;
        private string workExpenses;
        private string equipmentType;
        private bool state; 

        public string ServiceName { get => serviceName; set => serviceName = value; }
        public int ServiceId { get => serviceId; set => serviceId = value; }
        public string WorkExpenses { get => workExpenses; set => workExpenses = value; }
        public string EquipmentType { get => equipmentType; set => equipmentType = value; }
        public bool State { get => state; set => state = value; }

        public void AddService()
        {

        }

        public void ChangeState()
        {
            // CHange the state of a service from active to active (vice versa)
        }
    }
}
