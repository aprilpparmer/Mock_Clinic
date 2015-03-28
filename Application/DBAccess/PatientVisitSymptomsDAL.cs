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
                        insertCommand.Parameters.AddWithValue("@symptoms_name", symptoms.SymptomName);
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
    }
}
