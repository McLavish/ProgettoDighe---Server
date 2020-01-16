using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class Operatore
    {
        private int IDOperatore;
        private string Nome;
        private string Cognome;
        private DateTime DataDiNascita;
        public Operatore(int IDOperatore, string Nome, string Cognome, DateTime DataDiNascita)
        {
            this.IDOperatore = IDOperatore;
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.DataDiNascita = DataDiNascita;
        }
    }
}
