using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication.DBAccess
{
    public class NorthwindDbConnection
    {
        /// <summary>
        /// Opens the connection
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection connection;
            try
            {
                string connectionString =
                    "Data Source=localhost;Initial Catalog=CS6232-g7;" +
                    "Integrated Security=True";
                    connection = new SqlConnection(connectionString);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return connection;
        }

        /// <summary>
        /// Helper method to test what the SQL string is being generated
        /// </summary>
        /// <param name="commandToView">SqlCommand commandToView</param>
        public static void ViewString(SqlCommand commandToView)
        {


            string query = commandToView.CommandText;

            foreach (SqlParameter p in commandToView.Parameters)
                        {
                            query = query.Replace(p.ParameterName, p.Value.ToString());
                            
                        }
 
       MessageBox.Show(@"Query." + query);
        }
    
    }
}