//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/344803484/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0746_MinCostClimbingStairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            int cost1 = 0, cost2 = 0;
            var index = 2;
            for (; index < cost.Length; index++)
            {
                var curr = Math.Min(cost1 + cost[index - 2], cost2 + cost[index - 1]);
                cost1 = cost2;
                cost2 = curr;
            }

            return Math.Min(cost1 + cost[index - 2], cost2 + cost[index - 1]);
        }
    }
}
