//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 26.3 MB
// Link: https://leetcode.com/submissions/detail/345101395/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0598_RangeAdditionII
    {
        public int MaxCount(int m, int n, int[][] ops)
        {
            foreach (var op in ops)
            {
                m = Math.Min(m, op[0]);
                n = Math.Min(n, op[1]);
            }

            return m * n;
        }
    }
}
