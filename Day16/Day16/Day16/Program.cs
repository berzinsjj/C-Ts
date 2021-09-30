using System;
using System.Collections.Generic;

namespace Day16
{
    class Program
    {
        static List<String> Vuzvards = new List<String>();
        static List<int> DzGads = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Stuudent list");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet Vardu");
                Vuzvards.Add(Console.ReadLine());

                Console.WriteLine("Ievadiet dzimsanas gadu");
                DzGads.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Vards Uzvards : " + Vuzvards[i] + " DZimsanas gads: " + DzGads[i]);
            }
        }
    }
}
