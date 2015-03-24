using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class EmployeeDal
    {
        public static Employee ValidNurseLogIn(String userName, String password)
        {
            Employee employee = new Employee();

            String selectStatement = "Select employeeID, enabled, first_name, last_name, last_login, password, positionID, login, password from employees where login = '" + userName
              + "' and password = '" + password + "'";

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
                                employee.EmployeeId = (Int32)reader["employeeID"];
                                employee.Enabled = (Byte)reader["enabled"];
                                employee.FirstName = reader["first_name"].ToString().Trim();
                                employee.LastLogin = reader["last_login"].ToString().Trim();
                                employee.LastName = reader["last_name"].ToString().Trim();
                                employee.Login = reader["login"].ToString().Trim();
                                employee.Password = reader["password"].ToString().Trim();
                                employee.PositionId = (Int32)reader["positionID"];                              
                                
                            }
                        }
                                selectStatement = " Update employees SET last_login = getdate() where employeeID = " + employee.EmployeeId;
                                SqlCommand selectCommand2 = new SqlCommand(selectStatement, connection);
                                selectCommand2.ExecuteNonQuery();

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

            return employee;
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
                                employee.Enabled = (Byte)reader["enabled"];
                                employee.FirstName = reader["first_name"].ToString().Trim();
                                employee.Gender = reader["gender"].ToString().Trim();
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
    }
      
          
}
