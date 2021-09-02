using System;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kapinasana();
        }

        static void Kapinasana()
        {

            int sum = 0;

            string izvele = "";

            while (izvele != "EXIT")
            {

                int ievade = NumberInput("Ievadi skaitli");

                sum = sum + ievade;

                Console.WriteLine("Velies turpinat ? tad turpini, ja nee raksti EXIT");

                izvele = Console.ReadLine();
            }

            Console.WriteLine(sum);
            
        }


        static int NumberInput(String ievade)
        {
            Console.WriteLine(ievade);
            return Convert.ToInt32(Console.ReadLine());
        }
    }




}

