using BestCV.JobSeeker.Models.Skills;
using BestCV.JobSeeker.Models.Work;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestCV.JobSeeker.Models.Schooling
{
    public class Internship
    {
        public Guid InternshipID { get; set; }
        public string Designation { get; set; }
        public CompanyClient CompanyClient { get;  set; }
        public string ProjectName { get; set; }
        public int TeamSize { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SkillSet Skills { get; set; }
        public string Description { get; set; }
        public RolesAndResponsibilities RolesAndResponsibilities { get; set; }
        public bool IsCurrent { get;  set; }
        public bool IsVerified { get; set; }
    }
}
