using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileManager
{
    internal class BatchParser
    {
        public List<string> piecemarks = new List<string>();
        private PDFTextParser textparser = new PDFTextParser();

        public Batch Parse(string[] filenames)
        {
            string maintext = textparser.Parse(filenames[0]);
            string assytext = textparser.Parse(filenames[1]);
            string batchnumber = ParseBatchNumber(maintext);
            string jobnumber = ParseJobNumber(maintext);

            List<Part> mainparts = ParseParts(maintext);
            List<Part> assyparts = ParseParts(assytext);
            List<Part> parts = new List<Part>(mainparts.Count + assyparts.Count);
            parts.AddRange(mainparts);
            parts.AddRange(assyparts);
            

            return new Batch
            {
                Batchnumber = batchnumber,
                JobNumber = jobnumber,
                Parts = parts,
            };
        }

        public bool Verify(string[] filenames)
        {
            string maintext = textparser.Parse(filenames[0]);
            string assytext = textparser.Parse(filenames[1]);
            string batchnumber = ParseBatchNumber(maintext);
            string jobnumber = ParseJobNumber(maintext);

            string assybatchnumber = ParseBatchNumber(assytext);
            if (assybatchnumber != batchnumber)
                return false;
            string assyjobnumber = ParseJobNumber(assytext);
            if (assyjobnumber != jobnumber)
                return false;
            if (ParseType(assytext) == ParseType(maintext))
                return false;
            return true;
        }

        private string ParseBatchNumber(string text)
        {
            string strippedText = Regex.Replace(text, @"\t|\n|\r", " ");
            var batchIdx = strippedText.IndexOf("ProdBatchNos:", StringComparison.Ordinal);
            var nextLineIdx = strippedText.IndexOf("Ordered By", StringComparison.Ordinal);
            return strippedText.Substring(batchIdx, nextLineIdx - batchIdx).Split(new[] { ' ' })[1];
        }

        private string ParseJobNumber(string text)
        {
            var jobIdx = text.IndexOf("Job:", StringComparison.Ordinal);
            var theRest = text.Substring(jobIdx, text.Length - jobIdx).Split(new[] { ' ' });
            return theRest[1];
        }

        private List<Part> ParseParts(string text)
        {
            var parts = new List<Part>();
            var beginIndex = text.IndexOf("Notes");
            var endIndex = text.IndexOf("Total Pieces");
            var type = ParseType(text);
            string body = "";
            try
            {
                body = text.Substring(beginIndex + 6, (endIndex - 1) - (beginIndex + 6));
            }
            catch (Exception)
            {
                return parts;
            }

            while (body.Contains(type))
            {
                string firstpage = body.Substring(0, body.IndexOf(type));
                string secondpage = body.Substring(body.IndexOf("Notes") + 5);
                body = $"{firstpage}\n{secondpage}";
            }

            var bodysplit = body.Split(new[] { '\n' });

            foreach (string bodyline in bodysplit)
            {
                if (bodyline.Contains("Piece Weight") || bodyline.Contains("Notes") || bodyline.Count() < 2)
                    continue;
                string[] elements = bodyline.Split(new[] { ' ' });
                var reverseElements = elements.Reverse().ToArray();

                var part = new Part();
                var routingCodes = "";

                part.Qty = Convert.ToInt32(elements[0]);
                part.Mark = elements[1];
                part.Drawing = elements[2];
                part.ShapeType = Regex.Match(elements[3], @"[A-Z]+").Value;
                part.ShapeDetails = Regex.Replace(elements[3], @"[A-W]+", "");
                for (int i = 4; i < elements.Count(); i++)
                {
                    if (elements[i].Contains("A"))
                    {
                        part.Grade = elements[i];
                        break;
                    }                        
                    else
                        part.ShapeDetails = $"{part.ShapeDetails} {elements[i]}";
                }
                for (int i = 1; i < reverseElements.Count(); i++)
                {
                    if (Regex.IsMatch(reverseElements[i], @"((\bY\b)|(\bN\b))"))
                        break;
                    else
                        routingCodes = $"{reverseElements[i]} {routingCodes}";
                }                
                part.Notes = routingCodes;                
                if (type.Contains("Main"))
                    part.isMain = true;
                else
                    part.isMain = false;


                if (part.ShapeType.Contains("HS") || part.ShapeType.Contains("BO"))
                    continue;
                else
                    parts.Add(part);
            }
            return parts;
        }

        private string ParseType(string text)
        {
            var type = text.First();
            switch (type)
            {
                case 'A':
                    return "Assembly Mark List";
                case 'M':
                    return "Main Member List";
                default:
                    return "Report Type Not Identified";
            }

        }
        string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }
}