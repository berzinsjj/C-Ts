using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = -1;
            int sum = 0;
            int pcSum = 0;

            Random random = new Random();
           

            while (number!=0)
            {
                number = GenNumber();
                sum = sum + number;
                Console.WriteLine("Pasreizeja summa ir " +sum);

                int randomNumberPC = random.Next(1, 11);
                pcSum = pcSum + randomNumberPC;
                Console.WriteLine("Pasreizeja PC summa ir " + pcSum);

                if (sum > 21)
                {
                    Console.WriteLine("Jus nodegaat uzvareja pc");
                    return;
                }
                if (pcSum > 21)
                {
                    Console.WriteLine("Pc nodega jus uzvarejat");
                    return;
                }

                if (pcSum >=17 || pcSum >21)
                {
                    
                }

            }


            if (sum > pcSum)
            {
                Console.WriteLine("Jus uzvarejat");
            }
            else if (pcSum >sum)
            {
                Console.WriteLine("PC uzvareja");
            }
            else
            {
                Console.WriteLine("Neizskirts");
            }

        }

       
        
        static int GenNumber()
        {
            Console.WriteLine("ja gribi generet  spied 'y' ");

            string input = Console.ReadLine();

            if (input == "y")
            {
                Random random = new Random();

                int randomNumber = random.Next(1, 11);

                return randomNumber;
            }

            else  
            {
                return 0;
            }

        }
        
    }
}
