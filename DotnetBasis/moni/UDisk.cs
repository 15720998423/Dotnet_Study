using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.moni
{
    class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据");
        }

        public override void Wite()
        {
            Console.WriteLine("U盘在写入数据");
        }
    }
}
