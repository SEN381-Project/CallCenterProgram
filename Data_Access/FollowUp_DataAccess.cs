using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CallCenterProgram.Business_Logic;

namespace CallCenterProgram.Data_Access
{
    class FollowUp_DataAccess
    {
        //Set Connection String
        string connect = "Data Sourse =.; Initial Catalog = CallCenterDatabase; Integrated Security = SSPI";
        SqlConnection Conn;
        SqlCommand Command;
        SqlDataReader Reader;

        //object
        FollowUp objFollowUp = new FollowUp();


        public void InsertFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            string query = @"INSERT INTO FollowUp VALUES('"+ followUpId + "','" + status + "', '" + followUpDate + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("Follow up inserted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Follow up is not added!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        
         public void InsertFeedback(int feedbackId, string problem, bool helpedOnTime,string comment, DateTime feedbackDate)
        {
            string query = @"INSERT INTO Feedback VALUES('"+ feedbackId + "','" + problem + "','" + helpedOnTime + "','" + comment + "', '"+ feedbackDate + ")";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("Feedback inserted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Feedback up is not added!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }
        public void UpdateFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            string query = @"UPDATE INTO FollowUp VALUES('" + followUpId + "','" + status + "', '" + followUpDate + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("Follow up updated!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Follow up is not updated!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }
        public void DeleteFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            string query = @"DELETE INTO FollowUp VALUES('" + followUpId + "','" + status + "', '" + followUpDate + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("Follow up deleted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Follow up is not deleted!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        public List<FollowUp> DisplayFollowUps()
        {
            string query = @"SELECT * FROM FollowUp";

            Conn = new SqlConnection(connect);

            Conn.Open();

            Command = new SqlCommand(query, Conn);
            List<FollowUp> FollowUpData = new List<FollowUp>();

            try
            {
                Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    objFollowUp.FollowUpId = int.Parse(Reader[1].ToString());
                    objFollowUp.Status = Reader[2].ToString();
                    objFollowUp.FollowUpDate = DateTime.Parse(Reader[3].ToString());


                    FollowUpData.Add(new FollowUp(objFollowUp.FollowUpId, objFollowUp.Status, objFollowUp.FollowUpDate));
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

            return FollowUpData;
        }

        public List<FollowUp> DisplayFeedbacks()
        {
            string query = @"SELECT * FROM Feedback";

            Conn = new SqlConnection(connect);

            Conn.Open();

            Command = new SqlCommand(query, Conn);
            List<FollowUp> FeedbackData = new List<FollowUp>();

            try
            {
                Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    objFollowUp.FeedbackId = int.Parse(Reader[1].ToString());
                    objFollowUp.Problem = Reader[2].ToString();
                    objFollowUp.HelpedOnTime = bool.Parse(Reader[3].ToString());
                    objFollowUp.Comment = Reader[4].ToString();
                    objFollowUp.FeedbackDate = DateTime.Parse(Reader[5].ToString());


                    FeedbackData.Add(new FollowUp(objFollowUp.FeedbackId, objFollowUp.Problem, objFollowUp.HelpedOnTime, objFollowUp.Comment, objFollowUp.FeedbackDate));
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

            return FeedbackData;
        }
    }
}
