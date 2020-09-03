//-----------------------------------------------------------------------------
// Runtime: 152ms
// Memory Usage: 38.8 MB
// Link: https://leetcode.com/submissions/detail/340014935/
//-----------------------------------------------------------------------------

using System;
using System.Linq;

namespace LeetCode
{
    public class _0918_MaximumSumCircularSubarray
    {
        public int MaxSubarraySumCircular(int[] A)
        {
            int n = A.Length;
            if (n == 1) return A[0];

            int curr = int.MinValue, result1 = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                curr = A[i] + Math.Max(curr, 0);
                result1 = Math.Max(result1, curr);
            }

            int total = A.Sum();

            curr = int.MaxValue;
            int result2 = int.MaxValue;
            for (int i = 1; i < n; i++)
            {
                curr = A[i] + Math.Min(curr, 0);
                result2 = Math.Min(result2, curr);
            }
            result2 = total - result2;

            curr = int.MaxValue;
            int result3 = int.MaxValue;
            for (int i = 0; i < n - 1; i++)
            {
                curr = A[i] + Math.Min(curr, 0);
                result3 = Math.Min(result3, curr);
            }
            result3 = total - result3;

            return Math.Max(result1, Math.Max(result2, result3));
        }
    }
}
