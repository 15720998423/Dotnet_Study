using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.Calculator
{
    class Cheng:CalFather
    {
        public Cheng(double n1, double n2) : base(n1, n2)
        {

        }
        public override double GetResult()
        {
            return this.NumberOne * this.NumberTwo;
        }
    }
}
