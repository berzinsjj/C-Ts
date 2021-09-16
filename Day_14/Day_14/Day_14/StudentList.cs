using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14
{
    class StudentList
    {
        public static List<string> cilvekuList = new List<string>();

        public static void List()
        {
            
            String choice = "";

            while (choice != "0")
            {
                Console.WriteLine("0- Iziet");
                Console.WriteLine("1- Pievienot");
                Console.WriteLine("2- Izvadit");
                
                choice = Console.ReadLine();
                if (choice == "0")
                {
                    break;
                }

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Goodbye");
                        break;
                    case "1":
                        Console.WriteLine("Ievadiet Studenta Vardu un Uzvardu");
                        string Students = Console.ReadLine();
                        cilvekuList.Add(Students);
                        break;
                    case "2":
                        for (int i = 0; i < cilvekuList.Count; i++)
                        {
                            Console.WriteLine("Students " + cilvekuList[i]);
                        }
                        if (cilvekuList.Count == 0)
                        {
                            Console.WriteLine("Studentu nav");
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Jaievada 0,1,2 , lai izveletos");
                        break;
                }

            }
        }
    }
}
