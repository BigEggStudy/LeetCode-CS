//-----------------------------------------------------------------------------
// Runtime: 400ms
// Memory Usage: 30.6 MB
// Link: https://leetcode.com/submissions/detail/333619391/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1431_KidsWithTheGreatestNumberOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var max = candies.Max();
            var result = new bool[candies.Length];

            for (int i = 0; i < candies.Length; i++)
                result[i] = candies[i] + extraCandies >= max;

            return result;
        }
    }
}
