using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;


namespace CallCenterProgram.Business_Logic
{
    class Manager : Employee
    {
        Employee_DataAccess EmployeeData = new Employee_DataAccess();

        public Manager(int employeeId, string name, string surname, string address, string contactDetails, string jobtitle, string jobDescription)
        {
            EmployeeId = employeeId;
            Name = name;
            Surname = surname;
            Address = address;
            ContactDetails = contactDetails;
            Jobtitle = jobtitle;
            JobDescription = jobDescription;
        }

        public Manager(int departmentId, string departmentName, int stationNumber)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            StationNumber = stationNumber;
        }

        public Manager()
        {
        }

        public void FireEmployee(int employeeId, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescription)
        {
            EmployeeData.DeleteEmployee(employeeId, name, surname, address, contactDetails, jobTitle, jobDescription);

        }

        public void UpdateEmployeeInf(int employeeId, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescription)
        {
            EmployeeData.UpdateEmployee(employeeId, name, surname, address, contactDetails, jobTitle, jobDescription);
        }

        public void RemoveDepartment(int departmentId, string derptmentName, int stationNumber)
        {
            EmployeeData.DeleteDepartment(departmentId, derptmentName, stationNumber);

        }

        public void UpdateDepartment(int departmentId, string derptmentName, int stationNumber)
        {
            EmployeeData.UpdatetDepartment(departmentId, derptmentName, stationNumber);
        }
        
        public override string ToString()
        {
            return base.ToString();
        }

        public List<Employee> ViewEmployee()
        {
            List<Employee> Employees = EmployeeData.DisplayEmployee();
            return Employees;
        }

        public List<Employee> ViewDepartment()
        {
            List<Employee> Departments = EmployeeData.DisplayDepartment();
            return Departments;
        }

       
    }
}
