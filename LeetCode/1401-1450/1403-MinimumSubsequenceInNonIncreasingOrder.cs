//-----------------------------------------------------------------------------
// Runtime: 244ms
// Memory Usage: 31.8 MB
// Link: https://leetcode.com/submissions/detail/328321326/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1403_MinimumSubsequenceInNonIncreasingOrder
    {
        public IList<int> MinSubsequence(int[] nums)
        {
            var count = new int[101];
            var sum = 0;

            foreach (var num in nums)
            {
                sum += num;
                count[num]++;
            }

            var result = new List<int>();
            var current_sum = 0;
            var half_sum = sum / 2;
            for (int i = 100; i > 0; i--)
            {
                while (count[i] > 0)
                {
                    current_sum += i;
                    result.Add(i);
                    if (current_sum > half_sum)
                        return result;
                    count[i]--;
                }
            }

            return result;
        }
    }
}
