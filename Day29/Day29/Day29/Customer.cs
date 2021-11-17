using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29
{
    class Customer
    {
        public string vards { get; set; }
        public string uzvards { get; set; }
        public int tel { get; set; }
        public string epasts { get; set; }


        public void CustomeraPrikoli(string vards, string uzvards, int tel, string epasts)
        {
            this.vards = vards;
            this.uzvards = uzvards;
            this.tel = tel;
            this.epasts = epasts;
        }

        public void print()
        {
            Console.WriteLine(vards + " " + uzvards + " " + tel + " " + epasts);
        }

    }
}
