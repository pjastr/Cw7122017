using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osoby = new List<Osoba>();
            osoby.Add(new Osoba("Jan", "Kowalski", "dwadzieścia"));
            osoby.Add(new Osoba("Anna", "Kowalska", "34"));
            osoby.Add(new Osoba("Zofia", "Nowak", "76"));
            osoby.Sort();
        }
    }
}
