using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication52
{
    class Autobus:Pojazd
    {
        private int iloscMiejsc;

        public Autobus(char model, int cena, int iloscMiejsc)
            :base(model,cena)
        {
            this.iloscMiejsc = iloscMiejsc;           
        }
    }
}
