using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class OperatorePerDiga
    {
        private int IDOperatorePerDiga;
        private int IDOperatore;
        private int IDDiga;
        private DateTime InizioContratto;
        private DateTime FineContratto;
        public OperatorePerDiga(int IDOperatorePerDiga, int IDOperatore, int IDDiga, DateTime InizioContratto, DateTime FineContratto)
        {
            this.IDOperatorePerDiga = IDOperatorePerDiga;
            this.IDOperatore = IDOperatore;
            this.IDDiga = IDDiga;
            this.InizioContratto = InizioContratto;
            this.FineContratto = FineContratto;
        }
    }
}
