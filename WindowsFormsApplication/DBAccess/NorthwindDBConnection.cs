using System;
using System.Data.SqlClient;

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
    
    }
}