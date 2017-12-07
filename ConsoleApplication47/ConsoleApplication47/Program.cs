using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b");
            int b = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(a) >= Math.Abs(b))
            {
                Console.WriteLine("Liczba bliżej zera= "+b);
            }
            else
            {
                Console.WriteLine("Liczba bliżej zera= " + a);
            }

            Console.ReadKey();
        }
    }
}
