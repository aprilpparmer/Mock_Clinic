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


    }
}
