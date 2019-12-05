using System.Linq;

namespace Codehouse.CodeChallenges.Business.ChallengeZero
{
    public class GloveMerchant
    {
        public int CountPairs(int[] golveColours)
        {
            var pairs = 0;

            var quinueColours = golveColours.Distinct();

            foreach (var colour in quinueColours)
            {
                var golvesOfAcolour = golveColours.Where(i => i == colour);
                if (int.TryParse((golvesOfAcolour.Count() / 2).ToString(), out var pairsOfAColour))
                {
                    pairs += pairsOfAColour;
                }
            }

            return pairs;
        }
    }
}
