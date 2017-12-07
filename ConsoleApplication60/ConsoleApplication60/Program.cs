using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication60
{
    class Program
    {
        static void Main(string[] args)
        {
            Ccc c1 = new Ccc();
            c1.Metoda();
            Console.ReadKey();
        }
    }

    class Aaa
    {
        public virtual void Metoda()
        {
            Console.WriteLine("aaa");
        }
    }

    class Bbb:Aaa
    {
        public override sealed void Metoda()
        {
            Console.WriteLine("Bbb");
        }
    }

    class Ccc:Bbb
    {
        //public override void Metoda()
        //{

        //}
    }
}
