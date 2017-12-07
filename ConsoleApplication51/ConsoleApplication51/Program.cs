using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefon telefon1 = new Telefon("Nokia", 200, true);
            Telefon telefon2 = new Telefon("LG", 700, false);
        }
    }

    class Telefon
    {
        private string marka;
        private double cena;
        private bool gps;

        public Telefon(string marka, double cena, bool gps)
        {
            this.marka = marka;
            this.cena = cena;
            this.gps = gps;
        }
    }
}
