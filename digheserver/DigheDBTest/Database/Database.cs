using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest.Database
{
    class DatabaseInstance
    {
        private const string CONNECTION_STRING = @"Server=(local);Integrated security=yes";
        private static SqlConnection connection = new SqlConnection(CONNECTION_STRING);

        public static SqlConnection GetConnection()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            return connection;
        }

        public static void CreateDatabaseIfNotExists()
        {
            if (Exists()) {
                GetConnection().ChangeDatabase("Dighe");
                return;
            }
            using (var command = GetConnection().CreateCommand())
            {
                command.CommandText = "create database Dighe";
                command.ExecuteNonQuery();
            }
            string sqlCode = Properties.Resources.sqlCode;// System.IO.File.ReadAllText(@"./sqlCode.txt");
            using (var command = GetConnection().CreateCommand())
            {
                command.CommandText = sqlCode;
                command.ExecuteNonQuery();
            }
            GetConnection().ChangeDatabase("Dighe");
        }

        public static bool Exists()
        {
            using (var command = new SqlCommand($"SELECT db_id('Dighe')", GetConnection()))
            {
                return (command.ExecuteScalar() != DBNull.Value);
            }
        }
    }
}
