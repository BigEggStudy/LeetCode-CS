//-----------------------------------------------------------------------------
// Runtime: 264ms
// Memory Usage: 45.1 MB
// Link: https://leetcode.com/submissions/detail/335623583/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0575_DistributeCandies
    {
        public int DistributeCandies(int[] candies)
        {
            var set = new HashSet<int>(candies);
            return Math.Min(set.Count, candies.Length / 2);
        }
    }
}
