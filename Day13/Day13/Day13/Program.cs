using System;

namespace Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            Piemers1();
        }

        static void Piemers1()
        {
            int[] arrayPieci = new int[5];

            int[] arraySesi = new int[6];

            Random randNum = new Random();

            for (int i = 0; i < arrayPieci.Length; i++)
            {
                arrayPieci[i] = randNum.Next(1, 10);

                arraySesi[i] = arrayPieci[i];

                Console.WriteLine("Masiva 5 vertibas " + arrayPieci[i]);

                Console.WriteLine("Masiva 6 vertibas " + arraySesi[i]);

            }

            Console.WriteLine("Ievadiet vertibu!");

            arraySesi[arraySesi.Length -1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masiva 6 ievadita vertiba " + arraySesi[arraySesi.Length - 1]);

        }
    }
}
