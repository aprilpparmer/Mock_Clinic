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

        /// <summary>
        /// Deletes unsed allergies or sets an allergy inactive if it's been used
        /// </summary>
        /// <param name="allergyId"></param>
        /// <returns>sucess value</returns>
        public static int DeleteAllergy(int allergyId)
        {
            string updateStatement =
                " update allergies " +
                " set enabled = 0 where ( allergyID = @allergyID) ";

            string deleteStatement =
                 " DELETE FROM allergies " +
                 " where ( allergyID = @allergyID) ";

            Boolean presence = checkAllergyPresence(allergyId);

            try
            {
                if (presence == false)
                {
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
                else
                {
                    using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                    {
                        connection.Open();


                        using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@allergyID", allergyId);
                            return updateCommand.ExecuteNonQuery();

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
        /// Checks the DB to see if an allergy has been used
        /// </summary>
        /// <param name="allergyId"></param>
        /// <returns>true or false</returns>
        private static Boolean checkAllergyPresence(int allergyId)
        {
            Boolean presence = false;
            Allergy check = new Allergy();
            String checkStatement = "Select a.allergyID from allergies a join patient_allergies p on a.allergyID = p.allergyID where p.allergyID = @allergyID";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(checkStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@allergyID", allergyId);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                check.AllergyID = (Int32)reader["allergyID"];
                            }
                        }
                        if (check.AllergyID != 0)
                        {
                            presence = true;
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
            return presence;
        }
    }
}
