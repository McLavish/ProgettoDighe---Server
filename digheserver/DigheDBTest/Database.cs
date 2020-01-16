using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class Database
    {
        private const string CONNECTION_STRING = @"Server=(local);Database=Dighe;Integrated security=yes";
        private static SqlConnection connection = new SqlConnection(CONNECTION_STRING);

        public static SqlConnection GetConnection()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            return connection;
        }
    }
}
