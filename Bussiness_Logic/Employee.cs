using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Data_Access;

namespace CallCenterProgram.Business_Logic
{
    
        public abstract class Employee
        {
            private int employeeId;
            private string name;
            private string surname;
            private string address;
            private string contactDetails;
            private string jobTitle;
            private string jobDescription;
            private int departmentId;
            private string derptmentName;
            private int stationNumber;

            public int EmployeeId { get => employeeId; set => employeeId = value; }
            public string Name { get => name; set => name = value; }
            public string Surname { get => surname; set => surname = value; }
            public string Address { get => address; set => address = value; }
            public string  ContactDetails{ get => contactDetails; set => contactDetails = value; }
            public string Jobtitle { get => jobTitle; set => jobTitle = value; }
            public string JobDescription { get => jobDescription; set => jobDescription = value; }
            public int DepartmentId { get => departmentId; set => departmentId = value; }
            public string DepartmentName { get => derptmentName; set => derptmentName = value; }
            public int StationNumber { get => stationNumber; set => stationNumber = value; }

        public Employee()
        {
            this.EmployeeId = employeeId;
            this.Name = name;
            this.Surname = surname;
            this.Address = address;
            this.ContactDetails = contactDetails;
            this.Jobtitle = jobTitle;
            this.JobDescription = jobDescription;
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

        Employee_DataAccess EmployeeData = new Employee_DataAccess();

        public void InsertEnployee(int employeeId, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescriptiont)
        {
            EmployeeData.InsertEmployee(employeeId, name, surname, address, contactDetails, jobTitle, jobDescription);

        }

        public void InsertDepartmen(int departmentId, string derptmentName, int stationNumber)
        {
            EmployeeData.InsertDepartment(departmentId, derptmentName, stationNumber);

        }
    }

    
}
