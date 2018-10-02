using System;
namespace BestCV.JobSeeker.Models.Evidences
{
    public class Document
    {
        public bool IsVerified { get; set; }
        public Guid DocumentID { get; set; }
        public string Name { get; set; }
        public DateTime UploadDate { get; set; }
        public string DocumentLocation { get; set; }
    }
}
