using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    class Student:Osoba
    {
        private int numerAlbumu;

        public Student(int wiek, int numerAlbumu)
        {
            this.numerAlbumu = numerAlbumu;
            this.wiek = wiek;
        }

        public override string Ulga(bool p1)
        {
            return "sdsdd";
        }
    }
}
