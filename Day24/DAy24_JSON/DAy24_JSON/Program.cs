using System;
using System.IO;
using System.Text.Json;

namespace DAy24_JSON
{
    class Program
    {
        static String folderPath = @"C:\Users\Blenderis\Desktop\";
        static void Main(string[] args)
        {
            Rakstitajs();

            Lasitajs();
        }

        public static void Rakstitajs()
        {
            String fileName = folderPath + "sample1.txt";
            try
            {
                User user = new User();

                Console.WriteLine("Lietotaja Vards");
                string userName = Console.ReadLine();

                Console.WriteLine("Lietotaja parole");
                string passWord = Console.ReadLine();

                Console.WriteLine("Vards?");
                string name = Console.ReadLine();

                Console.WriteLine("Uzvards?");
                string lastName = Console.ReadLine();

                Console.WriteLine("Gads?");
                int year = Convert.ToInt32(Console.ReadLine());

                user.InitStudent(userName, passWord, name, lastName, year);
                String jsonString = JsonSerializer.Serialize(user);

                Console.WriteLine(jsonString);

                StreamWriter writer = new StreamWriter(fileName);

                writer.WriteLine(jsonString);

                writer.Close();
            }
            catch
            {
                Console.WriteLine("Error!");
            }

        }

        public static void Lasitajs()
        {
           
            String fileName = folderPath + "sample1.txt";
            try
            {
                StreamReader reader = new StreamReader(fileName);
                String a = reader.ReadToEnd();
                reader.Close();
                User user = JsonSerializer.Deserialize<User>(a);
                Console.WriteLine(user);
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }

    }
}
