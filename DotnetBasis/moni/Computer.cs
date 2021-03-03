using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.moni
{
    class Computer
    {
        public MobileStorage MS
        {
            get;
            set;
        }
        public void CPURead()
        {
            this.MS.Read();
        }
        public void CPUWrite()
        {
            this.MS.Wite();
        }
    }
}
