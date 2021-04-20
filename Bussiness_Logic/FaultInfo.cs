using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class FaultInfo : CallStats
    {
        //fields
        private string faultReport;

        //properties
        public string FaultReport { get => faultReport; set => faultReport = value; }
    }
}
