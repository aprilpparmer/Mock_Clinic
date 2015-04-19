using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class PatientAllergiesDal
    {
        public static List<PatientAllergies> GetAllPatientsAllergieses(int patientId)
        {
            List<PatientAllergies> patientAllergieList = new List<PatientAllergies>();

            string selectStatement = " Select patient_allergies.*, allergies.allergy_name as allergyName from patient_allergies " +
                                     " inner join allergies on allergies.allergyID = patient_allergies.allergyID " +
                                     " where patientID = " + patientId;

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
                                PatientAllergies allergy = new PatientAllergies();

                                allergy.AllergyId = (Int32)reader["allergyID"];
                                allergy.PatientAllergiesId = (Int32)reader["patientallergyID"];
                                allergy.PatientId = (Int32)reader["allergyID"];
                                allergy.AllergyName = reader["allergyName"].ToString().Trim();
                                patientAllergieList.Add(allergy);

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

            return patientAllergieList;
        }

        //Adds a new patient allergy
        public static int AddPatientAllergy(PatientAllergies allergies)
        {
            string insertStatement =
              "INSERT patient_allergies " +
                   "(patientID, allergyID, allergy_name) " +
              "VALUES (@patientID, @allergyID, @allergy_name)";
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        //parameters
                        insertCommand.Parameters.AddWithValue("@patientID", allergies.PatientId);
                        insertCommand.Parameters.AddWithValue("@allergyID", allergies.AllergyId);
                        insertCommand.Parameters.AddWithValue("@allergy_name", allergies.AllergyName);
                        insertCommand.ExecuteNonQuery();

                        string selectStatement =
                            "SELECT IDENT_CURRENT('patient_allergies') FROM patient_allergies";
                        SqlCommand selectCommand =
                            new SqlCommand(selectStatement, connection);
                        int confirmation = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return confirmation;
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
