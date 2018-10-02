using BestCV.JobSeeker.Models.Core;

namespace pdfgen
{
    class Program
    {
        static void Main(string[] args)
        {

            Hydrater hyde = new Hydrater();
            Candidate model = hyde.LoadCandidate();
            Generator DocGenerator = new Generator();
            DocGenerator.Generate(model);

        }
    }
}
