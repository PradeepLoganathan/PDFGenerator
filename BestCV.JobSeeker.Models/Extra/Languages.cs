using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BestCV.JobSeeker.Models.Extra
{
    public class Languages
    {
        public List<Language> LanguageList{ get; set; }
        public Languages()
        {
            LanguageList = new List<Language>();
        }

       
    }
}