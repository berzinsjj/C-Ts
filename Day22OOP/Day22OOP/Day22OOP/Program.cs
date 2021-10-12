using System;

namespace Day22OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidate c1 = new Candidate("Jānis", "Bērziņš", 8.7, 9.6);
            c1.Print();

            Console.WriteLine();

            Candidate c2 = new Candidate("Juris", "Ābols", 6.6, 7.1);
            c2.Print();
        }
    }
}
