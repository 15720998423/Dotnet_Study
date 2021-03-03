using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.Calculator
{
   public abstract class CalFather
    {
        public double NumberOne
        {
            get;
            set;
        }
        public double NumberTwo
        {
            get;
            set;
        }
        public abstract double GetResult();
        public CalFather(double n1, double n2)
        {
            this.NumberOne = n1;
            this.NumberTwo = n2;
        }

    }
}
