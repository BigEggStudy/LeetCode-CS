//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 25 MB
// Link: https://leetcode.com/submissions/detail/320345171/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _053_MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0) return int.MinValue;
            int currSum = nums[0], maxSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currSum = Math.Max(nums[i], currSum + nums[i]);
                maxSum = Math.Max(maxSum, currSum);
            }
            return maxSum;
        }
    }
}
