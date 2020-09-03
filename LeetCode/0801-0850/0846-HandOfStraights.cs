//-----------------------------------------------------------------------------
// Runtime: 264ms
// Memory Usage: 33 MB
// Link: https://leetcode.com/submissions/detail/368886996/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0846_HandOfStraights
    {
        public bool IsNStraightHand(int[] hand, int W)
        {
            if (hand.Length % W != 0) return false;

            var counts = new SortedDictionary<int, int>();
            foreach (var num in hand)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            while (counts.Count > 0)
            {
                var start = counts.Keys.First();
                for (int i = start; i < start + W; i++)
                {
                    if (!counts.ContainsKey(i)) return false;
                    if (counts[i] == 1) counts.Remove(i);
                    else counts[i]--;
                }
            }

            return true;
        }
    }
}
