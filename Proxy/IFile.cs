﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal interface IFile
    {
        public double GetSize();
        public string GetPath();
        public byte[] Show();
    }
}
