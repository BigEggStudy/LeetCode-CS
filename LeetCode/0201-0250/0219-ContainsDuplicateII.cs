//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 29.2 MB
// Link: https://leetcode.com/submissions/detail/358679761/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0219_ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]) && i - map[nums[i]] <= k)
                    return true;
                map[nums[i]] = i;
            }

            return false;
        }
    }
}
