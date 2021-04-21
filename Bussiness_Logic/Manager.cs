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

        public void FireEmployee(int employeeID, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescriptiont)
        {
            EmployeeData.DeleteEmployee(int.Parse(txtEmployeeId.Text), txtEmployeename.Text, txtEmployeesurname.Text, txtEmployeeAddress.Text, txtContactDetails.Text, txtMjobtitle.Text, txtMjobDespription.Text);

        }

        public void UpdateEmployeeInf(int employeeID, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescriptiont)
        {
            EmployeeData.UpdateEmployee(int.Parse(txtEmployeeId.Text), txtEmployeename.Text, txtEmployeesurname.Text, txtEmployeeAddress.Text, txtContactDetails.Text, txtMjobtitle.Text, txtMjobDespription.Text);
        }

        public void RemoveDepartmen(int departmentId, string derptmentName, int stationNumber)
        {
            EmployeeData.DeleteDepartment(int.Parse(txtidDepartment.Text), txtNameDepartment.Text, int.Parse(txtSationNo.Text));

        }

        public void UpdateDepartmen(int departmentId, string derptmentName, int stationNumber)
        {
            EmployeeData.UpdatetDepartMent(int.Parse(txtidDepartment.Text), txtNameDepartment.Text, int.Parse(txtSationNo.Text));
        }
        
        public override string ToString()
        {
            return base.ToString();
        }

        public void Display()
        {
          

        }

    }
}
