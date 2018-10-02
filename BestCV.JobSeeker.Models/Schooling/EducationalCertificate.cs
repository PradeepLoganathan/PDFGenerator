using System;
using BestCV.JobSeeker.Models.Evidences;
using BestCV.JobSeeker.Models.Skills;
using BestCV.JobSeeker.Models.Extra;

namespace BestCV.JobSeeker.Models.Schooling
{
    public class EducationalCertificate
    {
        public CertifyingAuthority CertifyingAuthority { get; set; }
        public Guid CertificateID { get;  set; }
        //public DateTime CertificationDate { get; set; }
        //public DateTime ValdityDate { get; set; }
        public string CertificateName { get; set; }
        public MarksCards MarksCards { get; set; }
        public Proofs Proofs { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsVerified { get; set; }
        public bool IsCurrentEducation { get; set; }
        public double PercentageObtained { get; set; }
        public Achievements Achievements { get; set; }
        public SkillSet Skills { get; set; }
        public string Specialization { get; set; }
        public InternshipSet InternshipSet { get; set; }
}
}
