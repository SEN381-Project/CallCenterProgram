using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CallCenterProgram;
using CallCenterProgram.Bussiness_Logic;

namespace CallCenterProgram.Data_Access
{
    class call_DataAccess
    {

        string connect = "Data Source=.; Initial Catalog= CallCenterDatabase; Integrated Security= SSPI";
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;

        

        public void InsertCall(int ClientID, DateTime initialTimestamp, DateTime finalTimestamp, string faultReport, string callReport, string problemInfo, string workRequest, int callDuration)
        {
            string query = @"
                            INSERT INTO 
                                Call 
                            VALUES 
                                ( '" + ClientID + "', '" + initialTimestamp + "', '" + finalTimestamp + "', '" + faultReport + "', '" + callReport + "', '" + problemInfo + "', '" + workRequest + "', '" + callDuration + "' )";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Call inserted into the database successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not insert call due to error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Call> GetCallHistory(int clientID)
        {
            string query = @"
                            SELECT *
                            FROM
                                Call 
                            WHERE 
                                ClientID = ('" + clientID + "')";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            List<Call> callHistory = new List<Call>();
            Call tempCall = new Call();

            try
            {
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    tempCall.ClientID = int.Parse(reader[1].ToString());
                    tempCall.InitialTimeStamp = (DateTime)reader[2];
                    tempCall.FinalTimeStamp = (DateTime)reader[3];
                    tempCall.FaultReport = reader[4].ToString();
                    tempCall.CallReport = reader[5].ToString();
                    tempCall.ProblemInfo = reader[6].ToString();
                    tempCall.WorkRequest = reader[7].ToString();
                    tempCall.CallDuration = int.Parse(reader[8].ToString());

                    callHistory.Add(tempCall);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not insert call due to error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return callHistory;
        }
    }
}
