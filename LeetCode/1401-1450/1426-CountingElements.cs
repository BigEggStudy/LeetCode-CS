//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 24.2 MB
// Link: https://leetcode.com/submissions/detail/321449442/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1426_CountingElements
    {
        public int CountElements(int[] arr)
        {
            var mapping = new SortedDictionary<int, int>();

            foreach (var num in arr)
            {
                if (!mapping.ContainsKey(num)) mapping.Add(num, 0);
                mapping[num]++;
            }

            var result = 0;
            foreach (var num in mapping.Keys)
                if (mapping.ContainsKey(num + 1))
                    result += mapping[num];

            return result;
        }
    }
}
