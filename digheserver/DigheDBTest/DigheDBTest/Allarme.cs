using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class Allarme
    {
        private int IDAllarme;
        private int IDMisurazione;
        private bool Rosso;
        public Allarme(int IDAllarme,int IDMisurazione,bool Rosso)
        {
            this.IDAllarme = IDAllarme;
            this.IDMisurazione = IDMisurazione;
            this.Rosso = Rosso;
        }
    }
}
