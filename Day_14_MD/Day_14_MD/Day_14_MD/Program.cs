using System;

namespace Day_14_MD
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array30 = new int[30];

            Random randNum = new Random();

            for (int i = 0; i < array30.Length; i++)
            {
                array30[i] = randNum.Next(1, 100);

                Console.WriteLine("Masiva vertibas " + array30[i]);
            }

            Console.WriteLine("dfdfdds "+ ArrayTools.Meklesana(10));
        }
       
    }
}
