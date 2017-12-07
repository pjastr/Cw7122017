using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Pacjent
    {
        public bool okulary;
        private int wiek;
        public string choroba;

        public string Info()
        {
            return okulary
                +","+wiek+","+choroba;
        }

        public void Badania(int p1)
        {
            Console.WriteLine(p1);
        }

        public Pacjent(bool okulary, int wiek, string choroba)
        {
            this.okulary = okulary;
            this.wiek = wiek;
            this.choroba = choroba;
        }
    }
}
