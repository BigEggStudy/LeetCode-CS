//-----------------------------------------------------------------------------
// Runtime: 332ms
// Memory Usage: 46.5 MB
// Link: https://leetcode.com/submissions/detail/363480535/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1338_ReduceArraySizeToTheHalf
    {
        public int MinSetSize(int[] arr)
        {
            var counts = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                if (!counts.ContainsKey(num))
                    counts[num] = 1;
                else
                    counts[num]++;
            }

            var countArr = counts.Values.OrderByDescending(num => num).ToArray();
            int sum = 0, half = arr.Length / 2, result = 0;

            foreach (var count in countArr)
            {
                sum += count;
                result++;
                if (sum >= half) return result;
            }

            return -1;
        }
    }
}
