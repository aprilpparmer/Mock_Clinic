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
        public static int AddPatientVisitNotes(PatientVisitNotes note)
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

                        string selectStatement =
                            "SELECT IDENT_CURRENT('patient_visit_notes') FROM patient_visit_notes";
                        SqlCommand selectCommand =
                            new SqlCommand(selectStatement, connection);
                        int noteID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return noteID;
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

        public static void UpdatePatientNotes(PatientVisitNotes note)
        {
            string updateStatement =
                "UPDATE patient_visit_notes SET " +
                    "note = @note, employeeID = @employeeID, date = @date " +
                "WHERE visitID = @visitID AND notesID = @notesID";
            try
            {
                using (SqlConnection connection = NorthwindDbConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        //parameters
                        updateCommand.Parameters.AddWithValue("@visitID", note.VisitId);
                        updateCommand.Parameters.AddWithValue("@notesID", note.NotesId);
                        updateCommand.Parameters.AddWithValue("@note", note.Note);
                        updateCommand.Parameters.AddWithValue("@employeeID", note.EmployeeId);
                        updateCommand.Parameters.AddWithValue("@date", DateTime.Now);
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
