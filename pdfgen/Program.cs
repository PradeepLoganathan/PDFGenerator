using BestCV.JobSeeker.Models.Core;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.IO;

namespace pdfgen
{
    class Program
    {
        static void Main(string[] args)
        {

            Hydrater hyde = new Hydrater();
            Candidate model = hyde.LoadCandidate();
            Generator DocGenerator = new Generator();
            var doc = DocGenerator.Generate(model);
            string filename = Path.GetRandomFileName() + ".pdf";
            string directory = Directory.GetCurrentDirectory();
            string filepath = directory + "\\" + filename;
            doc.Save(filepath);
            
            Process.Start(filepath);


        }
    }
}
