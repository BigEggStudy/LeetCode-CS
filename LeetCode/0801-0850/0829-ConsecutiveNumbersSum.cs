//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.4 MB
// Link: https://leetcode.com/submissions/detail/372046471/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0829_ConsecutiveNumbersSum
    {
        public int ConsecutiveNumbersSum(int N)
        {
            var upper = (int)(Math.Sqrt(2 * N + 0.25) - 0.5);

            var count = 0;
            for (int i = 1; i <= upper; i++)
            {
                N -= i;
                if (N % i == 0) count++;
            }

            return count;
        }
    }
}
