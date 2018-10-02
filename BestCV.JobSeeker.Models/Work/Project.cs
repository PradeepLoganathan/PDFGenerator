using BestCV.JobSeeker.Models.Location;
using BestCV.JobSeeker.Models.Schooling;
using BestCV.JobSeeker.Models.Skills;
using System;

namespace BestCV.JobSeeker.Models.Work
{
    public class Project
    {
        public string ProjectName { get;  set; }
        public int TenureinMonths { get;  set; }
        public string ProjectRole { get;  set; }
        public string ProjectDomain { get;  set; }
        public CompanyClient CompanyClient { get; set; }
        public Address ProjectLocation { get;  set; }
        public SkillSet Skills { get;  set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ProjectLink { get; set; }
        public int TeamSize { get; set; }
        public string Designation { get; set; }
        public bool IsCurrent { get; set; }
        public RolesAndResponsibilities RolesAndResponsibilities { get; set; }
    }
}
