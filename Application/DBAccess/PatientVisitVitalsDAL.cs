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
        //Adds a patient's vitals to a visit
        public static int AddPatientVisitVitals(PatientVisitVitals vitals)
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

                        string selectStatement =
                          "SELECT IDENT_CURRENT('patient_visit_vitals') FROM patient_visit_vitals";
                        SqlCommand selectCommand =
                          new SqlCommand(selectStatement, connection);
                        int vitalsID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return vitalsID;
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
        
        //Updates the patient's vitals
        public static void UpdatePatientVisitVitals(PatientVisitVitals vitals)
        {
            string updateStatement =
                "UPDATE patient_visit_vitals SET " +
                    "pulse = @pulse, blood_pressure = @blood_pressure, temp = @temp, " +
                    "height = @height, weight = @weight " +
                "WHERE visitID = @visitID AND vitalsID = @vitalsID";
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        //parameters
                        updateCommand.Parameters.AddWithValue("@visitID", vitals.VisitId);
                        updateCommand.Parameters.AddWithValue("@vitalsID", vitals.VitalsId);
                        updateCommand.Parameters.AddWithValue("@pulse", vitals.Pulse);
                        updateCommand.Parameters.AddWithValue("@blood_pressure", vitals.BloodPressure);
                        updateCommand.Parameters.AddWithValue("@temp", vitals.Temp);
                        updateCommand.Parameters.AddWithValue("@height", vitals.Height);
                        updateCommand.Parameters.AddWithValue("@weight", vitals.Weight);
                        updateCommand.ExecuteNonQuery();
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
