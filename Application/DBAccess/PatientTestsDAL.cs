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

        /// <summary>
        ///Updates a patient's test
        /// </summary>
        /// <param name="patientTest">Test to be updated</param>
        public static bool UpdatePatientTest(PatientTests patientTest)
        {
            string updateStatement =
                "UPDATE patient_tests SET " +
                    "test_taken = @test_taken, test_completed = @test_completed, results = @results " +
                "WHERE patient_testID = @patient_testID";
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        //parameters
                        if (patientTest.TestTaken == null) {
                            updateCommand.Parameters.AddWithValue("@test_taken", DBNull.Value);
                        }
                        else 
                        {
                            updateCommand.Parameters.AddWithValue("@test_taken", patientTest.TestTaken);
                        }
                        if (patientTest.TestCompleted == null) 
                        {
                            updateCommand.Parameters.AddWithValue("@test_completed", DBNull.Value);
                        }
                        else 
                        {
                            updateCommand.Parameters.AddWithValue("@test_completed", patientTest.TestCompleted);
                        }
                        if (patientTest.Results == "") 
                        {
                            updateCommand.Parameters.AddWithValue("@results", DBNull.Value);
                        }
                        else 
                        {
                            updateCommand.Parameters.AddWithValue("@results", patientTest.Results);
                        }
                        updateCommand.Parameters.AddWithValue("@patient_testID", patientTest.PatientTestsId);
                        int count = updateCommand.ExecuteNonQuery();
                        if (count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
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
        }
    }
}
