//-----------------------------------------------------------------------------
// Runtime: 252ms
// Memory Usage: 35 MB
// Link: https://leetcode.com/submissions/detail/263087505/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0239_SlidingWindowMaximum
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int n = nums.Length;
            if (n * k == 0) return new int[0];
            if (k == 1) return nums;

            int[] left = new int[n];
            int[] right = new int[n];
            left[0] = nums[0];
            right[n - 1] = nums[n - 1];

            for (int i = 1; i < n; i++)
            {
                if (i % k == 0) left[i] = nums[i];
                else left[i] = Math.Max(left[i - 1], nums[i]);

                var j = n - i - 1;
                if ((j + 1) % k == 0) right[j] = nums[j];
                else right[j] = Math.Max(right[j + 1], nums[j]);
            }

            var result = new int[n - k + 1];
            for (int i = 0; i < n - k + 1; i++)
                result[i] = Math.Max(left[i + k - 1], right[i]);

            return result;
        }
    }
}
