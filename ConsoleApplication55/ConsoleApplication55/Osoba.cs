using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    abstract class Osoba
    {
        protected int wiek;

        public Osoba()
        {

        }

        public Osoba(int wiek)
        {
            this.wiek = wiek;
        }

        public abstract string Ulga(bool p1);
    }
}
