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

        /// <summary>
        /// Returns the open incidents
        /// </summary>
        /// <returns>a list of open incidents</returns>
        public static List<Incidents> GetOpenIncidents()
        {
            List<Incidents> incidentList = new List<Incidents>();

            string selectStatement =
                "SELECT ProductCode, DateOpened, c.Name as custName, " +
                "t.name as techName, Title " +
                "FROM Incidents i join Customers c " +
                "ON c.CustomerID = i.CustomerID " +
                "Left Join Technicians t ON " +
                "i.TechID = t.TechID WHERE DateClosed is null; ";

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
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return incidentList;
        }


        /// <summary>
        /// Gets the products id code
        /// </summary>
        /// <param name="name">the products name</param>
        /// <returns>the product id code</returns>
        public static string productID(String name) {
            string productCode = "";
             string selectStatement =
               "select ProductCode from Products where Name = '" + name + "'";

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

                               productCode = reader["ProductCode"].ToString();
                               
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

            return productCode;

        }

        /// <summary>
        /// Gets the customers id number
        /// </summary>
        /// <param name="name">the customers name</param>
        /// <returns>the customers id number</returns>
         public static int customerID(String name) {
            int customerID = 0;
             string selectStatement =
               "select CustomerID from Customers where Name = '"+ name +"'";

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
                                
                               string customer = reader["CustomerID"].ToString();
                               customerID = Convert.ToInt32(customer);
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

            return customerID;

        }

         /// <summary>
         /// Gets the technicians id number
         /// </summary>
         /// <param name="name">the techs name</param>
         /// <returns>the techs id number</returns>
         public static int techID(String name)
         {
             int techID = 0;
             string selectStatement =
               "select TechID from Technicians where Name = '" + name + "'";

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

                                 string customer = reader["TechID"].ToString();
                                 techID = Convert.ToInt32(customer);
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

             return techID;

         }

/// <summary>
/// Adds an incident to the database
/// </summary>
/// <param name="name">the customers anme</param>
/// <param name="product">the products anme</param>
/// <param name="Title">the incident title</param>
/// <param name="Description">the incident description</param>
    public static void AddIncident(String name, String product, String Title, String Description) {
        SqlConnection connection = TechSupportData.TechniciansDBConnection.GetConnection();
        int custID = customerID(name);
        string prodID = productID(product);
        DateTime date = DateTime.Now;
        String title = Title;
        String description = Description;

        String addStatement = "INSERT into Incidents (CustomerID, ProductCode, DateOpened, Title, Description)" +
                               "Values (@custID, @prodID, @date, @title, @description)";
       SqlCommand insertCommand = new SqlCommand(addStatement, connection);
        insertCommand.Parameters.AddWithValue("@custID", custID);
        insertCommand.Parameters.AddWithValue("@prodID", prodID);
        insertCommand.Parameters.AddWithValue("@date", date);
        insertCommand.Parameters.AddWithValue("@title", title);
        insertCommand.Parameters.AddWithValue("@description", description);

        try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
            }
        catch (SqlException ex)
        {
            throw ex;
        }
        finally
        {
            connection.Close();
         
        }
    }

        /// <summary>
        /// Gets the given incident
        /// </summary>
        /// <param name="IncidentID">the id of the incident you would like to get</param>
        /// <returns>the incident with the given id</returns>
    public static List<Incidents> GetIncident(int IncidentID)
    {
        List<Incidents> incidentList = new List<Incidents>();

        string selectStatement =
            "SELECT ProductCode, DateOpened, c.Name as custName, t.Name as techName, " +
            "Title, DateOpened, Description " +
            "FROM Incidents i join Customers c " +
            "ON c.CustomerID = i.CustomerID " +
            "Left Join Technicians t ON " +
            "i.TechID = t.TechID WHERE DateClosed is null and IncidentID = " + IncidentID;

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
                            incidents.description = reader["Description"].ToString();
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
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return incidentList;
    }

    public static void UpdateIncident(String Description, String techName, int IncidentID)
    {
        SqlConnection connection = TechSupportData.TechniciansDBConnection.GetConnection();
        String description = Description;
        int technicianID = techID(techName);

        String addStatement = "Update Incidents " +
                               "SET Description = @description, TechID = @technician "+
                               "WHERE DateClosed is Null AND IncidentID = " + IncidentID;
        SqlCommand insertCommand = new SqlCommand(addStatement, connection);
        insertCommand.Parameters.AddWithValue("@description", Description);
        insertCommand.Parameters.AddWithValue("@technician", technicianID);


        try
        {
            connection.Open();
            insertCommand.ExecuteNonQuery();
        }

        catch (SqlException ex)
        {
            throw ex;
        }
        finally
        {
            connection.Close();

        }
    }

       
        
    }
}

