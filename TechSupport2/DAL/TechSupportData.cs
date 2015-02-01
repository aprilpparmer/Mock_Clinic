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
            try
            {
                string connectionString =
                    "Data Source=localhost;Initial Catalog=TechSupport;" +
                    "Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}