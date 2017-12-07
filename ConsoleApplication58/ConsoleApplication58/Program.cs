using System;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tablica; //deklaracja
            //tablica = new int[6];  //inicjacja wersja 1

            //int[] tab2 = { 3,4,5,6}; //deklaracja i inicjacja 2w1
            //int[] tab4 = tab2;

            //tab2[2] = 7;
            //int[] tab3 = new int[5];
            
            //Osoba[] osoby = new Osoba[4];
            Osoba[] osoby2 = { new Osoba("Jan"), new Osoba("Anna"), new Osoba("Zosia")};
            //Array.Sort(osoby2); //operacja zewnętrzna
            //for(int i=0; i<osoby2.Length; i++)
            //{
            //    Console.WriteLine(osoby2[i]);
            //}
            Array.Resize<Osoba>(ref osoby2, 6);
            foreach(var element in osoby2)
            {
                Console.WriteLine(element);
            }

            int[,] osoby = new int[5, 6];
            Console.ReadKey();
        }
    }

    class Osoba:IComparable<Osoba>
    {
        string imie;

        public Osoba(string imie)
        {
            this.imie = imie;
        }

        public override string ToString()
        {
            return imie;
        }

        public int CompareTo(Osoba other)
        {
            return other.imie.CompareTo(this.imie);
        }
    }
}
