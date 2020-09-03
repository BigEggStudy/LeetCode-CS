//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 24.5 MB
// Link: https://leetcode.com/submissions/detail/359600255/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0414_ThirdMaximumNumber
    {
        public int ThirdMax(int[] nums)
        {
            Array.Sort(nums);

            int findMax = 0;
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] != nums[i - 1])
                {
                    findMax++;
                    if (findMax == 2)
                        return nums[i - 1];
                }
            }

            return nums[nums.Length - 1];
        }
    }
}
