using System;
using System.Collections.Generic;

namespace BestCV.JobSeeker.Models.Evidences
{
    public class Proof
    {
        public Documents Documents { get; set; }
        public bool IsVerified { get; set; }
        public Guid ProofId { get; set; }
    }
}
