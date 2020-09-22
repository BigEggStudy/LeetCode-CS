//-----------------------------------------------------------------------------
// Runtime: 240ms
// Memory Usage: 33 MB
// Link: https://leetcode.com/submissions/detail/399395792/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0229_MajorityElementII
    {
        public IList<int> MajorityElement(int[] nums)
        {
            int count1 = 0, count2 = 0;
            int? candidate1 = null, candidate2 = null;
            foreach (var num in nums)
            {
                if (candidate1.HasValue && candidate1 == num)
                    count1++;
                else if (candidate2.HasValue && candidate2 == num)
                    count2++;
                else if (count1 == 0)
                {
                    candidate1 = num;
                    count1++;
                }
                else if (count2 == 0)
                {
                    candidate2 = num;
                    count2++;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }

            count1 = count2 = 0;
            foreach (var num in nums)
            {
                if (candidate1 != null && num == candidate1)
                    count1++;
                if (candidate2 != null && num == candidate2)
                    count2++;
            }

            var results = new List<int>();
            int n = nums.Length;
            if (count1 > n / 3)
                results.Add(candidate1.Value);
            if (count2 > n / 3)
                results.Add(candidate2.Value);

            return results;
        }
    }
}
