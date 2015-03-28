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
        public static void AddPatientVisitSymptoms(PatientVisitSymptoms symptoms)
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
