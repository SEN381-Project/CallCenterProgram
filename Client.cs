using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    public abstract class Client
    {
        private int clientID;
        private String name;
        private String surname;
        private String clientAddress;
        private String clientStatus;

        public int ClientID { get => clientID; set => clientID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string ClientAddress { get => clientAddress; set => clientAddress = value; }
        public string ClientStatus { get => clientStatus; set => clientStatus = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    

    
}
