using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;
using CallCenterProgram;
using System.Windows.Forms;

namespace CallCenterProgram.Bussiness_Logic
{
    class ManagerBusiness
    {
        private string authorize;

        public string Authorize { get => authorize; set => authorize = value; }

        Employee_DataAccess EmployeeData = new Employee_DataAccess();
        public void FireEmployee(int employeeId, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescription)
        {
            EmployeeData.DeleteEmployee(employeeId);

        }

        public void UpdateEmployeeInf(int employeeId, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescription)
        {
            EmployeeData.UpdateEmployee(employeeId, name, surname, address, contactDetails, jobTitle, jobDescription);
        }


        public void RemoveDepartment(int departmentId)
        {
            EmployeeData.DeleteDepartment(departmentId);

        }

        public void UpdateDepartment(int departmentId, string derptmentName, int stationNumber)
        {
            EmployeeData.UpdateDepartment(departmentId, derptmentName, stationNumber);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public BindingSource ViewEmployee()
        {
            BindingSource src = new BindingSource();
            src.DataSource = EmployeeData.DisplayEmployee();
            return src;
        }



        public void AddEmployee(int employeeId, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescription)
        {
            EmployeeData.InsertEmployee(employeeId, name, surname, address, contactDetails, jobTitle, jobDescription);

        }

        public void AddDepartment(int departmentId, string derptmentName, int stationNumber)
        {
            EmployeeData.InsertDepartment(departmentId, derptmentName, stationNumber);

        }

        public void MakeAuthorizarion(string authorize)
        {
            authorize = "M145628";
        }
    }
}
