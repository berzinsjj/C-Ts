using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_opp
{
    class Triangle
    {
        public double malaA { get; set; }
        public double malaB { get; set; }
        public double malaC { get; set; }

        public Triangle(double malaA, double malaB, double malaC)
        {
            this.malaA = malaA;
            this.malaB = malaB;
            this.malaC = malaC;
        }

        public double getPer()
        {
            return malaA + malaB + malaC;
        }

    }
}
