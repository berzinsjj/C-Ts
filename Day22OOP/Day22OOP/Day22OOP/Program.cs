using System;
using System.Collections.Generic;

namespace Day22OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Candidate> caList = new List<Candidate>();

            Console.WriteLine("Cik Kandidati?");
            int skaits = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < skaits; i++)
            {
                Console.WriteLine("Jus iedavat kandidatu nr- " + (i));

                Console.WriteLine("Vards?");
                string name = Console.ReadLine();

                Console.WriteLine("Uzvards?");
                string lastName = Console.ReadLine();

                Console.WriteLine("Ievadi HR Atzimi");
                double hrAtzime = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ievadi Ts Atzimi");
                double tsAtzime = Convert.ToDouble(Console.ReadLine());

                Candidate addCandidate = new Candidate(name,lastName,hrAtzime,tsAtzime);
                caList.Add(addCandidate);
            }

            Console.WriteLine();
            Console.WriteLine("Kandidatu liste");
            Console.WriteLine();



            foreach (Candidate ca in caList)
            {
                ca.Print();
                Console.WriteLine();
            }
        }
    }
}
