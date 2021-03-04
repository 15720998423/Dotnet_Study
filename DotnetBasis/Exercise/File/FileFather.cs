using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetBasis.File
{
    public abstract class FileFather
    {
        public FileFather(string fullPath)
        {
            this.fullPath = fullPath;
        }

        public string fullPath
        {
            get;
            set;
        }
        public abstract void OpenFile();
    }
}
