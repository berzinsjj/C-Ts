using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14
{
    class StudentList
    {
         public static void List()
        {
            List<string> cilvekuList = new List<string>();

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

                Console.WriteLine("Ievadiet Studenta Vardu un Uzvardu");
                string Students = Console.ReadLine();
                

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Goodbye");
                        break;
                    case "1":
                        cilvekuList.Add(Students);
                        break;
                    case "2":
                        Console.WriteLine("Students " + cilvekuList);
                        break;
                    default:
                        Console.WriteLine("Jaievada 0,1,2 , lai izveletos");
                        break;


                }

            }
        }
    }
}
