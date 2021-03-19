using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    
        public abstract class Employee
        {
          
            private String name;
            private String surname;
            private String address;
            private String contactDetails;

            
            public string Name { get => name; set => name = value; }
            public string Surname { get => surname; set => surname = value; }
            public string Address { get => address; set => address = value; }
            public string  ContactDetails{ get => contactDetails; set => contactDetails = value; }

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
