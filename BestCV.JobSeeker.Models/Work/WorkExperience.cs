using System;
using System.Collections.Generic;
using BestCV.JobSeeker.Models.Skills;

namespace BestCV.JobSeeker.Models.Work
{

    public class WorkExperience
    {
        public WorkExperience()
        {
            Company         = new Company();
            Projects        = new Projects();
            SkillSet        = new SkillSet();
            EmploymentType  = new EmploymentType();
            Compensation    = new Compensation();
            CompanyClient = new CompanyClient();
        }
        
        public bool IsVerified {get; set;}
        public bool IsCurrent { get; set; }
        public Company Company { get; set; }
        public Projects Projects { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Designation { get; set; }
        public SkillSet SkillSet { get; set; }
        public EmploymentType EmploymentType { get;  set; }
        public Compensation Compensation { get;  set; }
        public Guid WorkExperienceID { get;  set; }
        public RolesAndResponsibilities RolesAndResponsibilities { get;  set; }
        public CompanyClient CompanyClient { get; set; }
        public string CompanyIndustry { get; set; }
    }
}
