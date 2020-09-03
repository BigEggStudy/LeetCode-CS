//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 26.1 MB
// Link: https://leetcode.com/submissions/detail/352337912/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0674_LongestContinuousIncreasingSubsequence
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;

            var max = 1;
            var current = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    current++;
                    max = Math.Max(max, current);
                }
                else
                    current = 1;
            }

            return max;
        }
    }
}
