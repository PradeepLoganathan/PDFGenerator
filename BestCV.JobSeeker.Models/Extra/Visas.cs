using System;
using System.Collections.Generic;
using System.Text;

namespace BestCV.JobSeeker.Models.Extra
{
    public class Visas
    {
        public List<Visa> VisaList { get; set; }
        public Visas()
        {
            VisaList = new List<Visa>();
        }
    }
}
