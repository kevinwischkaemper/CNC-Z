using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text;

namespace FileManager
{
    internal class PDFTextParser
    {
        public string Parse(string pdfFilePath)
        {
            if (!File.Exists(pdfFilePath)) throw new FileNotFoundException("PDF not found!", pdfFilePath);

            var reader = new PdfReader(pdfFilePath);
            var sb = new StringBuilder();

            for (var i = 1; i < reader.NumberOfPages + 1; i++)
            {
                sb.Append(PdfTextExtractor.GetTextFromPage(reader, i, new SimpleTextExtractionStrategy()));
            }

            return sb.ToString();
        }
    }
}