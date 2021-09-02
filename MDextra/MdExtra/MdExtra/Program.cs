using System;

namespace MdExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Velesanas(18, "Arnmolds");

            int sk1 = 3;

            if (sk1 >= 1 && sk1 <= 3)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Ievaditais(sk1,20,30);
        }

        static void Velesanas(int Vecums, String Vards)
        {
            Console.WriteLine("Sveiki" + " " + Vards);
            if (Vecums >= 18)
            {
                Console.WriteLine("Jus varat piedalities velesanas");
            }
            else
            {
                Console.WriteLine("Jus nevarat piedalities velesanas");
            }
        }

        static void Ievaditais(int sk1,int sk2,int sk3)
        {

            if (sk1 == 1)
            {
                Console.WriteLine(sk2 + sk3);
            }
            else if (sk1 == 2)
            {
                Console.WriteLine(sk2 - sk3);
            }
            else if (sk1 == 3)
            {
                Console.WriteLine(sk2 * sk3);
            }

        }

      
    }
}
