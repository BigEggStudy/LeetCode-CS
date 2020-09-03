//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/343732957/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0256_PaintHouse
    {
        public int MinCost(int[][] costs)
        {
            if (costs.Length == 0) return 0;

            for (int i = costs.Length - 2; i >= 0; i--)
            {
                costs[i][0] += Math.Min(costs[i + 1][1], costs[i + 1][2]);
                costs[i][1] += Math.Min(costs[i + 1][0], costs[i + 1][2]);
                costs[i][2] += Math.Min(costs[i + 1][0], costs[i + 1][1]);
            }

            return Math.Min(costs[0][0], Math.Min(costs[0][1], costs[0][2]));

        }
    }
}
