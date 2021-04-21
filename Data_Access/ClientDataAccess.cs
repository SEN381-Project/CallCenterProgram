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
    class ClientDataAccess
    {
        SqlConnection conn = new SqlConnection(@"DataSource=.; Initial Catalog = CallCenterDatabase; Integrated Security = SSPI");
        SqlCommand cmd;
        String query;

        public void InsertBusinessClient(int ID, string name, string surname, string email, string cellphone, string status, string role, int streetnumber, string streetname, string city, string country)
        {
            try //this part inserts the ID, name and surname into the Client table
            {
                query = @"INSERT INTO Client VALUES ('" + ID + "', '" + name + "', '" + surname + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the Client table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

            try //this part inserts the client status and role into the business client info table
            {
                query = @"INSERT INTO BusinessClientInfo VALUES ('" + ID + "', '" + status + "', '" + role + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the BusinessClientInfo table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

            try //this part inserts the client address into the client address table
            {
                query = @"INSERT INTO ClientAddress VALUES ('" + ID + "', '" + streetnumber + "', '" + streetname + "', '" + city + "', '" + country + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the ClientAddress table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

            try //this part inserts the client contact info into the ClientContactInfo table
            {
                query = @"INSERT INTO ClientAddress VALUES ('" + ID + "', '" + email + "', '" + cellphone + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the ClientContactInfo table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsertIndividualClient(int ID, string name, string surname, string email, string cellphone, string status, string role, int currentclient, int streetnumber, string streetname, string city, string country)
        {
            try //this part inserts the ID, name and surname into the Client table
            {
                query = @"INSERT INTO Client VALUES ('" + ID + "', '" + name + "', '" + surname + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the Client table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

            try //this part inserts the client status and if the client is a current client into the individual client info table
            {
                query = @"INSERT INTO IndividualClientInfo VALUES ('" + ID + "', '" + status + "', '" + currentclient + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the BusinessClientInfo table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

            try //this part inserts the client address into the client address table
            {
                query = @"INSERT INTO ClientAddress VALUES ('" + ID + "', '" + streetnumber + "', '" + streetname + "', '" + city + "', '" + country + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the ClientAddress table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

            try //this part inserts the client contact info into the ClientContactInfo table
            {
                query = @"INSERT INTO ClientAddress VALUES ('" + ID + "', '" + email + "', '" + cellphone + "')";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not insert to the ClientContactInfo table: {0}", e.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
