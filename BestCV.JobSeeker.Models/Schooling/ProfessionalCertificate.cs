using System;
using BestCV.JobSeeker.Models.Evidences;
using BestCV.JobSeeker.Models.Skills;

namespace BestCV.JobSeeker.Models.Schooling
{
    public class ProfessionalCertificate
    {
        public bool IsVerified { get; set; }
        public Guid CertificateID { get;  set; }
        public string CertificateName { get;  set; }
        public CertifyingAuthority CertifyingAuthority { get;  set; }
        public DateTime CertificationDate { get;  set; }
        public DateTime ValidityDate { get;  set; }
        public MarksCards MarksCards { get; set; }
        public Proofs Proofs { get; set; }
        public bool isLifeTimeCertificate { get; set; }
        public SkillSet SkillSet { get; set; }
    }
}
