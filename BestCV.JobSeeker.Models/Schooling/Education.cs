using System.Collections.Generic;
namespace BestCV.JobSeeker.Models.Schooling
{
    public class Education
    {
        public List<EducationalCertificate> EducationalCertificates { get; set; }
        public List<ProfessionalCertificate> ProfessionalCertificates { get; set; }
    }
}
