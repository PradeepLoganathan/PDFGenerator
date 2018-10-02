using System;
using System.Collections.Generic;
using System.Text;

namespace BestCV.JobSeeker.Models.Work
{
    public class Projects
    {
        public Projects()
        {
            ProjectList = new List<Project>();
        }

        public List<Project> ProjectList { get; set; }
    }
}
