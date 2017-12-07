using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication52
{
    class Pojazd
    {
        protected char model;
        protected int cena;

        public Pojazd(char model, int cena)
        {
            this.model = model;
            this.cena = cena; 
        }
    }
}
