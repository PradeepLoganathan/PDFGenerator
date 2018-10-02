using System.Collections.Generic;
namespace BestCV.JobSeeker.Models.Work
{
    public class Career
    {
        public Career()
        {
            WorkExperiences = new List<WorkExperience>();
        }
        public List<WorkExperience> WorkExperiences { get; set; }
    }
}
