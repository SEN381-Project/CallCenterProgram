using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CallCenterProgram.Bussiness_Logic;
using System.Data;

namespace CallCenterProgram.Data_Access
{
    class FollowUp_DataAccess
    { //Set Connection String
        string connect = "Data Source =.; Initial Catalog = CallCenterDatabase; Integrated Security = SSPI";
        SqlConnection Conn;
        SqlCommand Command;
        SqlDataReader Reader;

        //object
        FollowUp objFollowUp = new FollowUp();

        #region Insert Data
        public void InsertFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            string query = @"INSERT INTO FollowUp VALUES('" + followUpId + "','" + status + "', '" + followUpDate + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
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


        public void InsertFeedback(int feedbackId, string problem, bool helpedOnTime, string comment, DateTime feedbackDate)
        {
            string query = @"INSERT INTO Feedback VALUES('" + feedbackId + "','" + problem + "','" + helpedOnTime + "','" + comment + "', '" + feedbackDate + ")";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
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

        public void InsertSetReminder(int reminderId, string reminder, DateTime reminderDate)
        {
            string query = @"INSERT INTO Reminder VALUES('" + reminderId + "','" + reminder + "','" + reminderDate + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Reminder inserted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is and error, Reminder is not added!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }
        #endregion

        #region Update Data
        public void UpdateFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            string query = @"UPDATE FollowUp SET  Status = 'status ', FollowUpDate = 'followUpDate ' WHERE  FollowId = 'followUpId '";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
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

        public void UpdateSetReminder(int reminderId, string reminder, DateTime reminderDate)
        {
            string query = @"UPDATE  Reminder SET Reminder ='reminder', ReminderDate = 'reminderDate' WHERE Reminder ='reminderId' ";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Reminder Updated!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is and error, Reminder is not updated!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        #endregion

        #region Delete Data
        public void DeleteFollowUp(int followUpId)
        {
            string query = @"DELETE FROM FollowUp  FollowUpId ='followUpId'";
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

        public void DeleteSetReminder(int reminderId)
        {
            string query = @"DELETE FROM Reminder WHERE ReminderId = 'reminderId'";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("Reminder Deleted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is and error, Reminder is not deleted!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        #endregion

        #region DisplayData
        public BindingSource DisplayFollowUps()
        {

            BindingSource src = new BindingSource();
            string query = @"SELECT FollowUp.FollowUpID, FollowUp.Status, FollowUp.FollowUpDate, FollowUp.ClientID, FollowUp.JobRef  , Client.ClientName, Client.ClientSurname,Job. jobStatus,Job.incidentRef
                             FROM FollowUp INNER JOIN Client ON FollowUp.ClientID = Client.ClientID
                             INNER JOIN Job ON FollowUp.jobID = Job.jobID ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            src.DataSource = table;
            return src;
           
        }

        public BindingSource DisplayFeedbacks()
        {

            BindingSource src = new BindingSource();
            string query = @"SELECT Feedback.FeedbackID, Feedback.HelpedOnTime, Feedback.Problem, Feedback.Comment, Feedback.FeedbackDate ,Feedback.ClientID, Client.ClientName, Client.ClientSurname
                             FROM Feedback 
                             INNER JOIN Client ON Feedback.ClientID = Client.ClientID ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            src.DataSource = table;
            return src;
            
        }

        public BindingSource DisplayReminder()
        {
            BindingSource src = new BindingSource();
            string query = @"SELECT ReminderId, Reminder, ReminderDate FROM  Reminder";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            src.DataSource = table;
            return src;
            
        }

        #endregion

    }
}
