using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PayablesData.model;
using System.Collections;

namespace OpenIncidents.DAL
{

    public static class IncidentsDAL
    {


        public static List<Incidents> GetOpenIncidents()
        {
            List<Incidents> incidentList = new List<Incidents>();

            string selectStatement =
                "SELECT ProductCode, DateOpened, c.Name as custName, " +
                "t.name as techName, Title " +
                "FROM Incidents i join Customers c " +
                "ON c.CustomerID = i.CustomerID " +
                "Left Join Technicians t ON " +
                "i.TechID = t.TechID; ";

            try
            {
                using (SqlConnection connection = TechSupportData.TechniciansDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Incidents incidents = new Incidents();
                                incidents.productCode = reader["ProductCode"].ToString();
                                incidents.openDate = (DateTime)reader["DateOpened"];
                                incidents.customer = reader["custName"].ToString();
                                incidents.technician = reader["techName"].ToString();
                                incidents.title = reader["Title"].ToString();
                                incidentList.Add(incidents);
                            }
                        }
                    }
                }


            }
            catch (SqlException ex)
            {
                //exceptions are thrown to the controller, then to the view
                //Please make sure that do not use MessageBox.Show(ex.Message) in the DAL
                //because it couples the DAL with the view
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return incidentList;
        }


        public static List<Incidents> GetCustomers()
        {
            List<Incidents> customerList = new List<Incidents>();
            SqlConnection connection = TechSupportData.TechniciansDBConnection.GetConnection();

            SqlCommand selectCommand = new SqlCommand();
            selectCommand.Connection = connection;
            selectCommand.CommandText = "GetCustomer";
            selectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = null;
              try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Incidents invoice = new Incidents();
                    Incidents incidents = new Incidents();
                    incidents.customer = reader["c.Name"].ToString();
                    customerList.Add(incidents);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return customerList;
        }

        }
    }

