//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 24.9 MB
// Link: https://leetcode.com/submissions/detail/330695260/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1394_FindLuckyIntegerInAnArray
    {
        public int FindLucky(int[] arr)
        {
            var counts = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            var result = -1;
            foreach (var key in counts.Keys)
            {
                if (key > result && counts[key] == key)
                    result = key;
            }

            return result;
        }
    }
}
