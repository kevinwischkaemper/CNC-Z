using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        #region Main Form
        BatchParser batchParser = new BatchParser();
        DSTVProcesssor dstvProcessor = new DSTVProcesssor();
        Batch currentBatch;        
        bool batchloaded = false;
        string cncbatchespath = @"Z:\Drawings in Process\CNC Batches";
        string machine = "Drill Line";
        string dstvPath;
        List<Part> beamParts = new List<Part>();
        string[] currentFiles = null; 

        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeBatch(object sender, EventArgs e)
        {
            var result = openReports.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadBatch(openReports.FileNames);
                currentFiles = openReports.FileNames;
            }
            else
                return;
        
        }

        private void LoadBatch(string[] filenames)
        {
            if (!batchParser.Verify(filenames))
            {
                MessageBox.Show("Must select one main and one assembly mark report of the same batch");
                return;
            }
            else
                currentBatch = batchParser.Parse(filenames);
            #region Turn Off All Displays
            this.dgvAnglesLengthChanges.Visible = false;
            this.dgvBeamsLengthChanges.Visible = false;
            this.dgvDRsFound.Visible = false;
            this.dgvDXFsNotFound.Visible = false;
            this.dgvNotFoundAngles.Visible = false;
            this.dgvNotFoundBeams.Visible = false;
            this.dgvNotVerifiedBeams.Visible = false;
            this.dgvSlotAdjustments.Visible = false;
            this.dgvStiffenersFound.Visible = false;
            this.lblAnglesDSTVsNotFoundInJob.Visible = false;
            this.lblAnglesHeaderLengthChanges.Visible = false;
            this.lblBeamsDSTVsNotFoundInJob.Visible = false;
            this.lblBeamsHeaderLengthChanges.Visible = false;
            this.lblCNCAnglesFolderCreated.Visible = false;
            this.lblCNCBeamsFolderCreated.Visible = false;
            this.lblComplete.Visible = false;
            this.lblDone.Visible = false;
            this.lblDRsFound.Visible = false;
            this.lblDSTVsNotExportedToPython.Visible = false;
            this.lblDXFsNotFound.Visible = false;
            this.lblSlotAdjustments.Visible = false;
            this.lblStiffenersFound.Visible = false;
            this.lblVerifiedPythonJobs.Visible = false;
            this.lblMachine.Text = "";
            this.btnChangeMachine.Visible = false;
            this.btnOpenDRs.Visible = false;
            this.btnOpenDXFsNotFound.Visible = false;
            this.btnOpenStiffeners.Visible = false;
            this.btnVerifyPythonBatch.Enabled = false;
            this.dgvMainList.Visible = false;
            this.tabControl1.Visible = false;
            this.dgvWTsFound.Visible = false;
            this.lblWTsFound.Visible = false;
            this.btnOpenWTDrawings.Visible = false;
            this.dgvLayoutMarksNeeded.Visible = false;
            this.labelLayoutMarksNeeded.Visible = false;
            this.btnOpenAngleLayoutPDFs.Visible = false;
            #endregion
            lblBatchHeading.Text = $"JOB {currentBatch.JobNumber}  BATCH {currentBatch.Batchnumber.TrimStart(new[] { '0' })}";
            batchloaded = true;
            this.btnGenerateShopPrints.Enabled = true;
            this.btnSortPlates.Enabled = true;
            if (this.chkAutoPlateSearch.CheckState == CheckState.Checked)
            {
                masterDXFsPath = currentBatch.FindPlateMasterDirectory();
                this.lblPlateSearchFolder.Text = masterDXFsPath;
            }
            this.chkAutoPlateSearch.Enabled = true;

            var anglePartsNeedingLayouts = currentBatch.Parts.Where(x => x.ShapeType == "L").Where(p => Regex.IsMatch(p.Notes, @"(M)|(CO)|(NS)|(DBA)") && !p.Notes.Contains("PM")).ToList();
            dgvLayoutMarksNeeded.DataSource = anglePartsNeedingLayouts;
            dgvLayoutMarksNeeded.Update();
            if (anglePartsNeedingLayouts.Any())
            {
                dgvLayoutMarksNeeded.Visible = true;
                labelLayoutMarksNeeded.Visible = true;
                this.btnOpenAngleLayoutPDFs.Visible = true;
            }
            this.dgvStiffenersFound.DataSource = currentBatch.Parts.Where(x => x.ShapeType == "PL" || x.ShapeType == "SH").Where(x => x.Notes.Contains("ST")).ToList();
            this.dgvStiffenersFound.Update();
            this.dgvStiffenersFound.Columns.Remove("Qty");
            this.dgvStiffenersFound.Columns.Remove("Grade");
            this.dgvStiffenersFound.Visible = true;
            this.btnOpenStiffeners.Visible = true;
            this.lblStiffenersFound.Visible = true;
            this.dgvDRsFound.DataSource = currentBatch.Parts.Where(x => x.ShapeType == "PL" || x.ShapeType == "SH").Where(x => x.Notes.Contains("DR")).ToList();
            this.dgvDRsFound.Update();
            this.dgvDRsFound.Columns.Remove("Qty");
            this.dgvDRsFound.Columns.Remove("Grade");
            this.dgvDRsFound.Visible = true;
            this.btnOpenDRs.Visible = true;
            this.lblDRsFound.Visible = true;
            this.beamParts = currentBatch.Parts.Where(x => x.ShapeType == "W" || x.ShapeType == "C" || x.ShapeType == "TS" || x.ShapeType == "WT" || x.ShapeType == "S" || x.ShapeType == "MC").ToList();
            machine = "Drill Line";
            this.btnChangeMachine.Visible = true;
            foreach (Part part in beamParts.Where(x => x.isMain).ToList())
            {
                if (part.Notes.Contains("CO") || part.Notes.Contains("BEV"))
                {
                    machine = "Python";
                    break;
                }
            }
            this.lblMachine.Text = machine;
            EventArgs e = null;
            TabChanged(this, e);
            this.dgvMainList.Visible = true;
            this.tabControl1.Visible = true;
            pDFsPath = currentBatch.FindJobPDFDirectory();
            this.lblPDFDirectory.Text = pDFsPath;
            pDFOutputPath = currentBatch.GetBatchDirectory();
            this.lblPDFOutputDirectory.Text = pDFOutputPath;
            gatherPath = currentBatch.GetGatherDirectory();
            if (machine == "Python")
            {
                this.btnVerifyPythonBatch.Enabled = true;
                if (!Directory.Exists($"{pythonJobsDirectory}\\{currentBatch.JobNumber.ToString()}\\BATCH {currentBatch.Batchnumber.TrimStart(new[] { '0' })}"))
                    Directory.CreateDirectory($"{pythonJobsDirectory}\\{currentBatch.JobNumber.ToString()}\\BATCH {currentBatch.Batchnumber.TrimStart(new[] { '0' })}");
            }
            if (machine == "Drill Line" && this.beamParts.Where(x => !x.isMain && (x.Notes.Contains("CO") || x.Notes.Contains("BEV"))).Select(x => x.Mark).ToList().Count > 0)
            {
                this.btnVerifyPythonBatch.Enabled = true;
                if (!Directory.Exists($"{pythonJobsDirectory}\\{currentBatch.JobNumber.ToString()}\\BATCH {currentBatch.Batchnumber.TrimStart(new[] { '0' })}"))
                    Directory.CreateDirectory($"{pythonJobsDirectory}\\{currentBatch.JobNumber.ToString()}\\BATCH {currentBatch.Batchnumber.TrimStart(new[] { '0' })}");
            }
        }

        private void ChangeMachine(object sender, EventArgs e)
        {
            if (machine == "Python")
            {
                machine = "Drill Line";
                if (this.beamParts.Where(x => !x.isMain && (x.Notes.Contains("CO") || x.Notes.Contains("BEV"))).Select(x => x.Mark).ToList().Count > 0)
                    this.btnVerifyPythonBatch.Enabled = true;
                else
                    this.btnVerifyPythonBatch.Enabled = false;
            }
            else
            {
                machine = "Python";
                this.btnVerifyPythonBatch.Enabled = true;
            }                
            this.lblMachine.Text = machine;
        }

        private void TabChanged(object sender, EventArgs e)
        {
            if (batchloaded)
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        dgvMainList.DataSource = currentBatch.Parts.Where(x => x.ShapeType == "PL" || x.ShapeType == "SH").ToList().OrderBy(x => Convert.ToInt32(Regex.Match(x.Mark, @"\d+").Value)).ToList().OrderBy(x => x.isMain).ToList();
                        dgvMainList.Update();
                        break;
                    case 1:
                        dgvMainList.DataSource = currentBatch.Parts.Where(x => x.ShapeType == "L").ToList().OrderBy(x => Convert.ToInt32(Regex.Match(x.Mark, @"\d+").Value)).ToList().OrderBy(x => x.isMain).ToList();
                        dgvMainList.Update();
                        break;
                    case 2:
                        dgvMainList.DataSource = this.beamParts.OrderBy(x => Convert.ToInt32(Regex.Match(x.Mark, @"\d+").Value)).ToList().OrderBy(x => x.isMain).ToList();
                        dgvMainList.Update();
                        break;
                    case 3:
                        dgvMainList.DataSource = currentBatch.Parts.Where(x => x.isMain).ToList().OrderBy(x => Convert.ToInt32(Regex.Match(x.Drawing, @"\d+").Value)).ToList();
                        dgvMainList.Update();
                        break;
                }
            }
        }
        #endregion

        #region Plates

        string masterDXFsPath;
        string gatherPath;
        string plateDXFsPath = @"G:\BURNING TABLE 1\2015 JOBS";
        string blankDXF = @"G:\Kevins Scripts, Lisps, Bats, AHK\Apps\FileManager\blank.dxf";
        List<Part> missingDXFs = new List<Part>();
        

        private void SelectMasterDXFsPath(object sender, EventArgs e)
        {
            DialogResult result = this.openMaster.ShowDialog();
            if (result == DialogResult.OK)
            {
                masterDXFsPath = this.openMaster.SelectedPath;
                this.lblPlateSearchFolder.Text = masterDXFsPath;
            }
        }

        private void chkAutoMasterDXFsFolderChanged(object sender, EventArgs e)
        {
            if (this.chkAutoPlateSearch.CheckState == CheckState.Unchecked)
            {
                masterDXFsPath = "";
                this.lblPlateSearchFolder.Text = masterDXFsPath;
                this.btnSelectMasterDXFsFolder.Enabled = true;

            }
            else
            {
                masterDXFsPath = currentBatch.FindPlateMasterDirectory();
                this.lblPlateSearchFolder.Text = masterDXFsPath;
                this.btnSelectMasterDXFsFolder.Enabled = false;
            }
        }

        private void SortPlates(object sender, EventArgs e)
        {
            this.lblComplete.Visible = true;
            this.lblComplete.Text = "Working....";
            if (string.IsNullOrEmpty(masterDXFsPath)) return;

            var platefilemanager = new BatchFileManager(plateDXFsPath, currentBatch);
            platefilemanager.CreateFolders();

            missingDXFs = platefilemanager.SearchAndSort(masterDXFsPath);
            if (missingDXFs.Any())
            {
                this.lblDXFsNotFound.Visible = true;
                this.dgvDXFsNotFound.DataSource = missingDXFs;
                this.dgvDXFsNotFound.Visible = true;
                this.dgvDXFsNotFound.Update();
                this.btnOpenDXFsNotFound.Visible = true;
                this.dgvDXFsNotFound.Columns.Remove("Qty");
                this.dgvDXFsNotFound.Columns.Remove("Grade");
            }
            else
            {
                this.lblDXFsNotFound.Visible = false;
                this.dgvDXFsNotFound.Visible = false;
            }

            this.lblComplete.Text = "Complete";
        }

        private void OpenStiffeners(object sender, EventArgs e)
        {
            foreach (Part stiffener in currentBatch.Parts.Where(x => x.ShapeType == "PL" || x.ShapeType == "SH").Where(x => x.Notes.Contains("ST")).ToList())
            {
                var filename = $"{masterDXFsPath}\\{stiffener.Mark}.dxf";
                Process.Start(filename);
            }
        }

        private void OpenDRs(object sender, EventArgs e)
        {
            foreach (Part drainhole in currentBatch.Parts.Where(x => x.ShapeType == "PL" || x.ShapeType == "SH").Where(x => x.Notes.Contains("DR")).ToList())
            {
                var filename = $"{masterDXFsPath}\\{drainhole.Mark}.dxf";
                Process.Start(filename);
            }
        }

        private void OpenDXFsNotFound(object sender, EventArgs e)
        {
            foreach (Part missingDXF in missingDXFs)
            {
                var destinationFile = Path.Combine(masterDXFsPath, $"{missingDXF.Mark}.dxf");
                File.Copy(blankDXF, destinationFile);
                Process.Start(destinationFile);

                if (missingDXF.isMain)
                {
                    var mainFiles = FileHelper.GetFiles(pDFsPath);
                    Process.Start(mainFiles.Where(x => Regex.Match(Path.GetFileNameWithoutExtension(x), @"\d+").Value == Regex.Match(missingDXF.Mark, @"\d+").Value).First());
                }

                else
                {
                    var assyFiles = FileHelper.GetFiles(gatherPath);
                    Process.Start(assyFiles.Where(x => Regex.IsMatch(Path.GetFileNameWithoutExtension(x), $"{missingDXF.Mark}")).First());
                }
                    
            }
        }
        #endregion

        #region Angles
        private void GenerateCNCAnglesBatch(object sender, EventArgs e)
        {
            dstvPath = currentBatch.FindJobCNCDirectory();
            string batchFolderName = $"{cncbatchespath}\\Batch {currentBatch.Batchnumber.TrimStart(new[] { '0' })} Angles - {machine}";
            Directory.CreateDirectory(batchFolderName);

            var files = FileHelper.GetFiles(dstvPath).ToList();
            var allDSTVs = files.Where(p => Path.GetExtension(p) == ".nc1").ToList();
            var notFoundDSTVs = new List<Part>();
            var angleParts = currentBatch.Parts.Where(x => x.ShapeType == "L").ToList();
            foreach (var part in angleParts)
            {
                bool dSTVFound = false;

                var matchingDSTVs = allDSTVs
                    .Where(x =>
                    {
                        var nameWithoutExtension = Path.GetFileNameWithoutExtension(x);
                        return nameWithoutExtension != null && nameWithoutExtension.ToLower() == part.Mark.ToLower();
                    })
                    .ToList();

                foreach (var dstv in matchingDSTVs)
                {
                    dSTVFound = true;
                    string newfile = Path.Combine(batchFolderName, Path.GetFileName(dstv));
                    File.Copy(dstv, newfile, true);
                    dstvProcessor.ProcessDSTV(newfile, currentBatch.JobNumber.ToString(), "ANGLES", currentBatch.Batchnumber);
                }

                if (!dSTVFound) notFoundDSTVs.Add(part);
            }
            var angleLengthChanges = dstvProcessor.lengthchanges.Where(x => angleParts.Select(p => p.Mark).ToList().Contains(Path.GetFileNameWithoutExtension(x.FileName))).ToList();
            if (angleLengthChanges.Count > 0)
            {
                this.dgvAnglesLengthChanges.DataSource = angleLengthChanges;
                this.dgvAnglesLengthChanges.Update();
                this.lblAnglesHeaderLengthChanges.Visible = true;
                this.dgvAnglesLengthChanges.Visible = true;
            }
            else
            {
                this.dgvAnglesLengthChanges.Visible = false;
                this.lblAnglesHeaderLengthChanges.Visible = false;
            }
            var slotLengthChanges = dstvProcessor.slotchanges.Where(x => angleParts.Select(p => p.Mark).ToList().Contains(Path.GetFileNameWithoutExtension(x.FileName))).ToList();
            if (slotLengthChanges.Count > 0)
            {
                this.dgvSlotAdjustments.DataSource = slotLengthChanges;
                this.dgvSlotAdjustments.Update();
                this.dgvSlotAdjustments.Visible = true;
                this.lblSlotAdjustments.Visible = true;
            }
            else
            {
                this.dgvSlotAdjustments.Visible = false;
                this.lblSlotAdjustments.Visible = false;
            }
            if (notFoundDSTVs.Count > 0)
            {
                this.dgvNotFoundAngles.DataSource = notFoundDSTVs;
                this.dgvNotFoundAngles.Update();
                this.lblAnglesDSTVsNotFoundInJob.Visible = true;
                this.dgvNotFoundAngles.Visible = true;
            }
            else
            {
                this.dgvNotFoundAngles.Visible = false;
                this.lblAnglesDSTVsNotFoundInJob.Visible = false;
                this.lblCNCAnglesFolderCreated.Visible = true;
            }
        }
        #endregion

        #region Beams        
        string pythonJobsDirectory = "G:\\PYTHON JOBS";
        
        private void GenerateCNCBeamsBatch(object sender, EventArgs e)
        {
            dstvPath = currentBatch.FindJobCNCDirectory();
            string batchFolderName = $"{cncbatchespath}\\Batch {currentBatch.Batchnumber.TrimStart(new[] { '0' })} Beams - {machine}";
            Directory.CreateDirectory(batchFolderName);            
            var files = FileHelper.GetFiles(dstvPath).ToList();
            var allDSTVs = files.Where(p => Path.GetExtension(p) == ".nc1").ToList();
            var notFoundDSTVs = new List<Part>();            
            foreach (var part in this.beamParts)
            {
                bool dSTVFound = false;
                var matchingDSTVs = allDSTVs
                    .Where(x =>
                    {
                        var nameWithoutExtension = Path.GetFileNameWithoutExtension(x);
                        return nameWithoutExtension != null && nameWithoutExtension.ToLower() == part.Mark.ToLower();
                    })
                    .ToList();
                foreach (var dstv in matchingDSTVs)
                {
                    dSTVFound = true;
                    string newfile = Path.Combine(batchFolderName, Path.GetFileName(dstv));
                    File.Copy(dstv, newfile, true);
                    dstvProcessor.ProcessDSTV(newfile, currentBatch.JobNumber.ToString(), "BEAMS", currentBatch.Batchnumber);
                }

                if (!dSTVFound)
                    notFoundDSTVs.Add(part);
            }

            

            var wts = currentBatch.Parts.Where(x => x.ShapeType == "WT").ToList();
            if (wts.Count > 0)
            {
                this.dgvWTsFound.DataSource = wts;
                this.dgvWTsFound.Update();
                this.dgvWTsFound.Columns.Remove("Qty");
                this.dgvWTsFound.Columns.Remove("Grade");
                this.dgvWTsFound.Visible = true;
                this.lblWTsFound.Visible = true;
                this.btnOpenWTDrawings.Visible = true;
            }
            var beamLengthChanges = dstvProcessor.lengthchanges.Where(x => this.beamParts.Select(p => p.Mark).ToList().Contains(Path.GetFileNameWithoutExtension(x.FileName))).ToList();
            if (beamLengthChanges.Count > 0)
            {
                this.dgvBeamsLengthChanges.DataSource = beamLengthChanges;
                this.dgvBeamsLengthChanges.Update();
                this.lblBeamsHeaderLengthChanges.Visible = true;
                this.dgvBeamsLengthChanges.Visible = true;
            }
            
            if (notFoundDSTVs.Count > 0)
            {
                this.dgvNotFoundBeams.DataSource = notFoundDSTVs;
                this.dgvNotFoundBeams.Update();
                this.lblBeamsDSTVsNotFoundInJob.Visible = true;
                this.dgvNotFoundBeams.Visible = true;
            }
            else
            {
                this.lblBeamsDSTVsNotFoundInJob.Visible = false;
                this.dgvNotFoundBeams.Visible = false;
                this.lblCNCBeamsFolderCreated.Visible = true;
            }            
        }

        private void OpenWTDrawings(object sender, EventArgs e)
        {
            foreach (Part missingWT in currentBatch.Parts.Where(x => x.ShapeType == "WT").ToList())
            {
                if (missingWT.isMain)
                {
                    var mainFiles = FileHelper.GetFiles(pDFsPath);
                    Process.Start(mainFiles.Where(x => Regex.Match(Path.GetFileNameWithoutExtension(x), @"\d+").Value == Regex.Match(missingWT.Mark, @"\d+").Value).First());
                }
                else
                {
                    var assyFiles = FileHelper.GetFiles(gatherPath);
                    Process.Start(assyFiles.Where(x => Regex.IsMatch(Path.GetFileNameWithoutExtension(x), $"{missingWT.Mark}")).First());
                }
            }
        }

        private void StandardFullPenPrep(object sender, EventArgs e)
        {
            if (dgvMainList.SelectedRows.Count != 1)
            {
                MessageBox.Show("Must only have one part selected.");
                return;
            }
            else
            {
                string piecemark = dgvMainList.SelectedRows[0].Cells[1].Value.ToString();
                string filename = $"{cncbatchespath}\\Batch {currentBatch.Batchnumber.TrimStart(new[] { '0' })} Beams - {machine}\\{piecemark}.nc1";

                string text = File.ReadAllText(filename);

                #region Header Parsing    
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
                double headerlength = Convert.ToDouble(textlines[9 + skippedlines].TrimEnd(new[] { '\r' }));
                headerlength += 12.70;
                int headerlengthline = 9 + skippedlines;
                double profileHeight = Convert.ToDouble(textlines[10 + skippedlines].TrimEnd(new[] { '\r' }));
                double flangeWidth = Convert.ToDouble(textlines[11 + skippedlines].TrimEnd(new[] { '\r' }));
                double flangeThickness = Convert.ToDouble(textlines[12 + skippedlines].TrimEnd(new[] { '\r' }));
                #endregion

                #region Block Parsing
                var blocktitlematch = new Regex("(\\n[A-Z][A-Z]\\r\\n)|(EN)");
                List<Block> blocklist = new List<Block>();
                foreach (Match blockmatch in blocktitlematch.Matches(text))
                {
                    if (blockmatch.Value.Contains("ST"))
                        continue;
                    if (blockmatch.Value.Contains("AK"))
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
                    List<string> newLines = new List<string>();
                    foreach  (string line in block.Lines)
                    {
                        string[] splitline = Regex.Split(line.Trim(), @"\s+");
                        string referenceFace = Regex.Match(splitline[1], "[a-z]").Value;
                        double xValue = Convert.ToDouble(splitline[1].Remove(splitline[1].Length - 1)) + 4.7625;
                        Regex xRegex = new Regex(splitline[1]);
                        newLines.Add(xRegex.Replace(line, $"{xValue.ToString()}{referenceFace}", 1));
                    }
                    block.Lines = newLines;
                    blocklist.Add(block);
                }
                #endregion

                #region AddingContourBlocks
                blocklist.Add(GenerateFullPenPreppedTopBlock(headerlength, flangeWidth, flangeThickness));
                blocklist.Add(GenerateFullPenPreppedBottomBlock(headerlength, flangeWidth, flangeThickness));
                blocklist.Add(GenerateFullPenPreppedWebBlock(headerlength, flangeThickness, profileHeight));
                
                #endregion

                #region Re-Writing DSTV
                var newfile = new StringBuilder();
                int linecounter = 0;
                textlines[headerlengthline] = textlines[headerlengthline].Substring(0, Regex.Match(textlines[headerlengthline], $"{headerlength.ToString()}").Index) + $"{headerlength}" + '\r';
                // need to increase the headerlength by 0.5 - make sure the increased length gets passed to generators
                foreach (string line in textlines)
                {
                    if (linecounter == 25 + skippedlines)
                        break;
                    newfile.Append(line + '\n');
                    linecounter += 1;
                }
                foreach (Block block in blocklist)
                {
                    newfile.Append(block.Type + '\r' + '\n');
                    foreach (string blockline in block.Lines)
                    {
                        newfile.Append(blockline + '\r' + '\n');
                    }
                }
                newfile.Append("EN" + '\r' + '\n');
                File.WriteAllText(filename, newfile.ToString());
                #endregion
            }
        }

        private Block GenerateFullPenPreppedBottomBlock(double x, double f, double y)
        {
            Block newBlock = new Block();
            newBlock.Type = "AK";
            newBlock.Lines = new List<string>();
            newBlock.Lines.Add($"  u  3.17u  0.00  0.00");
            newBlock.Lines.Add($"  u  {(x - 3.17):f2}u  0.00  0.00  -45.00  {(y):f2}");
            newBlock.Lines.Add($"  u  {(x - 3.17):f2}u  {f:f2}  0.00");
            newBlock.Lines.Add($"  u  3.17u  {f:f2}  0.00  -45.00  {(y):f2}");
            newBlock.Lines.Add($"  u  3.17u  0.00  0.00  -45.00  {(y):f2}");
            return newBlock;
        }

        private Block GenerateFullPenPreppedTopBlock(double x, double f, double y)
        {
            Block newBlock = new Block();
            newBlock.Type = "AK";
            newBlock.Lines = new List<string>();
            newBlock.Lines.Add($"  o  6.35u  {(f):f2}  0.00");
            newBlock.Lines.Add($"  o  {(x - 6.35):f2}u  {(f):f2}  0.00  45.00  0.00");
            newBlock.Lines.Add($"  o  {(x - 6.35):f2}u  0.00  0.00");
            newBlock.Lines.Add($"  o  6.35u  0.00  0.00  45.00  0.00");
            newBlock.Lines.Add($"  o  6.35u  {(f):f2}  0.00  45.00  0.00");
            return newBlock;
        }

        private Block GenerateFullPenPreppedWebBlock(double x, double y, double f)
        {
            Block newBlock = new Block();
            newBlock.Type = "AK";
            newBlock.Lines = new List<string>();
            newBlock.Lines.Add($"  v  3.175u  0.00  0.00");
            newBlock.Lines.Add($"  v  {(x - 3.175):f2}u  0.00  0.00");
            newBlock.Lines.Add($"  v  {(x - y - 3.175):f2}u  {y:f2}  0.00");
            newBlock.Lines.Add($"  v  {(x - y - 9.525):f2}u  {y:f2}  0.00");
            newBlock.Lines.Add($"  v  {(x - 38.1):f2}u  {28.575:f2}  0.00");
            newBlock.Lines.Add($"  v  {(x - 38.1):f2}u  {(y + 25.4):f2}  0.00");
            newBlock.Lines.Add($"  v  {(x - 9.525):f2}u  {(y + 25.4):f2}  0.00");
            newBlock.Lines.Add($"  v  {(x - 9.525):f2}u  {(f - y - 25.4):f2}  0.00");
            newBlock.Lines.Add($"  v  {(x - 38.1):f2}u  {(f - y - 25.4):f2}  0.00");
            newBlock.Lines.Add($"  v  {(x - 38.1):f2}u  {(f - y - 12.7):f2}  0.00");
            newBlock.Lines.Add($"  v  {(x - 23.8125):f2}u  {(f - y):f2}  0.00");
            newBlock.Lines.Add($"  v  {(x - 6.35):f2}u  {(f - y):f2}  0.00");
            newBlock.Lines.Add($"  v  {(x - 25.4):f2}u  {(f):f2}  0.00");
            newBlock.Lines.Add($"  v  {(6.35 + y):f2}u  {(f):f2}  0.00");
            newBlock.Lines.Add($"  v  {(6.35):f2}u  {(f - y):f2}  0.00");
            newBlock.Lines.Add($"  v  {(20.6375):f2}u  {(f - y):f2}  0.00");
            newBlock.Lines.Add($"  v  {(34.925):f2}u  {(f - y - 12.7):f2}  0.00");
            newBlock.Lines.Add($"  v  {(34.925):f2}u  {(f - y - 25.4):f2}  0.00");
            newBlock.Lines.Add($"  v  {(6.35):f2}u  {(f - y - 25.4):f2}  0.00");
            newBlock.Lines.Add($"  v  {(6.35):f2}u  {(25.4 + y):f2}  0.00");
            newBlock.Lines.Add($"  v  {(34.925):f2}u  {(25.4 + y):f2}  0.00");
            newBlock.Lines.Add($"  v  {(34.925):f2}u  {(28.575):f2}  0.00");
            newBlock.Lines.Add($"  v  {(6.35 + y):f2}u  {(y):f2}  0.00");
            newBlock.Lines.Add($"  v  {(3.175 + y):f2}u  {(y):f2}  0.00");
            newBlock.Lines.Add($"  v  3.175u  0.00  0.00");
            return newBlock;
        }

        private void VerifyPythonBatch(object sender, EventArgs e)
        { 
            string pythonJobsFolderName = $"{pythonJobsDirectory}\\{currentBatch.JobNumber.ToString()}\\BATCH {currentBatch.Batchnumber.TrimStart(new[] { '0' })}";
            var pythonFiles = FileHelper.GetFiles(pythonJobsFolderName).ToList().Where(p => Path.GetExtension(p) == ".nc1").ToList().Select(x => x = Path.GetFileNameWithoutExtension(x)).ToList();
            List<string> beamFiles;
            var filesNotVerified = new List<string>();
            if (machine == "Python")
                beamFiles = beamParts.Select(x => x.Mark).ToList();
            else
                beamFiles = beamParts.Where(x => (!x.isMain && (x.Notes.Contains("CO") || x.Notes.Contains("BEV"))) || x.ShapeType == "WT").Select(x => x.Mark).ToList();
            foreach (string file in beamFiles)
            {
                if (pythonFiles.Where(x => x == file).Any())
                    continue;
                else
                    filesNotVerified.Add(file);
            }            
            if (filesNotVerified.Count > 0)
            {
                this.dgvNotVerifiedBeams.DataSource = currentBatch.Parts.Where(x => filesNotVerified.Contains(x.Mark)).ToList();
                this.dgvNotVerifiedBeams.Update();
                this.lblDSTVsNotExportedToPython.Visible = true;
                this.dgvNotVerifiedBeams.Visible = true;
            }
            else
            {
                this.lblVerifiedPythonJobs.Visible = true;
                this.lblDSTVsNotExportedToPython.Visible = false;
                this.dgvNotVerifiedBeams.Visible = false;
            }            
        }
        #endregion

        #region Combine PDFs
        string pDFsPath;
        string pDFOutputPath;
                
        private void AutoPDFsDirectoryChecked(object sender, EventArgs e)
        {
            if (this.chckAutoPDFsDirectory.CheckState.Equals(CheckState.Unchecked))
            {
                this.btnSelectPDFOutputDirectory.Enabled = true;
                pDFsPath = "";
                this.lblPDFDirectory.Text = pDFsPath;

            }
            else
            {
                this.btnSelectPDFOutputDirectory.Enabled = false;
                pDFsPath = currentBatch.FindJobPDFDirectory();
                this.lblPDFDirectory.Text = pDFsPath;
            }
        }

        private void SelectPDFsDirectory(object sender, EventArgs e)
        {
            this.openPDFsDirectory.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = this.openPDFsDirectory.ShowDialog();
            if (result == DialogResult.OK)
            {
                pDFsPath = this.openPDFsDirectory.SelectedPath;
                this.lblPDFDirectory.Text = pDFsPath;
            }
        }

        private void AutoPDFOutputDirectoryChecked(object sender, EventArgs e)
        {
            if (this.chckAutoPDFOutputDirectory.CheckState.Equals(CheckState.Unchecked))
            {
                this.btnSelectPDFOutputDirectory.Enabled = true;
                pDFOutputPath = "";
                this.lblPDFOutputDirectory.Text = pDFOutputPath;
            }
            else
            {
                this.btnSelectPDFOutputDirectory.Enabled = false;
                pDFOutputPath = currentBatch.GetBatchDirectory();
                this.lblPDFOutputDirectory.Text = pDFOutputPath;
            }
        }

        private void SelectPDFOutputDirectory(object sender, EventArgs e)
        {
            this.openPDFOutputDirectory.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = this.openPDFOutputDirectory.ShowDialog();
            if (result == DialogResult.OK)
            {
                pDFOutputPath = this.openPDFOutputDirectory.SelectedPath;
                this.lblPDFOutputDirectory.Text = pDFOutputPath;
            }
        }

        private void GenerateShopPrints(object sender, EventArgs e)
        {
            
            this.lblDone.Text = "Working...";
            var drawingPDFService = new DrawingPDFService();
            string outputname = string.Format("\\BATCH {0} SEQ {1} {2}.pdf", currentBatch.Batchnumber.TrimStart(new[] { '0' }), this.txtSequence.Text, this.txtBatchDescription.Text);
            var outputPdfPath = string.Format("{0}{1}", pDFOutputPath, outputname);
            if (FileHelper.GetFiles(pDFOutputPath).Where(x => x.Contains(currentBatch.Batchnumber.TrimStart(new[] { '0' }))).Any())
            {
                string shopPrintPDF = FileHelper.GetFiles(pDFOutputPath).Where(x => x.Contains(currentBatch.Batchnumber.TrimStart(new[] { '0' }))).First();
                using (var form = new ShopPrintExists(Path.GetFileNameWithoutExtension(shopPrintPDF)))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            File.Delete(shopPrintPDF);

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Cannot overwrite because file is already open.");
                            return;
                        }
                    }
                    else
                        return;
                }
            }
            
            var drawingNumbers = currentBatch.Parts.Select(x => x.Drawing)
            .Distinct()
            .ToList()
            .OrderBy(x => Convert.ToInt32(Regex.Match(x, @"\d+").Value));

            var files = FileHelper.GetFiles(pDFsPath);
            var matches = new List<string>();
            var missings = new List<string>();

            foreach (var drawingNumber in drawingNumbers)
            {
                var matchingFile = files
                    .Where(p => Path.GetFileName(p) == $"{drawingNumber}.pdf")
                    .OrderByDescending(p => File.GetLastWriteTime(p))
                    .FirstOrDefault();
                if (string.IsNullOrEmpty(matchingFile) && Regex.Match(drawingNumber,@"\d+").Value.Length == 4 && Regex.Match(drawingNumber, @"\d+").Value.StartsWith("0"))
                    matchingFile = files.Where(p => Path.GetFileName(p) == Regex.Replace($"{drawingNumber}.pdf", "B0","B"))
                                        .OrderByDescending(p => File.GetLastWriteTime(p))
                                        .FirstOrDefault();
                if (string.IsNullOrEmpty(matchingFile))
                {
                    MessageBox.Show(string.Format("{0} not found, please select", drawingNumber));
                    this.openMissingPDF.Title = string.Format("{0} not found, please select", drawingNumber);
                    DialogResult result = this.openMissingPDF.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        matchingFile = this.openMissingPDF.FileName;
                    }
                }
                if (matchingFile != null)
                {
                    bool matchAdded = false;
                    if (matchingFile.EndsWith("A.pdf"))
                    {
                        matches.Add(matchingFile);
                        matchAdded = true;
                        var additionalFile = Regex.Replace(matchingFile, "A.pdf", "B.pdf");
                        if (File.Exists(additionalFile))
                            matches.Add(additionalFile);
                    }
                    if (matchingFile.EndsWith("B.pdf"))
                    {
                        var additionalFile = Regex.Replace(matchingFile, "B.pdf", "A.pdf");
                        if (File.Exists(additionalFile))
                            matches.Add(additionalFile);
                        matches.Add(matchingFile);
                        matchAdded = true;
                    }
                    if (!matchAdded)
                        matches.Add(matchingFile);
                }
            }
            drawingPDFService.GenerateShopPrintPdf(currentBatch, matches, outputPdfPath, this.txtSequenceColor.Text);
            this.lblDone.Text = string.Format("{0} generated.", outputname);
            Process.Start(outputPdfPath);
        }

        private void OpenShopPrints(object sender, EventArgs e)
        {
            if (pDFOutputPath.Contains(".pdf"))
                Process.Start(pDFOutputPath);
            else
            {
                try
                {
                    string shopPrintPDF = FileHelper.GetFiles(pDFOutputPath).Where(x => x.Contains(currentBatch.Batchnumber.TrimStart(new[] { '0' }))).First();
                    Process.Start(shopPrintPDF);
                }
                catch (Exception)
                {
                    MessageBox.Show("Shop print not found");
                    return;
                }
            }
            return;
        }

        private void PrintPDF(object sender, EventArgs e)
        {
            string shopPrintPDF = " ";
            try
            {
                shopPrintPDF = FileHelper.GetFiles(pDFOutputPath).Where(x => x.Contains(currentBatch.Batchnumber.TrimStart(new[] { '0' }))).First();
            }
            catch (Exception)
            {
                MessageBox.Show("Shop print not found");
                return;
            }
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = shopPrintPDF;
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(3000);
            if (false == p.CloseMainWindow())
                p.Kill();
        }



        #endregion

        private void PreviousBatch(object sender, EventArgs e)
        {
            int batchnumber = Convert.ToInt32(Regex.Match(currentFiles[0], @"\d+").Value) - 1;
            string[] newFiles = new string[] { $"Z:\\Drawings in Process\\Batch Reports\\{batchnumber.ToString()}M.pdf", $"Z:\\Drawings in Process\\Batch Reports\\{batchnumber.ToString()}A.pdf" };
            try
            {
                LoadBatch(newFiles);
                currentFiles = newFiles;
            }
            catch (Exception)
            {
                MessageBox.Show("Batch reports cannot be found");
                return;
            }
        }

        private void NextBatch(object sender, EventArgs e)
        {
            int batchnumber = Convert.ToInt32(Regex.Match(currentFiles[0], @"\d+").Value) + 1;
            string[] newFiles = new string[] { $"Z:\\Drawings in Process\\Batch Reports\\{batchnumber.ToString()}M.pdf", $"Z:\\Drawings in Process\\Batch Reports\\{batchnumber.ToString()}A.pdf" };
            try
            {
                LoadBatch(newFiles);
                currentFiles = newFiles;
            }
            catch (Exception)
            {
                MessageBox.Show("Batch reports cannot be found");
                return;
            }
        }

        private void OpenAngleLayoutMarkPDFs(object sender, EventArgs e)
        {
            var anglePartsNeedingLayouts = currentBatch.Parts.Where(x => x.ShapeType == "L").Where(p => Regex.IsMatch(p.Notes, @"(M)|(CO)|(NS)|(DBA)") && !p.Notes.Contains("PM")).ToList();
            foreach (Part angle in anglePartsNeedingLayouts)
            {
                if (angle.isMain)
                {
                    var mainFiles = FileHelper.GetFiles(pDFsPath);
                    Process.Start(mainFiles.Where(x => Regex.Match(Path.GetFileNameWithoutExtension(x), @"\d+").Value == Regex.Match(angle.Mark, @"\d+").Value).First());
                }
                else
                {
                    var assyFiles = FileHelper.GetFiles(gatherPath);
                    Process.Start(assyFiles.Where(x => Regex.IsMatch(Path.GetFileNameWithoutExtension(x), $"{angle.Mark}")).First());
                }
            }
        }

    }
}
