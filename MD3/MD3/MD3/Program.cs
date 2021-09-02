using System;

namespace MD3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Pirmais(50,1));
            Console.WriteLine(Otrais("hyhyhy","mjmjmj","dedede"));
        }

        static int Pirmais(int sk1, int sk2)
        {
            int abiDivi = sk1 + sk2;

            if (sk1 > sk2)
            {
                return sk1;
            }
            else if (sk1 < sk2)
            {
                return sk2;
            }
            else
            {
                return abiDivi;
            }

           
        }

        static int Otrais(string v1, string v2, string v3)
        {
            int videjais = (v1 + v2 + v3).Length / 3;

            return videjais;
        }
    }
}
