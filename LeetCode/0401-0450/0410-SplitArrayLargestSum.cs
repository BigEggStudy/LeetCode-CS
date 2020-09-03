//-----------------------------------------------------------------------------
// Runtime: 92ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0410_SplitArrayLargestSum
    {
        public int SplitArray(int[] nums, int m)
        {
            var largestNumber = 0;
            var total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                largestNumber = Math.Max(nums[i], largestNumber);
                total += nums[i];
            }

            var l = largestNumber;
            var h = total;
            while (l <= h)
            {
                var mid = l + (h - l) / 2;
                var count = 1;
                var currentSum = 0;
                for (var i = 0; i < nums.Length; i++)
                {
                    if (currentSum + nums[i] > mid)
                    {
                        count++;
                        if (count > m) break;
                        currentSum = nums[i];
                    }
                    else
                        currentSum += nums[i];
                }
                if (count <= m)
                    h = mid - 1;
                else
                    l = mid + 1;
            }
            return l;
        }
    }
}
