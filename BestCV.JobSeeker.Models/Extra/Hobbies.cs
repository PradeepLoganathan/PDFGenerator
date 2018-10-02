using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace BestCV.JobSeeker.Models.Extra
{
    public class Hobbies
    {
        public List<Hobby> HobbyList { get;  set; }

        public Hobbies()
        {
            HobbyList = new List<Hobby>();
        }
       
    }
}
