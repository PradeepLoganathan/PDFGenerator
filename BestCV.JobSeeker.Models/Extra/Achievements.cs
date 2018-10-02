using System.Collections.Generic;

namespace BestCV.JobSeeker.Models.Extra
{
    public class Achievements
    {
        
        public List<Achievement> AchievementList { get; set; }
        public Achievements()
        {
            AchievementList = new List<Achievement>();
        }
    }
}
