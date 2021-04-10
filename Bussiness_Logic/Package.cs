using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class Package
    {
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        private string packageName;
        private List<Service> services;
        private List<ServiceLevel> serviceLevels;

        public Package(string packageName, List<Service> services, List<ServiceLevel> serviceLevels)
        {
            this.packageName = packageName;
            this.services = services;
            this.serviceLevels = serviceLevels;
        }

        public string PackageName { get => packageName; set => packageName = value; }
        public List<Service> Services { get => services; set => services = value; }
        public List<ServiceLevel> ServiceLevels { get => serviceLevels; set => serviceLevels = value; }

        public Package CreatePackage(string packageName, List<Service> services, List<ServiceLevel> serviceLevels)
        {
            // every service will have a service level attatched to it. 
            // how do I add this ti the database ????????????????????????????????????????????
            // solved version 1 : use unique package names to query the databse for similar package name but add  them separatly.
            for (int i = 0; i < services.Count; i++)
            {
                dataAccess.InsertPackage(packageName, services[i].ServiceId, serviceLevels[i].SecurityLevel.SecurityLevelId);
            }

            Package package = new Package(packageName, services, serviceLevels);

            return package;
        }
        public void ViewPerformance(int contractTypeId)
        {
            // no implementation details yet 
            // no metrics to track 

            // how often a package is bouhght ?
            // how many issues raised on a specific package ?
            // which pakgage has best average etc 
        }
    }
}
