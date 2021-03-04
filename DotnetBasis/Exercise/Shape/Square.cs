using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.Shape
{
    class Square : Shape
    {
        public double Height
        {
            get;
            set;
        }
        public double Width { get; set; }

        public Square(double height,double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public override double Area()
        {
            return this.Height * this.Width;
        }

        public override double Perimeter()
        {
            return (this.Height + this.Width) * 2;
        }
    }
}
