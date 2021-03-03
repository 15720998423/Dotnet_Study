using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace DotnetBasis.File
{
    class Text : FileFather
    {
        public Text(string fullPath) : base(fullPath)
        {

        }
        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.fullPath);
            Process p = new Process();
            p.StartInfo = psi;
            try
            {
                p.Start();
            }
            catch (Exception)
            {

                Console.WriteLine("找不到文件");
            }
            
        }
    }
}
