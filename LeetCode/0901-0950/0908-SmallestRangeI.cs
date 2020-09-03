//-----------------------------------------------------------------------------
// Runtime: 108ms
// Memory Usage: 28.6 MB
// Link: https://leetcode.com/submissions/detail/333013905/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0908_SmallestRangeI
    {
        public int SmallestRangeI(int[] A, int K)
        {
            int max = int.MinValue, min = int.MaxValue;
            foreach (var num in A)
            {
                max = Math.Max(num, max);
                min = Math.Min(num, min);
            }

            var result = max - min - K * 2;
            return result < 0 ? 0 : result;
        }
    }
}
