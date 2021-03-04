using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.moni
{
    class MoblieDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }

        public override void Wite()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }
}
