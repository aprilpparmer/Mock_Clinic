using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class PatientTestsDal
    {
        /// <summary>
        /// Add's a test to a patient
        /// </summary>
        /// <param name="patientTest">Test to be added</param>
        public static void OrderTest(PatientTests patientTest)
        {

            const string insertStatement = "INSERT into patient_tests " +
                                           " (visitID, testID, test_ordered) " +
                                           " values(@visitID, @testID, @test_ordered)";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {

                        insertCommand.Parameters.AddWithValue("@visitID", patientTest.VisitId);
                        insertCommand.Parameters.AddWithValue("@testID", patientTest.TestId);
                        insertCommand.Parameters.AddWithValue("@test_ordered", patientTest.TestOrdered);
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
