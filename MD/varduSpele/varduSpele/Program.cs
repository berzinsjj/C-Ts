using System;

namespace varduSpele
{
    class Program
    {
        static void Main(string[] args)
        {
            uzdevums1();
        }

        static void uzdevums1()
        {
            ///// 1.UZD
            Console.WriteLine("Ievadiet savu vardu");

            String vards = Console.ReadLine();

            int vardaGarums = vards.Length;

            if (vardaGarums > 6)
            {
                Console.WriteLine("****");
            }
            else if (vardaGarums < 6)
            {
                Console.WriteLine("***");
            }
            else if (vardaGarums == 6)
            {
                Console.WriteLine("**");
            }
        }

        static void uzdevums2()
        {
            Console.WriteLine("Ievadiet slepeno vardu");
            String slepenaisVards = Console.ReadLine();

            Console.WriteLine("Ievadi slepenā vārda hintu");
            String slepenaVardaHints = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Slepenā vārda hints -- " + " " + slepenaVardaHints);

            String minejums = Console.ReadLine();

            if (slepenaisVards == minejums)
            {
                Console.WriteLine("Tu uzmineji");
            }
            else
            {
                Console.WriteLine("Tu zaudeji, megini velreiz");
            }
        }
    }
}
