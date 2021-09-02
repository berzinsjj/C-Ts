using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet 1. skaitli!");
            String input = Console.ReadLine();
            //input = "16"

            int number1 = Convert.ToInt32(input);
            //input = "16"
            //number1 = 16

            Console.WriteLine("Ievadiet 2. skaitli!");
            input = Console.ReadLine();
            //input = 4
            //number1 = 16

            int number2 = Convert.ToInt32(input);
            //input = 4
            //number1 = 16
            //number2 = 4

            Console.WriteLine("Ja velaties saskaitit spiezat + ja atnemt - ");
            String izvele = Console.ReadLine();

            if (izvele == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (izvele == "-") 
            {
                Console.WriteLine(number1 - number2);
            }
            
            

            //int number2 = Convert.ToInt32(Console.ReadLine());




        }
    }
}
