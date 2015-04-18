using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class DiagnosesDal
    {
        /// <summary>
        /// Gets a list of all diagnoses
        /// </summary>
        /// <returns></returns>
        public static List<Diagnoses> GetAllDiagnoses()
        {
            List<Diagnoses> diagList = new List<Diagnoses>();
            const string selectStatement = "Select * from diagnoses";

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
                                Diagnoses diag = new Diagnoses();
                                diag.DiagnosesId = (Int32)reader["diagnosesID"];
                                diag.Name = reader["diagnoses_name"].ToString().Trim();
                                diag.Treatment = reader["diagnoses_treatment"].ToString().Trim();
                                diag.Description = reader["diagnoses_description"].ToString().Trim();
                                diag.Enabled = (Byte)reader["enabled"];
                                diagList.Add(diag);

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

            return diagList;
        }

        /// <summary>
        /// Add's a diagnoses
        /// </summary>
        /// <param name="patient">Diagnoses diag, diag to be added</param>
        public static void AddDiagnoses(Diagnoses diag)
        {

            const string insertStatement = "INSERT into diagnoses " +
                                           " (diagnoses_name, diagnoses_description, diagnoses_treatment, enabled) " +
                                           " values(@diagnoses_name, @diagnoses_description, @diagnoses_treatment, 1)";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {

                        insertCommand.Parameters.AddWithValue("@diagnoses_name", diag.Name);
                        insertCommand.Parameters.AddWithValue("@diagnoses_description", diag.Description);
                        insertCommand.Parameters.AddWithValue("@diagnoses_treatment", diag.Treatment);
                       int rows= insertCommand.ExecuteNonQuery();
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
        /// Either deletes or sets a diagnosis that is not needed inactive based on if it's ever been used or not
        /// </summary>
        /// <param name="diagId"></param>
        /// <returns></returns>
        public static int DeleteDiag(int diagId)
        {

            string updateStatement =
                " update diagnoses " +
                " set enabled = 0 where ( diagnosesID = @diagnosesID) ";
            string deleteStatement =
                "delete from diagnoses where diagnosesID = @diagnosesID ";

            Boolean presence = checkDiagnosisPresence(diagId);
               
            try
            {
                if (presence == false) {
                    using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                    {
                        connection.Open();


                        using (SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@diagnosesID", diagId);
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
                            updateCommand.Parameters.AddWithValue("@diagnosesID", diagId);
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
        public static Diagnoses GetDiagnoses(int? diagId)
        {
            Diagnoses diag = new Diagnoses ();
            const string selectStatement = "Select * from diagnoses WHERE diagnosesID = @diagnosesID";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@diagnosesID", diagId);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                diag.DiagnosesId = (Int32)reader["diagnosesID"];
                                diag.Name = reader["diagnoses_name"].ToString().Trim();
                                diag.Description = reader["diagnoses_description"].ToString().Trim();
                                diag.Treatment = reader["diagnoses_treatment"].ToString().Trim();
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

            return diag;
        }

        /// <summary>
        /// Checks for the presence of a diagnosis ID to see if it's ever been used.
        /// </summary>
        /// <param name="diagId"></param>
        /// <returns></returns>
        private static Boolean checkDiagnosisPresence(int diagId)
        {
            Boolean presence = false;
            Diagnoses check = new Diagnoses();
            String checkStatement = "Select diagnosesID from diagnoses d join patient_visit_symptoms p on diagnoses_diagnosesID = diagnosesID where diagnosesID = @diagnosesID";

            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();


                    using (SqlCommand selectCommand = new SqlCommand(checkStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@diagnosesID", diagId);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                check.DiagnosesId = (Int32)reader["diagnosesID"];
                            }
                        }
                        if (check.DiagnosesId != 0)
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
