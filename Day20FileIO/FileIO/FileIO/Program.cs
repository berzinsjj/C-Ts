using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static String folderPath = @"C:\Users\Blenderis\Desktop\Tscourse\Csharp\";
        static void Main(string[] args)
        {
            WriteSample();
        }

        
        static void WriteSample()
        {
            String fileName = folderPath + "sample1.txt";
            try
            {
                Console.WriteLine("Ievadi 3 frazes");
                StreamWriter writer = new StreamWriter(fileName);
                for (int i =0; i <3; i++)
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
    }
}
