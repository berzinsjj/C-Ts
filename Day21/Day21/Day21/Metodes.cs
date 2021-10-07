using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21
{
    class Metodes
    {
        static String folderPath = @"C:\Users\Blenderis\Desktop\Tscourse\Csharp\";
        static List<String> teksti = new List<String>();
        public static void ReadSample()
        {
            String fileName = folderPath + "day21.txt";

            try
            {
                StreamReader reader = new StreamReader(fileName);
                String line = reader.ReadLine();
                while (line != null)
                {
                    teksti.Add(line);
                    line = reader.ReadLine();
                }

                reader.Close();

            }
            catch
            {
                Console.WriteLine("Fails neeksistee");
            }

            int sum = 0;

            for (int i = 0; i < teksti.Count; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);

        }

        public static void WriteSample()
        {
            String fileName = folderPath + "day21.txt";
            try
            {
                StreamWriter writer = new StreamWriter(fileName);
                Random rand = new Random();
                

                for (int i = 0; i < 20; i++)
                {
                    int randomskaitli = rand.Next(0, 20);
                    writer.WriteLine(randomskaitli);
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
