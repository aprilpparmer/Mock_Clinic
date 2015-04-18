using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        /// Gets a test based on ID
        /// </summary>
        /// <param name="patientTest">Test to be added</param>
        public static PatientTests getTest(int patientTestID)
        {

            const string selectStatement = "Select * from patient_tests where patient_testID = @patientTestID";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@patientTestID", patientTestID);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            PatientTests theTest = new PatientTests();;
                            while (reader.Read())
                            {
                                theTest.PatientTestsId = (Int32)reader["patient_testID"];
                                theTest.TestId = (Int32)reader["testID"];
                                theTest.VisitId = (Int32)reader["visitID"];

                                if (reader["results"] != DBNull.Value)
                                {
                                    theTest.Results = reader["results"].ToString().Trim();
                                }
                                if (reader["test_completed"] != DBNull.Value)
                                {
                                    theTest.TestCompleted = (DateTime)reader["test_completed"];
                                }
                                if (reader["test_ordered"] != DBNull.Value)
                                {
                                    theTest.TestOrdered = (DateTime)reader["test_ordered"];
                                }
                                if (reader["test_taken"] != DBNull.Value)
                                {
                                    theTest.TestTaken = (DateTime)reader["test_taken"];
                                }
                                return theTest;
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

            return null;
        }
       


        /// <summary>
        ///Updates a patient's test
        /// </summary>
        /// <param name="patientTest">Test to be updated</param>
        public static bool UpdatePatientTest(PatientTests oldPatientTest, PatientTests newPatientTest)
        {
            string updateTemp =
                "UPDATE patient_tests SET ";
            string whereTemp = " WHERE patient_testID = @patient_testID ";
            if ((newPatientTest.TestTaken != null))
            {
                updateTemp = updateTemp + " test_taken = @test_taken ";
                if (oldPatientTest.TestTaken == null)
                {
                    whereTemp = whereTemp + " AND test_taken is NULL  ";
                }
                else
                {
                    whereTemp = whereTemp + " AND test_taken = @oldTestTaken ";
                }
            }


            if ((newPatientTest.TestTaken != null) && (newPatientTest.TestCompleted != null))
            {
                updateTemp = updateTemp + ", ";
                whereTemp = whereTemp + " AND ";
            }



            if ((newPatientTest.TestCompleted != null))
            {
                updateTemp = updateTemp + " test_completed = @test_completed, results = @results";
                
                if (oldPatientTest.TestCompleted == null)
                {
                    whereTemp = whereTemp + " test_completed is NULL AND  results is NULL";
                }
                else
                {
                    whereTemp = whereTemp + " test_completed = @oldtest_completed AND  results = @oldresults ";
                }
            } 
            string updateStatement = updateTemp + whereTemp;
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        if ((newPatientTest.TestTaken != null) && (oldPatientTest.TestTaken == null))
                        {
                            updateCommand.Parameters.AddWithValue("@test_taken", newPatientTest.TestTaken);
                        }
                        else if ((newPatientTest.TestTaken != null) && (oldPatientTest.TestTaken != null))
                        {
                            updateCommand.Parameters.AddWithValue("@test_taken", newPatientTest.TestTaken);
                            updateCommand.Parameters.AddWithValue("@oldTestTaken", oldPatientTest.TestTaken);
                        }

                        if ((newPatientTest.TestCompleted != null) && (oldPatientTest.TestCompleted == null))
                        {
                            updateCommand.Parameters.AddWithValue("@test_completed", newPatientTest.TestCompleted);
                            updateCommand.Parameters.AddWithValue("@results", newPatientTest.Results);
                        }
                        else if ((newPatientTest.TestCompleted != null) && (oldPatientTest.TestCompleted != null))
                        {
                            updateCommand.Parameters.AddWithValue("@test_completed", newPatientTest.TestCompleted);
                            updateCommand.Parameters.AddWithValue("@results", newPatientTest.Results);
                            updateCommand.Parameters.AddWithValue("@oldtest_completed", oldPatientTest.TestCompleted);
                            updateCommand.Parameters.AddWithValue("@oldresults", oldPatientTest.Results);

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

        /// <summary>
        /// Delete's an ordered test 
        /// </summary>
        /// <param name="patientTestID">The patient test id that needs to be deleted</param>
        /// <returns></returns>
        public static int DeleteOrderedTest(int patientTestID)
        {

            string deleteStatement =
                " DELETE FROM patient_tests " +
                " where ( patient_testID = @patientTestID) ";
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@patientTestID", patientTestID);
                        return deleteCommand.ExecuteNonQuery();
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
