using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CallCenterProgram
{
    class IncidentDataAccess
    {
        //Constuctor
        public DataHandler()
        {
        }

        //Set Connection String
        string connect = "Data Source=.; Initial Catalog= CallCenterDatabase; Integrated Security= SSPI";
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader readers;

        //Objects
        Incident objIncident = new Incident();

        public InsertWorkRequest(string reportInfo, DateTime timeIssued, int priority, decimal cost, string[] abilityReq, int clientID, int callEmplpoyeeID)
        {
            string abilityrequirement = string.Empty;

            for (int i = 0; i < abilityReq.Length; i++)
            {
                abilityrequirement += abilityReq[i];

                if (i != abilityReq.Length - 1)
                {
                    abilityrequirement += ",";
                }
            }

            string query = @"INSERT INTO Incedent VALUES ( '" + reportInfo + "', '" + timeIssued + "', '" + priority + "', '" + cost + "', '" + abilityrequirement + "', '" + clientID + "', '" + callEmployeeID + "')";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.BeginExecuteNonQuery();
                MessageBox.Show("Work request made!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Work request not made: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public UpdateWorkRequest(int incidentID, string reportInfo, DateTime timeIssued, int priority, decimal cost, string[] abilityReq)
        {
            string abilityrequirement = string.Empty;

            for (int i = 0; i < abilityReq.Length; i++)
            {
                abilityrequirement += abilityReq[i];

                if (i != abilityReq.Length - 1)
                {
                    abilityrequirement += ",";
                }
            }

            string query = @"UPDATE Incident SET ReportInfo = '" + reportInfo + "', TimeIssued = '" + timeIssued + "', Priority = '" + priority + "', Cost = '" + cost + "', AbilityReq = '" + abilityrequirement + "' WHERE IncidentRef = '" + incidentID + "'";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.BeginExecuteNonQuery();
                MessageBox.Show("Work request updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Work request not updated: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Incident> DisplayIncident(int incidentID)
        {
            string query = @"SELECT * FROM Jobs WHERE incidentRef = ( '" + incidentID + "' )";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);
            List<Incident> incidentData = new List<Incident>();

            try
            {
                readers = command.ExecuteReader();

                if (readers.Read())
                {
                    objIncident.incidentID = int.Parse(readers[0].ToString());
                    objIncident.reportInfo = readers[1].ToString();
                    objIncident.cost = DateTime.Parse(readers[2].ToString());
                    objIncident.clientID = int.Parse(readers[3].ToString());
                    objIncident.priority = int.Parse(readers[4].ToString());
                    objIncident.abilityReq = readers[5].ToString().split(",");
                    objIncident.callWorkerID = int.Parse(readers[6].ToString());

                    incidentData.Add(new Incident(objIncident.incidentID, objIncident.reportInfo, objIncident.cost, objIncident.clientID, objIncident.priority, objIncident.abilityReq, objIncident.callWorkerID));
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

            return incidentData;
        }

        public List<Incident> DisplayIncident()
        {
            string query = @"SELECT * FROM Jobs";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);
            List<Incident> incidentData = new List<Incident>();

            try
            {
                readers = command.ExecuteReader();

                if (readers.Read())
                {
                    objIncident.incidentID = int.Parse(readers[0].ToString());
                    objIncident.reportInfo = readers[1].ToString();
                    objIncident.cost = DateTime.Parse(readers[2].ToString());
                    objIncident.clientID = int.Parse(readers[3].ToString());
                    objIncident.priority = int.Parse(readers[4].ToString());
                    objIncident.abilityReq = readers[5].ToString().split(",");
                    objIncident.callWorkerID = int.Parse(readers[6].ToString());

                    incidentData.Add(new Incident(objIncident.incidentID, objIncident.reportInfo, objIncident.cost, objIncident.clientID, objIncident.priority, objIncident.abilityReq, objIncident.callWorkerID));
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

            return incidentData;
        }
    }
}
