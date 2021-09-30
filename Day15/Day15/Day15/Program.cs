using System;
using System.Collections.Generic;

namespace Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> saraksts = new List<int>();

            int sum = 0;
           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ievadi Skaitli");
                int input = Convert.ToInt32(Console.ReadLine());
                saraksts.Add(input);
                sum = sum + input;
            }

            Console.WriteLine("kopeja summa " + sum);

            if (sum < 15)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(saraksts[i]);
                }
            }
            else if (sum >= 15)
            {
                for (int i = 9; i >= 0; i--)
                {
                    Console.WriteLine(saraksts[i]);
                }
            }
            
        }
    }

}
