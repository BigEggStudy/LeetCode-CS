//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 28.6 MB
// Link: https://leetcode.com/submissions/detail/359244266/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0914_XOfAKindInADeckOfCards
    {
        public bool HasGroupsSizeX(int[] deck)
        {
            var counts = new Dictionary<int, int>();
            foreach (var card in deck)
            {
                if (!counts.ContainsKey(card)) counts[card] = 1;
                else
                    counts[card]++;
            }

            var min = counts.Values.Min();
            for (var i = 2; i <= min; i++)
            {
                foreach (var count in counts.Values)
                {
                    if (count % i != 0)
                        goto skip;
                }

                return true;
            skip:;
            }

            return false;
        }
    }
}
