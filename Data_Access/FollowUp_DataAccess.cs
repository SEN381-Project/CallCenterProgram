using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CallCenterProgram
{
    class FollowUp_DataAccess
    {
        //Set Connection String
        string connect = "Data Sourse =.; Initial Catalog = CallCenterDatabase; Integrated Security = SSPI";
        SqlConnection Conn;
        SqlCommand Command;
        SqlDataReader Reader;

        //object
        FollowUp followUp = new FollowUp();


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

        
         public void InsertFeedback(int feedbackId, string problem, string helpedOnTime,string comment, DateTime feedbackDate)
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

        public void SetReminder()
        {
           
        }

      
    }
}
