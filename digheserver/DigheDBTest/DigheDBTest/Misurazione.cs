using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigheDBTest
{
    class Misurazione
    {
        private int IDMisurazione;
        private int misurazione;
        private int IDDiga;

        public Misurazione(int IDMisurazione,int IDDiga, int misurazione)
        {
            this.IDMisurazione = IDMisurazione;
            this.IDDiga = IDDiga;
            this.misurazione = misurazione;
        }
    }
}
