//-----------------------------------------------------------------------------
// Runtime: 228ms
// Memory Usage: 30 MB
// Link: https://leetcode.com/submissions/detail/326840305/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1389_CreateTargetArrayInTheGivenOrder
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            var result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
                result.Insert(index[i], nums[i]);

            return result.ToArray();
        }
    }
}
