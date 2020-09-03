//-----------------------------------------------------------------------------
// Runtime: 84ms
// Memory Usage: 24.4 MB
// Link: https://leetcode.com/submissions/detail/328748305/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _1207_UniqueNumberOfOccurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var map = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                if (map.ContainsKey(num))
                    map[num]++;
                else
                    map[num] = 1;
            }

            var set = new HashSet<int>();
            foreach (var value in map.Values)
                set.Add(value);

            return set.Count == map.Count;
        }
    }
}
