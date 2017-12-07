using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    class Baza:IWyszukiwanie
    {
        private int nazwa;

        public Baza(int nazwa)
        {
            this.nazwa = nazwa;
        }

        public string WyszNr(int p1, int p2)
        {
            return "numer";
        }

        public bool WyszTekst(string p3)
        {
            return false;
        }
    }
}
