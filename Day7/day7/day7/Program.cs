using System;

namespace day7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cikls2();
        }

        static void Uzdevums1()
        {
            int sumMax = 0;

            int sumMin = 0;

            String choice = "";

            while (choice != "exit")
            {
                Console.WriteLine("Ievadiet skaitli!");
                int sk = Convert.ToInt32(Console.ReadLine());

                
                if (sumMax == 0 && sumMin == 0)
                {
                    sumMin = sk;
                    sumMax = sk;
                }


                if (sk > sumMax)
                {
                    sumMax = sk;
                   
                }

                else if (sk < sumMin)
                {
                    sumMin = sk;
                }


                Console.WriteLine("Vai velaties turpinat darbu?");
                choice = Console.ReadLine();

            }

            Console.WriteLine("mazakais ir" + " " + sumMin + "lielakais" + " " + sumMax);
            
        }

        static void Cikls()
        {
            for (int i = 15; i <= 45; i++)
            {
                
                Console.WriteLine(i);
                
            }
        }

        static void Cikls2()
        {
            String choice = "";
            

            int counter = 1;

                
                while (choice != "EXIT")
                {
                    Console.WriteLine("sdsfs" + counter);

                    counter++;

                    Console.WriteLine("Rakstat EXIT, lai izietu, jebko citu, lai turpinatu!");
                    choice = Console.ReadLine();
                }
            

        }

       
    }
}
