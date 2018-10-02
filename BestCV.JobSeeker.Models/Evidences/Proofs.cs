using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BestCV.JobSeeker.Models.Evidences

{
    public class Proofs : IEnumerable<Proof>
    {
        public List<Proof> ProofList;

        public Proofs()
        {
            ProofList = new List<Proof>();
        }

        public Proofs(IEnumerable<Proof> Proofs)
        {
            ProofList = new List<Proof>();
            this.ProofList.ToList();

        }


        public IEnumerator<Proof> GetEnumerator()
        {
            return ProofList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ProofList.GetEnumerator();
        }
    }
}
