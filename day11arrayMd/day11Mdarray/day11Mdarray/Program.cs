using System;

namespace day11Mdarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevums2();
        }

        static void Uzdevums2()
        {
            Console.WriteLine("Ievada Lietotajs? Ja/ne ?");

            string ievade = Console.ReadLine();

            int[] arrayDesmit = new int[10];

            Random randNum = new Random();

            int pcSum = 0;

            int pcVid = 0;

            int mySum = 0;

            int myVid = 0;

            if (ievade == "Ne")
            {
                for (int i = 0; i < arrayDesmit.Length; i++)
                {
                    arrayDesmit[i] = randNum.Next(10, 100);

                    Console.WriteLine(arrayDesmit[i]);

                    pcSum = pcSum + arrayDesmit[i];

                    pcVid = pcVid + arrayDesmit[i] / arrayDesmit.Length;
                }

                Console.WriteLine("Masiva Summa " + pcSum);
                Console.WriteLine("Masiva Videjais " + pcVid);
            }
       
            else
            {
                
                for (int i = 0; i < arrayDesmit.Length; i++) 
                {
                    Console.WriteLine("Ievadiet vertibu!");
                    arrayDesmit[i] = Convert.ToInt32(Console.ReadLine());

                    mySum = mySum + arrayDesmit[i];

                    myVid = myVid + arrayDesmit[i] / arrayDesmit.Length;

                }

                Console.WriteLine("Masiva Summa " + mySum);
                Console.WriteLine("Masiva Videjais " + myVid);
            }
        }
    }
}
