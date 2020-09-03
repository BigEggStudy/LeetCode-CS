//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/371218471/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0983_MinimumCostForTickets
    {
        public int MincostTickets(int[] days, int[] costs)
        {
            var memo = new int?[days.Length];
            return DP(0, days, costs, memo, new int[] { 1, 7, 30 });
        }

        private int DP(int index, int[] days, int[] costs, int?[] memo, int[] duration)
        {
            if (index >= days.Length) return 0;
            if (memo[index].HasValue) return memo[index].Value;

            var result = int.MaxValue;
            var index2 = index;
            for (int type = 0; type < 3; type++)
            {
                while (index2 < days.Length && days[index2] < days[index] + duration[type])
                    index2++;

                result = Math.Min(result, DP(index2, days, costs, memo, duration) + costs[type]);
            }

            memo[index] = result;
            return result;
        }
    }
}
