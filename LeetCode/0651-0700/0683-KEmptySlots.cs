//-----------------------------------------------------------------------------
// Runtime: 260ms
// Memory Usage: 
// Link: 
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0683_KEmptySlots
    {
        public int KEmptySlots(int[] bulbs, int K)
        {
            var days = new int[bulbs.Length];
            for (int j = 0; j < bulbs.Length; j++)
                days[bulbs[j] - 1] = j + 1;

            var left = 0;
            var right = K + 1;
            var result = int.MaxValue;
            var i = 1;
            while (right < bulbs.Length)
            {
                if (days[left] < days[i] && days[right] < days[i])
                {
                    i++;
                    continue;
                }

                if (i == right)
                    result = Math.Min(result, Math.Max(days[left], days[right]));

                left = i;
                right = i + K + 1;
                i++;
            }

            return result < int.MaxValue ? result : -1;
        }
    }
}
