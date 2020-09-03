//-----------------------------------------------------------------------------
// Runtime: 132ms
// Memory Usage: 34.3 MB
// Link: https://leetcode.com/submissions/detail/352316912/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0628_MaximumProductOfThreeNumbers
    {
        public int MaximumProduct(int[] nums)
        {
            int max1, max2, max3, min1, min2;
            max1 = max2 = max3 = int.MinValue;
            min1 = min2 = int.MaxValue;
            foreach (var num in nums)
            {
                if (num >= max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = num;
                }
                else if (num >= max2)
                {
                    max3 = max2;
                    max2 = num;
                }
                else if (num > max3)
                    max3 = num;

                if (num <= min1)
                {
                    min2 = min1;
                    min1 = num;
                }
                else if (num <= min2)
                    min2 = num;
            }

            return Math.Max(min1 * min2 * max1, max1 * max2 * max3);
        }
    }
}
