//-----------------------------------------------------------------------------
// Runtime: 256ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0347_TopKFrequentElements
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            var counts = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!counts.ContainsKey(num))
                    counts.Add(num, 0);
                counts[num]++;
            }

            return counts.OrderByDescending(pair => pair.Value).Select(pair => pair.Key).Take(k).ToList();
        }
    }
}
