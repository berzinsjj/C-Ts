using System;

namespace day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Piemers(3.5, 7.8);

        }

        static void Piemers(double a, double b)
        {
            if (a >  b)
            {
                Console.WriteLine(a);
            }

            else if (a < b)
            {
                Console.WriteLine(b);
            }

            else 
            {
                Console.WriteLine("aaaa");
            }


        }
    }
}
