//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 30.1 MB
// Link: https://leetcode.com/submissions/detail/260821531/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0560_SubarraySumEqualsK
    {
        public int SubarraySum(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            map.Add(0, 1);

            var sum = 0;
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (map.ContainsKey(sum - k))
                    count += map[sum - k];

                if (map.ContainsKey(sum))
                    map[sum] += 1;
                else
                    map[sum] = 1;
            }

            return count;
        }
    }
}
