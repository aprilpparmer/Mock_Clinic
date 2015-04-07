using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class DiagnosesDal
    {
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

                                diag.Description = reader["Description"].ToString().Trim();
                                diag.DiagnosesId = (Int32)reader["positionID"];
                                diag.Name = reader["Name"].ToString().Trim();
                                diag.Treatment = reader["Name"].ToString().Trim();

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
                                           " (diagnoses_name, diagnoses_description, diagnoses_treatment) " +
                                           " values(@diagnoses_name, @diagnoses_description, @diagnoses_treatment)";

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
