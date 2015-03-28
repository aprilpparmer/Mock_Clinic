using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class PatientVisitDal
    {
      public static int AddPatientVisit(PatientVisit patientVisit)
        {
          string insertStatement =
            "INSERT patient_visit " +
                 "(patientID, visit_date, appt_date, doctorID, nurseID) " +
            "VALUES (@patientID, @visit_date, @appt_date, @doctorID, @nurseID)";
          try
          {
              using (SqlConnection connection = NorthwindDbConnection.GetConnection())
              {
                  connection.Open();
                  using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                  {
                      //parameters
                      insertCommand.Parameters.AddWithValue("@patientID", patientVisit.PatientId);
                      insertCommand.Parameters.AddWithValue("@visit_date", patientVisit.VisitDate);
                      if (patientVisit.ApptDate == null)
                      {
                          insertCommand.Parameters.AddWithValue("@appt_date", DBNull.Value);
                      }
                      else
                      {
                          insertCommand.Parameters.AddWithValue("@appt_date", patientVisit.ApptDate);
                      }
                      insertCommand.Parameters.AddWithValue("@doctorID", patientVisit.DoctorId);
                      insertCommand.Parameters.AddWithValue("@nurseID", patientVisit.NurseId);
                      insertCommand.ExecuteNonQuery();

                      string selectStatement =
                          "SELECT IDENT_CURRENT('patient_visit') FROM patient_visit";
                      SqlCommand selectCommand =
                          new SqlCommand(selectStatement, connection);
                      int visitID = Convert.ToInt32(selectCommand.ExecuteScalar());
                      return visitID;
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
