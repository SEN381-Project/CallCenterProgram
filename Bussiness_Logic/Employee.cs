using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterProgram
{
    
        public abstract class Employee
        {
          
            private string name;
            private string surname;
            private string address;
            private string contactDetails;
            private string jobTitle;
            private string jobDescriptiont;
            private int departmentId;
            private string derptmentName;
            private int stationNumber;


        public string Name { get => name; set => name = value; }
            public string Surname { get => surname; set => surname = value; }
            public string Address { get => address; set => address = value; }
            public string  ContactDetails{ get => contactDetails; set => contactDetails = value; }
            public string Jobtitle { get => jobTitle; set => jobTitle = value; }
            public string JobDescription { get => jobDescriptiont; set => jobDescriptiont = value; }
            public int DepartmentId { get => departmentId; set => departmentId = value; }
            public string DepartmentName { get => derptmentName; set => derptmentName = value; }
            public int StationNumber { get => stationNumber; set => stationNumber = value; }

        public Employee()
        {
            this.Name = name;
            this.Surname = surname;
            this.Address = address;
            this.ContactDetails = contactDetails;
            this.Jobtitle = jobTitle;
            this.JobDescription = jobDescriptiont;
            this.DepartmentId = departmentId;
            this.DepartmentName = DepartmentName;
            this.StationNumber = stationNumber;
        }

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
