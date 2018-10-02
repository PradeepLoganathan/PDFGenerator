using System.Collections.Generic;

namespace BestCV.JobSeeker.Models.Extra
{
    public class Highlights
    {
        public List<Highlight> HighlightList { get; set; }
        public Highlights()
        {
            HighlightList = new List<Highlight>();
        }
    }
}
