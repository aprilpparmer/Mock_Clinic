using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication2.DBAccess
{
    public class NorthwindDBConnection
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