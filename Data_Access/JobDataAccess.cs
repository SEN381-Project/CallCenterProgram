using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CallCenterProgram
{
    class JobDataAccess
    {
        //Constuctor
        public JobDataAccess()
        {
        }

        //Set Connection String
        string connect = "Data Source=.; Initial Catalog= CallCenterDatabase; Integrated Security= SSPI";
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader readers;

        //Objects
        Job objJob = new Job();

        public InsertJob(int jobStatus, int incidentRef, int assignedWorkerID)
        {
            string query = @"INSERT INTO Job VALUES ( '" + jobStatus + "', '" + incidentRef + "', '" + assignedWorkerID + "')";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.BeginExecuteNonQuery();
                MessageBox.Show("Job Made!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Job wasn't made: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public UpdateJob(int jobRef, int jobStatus, int assignedWorkerID)
        {
            string query = @"UPDATE Incident SET JobStatus = '" + jobStatus + "', AssignedWorkerID = '" + assignedWorkerID + "' WHERE IncidentRef = '" + jobRef + "'";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.BeginExecuteNonQuery();
                MessageBox.Show("Job updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Job not updated: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public CloseJob(int jobID)
        {
            string query = @"DELETE FROM Job WHERE JobRef = '" + jobID + "'";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.BeginExecuteNonQuery();
                MessageBox.Show("Job Closed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Job wasn't closed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public FindAvailableWorkers()
        {
        }

        public List<Job> DisplayJob()
        {
            string query = @"SELECT * FROM Jobs";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);
            List<Job> jobData = new List<Job>();

            try
            {
                readers = command.ExecuteReader();

                if (readers.Read())
                {
                    objJob.workerID = int.Parse(readers[0].ToString());
                    objJob.incidentID = int.Parse(readers[1].ToString());

                    if (int.Parse(readers[2].ToString()) == 1)
                    {
                        objJob.jobStatus = true;
                    }
                    else
                    {
                        objJob.jobStatus = false;
                    }

                    jobData.Add(new Job(objJob.workerID, objJob.incidentID, objJob.jobStatus));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return jobData;
        }

        public List<Job> DisplayJob(int employeeID)
        {
            string query = @"SELECT * FROM Jobs WHERE employeeID = ( '" + employeeID + "' )";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);
            List<Job> jobData = new List<Job>();

            try
            {
                readers = command.ExecuteReader();

                if (readers.Read())
                {
                    objJob.workerID = int.Parse(readers[0].ToString());
                    obJob.incidentID = int.Parse(readers[1].ToString());

                    if (int.Parse(readers[2].ToString()) == 1)
                    {
                        objJob.jobStatus = true;
                    }
                    else
                    {
                        objJob.jobStatus = false;
                    }

                    jobData.Add(new Job(objJob.workerID, objJob.incidentID, objJob.jobStatus));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return jobData;
        }
    }
}
