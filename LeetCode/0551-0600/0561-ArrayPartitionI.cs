//-----------------------------------------------------------------------------
// Runtime: 156ms
// Memory Usage: 34.9 MB
// Link: https://leetcode.com/submissions/detail/328332615/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0561_ArrayPartitionI
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);

            int sum = 0;
            for (var i = 0; i < nums.Length; i += 2)
                sum += nums[i];

            return sum;
        }
    }
}
