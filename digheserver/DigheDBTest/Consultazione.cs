using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class Consultazione
    {
        private int IDConsultazione;
        private int IDOperatore;
        private int IDUltimaMisurazione;
        private DateTime DataOra;
        public Consultazione(int IDConsultazione, int IDOperatore, int IDUltimaMisurazione, DateTime DataOra)
        {
            this.IDConsultazione = IDConsultazione;
            this.IDOperatore = IDOperatore;
            this.IDUltimaMisurazione = IDUltimaMisurazione;
            this.DataOra = DataOra;
        }
    }
}
