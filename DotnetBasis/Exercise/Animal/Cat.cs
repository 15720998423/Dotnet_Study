using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.Animal
{
    class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫喵喵的叫");
        }

        public override void Eat()
        {
            Console.WriteLine("猫舔着吃");
        }
    }
}
