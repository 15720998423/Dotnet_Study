using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.port
{
    class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟会飞");
            Console.ReadKey();
        }
    }
}
