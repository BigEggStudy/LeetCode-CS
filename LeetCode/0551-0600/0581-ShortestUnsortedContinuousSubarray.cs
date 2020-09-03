//-----------------------------------------------------------------------------
// Runtime: 116ms
// Memory Usage: 31.5 MB
// Link: https://leetcode.com/submissions/detail/359594641/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0581_ShortestUnsortedContinuousSubarray
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            int min = int.MaxValue, max = int.MinValue;
            var flag = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                    flag = true;
                if (flag)
                    min = Math.Min(min, nums[i]);
            }
            flag = false;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] > nums[i + 1])
                    flag = true;
                if (flag)
                    max = Math.Max(max, nums[i]);
            }

            int l, r;
            for (l = 0; l < nums.Length; l++)
                if (min < nums[l])
                    break;
            for (r = nums.Length - 1; r >= 0; r--)
                if (max > nums[r])
                    break;

            return r >= l ? r - l + 1 : 0;
        }
    }
}
