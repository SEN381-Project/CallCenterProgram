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
    class BusinessClient : IClient
    {

        private int clientID;
        private String name;
        private String surname;
        private String clientAddress; //may have to expand this into its separate parts
        private String clientStatus;
        private string clientRole;

        public string ClientRole { get => clientRole; set => clientRole = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string ClientAddress { get => clientAddress; set => clientAddress = value; }
        public string ClientStatus { get => clientStatus; set => clientStatus = value; }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Display()
        {
            //method for displaying
        }

        public void getDetailsForInsert()
        {
            
        }

        public void getServiceAgreement()
        {
           
        }
    }
}
