using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    class BusinessClient : Client
    {
        private string clientRole;

        public string ClientRole { get => clientRole; set => clientRole = value; }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Display()
        {

        }
    }
}
