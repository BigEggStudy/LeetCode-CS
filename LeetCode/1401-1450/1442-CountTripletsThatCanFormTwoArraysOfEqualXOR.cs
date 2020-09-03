//-----------------------------------------------------------------------------
// Runtime: 120ms
// Memory Usage: 24.2 MB
// Link: https://leetcode.com/submissions/detail/361680736/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1442_CountTripletsThatCanFormTwoArraysOfEqualXOR
    {
        public int CountTriplets(int[] arr)
        {
            var prefix = 0;
            var counts = new Dictionary<int, int>() { { 0, 1 } };
            var totals = new Dictionary<int, int>();

            var result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                prefix ^= arr[i];
                counts.TryGetValue(prefix, out int count);
                totals.TryGetValue(prefix, out int total);

                result += count * i - total;
                counts[prefix] = count + 1;
                totals[prefix] = total + i + 1;
            }

            return result;
        }
    }
}
