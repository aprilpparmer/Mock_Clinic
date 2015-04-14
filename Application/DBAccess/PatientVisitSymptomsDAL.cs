using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class PatientVisitSymptomsDal
    {
        public static int AddPatientVisitSymptoms(PatientVisitSymptoms symptoms)
        {
            string insertStatement =
              "INSERT patient_visit_symptoms " +
                   "(visitID, symptom_name) " +
              "VALUES (@visitID, @symptom_name)";
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        //parameters
                        insertCommand.Parameters.AddWithValue("@visitID", symptoms.VisitId);
                        insertCommand.Parameters.AddWithValue("@symptom_name", symptoms.SymptomName);
                        insertCommand.ExecuteNonQuery();

                        string selectStatement =
                            "SELECT IDENT_CURRENT('patient_visit_symptoms') FROM patient_visit_symptoms";
                        SqlCommand selectCommand =
                            new SqlCommand(selectStatement, connection);
                        int symptomID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return symptomID;
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
        /// Updates a Diag for a patient
        /// 
        /// </summary>
        /// <param name="symptoms">PatientVisitSymptoms symtpoms</param>
        public static void UpdatePatientDiagnoses(PatientVisitSymptoms symptoms)
        {
            string updateStatement =
                "UPDATE patient_visit_symptoms SET " +
                    "diagnoses_diagnosesID = @diagnoses_diagnosesID " +
                "WHERE visitID = @visitID AND symptomID = @symptomID";
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        //parameters
                        updateCommand.Parameters.AddWithValue("@visitID", symptoms.VisitId);
                        updateCommand.Parameters.AddWithValue("@symptomID", symptoms.SymptomId);
                        updateCommand.Parameters.AddWithValue("@diagnoses_diagnosesID", symptoms.DiagnosesID);
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

        public static PatientVisitSymptoms GetAllPatientSymtomsByVisitId(int visitId)
        {
            PatientVisitSymptoms patientVisitSymptoms = new PatientVisitSymptoms();
            const string selectStatement = "Select * from patient_visit_symptoms WHERE visitID = @visitID";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@visitID", visitId);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                patientVisitSymptoms.SymptomId = (Int32)reader["symptomID"];
                                patientVisitSymptoms.VisitId = (Int32)reader["visitID"];
                                patientVisitSymptoms.SymptomName = reader["symptom_name"].ToString().Trim();
                                if (reader["diagnoses_diagnosesID"] != DBNull.Value)
                                {
                                    patientVisitSymptoms.DiagnosesID = (Int32)reader["diagnoses_diagnosesID"];
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

            return patientVisitSymptoms;   
        }


        public static void UpdatePatientSymptoms(PatientVisitSymptoms symptoms)
        {
            string updateStatement =
                "UPDATE patient_visit_symptoms SET " +
                    "symptom_name = @symptom_name " +
                "WHERE symptomID = @symptomID";
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        //parameters
                        //updateCommand.Parameters.AddWithValue("@visitID", symptoms.VisitId);
                        updateCommand.Parameters.AddWithValue("@symptomID", symptoms.SymptomId);
                        updateCommand.Parameters.AddWithValue("@symptom_name", symptoms.SymptomName);
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


        internal static bool UpdateDiagnoses(int visitID, int? diag, string symptom)
        {
            string updateStatement =
               "UPDATE patient_visit_symptoms SET " +
                   "diagnoses_diagnosesID = @diagnoses_diagnosesID " +
               "WHERE visitID = @visitID AND symptom_name = @symptom_name";
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        //parameters
                        updateCommand.Parameters.AddWithValue("@visitID", visitID);
                        updateCommand.Parameters.AddWithValue("@symptom_name", symptom);
                        updateCommand.Parameters.AddWithValue("@diagnoses_diagnosesID", diag);
                        int count = updateCommand.ExecuteNonQuery();
                          if (count > 0)
                            return true;
                        else
                            return false;
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





