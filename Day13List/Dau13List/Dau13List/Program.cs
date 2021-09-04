using System;
using System.Collections.Generic;

namespace Dau13List
{
    class Program
    {
        static void Main(string[] args)
        {
            Piemers1();
        }

        static void Piemers1()
        {
            Console.WriteLine("Cik studenti?");
            int input = Convert.ToInt32(Console.ReadLine());

            List<string> cilvekuList = new List<string>();

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Ievadiet Vardu Uzvardu");

                cilvekuList.Add(Console.ReadLine());
            }

            for (int i = 0; i < cilvekuList.Count; i++)
            {
                Console.WriteLine("Students " + cilvekuList[i]);
            }

        }
    }
}
