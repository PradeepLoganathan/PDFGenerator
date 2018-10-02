using System.Collections.Generic;
namespace BestCV.JobSeeker.Models.Core
{
    public class SocialProfiles
    {
        public SocialProfiles()
        {
            ProfileList = new List<SocialProfile>();
        }
        public List<SocialProfile> ProfileList { get; set; }
       
    }
}
