using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class Contract
    {
        private bool onGoing;

        public bool OnGoing { get => onGoing; set => onGoing = value; }

        public void CreateContract(Package package, int clientID)
        {

        }

        public void TerminateContract()
        {
            // switch onGoing from true to false to indicate termination.
        }
    }
}
