using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Day25
{
    class Program
    {
        public static List<string> stringList = new List<string>();
        static String folderPath = @"C:\Users\Blenderis\Desktop\";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello All");
            Iedave();
            Izvade();
        }

        static void Iedave()
        {
            

            String fileName = folderPath + "string.txt";

            for (int i =0; i<5; i++)
            {
                Console.WriteLine("Ievadi stringu");
                string ievade = Console.ReadLine();
                stringList.Add(ievade);
            }

            String jsonString = JsonSerializer.Serialize(stringList);

            Console.WriteLine(jsonString);

            StreamWriter writer = new StreamWriter(fileName);

            writer.WriteLine(jsonString);

            writer.Close();

        }

        static void Izvade()
        {
            String fileName = folderPath + "string.txt";

            StreamReader reader = new StreamReader(fileName);

            String a = reader.ReadToEnd();

            reader.Close();

            List<String> stringList = JsonSerializer.Deserialize<List<String>>(a);
            
            for (int i = 0; i<stringList.Count; i++)
            {
                Console.WriteLine(stringList[i]);
            }
        }
    }
}
