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
                StreamWriter writer = new StreamWriter(fileName);
                writer.WriteLine("Man");
                writer.WriteLine("Garso");
                writer.WriteLine("Alus");
                writer.Close();
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
