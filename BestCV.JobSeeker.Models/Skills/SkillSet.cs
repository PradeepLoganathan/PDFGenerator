using System.Collections.Generic;

namespace BestCV.JobSeeker.Models.Skills
{
    public class SkillSet
    {
        public List<Skill> SkillList { get; set; }

        public SkillSet()
        {
            SkillList = new List<Skill>();
        }
        
    }
}
