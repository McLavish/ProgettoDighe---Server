using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class Diga
    {
        private int IDDiga;
        private string Nome;
        private string Citta;
        private int LivelloArancio;
        private int LivelloRosso;
        public Diga(int IDDiga, string Nome, string Citta, int LivelloArancio, int LivelloRosso)
        {
            this.IDDiga = IDDiga;
            this.Nome = Nome;
            this.Citta = Citta;
            this.LivelloArancio = LivelloArancio;
            this.LivelloRosso = LivelloRosso;
        }
    }
}
