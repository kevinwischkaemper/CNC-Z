using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FileManager
{
    public class Part
    {
        public int Qty { get; set; }
        public string Mark { get; set; }
        private string drawing;
        public string Drawing { get; set; }
        public string Shape
        {
            get
            {
                return $"{ShapeType}{ShapeDetails}";
            }
            set
            {
                Shape = value;
            }
        }
        public string ShapeType;
        public string ShapeDetails;
        public string Grade { get; set; }
        public double Length;
        public double Width;
        public double Weight;
        public string Notes { get; set; }
        public bool isMain;        
    }
}