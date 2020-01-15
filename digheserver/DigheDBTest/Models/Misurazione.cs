using DigheDBTest.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class Misurazione : Table
    {
        public int IDMisurazione;
        public int misurazione;
        public string IDDiga;
        public DateTime Data;

        public Misurazione(string IDDiga, int Misurazione, DateTime Data) : base("Misurazioni")
        {
            this.IDDiga = IDDiga;
            this.misurazione = Misurazione;
            this.Data = Data;
        }

        public void Insert()
        {
            List<string> columns = new List<string>();
            columns.AddRange(new string[] { "IDDiga", "Misurazione", "Data" });
            List<string> values = new List<string>();
            values.AddRange(new string[] { IDDiga.ToString(), misurazione.ToString(), Data.ToString() });
            IDMisurazione = Convert.ToInt32(base.Insert(columns, values));
        }
    }
}
