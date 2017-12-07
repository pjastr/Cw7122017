using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Program
    {
        static void Main(string[] args)
        {
            Pacjent pacjent1 = new Pacjent(true,44,"sssd");
            Pacjent pacjent2 = new Pacjent(false,55,"sddfdfsf");
            pacjent1.Info();
            pacjent2.Info();
            pacjent1.Badania(55);
            pacjent2.Badania(11);

            Console.ReadKey();
            
        }
    }
}
