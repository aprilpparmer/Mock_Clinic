using System;
using System.Data.SqlClient;

namespace WindowsFormsApplication.DBAccess
{
    class NorthwindDal
    {
        public static Boolean ValidNurseLogIn(String userName, String password)
        {
            
            Boolean valid = false;
            string selectStatement =
                "Select first_name, last_name, login, password, positionID FROM employees where login = '" +
                userName + "' and password = '" + password + "'";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                    String currentUser = reader["login"].ToString().Trim();
                                    String currentPassword = reader["login"].ToString().Trim();
                                    Int32 nurse = (Int32)reader["positionID"];

                                    if (currentUser == userName && currentPassword == password && nurse == 1)
                                {
                                    valid = true;
                                }
                                
                                
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

            return valid;
        }

        public static String LogIn(String userName, String password)
        {
            String name = " ";
            string selectStatement =
                "Select first_name, last_name, login, password FROM employees where login = '" +
                userName + "' and password = '" + password +"'";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                name = reader["first_name"].ToString().Trim() + " " + reader["last_name"].ToString().Trim();

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
            
            return name;

        }
    }          
          
}
