
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class SlotChange
    {
        public double InitialSlot { get; set; }
        public double NewSlot { get; set; }
        public string Diameter { get; set; }
        public string FileName
        {
            get
            { return Path.GetFileNameWithoutExtension(fileName); }
            set
            { fileName = value; }
        }
        private string fileName;
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)FileName).GetEnumerator();
        }
    }
}
