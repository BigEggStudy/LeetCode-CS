//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.5 MB
// Link: https://leetcode.com/submissions/detail/336924970/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1099_TwoSumLessThanK
    {
        public int TwoSumLessThanK(int[] A, int K)
        {
            Array.Sort(A);

            int left = 0, right = A.Length - 1;
            int max = -1;
            while (left < right)
            {
                var sum = A[left] + A[right];
                if (sum < K)
                {
                    left++;
                    max = Math.Max(max, sum);
                }
                else
                    right--;
            }

            return max;
        }
    }
}
