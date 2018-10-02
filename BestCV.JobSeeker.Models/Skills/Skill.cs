using System;
namespace BestCV.JobSeeker.Models.Skills
{
    public class Skill
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SkillRating SkillRating { get; set; }
        public Guid SkillID { get;  set; }
        public bool IsVerified { get;  set; }
        public int ExperienceInMonth { get; set; }
    }
}
