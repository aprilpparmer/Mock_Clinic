using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class PatientVisitVitalsDal
    {
        public static void AddPatientVisitVitals(PatientVisitVitals vitals)
        {
            string insertStatement =
              "INSERT patient_visit_vitals " +
                   "(visitID, blood_pressure, temp, pulse, height, weight) " +
              "VALUES (@visitID, @blood_pressure, @temp, @pulse, @height, @weight)";
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        //parameters
                        insertCommand.Parameters.AddWithValue("@visitID", vitals.VisitId);
                        insertCommand.Parameters.AddWithValue("@blood_pressure", vitals.BloodPressure);
                        insertCommand.Parameters.AddWithValue("@temp", vitals.Temp);
                        insertCommand.Parameters.AddWithValue("@pulse", vitals.Pulse);
                        insertCommand.Parameters.AddWithValue("@height", vitals.Height);
                        insertCommand.Parameters.AddWithValue("@weight", vitals.Weight);
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
