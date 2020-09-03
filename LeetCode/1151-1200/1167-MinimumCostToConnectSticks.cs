//-----------------------------------------------------------------------------
// Runtime: 372ms
// Memory Usage: 35.1 MB
// Link: https://leetcode.com/submissions/detail/369942316/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1167_MinimumCostToConnectSticks
    {
        public int ConnectSticks(int[] sticks)
        {
            var pq = new SortedList<int, int>();
            foreach (var stick in sticks)
            {
                if (pq.ContainsKey(stick))
                    pq[stick]++;
                else
                    pq[stick] = 1;
            }

            int result = 0;
            while (pq.Count > 1 || (pq.Count == 1 && pq.Values.First() > 1))
            {
                var x = pq.Keys.First();
                if (pq[x] == 1)
                    pq.Remove(x);
                else
                    pq[x]--;

                var y = pq.Keys.First();
                if (pq[y] == 1)
                    pq.Remove(y);
                else
                    pq[y]--;

                var cost = x + y;
                result += cost;

                if (pq.ContainsKey(cost))
                    pq[cost]++;
                else
                    pq[cost] = 1;
            }

            return result;
        }
    }
}
