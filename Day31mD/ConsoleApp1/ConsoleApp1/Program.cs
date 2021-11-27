using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Customer> lst = OtraKlase.Connect();

            foreach (Customer a in lst)
            {
                Console.WriteLine(a.vards);
                Console.WriteLine(a.uzvards);
                Console.WriteLine(a.telefons);
                Console.WriteLine(a.epasts);
                Console.WriteLine("======");

            }
        }

       
    }
}
