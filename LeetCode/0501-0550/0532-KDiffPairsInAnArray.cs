//-----------------------------------------------------------------------------
// Runtime: 148ms
// Memory Usage: 30.6 MB
// Link: https://leetcode.com/submissions/detail/359589168/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0532_KDiffPairsInAnArray
    {
        public int FindPairs(int[] nums, int k)
        {
            if (k < 0) return 0;

            var counts = new SortedDictionary<int, int>();
            foreach (var num in nums)
            {
                if (!counts.ContainsKey(num))
                    counts[num] = 1;
                else
                    counts[num]++;
            }

            var count = 0;
            if (k == 0)
                foreach (var key in counts.Keys)
                {
                    if (counts[key] > 1) count++;
                }
            else
                foreach (var key in counts.Keys)
                    if (counts.ContainsKey(key + k)) count++;

            return count;
        }
    }
}
