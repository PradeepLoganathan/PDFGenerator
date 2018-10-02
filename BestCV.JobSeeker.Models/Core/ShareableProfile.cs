using System;

namespace BestCV.JobSeeker.Models.Core
{
    public class ShareableProfile
    {
        public string ProfileName { get; set; }
        public bool IsPublic { get; set; }
        public Guid TemplateId { get; set; }
    }
}
