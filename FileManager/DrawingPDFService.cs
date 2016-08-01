using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class DrawingPDFService
    {
        public void GenerateShopPrintPdf(Batch batch, IEnumerable<string> pdfFilePaths, string outputPath, string color,
            bool isForQa = false)
        {

            var pdfFilePathsList = pdfFilePaths.ToList();
            if (!pdfFilePathsList.Any()) return;
            float scaleFactor = 0.95f;

            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));
            PdfReader reader;
            string shopprintfilepath = "G:\\Kevins Scripts, Lisps, Bats, AHK\\Apps\\stamp.png";
            iTextSharp.text.Image shopprint = Image.GetInstance(shopprintfilepath);

            doc.Open();
            PdfContentByte cb = writer.DirectContent;

            for (var i = 0; i < pdfFilePathsList.Count; i++)
            {
                reader = new PdfReader(pdfFilePathsList[i]);

                doc.SetPageSize(
                    reader.GetPageSizeWithRotation(1));
                doc.SetMargins(0, 0, 0, 0);

                doc.NewPage();
                PdfImportedPage importedPage = writer.GetImportedPage(reader, 1);

                var pageRotation = reader.GetPageRotation(1);
                var pageWidth = reader.GetPageSizeWithRotation(1).Width;
                var pageHeight = reader.GetPageSizeWithRotation(1).Height;
                var basefont = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                var batchString = string.Format("BATCH {0}   {1}", batch.Batchnumber.TrimStart(new[] { '0' }), color);
                var jobString = string.Format("JOB {0}", batch.JobNumber);
                float fontsize = (pageHeight * .025f);

                float jobx = (pageWidth * 0.15f);
                float joby = (pageHeight * .97f);
                float batchy = joby - fontsize - 3f;



                cb.BeginText();
                cb.SetFontAndSize(basefont, fontsize);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, jobString, jobx + 60f, joby, 0);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, batchString, jobx + 60f, batchy, 0);
                cb.EndText();

                switch (pageRotation)
                {
                    case 0:
                        writer.DirectContent.AddTemplate(importedPage, scaleFactor, 0, 0, scaleFactor, 0, 0);
                        break;

                    case 90:
                        writer.DirectContent.AddTemplate(importedPage, 0, (scaleFactor * -1), scaleFactor, 0, 0, (pageHeight - (pageHeight * .05)));
                        break;

                    case 180:
                        writer.DirectContent.AddTemplate(importedPage, (scaleFactor * -1), 0, 0, (scaleFactor * -1), (pageWidth - (pageWidth * .05)), (pageHeight - (pageHeight * .05)));
                        break;

                    case 270:
                        writer.DirectContent.AddTemplate(importedPage, 0, scaleFactor, (scaleFactor * -1), 0, (pageWidth - (pageWidth * .05)), 0);
                        break;

                    default:
                        throw new InvalidOperationException($"Unexpected page rotation: [{pageRotation}].");
                }

                float shopprintheightscale = (pageHeight * .2f);
                float shopprintwidthscale = (pageWidth * .2f);
                float shopprintheight = (pageHeight * .93f);
                shopprint.SetAbsolutePosition(80f, shopprintheight);
                shopprint.ScaleToFit(shopprintheightscale, shopprintwidthscale);
                doc.Add(shopprint);





            }

            doc?.Close();
        }

        private double DegreeToRadian(int angle, bool isNegative = false)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
