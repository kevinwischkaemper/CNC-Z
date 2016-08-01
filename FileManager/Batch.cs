using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileManager
{
    internal class Batch
    {
        public string Batchnumber;
        public string JobNumber;
        public List<Part> Parts;

        internal string FindPlateMasterDirectory()
        {
            try
            {
                string[] anyjobfolders = Directory.GetDirectories(@"G:\BURNING TABLE 1\2015 JOBS");
                string rightjob = anyjobfolders.ToList<string>().Where(p => p.Contains(JobNumber.ToString())).First<string>();
                string[] rightjobfolders = Directory.GetDirectories(rightjob);
                return rightjobfolders.ToList<string>().Where(p => p.Contains("MASTER")).First<string>();
            }
            catch (Exception)
            {
                return "Plate Master folder not found";
            }
        }

        internal string FindJobPDFDirectory()
        {
            try
            {
                string[] anyjobfolders = Directory.GetDirectories(@"Z:\Drawings in Process\2015 JOBS");
                var listfolders = anyjobfolders.ToList<string>();
                string rightjob = anyjobfolders.ToList<string>().Where(p => p.Contains(JobNumber.ToString())).First<string>();
                string[] rightjobfolders = Directory.GetDirectories(rightjob);
                listfolders = anyjobfolders.ToList<string>();
                return rightjobfolders.ToList<string>().Where(p => p.Contains("PDF")).First<string>();
            }
            catch (Exception)
            {
                try
                {
                    string[] anyjobfolders = Directory.GetDirectories(@"Z:\Drawings in Process\2016 JOBS");
                    var listfolders = anyjobfolders.ToList<string>();
                    string rightjob = anyjobfolders.ToList<string>().Where(p => p.Contains(JobNumber.ToString())).First<string>();
                    string[] rightjobfolders = Directory.GetDirectories(rightjob);
                    listfolders = anyjobfolders.ToList<string>();
                    return rightjobfolders.ToList<string>().Where(p => p.Contains("PDF")).First<string>();

                }
                catch (Exception)
                {

                    return "Job PDFs folder not found";
                }
            }
        }

        internal string FindJobCNCDirectory()
        {
            try
            {
                string[] anyjobfolders = Directory.GetDirectories(@"Z:\Drawings in Process\2015 JOBS");
                var listfolders = anyjobfolders.ToList<string>();
                string rightjob = anyjobfolders.ToList<string>().Where(p => p.Contains(JobNumber)).First<string>();
                string[] rightjobfolders = Directory.GetDirectories(rightjob);
                listfolders = anyjobfolders.ToList<string>();
                return rightjobfolders.ToList<string>().Where(p => p.Contains("NC1")).First<string>();
            }
            catch (Exception)
            {
                try
                {
                    string[] anyjobfolders = Directory.GetDirectories(@"Z:\Drawings in Process\2016 JOBS");
                    var listfolders = anyjobfolders.ToList<string>();
                    string rightjob = anyjobfolders.ToList<string>().Where(p => p.Contains(JobNumber)).First<string>();
                    string[] rightjobfolders = Directory.GetDirectories(rightjob);
                    listfolders = anyjobfolders.ToList<string>();
                    return rightjobfolders.ToList<string>().Where(p => p.Contains("NC1")).First<string>();

                }
                catch (Exception)
                {

                    return "Job NC1s folder not found";
                }
            }
        }

        internal string GetBatchDirectory()
        {
            try
            {
                string[] anyjobfolders = Directory.GetDirectories(@"N:\FY 2015");
                var listfolders = anyjobfolders.ToList<string>();
                string rightjob = anyjobfolders.ToList<string>().Where(p => p.Contains(JobNumber)).First<string>();
                string[] rightjobfolders = Directory.GetDirectories(rightjob);
                listfolders = anyjobfolders.ToList<string>();
                return rightjobfolders.ToList<string>().Where(p => p.Contains("BATCH")).First<string>();
            }
            catch (Exception)
            {
                try
                {
                    string[] anyjobfolders = Directory.GetDirectories(@"N:\FY 2016");
                    var listfolders = anyjobfolders.ToList<string>();
                    string rightjob = anyjobfolders.ToList<string>().Where(p => p.Contains(JobNumber)).First<string>();
                    string[] rightjobfolders = Directory.GetDirectories(rightjob);
                    listfolders = anyjobfolders.ToList<string>();
                    return rightjobfolders.ToList<string>().Where(p => p.Contains("BATCH")).First<string>();

                }
                catch (Exception)
                {

                    return "Batch folder not found";
                }
            }
        }

        internal string GetGatherDirectory()
        {
            try
            {
                string[] anyjobfolders = Directory.GetDirectories(@"N:\FY 2015");
                var listfolders = anyjobfolders.ToList<string>();
                string rightjob = anyjobfolders.ToList<string>().Where(p => p.Contains(JobNumber)).First<string>();
                string[] rightjobfolders = Directory.GetDirectories(rightjob);
                listfolders = anyjobfolders.ToList<string>();
                return rightjobfolders.ToList<string>().Where(p => p.Contains("GATHER")).First<string>();
            }
            catch (Exception)
            {
                try
                {
                    string[] anyjobfolders = Directory.GetDirectories(@"N:\FY 2016");
                    var listfolders = anyjobfolders.ToList<string>();
                    string rightjob = anyjobfolders.ToList<string>().Where(p => p.Contains(JobNumber)).First<string>();
                    string[] rightjobfolders = Directory.GetDirectories(rightjob);
                    listfolders = anyjobfolders.ToList<string>();
                    return rightjobfolders.ToList<string>().Where(p => p.Contains("GATHER")).First<string>();

                }
                catch (Exception)
                {

                    return "Gather sheet folder not found";
                }
            }
        }
    }
}