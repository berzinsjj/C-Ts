using System;

namespace PCvsUser
{
    class Program
    {
        static void Main(string[] args)
        {
            String izvele = "";

            while (izvele != "No")
            {
                Console.WriteLine("Skaitļu minēšana no 1-5");

                Random random = new Random();

                int randomNumber1 = random.Next(1, 5);

                int randomNumber2 = random.Next(1, 5);

                int randomNumber3 = random.Next(1, 5);

                int pcSumm = randomNumber1 + randomNumber2 + randomNumber3;




                Console.WriteLine("Ievadiet 1 skaitli no 1-5");

                int userInput1 = SkaitlaIevade();

                if (userInput1 < 1 || userInput1 > 5)
                {
                    Console.WriteLine("Nepareizs skaitlis, Jabut no 1-5");
                    SkaitlaIevade();
                    
                }

                Console.WriteLine("Ievadiet 2 skaitli no 1-5");

                int userInput2 = SkaitlaIevade();

                if (userInput2 < 1 || userInput2 > 5)
                {
                    Console.WriteLine("Nepareizs skaitlis, Jabut no 1-5");
                    SkaitlaIevade();
                }

                Console.WriteLine("Ievadiet 3 skaitli no 1-5");

                int userInput3 = SkaitlaIevade();

                if (userInput3 < 1 || userInput3 > 5)
                {
                    Console.WriteLine("Nepareizs skaitlis, Jabut no 1-5");
                    SkaitlaIevade();
                }





                int userSumm = userInput1 + userInput2 + userInput3;

                if (pcSumm > userSumm)
                {
                    Console.WriteLine("Uzvareja PC ar summu " + pcSumm + " Jusu summa bija " + userSumm);
                }
                else if (userSumm > pcSumm)
                {
                    Console.WriteLine("Jus uzvarejat ar summu " + userSumm + " Pc summa bija " + pcSumm);
                }
                else if (userSumm == pcSumm)
                {

                    Console.WriteLine("Neizkirts, abu summas vienadas");
                }




                Console.WriteLine("Spelet velreiz Yes/No");
                izvele = Console.ReadLine();
            }


            static int SkaitlaIevade()
            {
                Console.WriteLine("Ievadiet skaitli!");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                return skaitlis;
            }

        }
    }
}
