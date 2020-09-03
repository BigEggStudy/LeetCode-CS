//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.1 MB
// Link: https://leetcode.com/submissions/detail/373736264/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0300_LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int[] dp = new int[nums.Length];
            int length = 0;
            foreach (int num in nums)
            {
                int i = Array.BinarySearch(dp, 0, length, num);
                if (i < 0) i = ~i;
                dp[i] = num;

                if (i == length) length++;
            }
            return length;
        }
    }
}
