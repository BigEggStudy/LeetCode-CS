//-----------------------------------------------------------------------------
// Runtime: 132ms
// Memory Usage: 33.2 MB
// Link: https://leetcode.com/submissions/detail/343619768/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0697_DegreeOfAnArray
    {
        public int FindShortestSubArray(int[] nums)
        {
            var counts = new Dictionary<int, int>();
            var left = new Dictionary<int, int>();
            var right = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!left.ContainsKey(nums[i]))
                    left[nums[i]] = i;
                right[nums[i]] = i;
                if (!counts.ContainsKey(nums[i]))
                    counts[nums[i]] = 1;
                else
                    counts[nums[i]]++;
            }

            var max = counts.Values.Max();
            var answer = nums.Length;
            foreach (var key in counts.Keys)
            {
                if (counts[key] == max)
                {
                    answer = Math.Min(answer, right[key] - left[key] + 1);
                }
            }

            return answer;
        }
    }
}
