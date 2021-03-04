using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.moni
{
    class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3在读取数据");
        }

        public override void Wite()
        {
            Console.WriteLine("MP3在写入数据");
        }
        public void PlayMusic()
        {
            Console.WriteLine("MP3在播放音乐");
        }
    }
}
