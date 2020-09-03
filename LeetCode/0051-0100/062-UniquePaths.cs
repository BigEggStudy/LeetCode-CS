//-----------------------------------------------------------------------------
// Runtime: 40ms
// Memory Usage: 14.4 MB
// Link: https://leetcode.com/submissions/detail/360084176/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _062_UniquePaths
    {
        public int UniquePaths(int m, int n)
        {
            var rest = Math.Min(m - 1, n - 1);
            if (rest == 0) { return 1; }
            if (rest == 1) { return m + n - 2; }

            long result = 1;
            int temp = m + n - 2, i = rest;
            while (i-- > 0)
            {
                result *= temp--;
            }

            while (rest > 1)
            {
                result /= rest--;
            }

            return (int)result;
        }
    }
}
