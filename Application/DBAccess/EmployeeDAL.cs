using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication.Model;


namespace WindowsFormsApplication.DBAccess
{
    class EmployeeDal
    {
        /// <summary>
        /// Logs a user in
        /// </summary>
        /// <param name="userName">the login name</param>
        /// <param name="password">the person's password</param>
        /// <returns>an employee object for that user if there is one, or null otherwise</returns>
        public static Employee EmployeeLogIn(String userName, String password)
        {
            Employee employeeReturn = null;
            Employee employee = new Employee();
            SimpleAES encrypt = new SimpleAES();

            String selectStatement = "Select employeeID, enabled, first_name, last_name, last_login, password, positionID, login, password from employees " 
            +"where login = @username and password = @password";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        password = encrypt.DecryptString(password);
                        selectCommand.Parameters.AddWithValue("@username", userName);
                        selectCommand.Parameters.AddWithValue("@password", password);

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
                if (employee.Login != null && employee.Login != "")
                {
                    employeeReturn = employee; 
                } else {
                    return employeeReturn;
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
            
            return employeeReturn;
        }

        /// <summary>
        /// Gets all employees
        /// </summary>
        /// <returns> a list of all employees</returns>
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

        /// <summary>
        /// Adds a new employee
        /// </summary>
        /// <param name="employee"></param>
        public static void AddEmployee(Employee employee)
        {

            const string insertStatement = "INSERT into employees " +
                                           " (address, city, dob, first_name, gender, last_name, middle_initial, positionID, phone, ssn, state, zip) " +
                                           " values(@address, @city, @dob, @first_name, @gender, @last_name, @middle_initial, @positionID, @phone, @ssn, @state, @zip)";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {

                        insertCommand.Parameters.AddWithValue("@address", employee.Address);
                        insertCommand.Parameters.AddWithValue("@city", employee.City);
                        insertCommand.Parameters.AddWithValue("@dob", employee.Dob);
                        insertCommand.Parameters.AddWithValue("@first_name", employee.FirstName);
                        insertCommand.Parameters.AddWithValue("@gender", employee.Gender);
                        insertCommand.Parameters.AddWithValue("@last_name", employee.LastName);
                        insertCommand.Parameters.AddWithValue("@positionID", employee.PositionId);
                        insertCommand.Parameters.AddWithValue("@middle_initial", employee.MiddleInitial);
                        insertCommand.Parameters.AddWithValue("@phone", employee.Phone);
                        insertCommand.Parameters.AddWithValue("@ssn", employee.Ssn);
                        insertCommand.Parameters.AddWithValue("@state", employee.State);
                        insertCommand.Parameters.AddWithValue("@zip", employee.Zip);
                        insertCommand.ExecuteNonQuery();
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
        }

        /// <summary>
        /// Updates and existing employee
        /// </summary>
        /// <param name="updatedEmployee"></param>
        /// <returns></returns>
        public static void UpdateEmployee(Employee updatedEmployee)
        {

            const string updateStatement = "Update employees set " +
                                           " address = @address , city = @city, dob = @dob, first_name= @first_name, gender = @gender ," +
                                           " last_name = @last_name, middle_initial =@middle_initial, phone = @phone, ssn =@ssn, state =@state, zip=@zip "
                                          + " where employeeID = @employeeID ";
                                           
                                        

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {

                        updateCommand.Parameters.AddWithValue("@address", updatedEmployee.Address);
                        updateCommand.Parameters.AddWithValue("@city", updatedEmployee.City);
                        updateCommand.Parameters.AddWithValue("@dob", updatedEmployee.Dob);
                        updateCommand.Parameters.AddWithValue("@first_name", updatedEmployee.FirstName);
                        updateCommand.Parameters.AddWithValue("@gender", updatedEmployee.Gender);
                        updateCommand.Parameters.AddWithValue("@last_name", updatedEmployee.LastName);
                        updateCommand.Parameters.AddWithValue("@middle_initial", updatedEmployee.MiddleInitial);
                        updateCommand.Parameters.AddWithValue("@phone", updatedEmployee.Phone);
                        updateCommand.Parameters.AddWithValue("@ssn", updatedEmployee.Ssn);
                        updateCommand.Parameters.AddWithValue("@state", updatedEmployee.State);
                        updateCommand.Parameters.AddWithValue("@zip", updatedEmployee.Zip);
                        updateCommand.Parameters.AddWithValue("@employeeID", updatedEmployee.EmployeeId);                  

                       updateCommand.ExecuteNonQuery();
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
        }

        /// <summary>
        /// Returns a list employees that match with first name and last name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public static List<Employee> searchEmployees(string lastName, string firstName)
        {
            List<Employee> employeeList = new List<Employee>();

            string selectStatement =
                "SELECT * " +
                "FROM employees " +
                "WHERE (last_name = @lastName AND first_name = @firstName)";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@lastName", lastName);
                        selectCommand.Parameters.AddWithValue("@firstName", firstName);


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
            catch (SqlException sqlException)
            {
                throw sqlException;
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return employeeList;
        }



    }          
 }
