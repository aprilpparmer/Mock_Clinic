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
            string selectStatement =
                "Select * from diagnoses";
            

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
                               // diag.t
                            


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
    }
}
