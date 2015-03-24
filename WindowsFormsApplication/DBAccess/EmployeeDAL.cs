using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class EmployeeDal
    {
        public static Boolean ValidNurseLogIn(String userName, String password)
        {
            string selectStatement =
                "Select first_name, last_name, login, password, positionID FROM employees where login = '" +
                userName + "' and password = '" + password + "' and positionID = 1 ";

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

                                return  true;
                                
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

            return false;
        }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            const string selectStatement = "Select * from employees";

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
                                Employee employee = new Employee();

                                employee.Address = reader["address"].ToString().Trim();
                                employee.City = reader["city"].ToString().Trim();
                                employee.Dob = (DateTime)reader["dob"];
                                employee.EmployeeId = (Int32)reader["employeeID"];
                                employee.Enabled = (Int32)reader["enabled"];
                                employee.FirstName = reader["first_name"].ToString().Trim();
                                employee.Gender = (char)reader["gender"];
                                employee.LastLogin = reader["last_login"].ToString().Trim();
                                employee.LastName = reader["last_name"].ToString().Trim();
                                employee.Login = reader["login"].ToString().Trim();
                                employee.MiddleInitial = reader["middle_initial"].ToString().Trim();
                                employee.Password = reader["password"].ToString().Trim();
                                employee.Phone = reader["phone"].ToString().Trim();
                                employee.PositionId = (Int32)reader["positionID"];
                                employee.Ssn = (Int32)reader["ssn"];
                                employee.State = reader["state"].ToString().Trim();
                                employee.Zip = (Int32)reader["zip"];
                                employeeList.Add(employee);

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

            return employeeList;
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
