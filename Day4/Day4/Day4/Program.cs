using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            Console.WriteLine(StringSum(b: "es", c: "gulu", d: "rapsii"));

            
        }


        static int StringSum(string b, string c, string d)
        {

            int kopejais = (b + c + d).Length;

            return kopejais;
        }
    }


}

