using System;

namespace whaat
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums1();
        }

        static void Uzdevums1()
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 11);

            int guess = NumberInput();

            int guessNr = 5;

            for (int i = 0; i < guessNr; i++)
            {

            }

            if (randomNumber == guess)
            {
                Console.WriteLine("Spele ir uzvareta!");
            }
            else
            {
                Console.WriteLine("Spele zaudeta, istais skaitlis ir " + randomNumber);
            }
        }

        static int NumberInput()
        {
            Console.WriteLine("Ievadiet skaitli!");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
