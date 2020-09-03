//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 30.8 MB
// Link: https://leetcode.com/submissions/detail/378090797/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _031_NextPermutation
    {
        public void NextPermutation(int[] nums)
        {
            int i = nums.Length - 1;
            while (i > 0 && nums[i - 1] >= nums[i])
                i--;

            if (i <= 0)
            {
                Array.Reverse(nums);
                return;
            }

            int j = nums.Length - 1;
            while (j >= 0 && nums[j] <= nums[i - 1])
                j--;

            int temp = nums[j];
            nums[j] = nums[i - 1];
            nums[i - 1] = temp;

            Array.Reverse(nums, i, nums.Length - i);
        }
    }
}
