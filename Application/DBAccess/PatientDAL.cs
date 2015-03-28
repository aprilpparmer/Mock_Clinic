﻿using System;
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
                                           " (address, city, dob, first_name, gender, last_name, middle_initial, home_phone, work_phone, ssn, state, zip) " +
                                           " values(@address, @city, @dob, @first_name, @gender, @last_name, @middle_initial, @home_phone, @work_phone, @ssn, @state, @zip)";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {

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





        /// <summary>
        /// Returns a list of patients that match with first name and last name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="dateOfBirth"></param>
        /// <returns></returns>
        public static List<Patient> getPatientsByNameAndDOB(string firstName, string lastName)
        {
            List<Patient> patients = new List<Patient>();

            string selectStatement =
                "SELECT * " +
                "FROM patients " +
                "WHERE last_name = @lastName AND first_name = @firstName";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@lastName", lastName);
                        selectCommand.Parameters.AddWithValue("@firstName", firstName);

                        using (SqlDataReader dataReader = selectCommand.ExecuteReader())
                        {
                            
                            int patientIDOrdinal = dataReader.GetOrdinal("patientID");
                            int ssnOrdinal = dataReader.GetOrdinal("ssn");
                            int last_nameOrdinal = dataReader.GetOrdinal("last_name");
                            int middle_initialOrdinal = dataReader.GetOrdinal("middle_initial");
                            int first_nameOrdinal = dataReader.GetOrdinal("first_name");
                            int dobOrdinal = dataReader.GetOrdinal("dob");
                            int genderOrdinal = dataReader.GetOrdinal("gender");
                            int addressOrdinal = dataReader.GetOrdinal("address");
                            int cityOrdinal = dataReader.GetOrdinal("city");
                            int stateOrdinal = dataReader.GetOrdinal("state");
                            int zipOrdinal = dataReader.GetOrdinal("zip");
                            int home_phoneOrdinal = dataReader.GetOrdinal("home_phone");
                            int work_phoneOrdinal = dataReader.GetOrdinal("work_phone");
                            int childOrdinal = dataReader.GetOrdinal("child");
                            int motherIDOrdinal = dataReader.GetOrdinal("motherID");
                            int fatherIDOrdinal = dataReader.GetOrdinal("fatherID");

                            while (dataReader.Read())
                            {
                                Patient patient = new Patient();

                                patient.PatientId = dataReader.GetInt32(patientIDOrdinal);
                                patient.Ssn = dataReader.GetInt32(ssnOrdinal);
                                patient.LastName = dataReader.GetString(last_nameOrdinal);
                                

                                if (!dataReader.IsDBNull(middle_initialOrdinal))
                                    patient.MiddleInitial = dataReader.GetString(middle_initialOrdinal);
                                else
                                   patient.MiddleInitial = string.Empty;

                                patient.FirstName = dataReader.GetString(first_nameOrdinal);
                                patient.Dob = dataReader.GetDateTime(dobOrdinal);
                                patient.Gender = dataReader.GetString(genderOrdinal);
                                patient.Address = dataReader.GetString(addressOrdinal);
                                patient.City = dataReader.GetString(cityOrdinal);
                                patient.State = dataReader.GetString(stateOrdinal);
                                patient.Zip = dataReader.GetInt32(zipOrdinal);
                                patient.HomePhone = dataReader.GetString(home_phoneOrdinal);

                                if (!dataReader.IsDBNull(work_phoneOrdinal))
                                    patient.WorkPhone = dataReader.GetString(work_phoneOrdinal);
                                else
                                   patient.WorkPhone = string.Empty;

                                if (!dataReader.IsDBNull(childOrdinal))
                                    patient.Child = dataReader.GetString(childOrdinal);
                                else
                                   patient.Child = string.Empty;

                                if (!dataReader.IsDBNull(motherIDOrdinal))
                                    patient.MotherId = dataReader.GetInt32(motherIDOrdinal);
                                else
                                   patient.MotherId = -1;

                                 if (!dataReader.IsDBNull(fatherIDOrdinal))
                                    patient.FatherId = dataReader.GetInt32(fatherIDOrdinal);
                                else
                                   patient.FatherId = -1;

                                patients.Add(patient);

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

            return patients;
        }
    }
}
