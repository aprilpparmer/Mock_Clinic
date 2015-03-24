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
                                patient.Gender = (char)reader["gender"];
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

    }
}
