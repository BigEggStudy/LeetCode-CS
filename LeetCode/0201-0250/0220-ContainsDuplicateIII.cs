//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 25.8 MB
// Link: https://leetcode.com/submissions/detail/390096592/
//-----------------------------------------------------------------------------

using System;
using System.Linq;

namespace LeetCode
{
    public class _0220_ContainsDuplicateIII
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            var arr = nums.Select((num, index) => new { num, index })
                          .OrderBy(u => u.num)
                          .ToArray();

            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length && arr[j].num - (long)arr[i].num <= t; j++)
                    if (Math.Abs(arr[i].index - arr[j].index) <= k)
                        return true;

            return false;
        }
    }
}
