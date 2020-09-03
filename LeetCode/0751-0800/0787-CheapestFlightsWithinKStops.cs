//-----------------------------------------------------------------------------
// Runtime: 124ms
// Memory Usage: 26.6 MB
// Link: https://leetcode.com/submissions/detail/353727324/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0787_CheapestFlightsWithinKStops
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K)
        {
            var costs = new int[n];
            for (int i = 0; i < n; i++)
                costs[i] = int.MaxValue / 2;
            costs[src] = 0;

            for (int i = 0; i <= K; i++)
            {
                var currentCost = new int[n];
                Array.Copy(costs, currentCost, n);

                foreach (var flight in flights)
                {
                    if (currentCost[flight[1]] > costs[flight[0]] + flight[2])
                        currentCost[flight[1]] = costs[flight[0]] + flight[2];
                }

                costs = currentCost;
            }

            return costs[dst] == int.MaxValue / 2 ? -1 : costs[dst];
        }
    }
}
