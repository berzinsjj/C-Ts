using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums1();
        }

        static void Uzdevums1()
        {


            int kkadsMurgs = 0;

            for (int i = 0; i < 5; i++)
            {
                int ievadSk = NumberInput();

                

                if (ievadSk > kkadsMurgs || kkadsMurgs >=0)
                {
                    kkadsMurgs = ievadSk;
                }
               
            }

            Console.WriteLine(" Lielakais ir " + kkadsMurgs);

        }


        static int NumberInput()
        {
            Console.WriteLine("Ievadiet skaitli!");

            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
