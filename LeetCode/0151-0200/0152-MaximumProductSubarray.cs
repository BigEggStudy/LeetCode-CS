//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0152_MaximumProductSubarray
    {
        public int MaxProduct(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            int minProduct = 1, maxProduct = 1, result = int.MinValue;
            foreach (var num in nums)
            {
                if (num < 0)
                {
                    var temp = minProduct;
                    minProduct = maxProduct;
                    maxProduct = temp;
                }

                minProduct = Math.Min(num, minProduct * num);
                maxProduct = Math.Max(num, maxProduct * num);

                result = Math.Max(result, maxProduct);
            }

            return result;
        }
    }
}
