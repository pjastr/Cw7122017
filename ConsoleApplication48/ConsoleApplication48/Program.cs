using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe a");
            int a=0, b=0;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Podaj liczbe b");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (Math.Abs(a) >= Math.Abs(b))
            {
                Console.WriteLine("Liczba bliżej zera= " + b);
            }
            else
            {
                Console.WriteLine("Liczba bliżej zera= " + a);
            }
            

            Console.ReadKey();
        }
    }
}
