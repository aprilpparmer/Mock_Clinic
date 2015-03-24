using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using PayablesData.model;

namespace OpenIncidents.DAL
{

    public static class IncidentsDAL
    {


        public static List<Incidents> GetOpenIncidents()
        {
            List<Incidents> incidentList = new List<Incidents>();

            string selectStatement =
                "SELECT ProductCode, DateOpened, c.Name," +
                "t.name, Title" +
                "FROM Incidents i join Customers c" +
                "ON c.CustomerID = i.CustomerID" +
                "Left Join Technicians t ON" +
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
                                incidents.customer = reader["c.Name"].ToString();
                                incidents.technician = reader["t.name"].ToString();
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
        /// <summary>
        /// This method uses try/catch/finally and placed closing of the resources (connection, reader) in the 
        /// finally block.
        /// 
        /// </summary>
        /// <returns>a list of Invoices</returns>
        public static List<Incidents> GetOpenIncidents2()
        {
            List<Incidents> incidentList = new List<Incidents>();
            SqlConnection connection = TechSupportData.TechniciansDBConnection.GetConnection();
            string selectStatement =
                "SELECT ProductCode, DateOpened, c.Name," +
                "t.name, Title" +
                "FROM Incidents i join Customers c" +
                "ON c.CustomerID = i.CustomerID" +
                "Left Join Technicians t ON" +
                "i.TechID = t.TechID; ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Incidents invoice = new Incidents();
                    Incidents incidents = new Incidents();
                    incidents.productCode = reader["ProductCode"].ToString();
                    incidents.openDate = (DateTime)reader["DateOpened"];
                    incidents.productCode = reader["c.Name"].ToString();
                    incidents.technician = reader["t.name"].ToString();
                    incidents.title = reader["ITitle"].ToString();
                    incidentList.Add(incidents);
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
            return incidentList;
        }

    }
}
