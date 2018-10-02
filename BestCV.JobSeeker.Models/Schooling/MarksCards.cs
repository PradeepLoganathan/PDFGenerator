using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BestCV.JobSeeker.Models.Schooling
{
    public class MarksCards :IEnumerable<MarksCard>
    {
        public List<MarksCard> MarksCardList;

        public MarksCards()
        {
            MarksCardList = new List<MarksCard>();
        }

        public MarksCards(IEnumerable<MarksCard> MarksCards)
        {
            MarksCardList = new List<MarksCard>();
            MarksCardList = MarksCards.ToList();
        }
        
        

        public IEnumerator<MarksCard> GetEnumerator()
        {
            return MarksCardList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return MarksCardList.GetEnumerator();
        }
    }
}
