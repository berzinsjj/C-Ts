using System;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums2();
        }

        static void Uzdevums2()
        {
            
            Console.WriteLine("Es esmu dators");

            String[] arrayPieci = new String[5];

            for (int i = 0; i < arrayPieci.Length; i++)
            {
                Console.WriteLine("Ievadiet vertibu!");
                arrayPieci[i] = Console.ReadLine();

                if (arrayPieci[i].Contains("Sveiki") == true)
                {
                    arrayPieci[i] = "*****";

                    Console.WriteLine(arrayPieci[i]);
                }
                
            }
           
        }
    }
}
