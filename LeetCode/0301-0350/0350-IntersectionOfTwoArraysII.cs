//-----------------------------------------------------------------------------
// Runtime: 232ms
// Memory Usage: 31.1 MB
// Link: https://leetcode.com/submissions/detail/344239069/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0350_IntersectionOfTwoArraysII
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums2.Length < nums1.Length) return Intersect(nums2, nums1);

            var counts = new Dictionary<int, int>();
            foreach (var num in nums1)
            {
                if (!counts.ContainsKey(num))
                    counts[num] = 1;
                else
                    counts[num]++;
            }

            var result = new List<int>();
            foreach (var num in nums2)
            {
                if (counts.ContainsKey(num) && counts[num] > 0)
                {
                    result.Add(num);
                    counts[num]--;
                }
            }

            return result.ToArray();
        }
    }
}
