//-----------------------------------------------------------------------------
// Runtime: 592ms
// Memory Usage: 41.2 MB
// Link: https://leetcode.com/submissions/detail/368883713/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _1296_DivideArrayInSetsOfKConsecutiveNumbers
    {
        public bool IsPossibleDivide(int[] nums, int k)
        {
            if (nums.Length % k != 0) return false;

            var counts = new SortedDictionary<int, int>();
            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            while (counts.Count > 0)
            {
                var start = counts.Keys.First();
                for (int i = start; i < start + k; i++)
                {
                    if (!counts.ContainsKey(i)) return false;
                    if (counts[i] == 1) counts.Remove(i);
                    else counts[i]--;
                }
            }

            return true;
        }
    }
}
