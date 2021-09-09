using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Matematika
    {
        public static void MatematikaOut()
        {
            String izvele = "";

            while (izvele != "Ne")
            {
                Console.WriteLine("Ievadi 1 skaitli");
                Double skaitlis1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Izvelaties darbibu " + " + " + " - " + " * " + " / ");
                string darbiba = Console.ReadLine();

                Console.WriteLine("Ievadi 2 skaitli");
                Double skaitlis2 = Convert.ToDouble(Console.ReadLine());

                Double sum = 0;

                if (darbiba == "+")
                {
                    sum = skaitlis1 + skaitlis2;
                    Console.WriteLine("Jusu iznakums " + sum);
                }
                else if (darbiba == "-")
                {
                    sum = skaitlis1 - skaitlis2;
                    Console.WriteLine("Jusu iznakums " + sum);
                }
                else if (darbiba == "*")
                {
                    sum = skaitlis1 * skaitlis2;
                    Console.WriteLine("Jusu iznakums " + sum);
                }
                else if (darbiba == "/")
                {
                    sum = skaitlis1 / skaitlis2;
                    Console.WriteLine("Jusu iznakums " + sum);
                }

                Console.WriteLine("Izmantot velreiz? Ja/Ne");
                izvele = Console.ReadLine();
            }
        }
    }
}
