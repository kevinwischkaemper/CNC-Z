using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileManager
{
    internal class BatchFileManager
    {
        private Batch currentbatch;
        private string plateDXFsPath;

        public BatchFileManager(string plateDXFsPath, Batch currentbatch)
        {
            this.plateDXFsPath = plateDXFsPath;
            this.currentbatch = currentbatch;
        }

        internal void CreateFolders()
        {
            var jobFolderPath = Path.Combine(plateDXFsPath, currentbatch.JobNumber.ToString());
            if (!Directory.Exists(jobFolderPath)) Directory.CreateDirectory(jobFolderPath);

            var batchFolderPath = Path.Combine(jobFolderPath, $"Batch {Int32.Parse(currentbatch.Batchnumber)}");
            if (!Directory.Exists(batchFolderPath)) Directory.CreateDirectory(batchFolderPath);
            foreach (var partFolderPath in currentbatch.Parts.Where(x => x.ShapeType == "PL" || x.ShapeType == "SH").Select(part => Path.Combine(batchFolderPath, $"{part.ShapeType}{part.ShapeDetails.Replace("/", "")}")).Where(partFolderPath => !Directory.Exists(partFolderPath)))
            {
                Directory.CreateDirectory(partFolderPath);
            }
        }

        internal List<Part> SearchAndSort(string searchFolderPath)
        {
            var files = FileHelper.GetFiles(searchFolderPath).ToList();
            var allDxfs = files.Where(p => Path.GetExtension(p) == ".dxf").ToList();
            var notFoundDxfs = new List<Part>();

            foreach (var part in currentbatch.Parts.Where(x => x.ShapeType == "PL" || x.ShapeType == "SH"))
            {
                bool dxfFound = false;

                var matchingDxfs = allDxfs
                    .Where(p =>
                    {
                        var nameWithoutExtension = Path.GetFileNameWithoutExtension(p);
                        return nameWithoutExtension != null && nameWithoutExtension.ToLower() == part.Mark.ToLower();
                    })
                    .ToList();

                foreach (var dxf in matchingDxfs)
                {
                    dxfFound = true;
                    File.Copy(dxf, Path.Combine(GetDestinationPartFolder(part), Path.GetFileName(dxf)), true);
                }

                if (!dxfFound) notFoundDxfs.Add(part);
            }

            return notFoundDxfs;
        }

        internal string GetDestinationPartFolder(Part part)
        {
            var jobFolderPath = Path.Combine(plateDXFsPath, currentbatch.JobNumber.ToString());
            var batchFolderPath = Path.Combine(jobFolderPath, $"Batch {Int32.Parse(currentbatch.Batchnumber)}");
            var description = $"{part.ShapeType}{part.ShapeDetails}";
            return Path.Combine(batchFolderPath, description.Replace("/", ""));
        }
    }
}