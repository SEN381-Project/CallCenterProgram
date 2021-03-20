using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
<<<<<<< HEAD
    class Package
    {
        private string packageName;

        public string PackageName { get => packageName; set => packageName = value; }

        public void CreatePackage(List<Service> services, List<ServiceLevel> serviceLevels)
        {

        }
        public void ViewPerformance(int contractTypeId)
=======
    class package : contract
    {
        public void GetServices()
        {

        }
        public void GetServiceLevels()
>>>>>>> 53d0d4c35aba3fac80186fa043cd74f74a4079a3
        {

        }
    }
}
