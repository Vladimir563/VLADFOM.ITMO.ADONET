using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VLADFOM.ITMO.ADONET
{
    public class WorkWithDataBase
    {
        public static int ExecuteScalarMetod(string connectionString, string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = queryString;
                int number = (int)command.ExecuteScalar();
                return number;
            }
        }
    }
}
