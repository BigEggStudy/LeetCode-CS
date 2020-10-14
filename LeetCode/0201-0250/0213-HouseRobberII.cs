//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/408807447/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0213_HouseRobberII
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            var max1 = Rob(nums, 0, nums.Length - 2);
            var max2 = Rob(nums, 1, nums.Length - 1);

            return Math.Max(max1, max2);
        }

        private int Rob(int[] nums, int start, int end)
        {
            int amount1 = 0, amount2 = 0;
            for (int i = start; i <= end; i++)
            {
                var current = Math.Max(amount2 + nums[i], amount1);
                amount2 = amount1;
                amount1 = current;
            }
            return amount1;
        }
    }
}
