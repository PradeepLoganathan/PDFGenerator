using System;
using System.Collections.Generic;
using System.Text;

namespace BestCV.JobSeeker.Models.Core
{
    public class EmailIDs
    {
        public List<Emailid> EmailID { get; set; }
        public EmailIDs()
        {
            EmailID = new List<Emailid>();
        }
    }
}
