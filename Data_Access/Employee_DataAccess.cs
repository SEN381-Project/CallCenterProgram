using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CallCenterProgram;
using CallCenterProgram.Presentation;
using CallCenterProgram.Bussiness_Logic;


namespace CallCenterProgram.Data_Access
{
    class Employee_DataAccess
    {
         //Set Connection String
        string connect = "Data Source=.; Initial Catalog= CallCenterDatabase; Integrated Security= SSPI";
        SqlConnection Conn;
        SqlCommand Command;
        SqlDataReader readers;


        //Insering Employee details
        public void InsertEmployee(int employeeID, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescriptiont)
        {
            string query = @"INSERT INTO Employee VALUES('" + employeeID + "','" + name + "','" + surname + "', '" + address + "','" + contactDetails + "','" + jobTitle + "','" + jobDescriptiont + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("New Employee inserted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is an error, Employee is not added!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        //Insering Department details
        public void InsertDepartMent(int departmentId, string derptmentName, int stationNumber)
            {
                string query = @"INSERT INTO Department VALUES('" + departmentId + "','" + derptmentName + "', '" + stationNumber + "')";
                Conn = new SqlConnection(connect);
                Conn.Open();
                Command = new SqlCommand(query, Conn);

                try
                {
                    Command.BeginExecuteNonQuery();
                    MessageBox.Show("Department inserted!");
                }
                catch (Exception e)
                {

                    MessageBox.Show("Department Details are not added!" + e.Message);
                }

                finally
                {
                    Conn.Close();
                }
            }
        //inserting technicial info
        public void InsertTechnicians(string abilities, string qualification)
        {
            string query = @"INSERT INTO Employee VALUES('" + abilities + "','" + qualification+ "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("Technician info inserted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is an error,Technician info is not added!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        //Updating Employee details
        public void UpdateEmployee(int employeeID, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescriptiont)
        {
            string query = @"UPDATE INTO Employee VALUES('" + employeeID + "','" + name + "','" + surname + "', '" + address + "','" + contactDetails + "','" + jobTitle + "','" + jobDescriptiont + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("Employee details are updated!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Employee details are not updated!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        //Updating Department details
        public void UpdatetDepartMent(int departmentId, string derptmentName, int stationNumber)
        {
            string query = @"UPDATE INTO Department VALUES('" + departmentId + "','" + derptmentName + "', '" + stationNumber + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("Department is updated!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Department details are not updated!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        //update technian info
        public void UpdateTechnicians(string abilities, string qualification)
        {
            string query = @"UPDATE INTO Employee VALUES('" + abilities + "','" + qualification + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("Technician info Updated!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is an error,Technician info is not updated!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        //Deleting Employee details
        public void DeleteEmployee(int employeeID, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescriptiont)
        {
            string query = @"DELETE INTO Employee VALUES('" + employeeID+ "','" + name + "','" + surname + "', '" + address + "','" + contactDetails + "','" + jobTitle + "','" + jobDescriptiont + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("The Employee is Remove From the system!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Employee is not removed!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        //Deleting Derpartment details
        public void DeleteDepartment(int departmentId, string derptmentName, int stationNumber)
        {
            string query = @"DELETE INTO Department VALUES('" + departmentId + "','" + derptmentName + "', '" + stationNumber + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("The Department is Remove From the system!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Department is not removed!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        public string DisplayEmployeeSkills(int employeeID)
        {
            string query = @"SELECT Qualification FROM Employee WHERE EmployeeID = ( '" + employeeID + "' )";

            Conn = new SqlConnection(connect);

            Conn.Open();

            Command = new SqlCommand(query, Conn);
            string qualifications = string.Empty;

            try
            {
                readers = Command.ExecuteReader();

                while (readers.Read())
                {
                    qualifications = readers[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }

            return qualifications;
        }

        public List<string> DisplayEmployeeSkills()
        {
            string query = @"SELECT EmployeeID, Qualification FROM Employee";

            Conn = new SqlConnection(connect);

            Conn.Open();

            Command = new SqlCommand(query, Conn);
            List<string> info = new List<string>();

            try
            {
                readers = Command.ExecuteReader();

                while (readers.Read())
                {
                    string infoStr;
                    infoStr = readers[0].ToString();
                    infoStr += ',' + readers[1].ToString();

                    info.Add(infoStr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }

            return info;
        }

        //delete technician info
        public void DeleteTechnicians(string abilities, string qualification)
            {
                string query = @"DELETE INTO Employee VALUES('" + abilities + "','" + qualification + "')";
                Conn = new SqlConnection(connect);
                Conn.Open();
                Command = new SqlCommand(query, Conn);

                try
                {
                    Command.BeginExecuteNonQuery();
                    MessageBox.Show("Technician info deleted!");
                }
                catch (Exception e)
                {

                    MessageBox.Show("There is an error,Technician info is not deleted!" + e.Message);
                }

                finally
                {
                    Conn.Close();
                }
             
            }  
      }
    }

