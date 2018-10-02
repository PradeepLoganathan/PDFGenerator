namespace BestCV.JobSeeker.Models.Core
{
    public class Emailid
    {
        public string DomainName { get; set; }
        public string EmailName { get; set; }
        public bool IsPrimaryEmail { get; set; }
        public override string ToString()
        {
            return EmailName + "@" + DomainName;
        }
    }
}
