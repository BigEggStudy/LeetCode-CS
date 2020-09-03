//-----------------------------------------------------------------------------
// Runtime: 332ms
// Memory Usage: 43.6 MB
// Link: https://leetcode.com/submissions/detail/382308922/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0352_DataStreamAsDisjointIntervals
    {
        private readonly SortedDictionary<int, int[]> map;

        /** Initialize your data structure here. */
        public _0352_DataStreamAsDisjointIntervals()
        {
            map = new SortedDictionary<int, int[]>();
        }

        public void AddNum(int val)
        {
            if (map.ContainsKey(val)) return;

            var keys = map.Keys.ToArray();
            var indexHi = Array.BinarySearch(keys, val);
            indexHi = ~indexHi;
            var indexLo = indexHi - 1;
            if (indexLo >= 0 && indexLo < keys.Length && indexHi < keys.Length && map[keys[indexLo]][1] + 1 == val && keys[indexHi] == val + 1)
            {
                map[keys[indexLo]][1] = map[keys[indexHi]][1];
                map.Remove(keys[indexHi]);
            }
            else if (indexLo >= 0 && indexLo < keys.Length && map[keys[indexLo]][1] + 1 >= val)
                map[keys[indexLo]][1] = Math.Max(map[keys[indexLo]][1], val);
            else if (indexHi < keys.Length && keys[indexHi] == val + 1)
            {
                map[val] = new int[] { val, map[keys[indexHi]][1] };
                map.Remove(keys[indexHi]);
            }
            else
                map[val] = new int[] { val, val };
        }

        public int[][] GetIntervals()
        {
            return map.Values.ToArray();
        }
    }

    /**
     * Your SummaryRanges object will be instantiated and called as such:
     * SummaryRanges obj = new SummaryRanges();
     * obj.AddNum(val);
     * int[][] param_2 = obj.GetIntervals();
     */
}
