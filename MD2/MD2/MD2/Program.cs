using System;

namespace MD2
{
    class Program
    {
        static void Main(string[] args)
        {

            IntMethod(30);
            IntMethod(2);
            StringSum(b: "es", c:"gulu", d:"rapsii");
        }

        static void IntMethod(int a)
        {
            if (a > 5)
            {
                Console.WriteLine("#####");
            }
            else if (a < 5) 
            {
                Console.WriteLine("***");
            }
        }

        static void StringSum(string b, string c, string d)
        {
            
            Console.WriteLine(b + c + d);

            Console.WriteLine((b+c+d).Length);
        }
    }
}
