using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54
{
    class Osoba:IComparable<Osoba>
    {
        private string imie;
        private string nazwisko;
        private string wiek;

        public Osoba(string imie, string nazwisko, string wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }

        public int CompareTo(Osoba other)
        {
            return this.imie.CompareTo(other.imie);
        }
    }
}
