using System;
using System.Collections.Generic;

namespace Day29
{
    class Program
    {
        static void Main(string[] args)
        {
            Piemers1();
        }

        static void Piemers1()
        {
            Console.WriteLine("Ievadiisi 5 vertibas mazais zikeri");
           
            List<string> cilvekuList = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("zikerim jaievada vertiba");

                cilvekuList.Add(Console.ReadLine());
            }

            for (int i = 0; i < cilvekuList.Count; i++)
            {
                Console.WriteLine("Aug " + cilvekuList[i]);
            }

            for (int i = cilvekuList.Count; i--> 0;)
            {
                Console.WriteLine("Dilst " + cilvekuList[i]);
            }

        }
    }
}
