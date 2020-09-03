//-----------------------------------------------------------------------------
// Runtime: 368ms
// Memory Usage: 46.9 MB
// Link: https://leetcode.com/submissions/detail/337438610/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1331_RankTransformOfAnArray
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            var map = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                if (!map.ContainsKey(num))
                    map.Add(num, 0);
            }

            var rank = 1;
            foreach (var key in map.Keys.OrderBy(key => key))
                map[key] = rank++;

            var result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                result[i] = map[arr[i]];

            return result;
        }
    }
}
