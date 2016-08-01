﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class LengthChange
    {
        
        public string FileName
        {
            get
            { return Path.GetFileNameWithoutExtension(fileName); }
            set
            { fileName = value; }
        }
        public string InitialLength { get; set; }
        public string NewLength { get; set; }
        public bool OutOfTolerance { get; set; }
        private string fileName;
    }
}
