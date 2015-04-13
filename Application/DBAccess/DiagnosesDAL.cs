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

        public static int DeleteDiag(int diagId)
        {

            string deleteStatement =
                " update diagnoses " +
                " set enabled = 0 where ( diagnosesID = @diagnosesID) ";
            // Need to find a way to delete only if its not in the patient_visit_symptoms tabel.
                   // "and diagnosesID != (Select diagnoses_diagnosesID from patient_visit_symptoms where diagnoses_diagnosesID = @diagnosesID)";
                
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

    }
}
