using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileManager
{
    public class DSTVProcesssor
    {
        public List<LengthChange> lengthchanges = new List<LengthChange>();
        public List<SlotChange> slotchanges = new List<SlotChange>();

        public void ProcessDSTV(string filename, string jobNumber, string groupType, string batchNumber)
        {

            string text = File.ReadAllText(filename);

            #region Header Parsing    
            bool islengthchange = false;
            var textlines = text.Split(new[] { '\n' });
            int skippedlines = 0;
            for (int i = 0; i < 23; i++)
            {                
                if (textlines[i].TrimEnd(new[] { '\r' }).Contains("*"))
                {
                    skippedlines += 1;
                    continue;
                }                
            }
            int orderIDline = 1 + skippedlines;
            int drawingIDline = 2 + skippedlines;
            int phaseIDline = 3 + skippedlines;
            string grade = textlines[5 + skippedlines].TrimEnd(new[] { '\r' });
            string shape = textlines[7 + skippedlines].TrimEnd(new[] { '\r' });
            double headerlength = Convert.ToDouble(textlines[9 + skippedlines].TrimEnd(new[] { '\r' }));
            int headerlengthline = 9 + skippedlines;
            double profileHeight = Convert.ToDouble(textlines[10 + skippedlines].TrimEnd(new[] { '\r' }));
            double flangeWidth = Convert.ToDouble(textlines[11 + skippedlines].TrimEnd(new[] { '\r' }));
            double webThickness = Convert.ToDouble(textlines[13 + skippedlines].TrimEnd(new[] { '\r' }));
            double weightpermeter = Convert.ToDouble(textlines[15 + skippedlines].TrimEnd(new[] { '\r' }));
            double webheadcut = Convert.ToDouble(textlines[17 + skippedlines].TrimEnd(new[] { '\r' }));
            double webtailcut = Convert.ToDouble(textlines[18 + skippedlines].TrimEnd(new[] { '\r' }));
            double flangeheadcut = Convert.ToDouble(textlines[19 + skippedlines].TrimEnd(new[] { '\r' }));
            double flangetailcut = Convert.ToDouble(textlines[20 + skippedlines].TrimEnd(new[] { '\r' }));
            string shapeType = shape.Substring(0, Regex.Match(shape,@"\d").Index).Trim();
            string shapeDetails = shape.Substring(Regex.Match(shape,@"\d").Index);
            #endregion

            #region Block Parsing
            var blocktitlematch = new Regex("\\n[A-Z][A-Z]\\r\\n");
            List<Block> blocklist = new List<Block>();
            foreach (Match blockmatch in blocktitlematch.Matches(text))
            {
                if (blockmatch.Value.Contains("ST"))
                    continue;
                if (blockmatch.Value.Contains("EN"))
                    break;
                Block block = new Block();
                block.Lines = new List<string>();
                var splitblock = text.Substring(blockmatch.Index, blockmatch.NextMatch().Index - blockmatch.Index).Split(new[] { '\r' });
                block.Type = splitblock[0].TrimStart(new[] { '\n' });
                for (int i = 1; i < splitblock.Count() - 1; i++)
                {
                    block.Lines.Add(splitblock[i].TrimStart(new[] { '\n' }));
                }
                blocklist.Add(block);
            }
            #endregion

            #region Block Logic and Routing
            double maxLength = 0;
            double minLength = 2540;
            List<Block> LayoutBLockList = new List<Block>();
            foreach (Block block in blocklist)
            {
                List<Point> coordList = new List<Point>();
                bool findingFace = true;
                if (block.Type == "AK")
                {
                    Block LayoutsBlock = new Block()
                    {
                        Type = "BO",
                        Lines = new List<string>()
                    };
                    
                    foreach (string line in block.Lines)
                    {
                        #region Finding Face
                        if (findingFace)
                        {
                            try
                            {
                                block.Face = Regex.Match(line, @"v|o|u|h", RegexOptions.IgnoreCase).Value;
                                findingFace = false;
                                LayoutsBlock.Face = block.Face;
                            }
                            catch (Exception)
                            {
                            }
                        }
                        #endregion

                        #region CoordList
                        Regex floatMatch = new Regex(@"\d+.\d+");
                        double x = Convert.ToDouble(floatMatch.Matches(line)[0].ToString());
                        double y = Convert.ToDouble(floatMatch.Matches(line)[1].ToString());
                        coordList.Add(new Point(x, y));
                        #endregion

                        maxLength = Math.Max(maxLength, x);
                        minLength = Math.Min(minLength, x);
                    }
                    #region Angle Layout Marks
                    int MarksPerLine = 3;

                    if (shapeType == "L")
                    {
                        for (int i = 0; i < coordList.Count - 1; i++)
                        {
                            Point start;
                            Point end;
                            float yDirection;
                            float xDirection;
                            start = coordList[i];
                            end = coordList[i + 1];
                            if (start.X < end.X)
                                xDirection = 1;
                            else
                                xDirection = -1;
                            if (start.Y < end.Y)
                                yDirection = 1;
                            else
                                yDirection = -1;
                            
                            if (start.X == end.X)
                            {
                                if (start.X == 0 || start.X == maxLength)
                                    continue;
                                for (int p = 1; p < MarksPerLine + 1; p++)
                                {
                                    string newline = $"  {block.Face}   {start.X}o   {start.Y + (p * yDirection * (Math.Abs(end.Y - start.Y)) / (MarksPerLine + 1))}m   0.00   0.00";
                                    LayoutsBlock.Lines.Add(newline);
                                }
                                continue;
                            }
                            if (start.Y == end.Y)
                            {
                                if (start.Y == 0)
                                    continue;
                                if (block.Face == "v" && start.Y == profileHeight)
                                    continue;
                                if ((block.Face == "o" || block.Face == "u") && start.Y == flangeWidth)
                                    continue;
                                for (int p = 1; p < MarksPerLine + 1; p++)
                                {
                                    string newline = $"  {block.Face}   {start.X + (p * xDirection * Math.Abs(end.X - start.X) / (MarksPerLine + 1))}o   {start.Y}m   0.00   0.00";
                                    LayoutsBlock.Lines.Add(newline);
                                }
                                continue;
                            }

                            double slope = (end.Y - start.Y) / (end.X - start.X);
                            double distance = Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));

                            if (slope > 0)
                            {
                                if (start.Y < end.Y)
                                    yDirection = 1;
                                else
                                    yDirection = -1;
                            }
                            else
                            {
                                if (start.Y < end.Y)
                                    yDirection = -1;
                                else
                                    yDirection = 1;
                            }


                            for (int p = 1; p < MarksPerLine + 1; p++)
                            {
                                double layoutX = start.X + xDirection * ((p * (distance / (MarksPerLine + 1))) / Math.Sqrt(1 + Math.Pow(slope, 2)));
                                double layoutY = start.Y + yDirection * (((p * (distance / (MarksPerLine + 1))) * slope) / Math.Sqrt(1 + Math.Pow(slope, 2)));
                                string newline = $"  {block.Face}   {layoutX}o   {layoutY}m   0.00   0.00";
                                LayoutsBlock.Lines.Add(newline);
                            }
                        }

                    }
                    #endregion
                    LayoutBLockList.Add(LayoutsBlock);
                }
                
                //if (block.Type == "AK")
                //{
                //    for (int i = 0; i < block.Lines.Count; i++)
                //    {
                //        string[] blocklinevalues = Regex.Split(block.Lines[i].Trim(), @"\s+");
                //        int first;
                //        if (string.IsNullOrWhiteSpace(blocklinevalues[0]) || Regex.IsMatch(blocklinevalues[0], @"[a-z]"))
                //            first = 1;
                //        else
                //            first = 0;
                //        if (Regex.IsMatch(blocklinevalues[first], @"[a-z]"))
                //        {
                //            blocklinevalues[first] = blocklinevalues[first].Substring(0, Regex.Match(blocklinevalues[first], @"[a-z]").Index);
                //        }
                //        maxLength = Math.Max(maxLength, Convert.ToDouble(blocklinevalues[first]));
                //        minLength = Math.Min(minLength, Convert.ToDouble(blocklinevalues[first]));
                //    }
                //}

                #region Angle Slots
                if (block.Type == "BO" && shapeType == "L") 
                {
                    bool slotted = false;
                    for (int i = 0; i < block.Lines.Count; i++)
                    {
                        string[] blocklinestrings = Regex.Split(block.Lines[i].Trim(), @"\s+");
                        List<double> blocklinedoubles = new List<double>();
                        int first;                        
                        if (string.IsNullOrWhiteSpace(blocklinestrings[0]) || Regex.IsMatch(blocklinestrings[0], @"[a-z]"))
                        {
                            first = 1;
                            block.Face = Regex.Match(blocklinestrings[0], @"[a-z]").Value;
                        }                            
                        else
                            first = 0;
                        if (blocklinestrings.Length > 4)
                        {
                            if (Regex.IsMatch(blocklinestrings[first + 1], @"[a-z]"))
                            {
                                if (Regex.Match(blocklinestrings[first + 1], @"[a-z]").Value != "m")
                                {
                                    if (Regex.Match(blocklinestrings[first + 3], @"[a-z]").Value == "l")
                                        slotted = true;
                                }
                            }
                            else if (Regex.Match(blocklinestrings[first + 3], @"[a-z]").Value == "l") 
                                slotted = true;
                            if (slotted)
                            {
                                for (int p = first; p < blocklinestrings.Count(); p++)
                                {
                                    blocklinedoubles.Add(Convert.ToDouble(Regex.Replace(blocklinestrings[p], "[a-z]", "").Trim()));
                                }
                                string referenceFace = Regex.Match(blocklinestrings[first], "[a-z]").Value;
                                var lengthindirection = blocklinedoubles[4];
                                if (blocklinedoubles[4] == 0)
                                    lengthindirection = blocklinedoubles[5];
                                int direction = 1;
                                int oneEighty = 0;
                                if (blocklinedoubles[6] > 174 && blocklinedoubles[6] < 186)
                                    oneEighty = 1;
                                if (blocklinedoubles[5] > 174 && blocklinedoubles[5] < 186)
                                    oneEighty = 1;
                                if (blocklinedoubles[4] > 0)
                                    if ((blocklinedoubles[6] > 4 && blocklinedoubles[6] < 174) || blocklinedoubles[6] > 186)
                                        direction = 1;
                                    else
                                        direction = 0;
                                if ((blocklinedoubles[5] > 4 && blocklinedoubles[6] < 174) || blocklinedoubles[6] > 186)
                                    if (blocklinedoubles[6] > 0)
                                        direction = 0;
                                    else
                                        direction = 1;
                                if (blocklinedoubles[2] + lengthindirection > 32.1 && blocklinedoubles[2] < 21.6375 && blocklinedoubles[2] > 19.6375)
                                {
                                    var slotchange = new SlotChange();
                                    
                                    slotchange.InitialSlot = ((blocklinedoubles[2] + lengthindirection) / 25.40);
                                    slotchange.Diameter = "13/16";
                                    slotchange.NewSlot = 31.75;
                                    slotchange.FileName = Path.GetFileName(filename);
                                    slotchanges.Add(slotchange);
                                    block.Lines[i] = $"  {block.Face}      {(blocklinedoubles[0] - (oneEighty * blocklinedoubles[4])):f2}{referenceFace}     {blocklinedoubles[1]:f2}      {blocklinedoubles[2]:f2}    {"0.00l"}    {((slotchange.NewSlot - blocklinedoubles[2]) * (1 - direction)):f2}     {((slotchange.NewSlot - blocklinedoubles[2]) * direction):f2}  {0.00:f2}\r\n  {block.Face}      {(blocklinedoubles[0] - (oneEighty * blocklinedoubles[4]) + (lengthindirection + blocklinedoubles[2] - slotchange.NewSlot) * (1-direction)):f2}{referenceFace}     {blocklinedoubles[1] + (lengthindirection + blocklinedoubles[2] - slotchange.NewSlot) * direction:f2}      {blocklinedoubles[2]:f2}    {"0.00l"}    {((slotchange.NewSlot - blocklinedoubles[2]) * (1 - direction)):f2}     {((slotchange.NewSlot - blocklinedoubles[2]) * direction):f2}  {0.00:f2}";
                                }
                                if (blocklinedoubles[2] + lengthindirection > 33.5 && blocklinedoubles[2] < 27.9875 && blocklinedoubles[2] > 25.9875)
                                {
                                    var slotchange = new SlotChange();
                                    slotchange.InitialSlot = ((blocklinedoubles[2] + lengthindirection) / 25.40);
                                    slotchange.Diameter = "1 1/16";
                                    slotchange.NewSlot = 33.3375;
                                    slotchange.FileName = Path.GetFileName(filename);
                                    slotchanges.Add(slotchange);
                                    block.Lines[i] = $"  {block.Face}      {(blocklinedoubles[0] - (oneEighty * blocklinedoubles[4])):f2}{referenceFace}     {blocklinedoubles[1]:f2}      {blocklinedoubles[2]:f2}    {"0.00l"}    {((slotchange.NewSlot - blocklinedoubles[2]) * (1 - direction)):f2}     {((slotchange.NewSlot - blocklinedoubles[2]) * direction):f2}  {0.00:f2}\r\n  {block.Face}      {(blocklinedoubles[0] - (oneEighty * blocklinedoubles[4]) + (lengthindirection + blocklinedoubles[2] - slotchange.NewSlot) * (1 - direction)):f2}{referenceFace}     {blocklinedoubles[1] + (lengthindirection + blocklinedoubles[2] - slotchange.NewSlot) * direction:f2}      {blocklinedoubles[2]:f2}    {"0.00l"}    {((slotchange.NewSlot - blocklinedoubles[2]) * (1 - direction)):f2}     {((slotchange.NewSlot - blocklinedoubles[2]) * direction):f2}  {0.00:f2}";
                                }
                                if (blocklinedoubles[2] + lengthindirection > 33.5 && blocklinedoubles[2] < 24.8125 && blocklinedoubles[2] > 22.8125)
                                {
                                    var slotchange = new SlotChange();
                                    slotchange.InitialSlot = ((blocklinedoubles[2] + lengthindirection) / 25.40);
                                    slotchange.Diameter = "15/16";
                                    slotchange.NewSlot = 33.3375;
                                    slotchange.FileName = Path.GetFileName(filename);
                                    slotchanges.Add(slotchange);
                                    block.Lines[i] = $"  {block.Face}      {(blocklinedoubles[0] - (oneEighty * blocklinedoubles[4])):f2}{referenceFace}     {blocklinedoubles[1]:f2}      {blocklinedoubles[2]:f2}    {"0.00l"}    {((slotchange.NewSlot - blocklinedoubles[2]) * (1 - direction)):f2}     {((slotchange.NewSlot - blocklinedoubles[2]) * direction):f2}  {0.00:f2}\r\n  {block.Face}      {(blocklinedoubles[0] - (oneEighty * blocklinedoubles[4]) + (lengthindirection + blocklinedoubles[2] - slotchange.NewSlot) * (1 - direction)):f2}{referenceFace}     {blocklinedoubles[1] + (lengthindirection + blocklinedoubles[2] - slotchange.NewSlot) * direction:f2}      {blocklinedoubles[2]:f2}    {"0.00l"}    {((slotchange.NewSlot - blocklinedoubles[2]) * (1 - direction)):f2}     {((slotchange.NewSlot - blocklinedoubles[2]) * direction):f2}  {0.00:f2}";
                                }
                            }
                        }
                    }
                }
                #endregion
                #region Replacing Layout Marks with Holes on Beams

                if (block.Type == "BO" && (shapeType == "W" || shapeType == "C" || shapeType == "TS" || shapeType == "WT" || shapeType == "S"))
                {
                    bool waitingOnDiameter = false;
                    int waitingDiameterIndex = 3;
                    int waitingOnDiameterLine = 0;
                    string lastNonZeroDiameter = "0.00";
                    for (int i = 0; i < block.Lines.Count; i++)
                    {
                        string[] blocklinevalues = Regex.Split(block.Lines[i], @"\s+");
                        int first;
                        if (string.IsNullOrWhiteSpace(blocklinevalues[0]) || Regex.IsMatch(blocklinevalues[0], @"[a-z]"))
                            first = 1;
                        else
                            first = 0;
                        if (Regex.IsMatch(blocklinevalues[first], @"[a-z]"))
                        {
                            blocklinevalues[first] = blocklinevalues[first].Substring(0, Regex.Match(blocklinevalues[first], @"[a-z]").Index);
                        }
                        double holeDiameter;
                        try
                        {
                            holeDiameter = Convert.ToDouble(blocklinevalues[first + 2]);
                        }
                        catch (Exception)
                        {
                            holeDiameter = 0;
                        }
                        
                        if (holeDiameter != 0)
                            lastNonZeroDiameter = blocklinevalues[first + 2];
                        if (shapeType == "W" || shapeType == "C" || shapeType == "TS" || shapeType == "WT" || shapeType == "S")
                        {
                            if (waitingOnDiameter && holeDiameter != 0)
                            {
                                string[] oldLine = Regex.Split(block.Lines[waitingOnDiameterLine], @"\s+");
                                oldLine[waitingDiameterIndex - 1] = oldLine[waitingDiameterIndex - 1].Replace("m", "");
                                oldLine[waitingDiameterIndex] = blocklinevalues[first + 3];
                                string newline = "";
                                for (int p = 0; p < oldLine.Count(); p++)
                                {
                                    newline = $"{newline} {oldLine[p]}";
                                }
                                block.Lines[waitingOnDiameterLine] = newline;
                                waitingOnDiameter = false;
                            }
                            if (Regex.IsMatch(blocklinevalues[first + 2], "m"))
                            {
                                blocklinevalues[first + 2] = blocklinevalues[first + 2].Replace("m","");
                                if (lastNonZeroDiameter == "0.00")
                                {
                                    waitingOnDiameter = true;
                                    waitingDiameterIndex = first + 3;
                                    waitingOnDiameterLine = i;
                                }
                                else
                                {
                                    string newline = "";
                                    blocklinevalues[first + 2] = lastNonZeroDiameter;
                                    for (int p = 0; p < blocklinevalues.Count(); p++)
                                    {
                                        newline = $"{newline} {blocklinevalues[p]}";
                                    }
                                    block.Lines[i] = newline;
                                }
                            }
                        }
                    }
                }
                #endregion
            }
            blocklist.AddRange(LayoutBLockList);

            double lengthFromAKBlocks = maxLength - minLength;
            if (maxLength - minLength != headerlength)
            {
                islengthchange = true;
                var change = new LengthChange();
                change.FileName = filename;
                change.InitialLength = headerlength.ToString();
                change.NewLength = lengthFromAKBlocks.ToString();
                if (headerlength - lengthFromAKBlocks >= 3.175)
                    change.OutOfTolerance = true;
                else
                    change.OutOfTolerance = false;
                lengthchanges.Add(change);
            }

            #endregion
            #region Re-Writing DSTV
            if (islengthchange)
            {
                textlines[headerlengthline] = textlines[headerlengthline].Substring(0, Regex.Match(textlines[headerlengthline], $"{headerlength.ToString()}").Index) + lengthFromAKBlocks.ToString() + '\r';                          
            }
            textlines[orderIDline] = $"  {jobNumber}";
            textlines[drawingIDline] = $"  {groupType}";
            textlines[phaseIDline] = $"  {batchNumber.TrimStart(new[] {'0'})}";
            var newfile = new StringBuilder();
            int linecounter = 0;
            foreach (string line in textlines)
            {
                if (linecounter == 25 + skippedlines)
                    break;
                newfile.Append(line + '\n');
                linecounter += 1;
            }
            foreach (Block block in blocklist)
            {
                if (block.Type.Trim() == "SI" || block.Type.Trim() == "PU" || block.Type.Trim() == "KO")
                    continue;
                newfile.Append(block.Type + '\r' + '\n');
                if (minLength > 0)
                    foreach (string blockline in block.Lines)
                     {
                        Regex doubleRegex = new Regex(@"\d+.\d+");
                        string offsetBlockLine = doubleRegex.Replace(blockline,(Convert.ToDouble(Regex.Match(blockline, @"\d+.\d+").Value) - minLength).ToString("F2"), 1);
                        newfile.Append(offsetBlockLine + '\r' + '\n');
                     }
                else
                foreach (string blockline in block.Lines)
                     {
                        newfile.Append(blockline + '\r' + '\n');
                     }
            }
            newfile.Append("EN");
            File.WriteAllText(filename, newfile.ToString());
            #endregion
        }
    }
}
