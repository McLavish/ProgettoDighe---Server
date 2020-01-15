using DigheDBTest.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class Diga : Table
    {
        public string IDDiga;
        public string Nome = "asd";
        public string Citta = "asd";
        public double LivelloArancio = 1;
        public double LivelloRosso = 3;

        public Diga(string IDDiga/*string Nome, string Citta, int LivelloArancio, int LivelloRosso*/) : base("Dighe")
        {
            this.IDDiga = IDDiga;
            //this.Nome = Nome;
            //this.Citta = Citta;
            //this.LivelloArancio = LivelloArancio;
            //this.LivelloRosso = LivelloRosso;
        }

        public void Insert()
        {
            List<string> columns = new List<string>();
            columns.AddRange(new string[] { "IDDiga", "Nome", "Citta", "LivelloArancio", "LivelloRosso" });
            List<string> values = new List<string>();
            values.AddRange(new string[] { IDDiga.ToString(), Nome, Citta, LivelloArancio.ToString(), LivelloRosso.ToString() });
            base.Insert(columns, values, false);
        }

        public bool Exists()
        {
            return base.Exists("IDDiga", IDDiga.ToString());
        }

        public void LoadData()
        {
            SqlDataReader row = base.LoadData("IDDiga", IDDiga.ToString());
            Nome = row["Nome"].ToString();
            Citta = row["Citta"].ToString();
            LivelloArancio = Convert.ToDouble(row["LivelloArancio"]);
            LivelloRosso = Convert.ToDouble(row["LivelloRosso"]);
            row.Close();
        }

        public static List<Diga> ElencoDighe()
        {
            List<Diga> dighe = new List<Diga>();
            SqlConnection connection = Database.DatabaseInstance.GetConnection();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Dighe";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Diga diga = new Diga(reader[0].ToString());
                    diga.LivelloArancio = Convert.ToDouble(reader["LivelloArancio"]);
                    diga.LivelloRosso = Convert.ToDouble(reader["LivelloRosso"]);
                    dighe.Add(diga);
                }
            }
            return dighe;
        }
    }
}
