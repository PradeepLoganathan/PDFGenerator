using System;
using System.Collections.Generic;
using System.Text;

namespace BestCV.JobSeeker.Models.Schooling
{
    public class InternshipSet
    {
        public List<Internship> InternshipList { get; set; }

        public InternshipSet()
        {
            InternshipList = new List<Internship>();
        }
    }
}
