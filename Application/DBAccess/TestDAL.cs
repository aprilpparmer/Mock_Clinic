using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class TestDal
    {
        
        /// <summary>
        /// Add's a test to the DB
        /// </summary>
        /// <param name="test"></param>
        public static void AddTest(Test test)
        {

            const string insertStatement = "INSERT into tests " +
                                           " (test_name) " +
                                           " values(@test_name)";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {

                        insertCommand.Parameters.AddWithValue("@test_name", test.TestName);
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
        /// Returns all tests from the database
        /// </summary>
        /// <returns></returns>
        public static List<Test> GetAllTests()
        {
            List<Test> testList = new List<Test>();
            const string selectStatement = "Select * from tests";

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
                                Test test = new Test();
                                test.TestId = (Int32)reader["testID"];
                                test.TestName = reader["test_name"].ToString().Trim();
                                testList.Add(test);

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

            return testList;
        }

        public static int DeleteTest(int testId)
        {

            string deleteStatement =
                " DELETE FROM tests " +
                " where ( testID = @testID) ";

            using (SqlConnection connection = NorthwindDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@testID", testId);
                    return deleteCommand.ExecuteNonQuery();
                }

            }
        }


        /// <summary>
        /// Updates a test
        /// </summary>
        /// <returns></returns>
        public static bool updateTest(int oldTestId, String newTestName)
        {
            string updateStatement =
                "UPDATE Tests SET " +
                  "test_name = @newTestName " +
                "WHERE testID = @oldTestID ";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection .GetConnection())
                {
                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@NewTestName", newTestName);
                        updateCommand.Parameters.AddWithValue("@oldTestID", oldTestId);

                        int count = updateCommand.ExecuteNonQuery();
                        if (count > 0)
                            return true;
                        else
                            return false;
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
        }

    }
}
