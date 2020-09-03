//-----------------------------------------------------------------------------
// Runtime: 148ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1011_CapacityToShipPackagesWithinDDays
    {
        public int ShipWithinDays(int[] weights, int D)
        {
            var totalSum = 0;
            var largestNumber = -1;
            for (int i = 0; i < weights.Length; i++)
            {
                largestNumber = Math.Max(largestNumber, weights[i]);
                totalSum += weights[i];
            }

            var l = largestNumber;
            var h = totalSum;
            while (l <= h)
            {
                var mid = l + (h - l) / 2;
                var count = 1;
                var currentSum = 0;
                for (int i = 0; i < weights.Length; i++)
                {
                    if (currentSum + weights[i] > mid)
                    {
                        count++;
                        if (count > D) break;
                        currentSum = weights[i];
                    }
                    else currentSum += weights[i];
                }
                if (count > D) l = mid + 1;
                else h = mid - 1;
            }
            return l;
        }
    }
}
