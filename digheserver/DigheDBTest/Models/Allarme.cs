using DigheDBTest.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class Allarme : Table
    {
        private int IDAllarme;
        private int IDMisurazione;
        private bool Rosso;

        public Allarme(int IDMisurazione, bool Rosso) : base("Allarmi")
        {
            this.IDMisurazione = IDMisurazione;
            this.Rosso = Rosso;
        }

        public void Insert()
        {
            List<string> columns = new List<string>();
            columns.AddRange(new string[] { "IDMisurazione", "Rosso" });
            List<string> values = new List<string>();
            values.AddRange(new string[] { IDMisurazione.ToString(), Rosso.ToString() });
            IDAllarme = Convert.ToInt32(base.Insert(columns, values));
        }
    }
}
