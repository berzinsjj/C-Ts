using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static String folderPath = @"C:\Users\Blenderis\Desktop\Tscourse\Csharp\";
        static void Main(string[] args)
        {
            ReadSample();
        }


        static void WriteSample()
        {
            String fileName = folderPath + "sample1.txt";
            try
            {
                Console.WriteLine("Cik frzes ievadis?");
                int frazes = Convert.ToInt32(Console.ReadLine());

                StreamWriter writer = new StreamWriter(fileName);
                for (int i = 0; i < frazes; i++)
                {
                    Console.WriteLine("ievadi frazi");
                    string ievade = Console.ReadLine();
                    writer.WriteLine(ievade);
                }

                writer.Close();
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }

        static void ReadSample()
        {
            String fileName = folderPath + "sample1.txt";

            try
            {
                StreamReader reader = new StreamReader(fileName);
                String line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }

                WriteSample();
              
                reader.Close();

            }
            catch
            {
                Console.WriteLine("dsdsdsd");
            }
            
        }
    }
}
