//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 30.6 MB
// Link: https://leetcode.com/submissions/detail/365290998/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _078_Subsets
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var results = new List<IList<int>>();
            results.Add(new List<int>());

            if (nums == null || nums.Length == 0) { return results; }
            Array.Sort(nums);

            int i, j, n = nums.Length, number = 1 << nums.Length, temp;
            for (i = 1; i < number; i++)
            {
                var result = new List<int>();
                temp = i;
                for (j = 0; j < n; j++)
                {
                    if ((temp & 1) == 1) { result.Add(nums[j]); }
                    temp >>= 1;
                }
                results.Add(result);
            }

            return results;
        }
    }
}
