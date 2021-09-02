using System;

namespace Day1_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Kā Jus sauc ?");
            //// String vards = Console.ReadLine();

            String vards;
            vards = Console.ReadLine();

            Console.WriteLine("Cik jums ir gadu?");
            String gadi = Console.ReadLine();
            

            Console.WriteLine("Jūs sauc {0}. Jums ir {1} gadi", vards , gadi);

        }
    }
}
