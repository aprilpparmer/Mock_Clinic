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
        public static bool UpdatePatientTest(PatientTests oldPatientTest, PatientTests newPatientTest)
        {
            string updateStatement =
                "UPDATE patient_tests SET " +
                    "test_taken = @test_taken, test_completed = @test_completed, results = @results " +
                "WHERE patient_testID = @patient_testID " + 
                    "AND test_taken = @oldTestTaken " +
                    "AND test_completed = @oldTestCompleted " +
                    "AND results = @oldResults";
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        if (oldPatientTest.TestTaken == null) 
                        {
                            updateCommand.Parameters.AddWithValue("@oldTestTaken", DBNull.Value);
                        }
                        else
                        {
                            updateCommand.Parameters.AddWithValue("@oldTestTaken", oldPatientTest.TestTaken);
                        }
                        if (oldPatientTest.TestCompleted == null)
                        {
                            updateCommand.Parameters.AddWithValue("@oldTestCompleted", DBNull.Value);
                        }
                        else
                        {
                            updateCommand.Parameters.AddWithValue("@oldTestCompleted", oldPatientTest.TestCompleted);
                        }
                        if (oldPatientTest.Results == null)
                        {
                            updateCommand.Parameters.AddWithValue("@oldResults", DBNull.Value);
                        }
                        else
                        {
                            updateCommand.Parameters.AddWithValue("@oldResults", oldPatientTest.Results);
                        }
                        //parameters
                        if (newPatientTest.TestTaken == null) {
                            updateCommand.Parameters.AddWithValue("@test_taken", DBNull.Value);
                        }
                        else 
                        {
                            updateCommand.Parameters.AddWithValue("@test_taken", newPatientTest.TestTaken);
                        }
                        if (newPatientTest.TestCompleted == null) 
                        {
                            updateCommand.Parameters.AddWithValue("@test_completed", DBNull.Value);
                        }
                        else 
                        {
                            updateCommand.Parameters.AddWithValue("@test_completed", newPatientTest.TestCompleted);
                        }
                        if (newPatientTest.Results == "") 
                        {
                            updateCommand.Parameters.AddWithValue("@results", DBNull.Value);
                        }
                        else 
                        {
                            updateCommand.Parameters.AddWithValue("@results", newPatientTest.Results);
                        }
                        updateCommand.Parameters.AddWithValue("@patient_testID", newPatientTest.PatientTestsId);
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
