using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TechSupportData
{
    public static class TechniciansDBConnection
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
                    "Data Source=localhost;Initial Catalog=TechSupport;" +
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