using BestCV.JobSeeker.Models.Core;
using Newtonsoft.Json;
using System.IO;

namespace pdfgen
{
    public class Hydrater
    {
        public Hydrater()
        {

        }

        public Candidate LoadCandidate()
        {
            Candidate ModelCandidate;
            using (StreamReader file = File.OpenText(@"..\..\..\pdfgen\candidate.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                ModelCandidate = (Candidate)serializer.Deserialize(file, typeof(Candidate));
            }

            return ModelCandidate;


        }
    }
}
