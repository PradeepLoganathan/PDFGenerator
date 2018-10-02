using BestCV.JobSeeker.Models.Location;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace BestCV.JobSeeker.Models.Extra
{
    public class PreferredJobLocations
    {
        public PreferredJobLocations()
        {
            PreferredJobLocationsList = new List<Address>();
        }

      
        public List<Address> PreferredJobLocationsList { get; set; }

      
    }
}
