//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0312_BurstBalloons
    {
        public int MaxCoins(int[] nums)
        {
            var paddingNums = new int[nums.Length + 2];
            for (int i = 0; i < nums.Length; i++)
                paddingNums[i + 1] = nums[i];
            paddingNums[0] = paddingNums[nums.Length + 1] = 1;

            var memo = new int[paddingNums.Length, paddingNums.Length];

            return DP(paddingNums, 0, paddingNums.Length - 1, memo);
        }

        private int DP(int[] nums, int left, int right, int[,] memo)
        {
            if (right - left == 1) return 0;
            if (memo[left, right] > 0) return memo[left, right];

            var result = 0;
            for (int i = left + 1; i < right; i++)
                result = Math.Max(
                    result,
                    nums[left] * nums[i] * nums[right] + DP(nums, left, i, memo) + DP(nums, i, right, memo)
                    );

            memo[left, right] = result;
            return result;
        }
    }
}
