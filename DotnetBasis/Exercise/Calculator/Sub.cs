using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.Calculator
{
    class Sub:CalFather
    {
        public Sub(double n1, double n2) : base(n1, n2)
        {

        }
        public override double GetResult()
        {
            return this.NumberOne - this.NumberTwo;
        }
    }
}
