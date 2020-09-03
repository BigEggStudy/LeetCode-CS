//-----------------------------------------------------------------------------
// Runtime: 120ms
// Memory Usage: 32 MB
// Link: https://leetcode.com/submissions/detail/375092264/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0523_ContinuousSubarraySum
    {
        public bool CheckSubarraySum(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            map.Add(0, -1);
            var sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (k != 0)
                    sum %= k;

                if (map.ContainsKey(sum))
                {
                    if (i - map[sum] >= 2)
                        return true;
                }
                else
                    map[sum] = i;
            }

            return false;
        }
    }
}
