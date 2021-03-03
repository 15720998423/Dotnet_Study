using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.job
{
    /// <summary>
    /// 实现继承的条件：1.子类是父类 is as  2.子类能够实现父类中所规范的所有成员
    /// </summary>
    abstract class Animal
    {
        public abstract void GetFood();
    }
}
