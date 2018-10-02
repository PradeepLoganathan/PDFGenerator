namespace BestCV.JobSeeker.Models.Core
{
    public class MobileNumber
    {
        public string Number { get;  set; }
        public string ISDCode { get;  set; }
        public bool IsPrimaryMobileNumber { get; set; }
        public bool IsVerified { get; set; }
    }
}
