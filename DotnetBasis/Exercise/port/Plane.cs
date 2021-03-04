using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.port
{
    class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("飞机会飞");
        }
    }
}
