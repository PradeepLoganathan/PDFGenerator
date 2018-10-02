using System;
using System.Collections.Generic;
namespace BestCV.JobSeeker.Models.Work
{
    public class Compensation
    {
        public double CostToCompany { get; set; }
        public Guid CompensationId { get; set; }
        public bool IsVerified { get; set; }
        public List<CompensationItem> CompensationItems { get; set; }
    }
}
