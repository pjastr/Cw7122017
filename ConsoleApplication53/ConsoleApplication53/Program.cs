using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    class Program
    {
        static void Main(string[] args)
        {
            Baza b1 = new Baza(456);
            b1.WyszNr(5, 6);
            b1.WyszTekst("sdsds");
        }
    }
}
