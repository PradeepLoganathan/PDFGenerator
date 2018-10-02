using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace BestCV.JobSeeker.Models.Extra
{
    public class References
    {
        public List<Reference> ReferenceList { get;  set; }

        public References()
        {
            ReferenceList = new List<Reference>();
        }
    }
}