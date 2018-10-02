using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BestCV.JobSeeker.Models.Skills
{
    public class PersonalSkillSet
    {
        public List<PersonalSkill> PersonalSkillList { get; set; }
        public PersonalSkillSet()
        {
            PersonalSkillList = new List<PersonalSkill>();
        }

    }
}
