//-----------------------------------------------------------------------------
// Runtime: 136ms
// Memory Usage: 35 MB
// Link: https://leetcode.com/submissions/detail/340999715/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0485_MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0, maxCount = 0;
            foreach (var num in nums)
            {
                if (num == 0)
                {
                    maxCount = Math.Max(maxCount, count);
                    count = 0;
                }
                else
                    count++;
            }

            return Math.Max(maxCount, count);
        }
    }
}
