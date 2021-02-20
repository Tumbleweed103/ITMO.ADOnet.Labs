using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBConnection
{
    class WorkWithDB
    {
        public static int ExecuteScalarMethod(string connectionString, string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = query;
                int number = (int)command.ExecuteScalar();
                return number;
            }
        }
    }
}
