//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 23.9 MB
// Link: https://leetcode.com/submissions/detail/331981659/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1413_MinimumValueToGetPositiveStepByStepSum
    {
        public int MinStartValue(int[] nums)
        {
            var minSum = int.MaxValue;
            var sum = 0;
            foreach (var num in nums)
            {
                sum += num;
                minSum = Math.Min(minSum, sum);
            }

            if (minSum > 0) return 1;
            else
                return 1 - minSum;
        }
    }
}
