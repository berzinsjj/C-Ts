using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            Piemers2();
        }

        static void Piemers1()
        {
            int[] testArray = new int[10];

           
            Random randNum = new Random();

            int max = int.MinValue;


            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = randNum.Next(10,100);

                Console.WriteLine(testArray[i]);
                

                if (testArray[i] > max)
                {
                    max = testArray[i];
                }
            }

            Console.WriteLine("Lielakais " + max);

        }

        static void Piemers2()
        {

            Console.WriteLine("Ievadiet masiva garumu!");
            int len = Convert.ToInt32(Console.ReadLine());

            String[] arrayOfStrings = new String[len];

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Ievadiet " + i + ". vertibu!");
                arrayOfStrings[i] = Console.ReadLine();
            }
            Console.WriteLine();

            for (int i = 0; i < len; i++)
            {
                Console.Write(arrayOfStrings[i] + " ");
            }


        }
    }
}
