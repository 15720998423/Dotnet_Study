using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.Company
{
    class Programmer:Employee
    {
        public override void Daka()
        {
            Console.WriteLine("程序员不打卡");
        }
    }
}
