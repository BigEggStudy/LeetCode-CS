//-----------------------------------------------------------------------------
// Runtime: 236ms
// Memory Usage: 33.3 MB
// Link: https://leetcode.com/submissions/detail/327393922/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1086_HighFive
    {
        public int[][] HighFive(int[][] items)
        {
            var map = new Dictionary<int, List<int>>();
            foreach (var item in items)
            {
                if (!map.ContainsKey(item[0]))
                    map.Add(item[0], new List<int>());

                map[item[0]].Add(item[1]);
            }

            var result = new int[map.Keys.Count][];
            var i = 0;
            foreach (var pair in map)
                result[i++] = new int[] { pair.Key, pair.Value.OrderByDescending(a => a).Take(5).Sum() / 5 };

            return result;
        }
    }
}
