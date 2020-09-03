//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.7 MB
// Link: https://leetcode.com/submissions/detail/348826564/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1029_TwoCityScheduling
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            Array.Sort(costs, (a, b) => (a[0] - a[1]) - (b[0] - b[1]));

            var n = costs.Length / 2;
            var result = 0;
            for (int i = 0; i < n; i++)
                result += costs[i][0] + costs[i + n][1];

            return result;
        }
    }
}
