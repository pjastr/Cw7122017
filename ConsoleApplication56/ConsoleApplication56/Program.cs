using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Pasazer
    {
        string imie;

        public Pasazer(string imie)
        {
            this.imie = imie;
        }
    }

    class Pociag
    {
        private List<Pasazer> pasazerowie;

        public void DopiszPasazeraDoListy(Pasazer p)
        {
            pasazerowie.Add(p);
        }
    }
}
