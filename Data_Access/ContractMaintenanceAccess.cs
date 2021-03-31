using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CallCenterProgram
{
    class ContractMaintenanceAccess
    {
        string connect = "Data Source=.; Initial Catalog= CallCenterDatabase; Integrated Security= SSPI";
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;
        // Insert functions: These functions are used to add services, service levels (including security levels),
        // add packages add contract(aka create a contract)

        // Only the manager can use this method (or anyone with clearance to create services)
        public void InsertService(string name, string equipmentType, string workExpenses, int state)
        {
            string query = $"INSERT INTO Service VALUES({name}, {equipmentType}, {workExpenses},{state})";
            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                // MessageBox.Show() overload number 7
                MessageBox.Show("New service inserted succesfully", "Service Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // MessageBox.Show() overload number 7
                MessageBox.Show("Failed to insert new Service: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Only the manager can use this method (or anyone with clearance to create service levels)
        public void InsertServiceLevel(string levelName, string optOutDetails, double penaltiesForLateWork, double penaltiesForNonPerformance, int state, int securityLevelID)
        {
            string query = $"INSERT INTO ServiceLevel VALUES({levelName}, {optOutDetails}, {penaltiesForLateWork},{penaltiesForNonPerformance},{state},{securityLevelID})";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                // MessageBox.Show() overload number 7
                MessageBox.Show("New service level inserted succesfully", "Service Level Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // MessageBox.Show() overload number 7
                MessageBox.Show("Failed to insert new Service Level: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Only the manager can use this method (or anyone with clearance to create packages)
        public void InsertPackage(string packageName, int serviceID, int serviceLevelID)
        {
            string query = $"INSERT INTO ContractType VALUES({packageName}, {serviceID}, {serviceLevelID})";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("New package inserted succesfully", "Package Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert new Package: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // Both the manager and call center personeel can use this method (or anyone with clearance to create contracts)
        // most likely to be used by the call senter personeel, as they deal with clients and create these contracts (sell the services)
        public void InsertContract(int contractTypeID, int clientID)
        {
            string query = $"INSERT INTO Contract VALUES({contractTypeID}, {clientID})";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("New contract inserted succesfully", "Contract Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert new Contract: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        // The manager can use this method (or anyone with clearance to create security levels)
        public void InsertSecuriyLevel(string levelDescription, int availability, string emailSupport, string phoneSupport)
        {
            string query = $"INSERT INTO SecurityLevel VALUES({levelDescription}, {availability}, {emailSupport},{phoneSupport})";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("New security level inserted succesfully", "Security Level Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert new security level: " + ex.Message, "Insert Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
