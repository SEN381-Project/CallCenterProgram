using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;
using CallCenterProgram;

namespace CallCenterProgram.Bussiness_Logic
{
    class Package
    {
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        private string packageName;
        private List<Service> services;
        private List<ServiceLevel> serviceLevels;

        public Package()
        {
        }

        public Package(string packageName, List<Service> services, List<ServiceLevel> serviceLevels)
        {
            this.packageName = packageName;
            this.services = services;
            this.serviceLevels = serviceLevels;
        }

        public string PackageName { get => packageName; set => packageName = value; }
        public List<Service> Services { get => services; set => services = value; }
        public List<ServiceLevel> ServiceLevels { get => serviceLevels; set => serviceLevels = value; }

        public Package CreatePackage(string packageName, string services, string serviceLevels)
        {   
            dataAccess.InsertPackage(packageName, services, serviceLevels);
            List<Service> servicesLst = new List<Service>();
            List<ServiceLevel> serviceLevelLst = new List<ServiceLevel>();
            for (int i = 0; i < services.Length; i++)
            {
                SqlDataReader readerService = dataAccess.GetService(int.Parse(services[i].ToString()));
                bool state = (int)readerService[4] == 1 ? true : false;
                Service service = new Service(readerService[0].ToString(), int.Parse(readerService[1].ToString()), readerService[2].ToString(), readerService[3].ToString(), state);

                SqlDataReader readerServiceLevel = dataAccess.GetService(int.Parse(serviceLevels[i].ToString()));
                ServiceLevel serviceLevel = new ServiceLevel();
                servicesLst.Add(service);
                //serviceLevelLst.Add();
            }
            Package package = new Package(packageName, Services, ServiceLevels);

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
