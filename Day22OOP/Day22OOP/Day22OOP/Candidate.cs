using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22OOP
{
    class Candidate
    {
        public String name;
        public String lastName;
        public double hrAtzime;
        public double tsAtzime;

        public Candidate(String name, String lastName, double hrAtzime, double tsAtzime)
        {
            this.name = name;
            this.lastName = lastName;
            this.hrAtzime = hrAtzime;
            this.tsAtzime = tsAtzime;
        }

        public void Print()
        {
            Console.WriteLine(name + " " + lastName);
            Console.WriteLine("HR-Atzime- " + hrAtzime );
            Console.WriteLine("TSV-Atzime- " + tsAtzime);
            Console.WriteLine("VIDEJA- " + (hrAtzime + tsAtzime)/2);
        }
    }
}
