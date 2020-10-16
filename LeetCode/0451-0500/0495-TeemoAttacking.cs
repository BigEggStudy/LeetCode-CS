//-----------------------------------------------------------------------------
// Runtime: 124ms
// Memory Usage: 36.7 MB
// Link: https://leetcode.com/submissions/detail/409239239/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0495_TeemoAttacking
    {
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int n = timeSeries.Length;
            if (n == 0) return 0;

            int total = 0;
            for (int i = 0; i < n - 1; ++i)
                total += Math.Min(timeSeries[i + 1] - timeSeries[i], duration);
            return total + duration;
        }
    }
}
