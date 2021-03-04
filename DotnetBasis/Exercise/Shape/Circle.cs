using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.Shape
{
    class Circle : Shape
    {
        public double R { get; set; }
        public Circle(double r)
        {
            this.R = r;
        }

       

        public override double Area()
        {
            return Math.PI * this.R * this.R;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * this.R;
        }
    }
}
