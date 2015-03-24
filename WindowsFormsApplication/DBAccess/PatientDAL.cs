using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class PatientDal
    {
        public static List<Patient> GetAllPatients()
        {
            List<Patient> patientList = new List<Patient>();
            const string selectStatement = "Select * from patients";

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
                                Patient patient = new Patient();

                                patient.PatientId = (Int32)reader["patientID"];
                                patient.Address = reader["address"].ToString().Trim();
                                patient.City = reader["city"].ToString().Trim();
                                patient.Dob = (DateTime)reader["dob"];
                                patient.FirstName = reader["first_name"].ToString().Trim();
                                patient.Gender = reader["gender"].ToString().Trim();
                                patient.LastName = reader["last_name"].ToString().Trim();
                                patient.MiddleInitial = reader["middle_initial"].ToString().Trim();
                                patient.HomePhone = reader["home_phone"].ToString().Trim();
                                patient.WorkPhone = reader["work_phone"].ToString().Trim();
                                patient.Ssn = (Int32)reader["ssn"];
                                patient.State = reader["state"].ToString().Trim();
                                patient.Zip = (Int32)reader["zip"];
                                patient.Child = reader["child"].ToString().Trim();
                                patient.MotherId = (Int32)reader["motherID"];
                                patient.FatherId = (Int32)reader["fatherID"];
                                patientList.Add(patient);

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

            return patientList;
        }

        public static void AddPatients(Patient patient)
        {
            //string dateNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            const string insertStatement = "INSERT into patients " +
                                           " (patientID, address, city, dob, first_name, gender, last_name, middle_initial, home_phone, work_phone, ssn, state, zip) " +
                                           " values(@patientID, @address, @city, @dob, @first_name, @gender, @last_name, @middle_initial, @home_phone, @work_phone, @ssn, @state, @zip)";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {

                        insertCommand.Parameters.AddWithValue("@patientID", patient.PatientId);
                        insertCommand.Parameters.AddWithValue("@address", patient.Address);
                        insertCommand.Parameters.AddWithValue("@city", patient.City);
                        insertCommand.Parameters.AddWithValue("@dob", patient.Dob);
                        insertCommand.Parameters.AddWithValue("@first_name", patient.FirstName);
                        insertCommand.Parameters.AddWithValue("@gender", patient.Gender);
                        insertCommand.Parameters.AddWithValue("@last_name", patient.LastName);
                        insertCommand.Parameters.AddWithValue("@middle_initial", patient.MiddleInitial);
                        insertCommand.Parameters.AddWithValue("@home_phone", patient.HomePhone);
                        insertCommand.Parameters.AddWithValue("@work_phone", patient.WorkPhone);
                        insertCommand.Parameters.AddWithValue("@ssn", patient.Ssn);
                        insertCommand.Parameters.AddWithValue("@state", patient.State);
                        insertCommand.Parameters.AddWithValue("@zip", patient.Zip);
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
    }
}
