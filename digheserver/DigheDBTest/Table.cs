using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class Table
    {
        private string Name;
        private SqlConnection connection = Database.GetConnection();

        public Table(string name)
        {
            this.Name = name;
        }

        protected string Insert(List<string> columnNames, List<string> values)
        {
            SqlCommand command = connection.CreateCommand();
            string commandText = "INSERT INTO " + Name + " (";
            foreach (string column in columnNames)
                commandText += column + ", ";
            commandText = commandText.Substring(0, commandText.Length - 2);
            commandText += ") output INSERTED.ID VALUES (";
            foreach (string value in values)
                commandText += "'" + value + "'" + ", ";
            commandText = commandText.Substring(0, commandText.Length - 2);
            commandText += ")";
            command.CommandText = commandText;
            
            return command.ExecuteScalar().ToString();
        }

        protected bool Exists(string columnName, string value)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from " + Name + " WHERE " + columnName + " = " + value;
            bool exists = false;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                exists = reader.Read();
            }
            return exists;
        }

        protected SqlDataReader LoadData(string columnName, string id)
        {
            if (!Exists(columnName, id))
                throw new Exception("Non esiste la diga");
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from " + Name + " WHERE " + columnName + " = " + id;
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            return reader;
        }
    }
}
