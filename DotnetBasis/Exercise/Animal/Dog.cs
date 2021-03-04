using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.Animal
{
    class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗旺旺的叫");
        }

        public override void Eat()
        {
            Console.WriteLine("狗咬的吃");
        }
    }
}
