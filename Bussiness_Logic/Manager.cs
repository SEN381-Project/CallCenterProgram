using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;


namespace CallCenterProgram.Bussiness_Logic
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

        internal void InsertDepartment(int v1, string text, int v2)
        {
            throw new NotImplementedException();
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

        public List<Manager> ViewEmployee()
        {
            List<Manager> Employees = EmployeeData.DisplayEmployee();
            return Employees;
        }

        public List<Manager> ViewDepartment()
        {
            List<Manager> Departments = EmployeeData.DisplayDepartment();
            return Departments;
        }
        

        public void InsertEnployee(int employeeId, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescription)
        {
            EmployeeData.InsertEmployee(employeeId, name, surname, address, contactDetails, jobTitle, jobDescription);

        }

        public void InsertDepartmen(int departmentId, string derptmentName, int stationNumber)
        {
            EmployeeData.InsertDepartment(departmentId, derptmentName, stationNumber);

        }

    }
}
