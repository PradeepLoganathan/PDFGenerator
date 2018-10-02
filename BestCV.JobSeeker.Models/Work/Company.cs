using BestCV.JobSeeker.Models.Location;

namespace BestCV.JobSeeker.Models.Work
{
    public class Company
    {
        public string Name { get; set; }
        public Address Location { get; set; }
        public string ROCID { get; set; }
        public byte[] Logo { get; set; }
    }
}
