//-----------------------------------------------------------------------------
// Runtime: 252ms
// Memory Usage: 30.4 MB
// Link: https://leetcode.com/submissions/detail/353312675/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _0368_LargestDivisibleSubset
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            var n = nums.Length;
            if (n <= 0) return nums;

            Array.Sort(nums);
            var length = new int[n];
            var prevIndex = new int[n];

            for (int i = 0; i < n; i++)
            {
                length[i] = 1;
                prevIndex[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (nums[i] % nums[j] == 0)
                    {
                        if (length[j] + 1 > length[i])
                        {
                            length[i] = length[j] + 1;
                            prevIndex[i] = j;
                        }
                    }
                }
            }

            var maxDistance = 0;
            var index = -1;
            for (int i = 0; i < n; i++)
            {
                if (length[i] > maxDistance)
                {
                    maxDistance = length[i];
                    index = i;
                }
            }

            var result = new List<int>();
            while (index != -1)
            {
                result.Add(nums[index]);
                index = prevIndex[index];
            }

            return result;
        }
    }
}
