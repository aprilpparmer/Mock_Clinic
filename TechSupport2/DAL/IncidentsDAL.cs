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
       
        
    }
}

