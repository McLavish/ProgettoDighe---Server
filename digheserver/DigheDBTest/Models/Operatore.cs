using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using DigheDBTest.Database;

namespace DigheDBTest
{
    class Operatore : Table
    {
        public string Username;
        private string Nome;
        private string Cognome;
        private DateTime DataDiNascita;

        public Operatore(string username) : base("Operatori")
        {
            this.Username = username;
        }
        public Operatore(string Username, string Nome, string Cognome, DateTime DataDiNascita) : base("Operatori")
        {
            this.Username = Username;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.DataDiNascita = DataDiNascita;
        }

        public bool Login(string password)
        {
            SqlDataReader row = base.LoadData("Username", Username);
            string storedPassword = row["password"].ToString();
            row.Close();
            return DigheDBTest.Database.Hash.GetHashString(password) == storedPassword;
        }

        public bool Register(string password)
        {
            if (Exists())
                return false;

            List<string> columns = new List<string>();
            columns.AddRange(new string[] { "Username", "Password", "Nome", "Cognome", "DataNascita" });
            List<string> values = new List<string>();
            values.AddRange(new string[] { Username, Hash.GetHashString(password), Nome, Cognome, DataDiNascita.ToString() });
            base.Insert(columns, values, false);
            return true;
        }

        public bool Exists()
        {
            return base.Exists("Username", Username);
        }
    }
}
