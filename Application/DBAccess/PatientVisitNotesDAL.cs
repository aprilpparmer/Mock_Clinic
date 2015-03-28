using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.DBAccess
{
    class PatientVisitNotesDal
    {
        public static void AddPatientVisitNotes(PatientVisitNotes note)
        {
            string insertStatement =
              "INSERT patient_visit_notes " +
                   "(employeeID, visitID, note, date) " +
              "VALUES (@employeeID, @visitID, @note, @date)";
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        //parameters
                        insertCommand.Parameters.AddWithValue("@employeeID", note.EmployeeId);
                        insertCommand.Parameters.AddWithValue("@visitID", note.VisitId);
                        insertCommand.Parameters.AddWithValue("@note", note.Note);
                        insertCommand.Parameters.AddWithValue("@date", DateTime.Now);
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
