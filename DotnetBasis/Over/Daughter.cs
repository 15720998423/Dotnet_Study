using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.Over
{
    class Daughter:Father
    {
        public Daughter(string lastName,decimal property,string boolType) : base(lastName,property,boolType)
        {
            //调用父类的构造函数（：base（））给子类的字段赋值
        }
        public void Dance()
        {
            Console.WriteLine("女儿在跳舞");
        }
    }
}
