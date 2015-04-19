using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class AllergyDAL
    {
        /// <summary>
        /// Add's an allergy to the db
        /// </summary>
        /// <param name="allergy">The allergy to be added</param>
        public static void AddAllergy(Allergy allergy)
        {
            const string insertStatement = "INSERT into allergies " +
                                           " (allergy_name, enabled) " +
                                           " values(@allergy_name, @enabled)";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {

                        insertCommand.Parameters.AddWithValue("@allergy_name", allergy.AllergyName);
                        insertCommand.Parameters.AddWithValue("@enabled", 1);
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
        /// Returns all allergies from the database
        /// </summary>
        /// <returns></returns>
        public static List<Allergy> GetAllAllergies()
        {
            List<Allergy> allergyList = new List<Allergy>();
            const string selectStatement = "Select * from allergies";

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
                                Allergy allergy = new Allergy();
                                allergy.AllergyID = (Int32)reader["allergyID"];
                                allergy.AllergyName = reader["allergy_name"].ToString().Trim();
                                allergy.Enabled = (Byte)reader["enabled"];
                                allergyList.Add(allergy);

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

            return allergyList;
        }

        public static int DeleteAllergy(int allergyId)
        {
            string deleteStatement =
                 " DELETE FROM allergies " +
                 " where ( allergyID = @allergyID) ";

            using (SqlConnection connection = NorthwindDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@allergyID", allergyId);
                    return deleteCommand.ExecuteNonQuery();
                }

            }
        
        }
    }
}
