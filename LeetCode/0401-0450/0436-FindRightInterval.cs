//-----------------------------------------------------------------------------
// Runtime: 364ms
// Memory Usage: 40.1 MB
// Link: https://leetcode.com/submissions/detail/387435638/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0436_FindRightInterval
    {
        public int[] FindRightInterval(int[][] intervals)
        {
            var startIndex = new SortedDictionary<int, int>();
            for (int i = 0; i < intervals.Length; i++)
                startIndex[intervals[i][0]] = i;

            var results = new int[intervals.Length];
            var starts = startIndex.Keys.ToArray();
            for (int i = 0; i < intervals.Length; i++)
            {
                var index = Array.BinarySearch(starts, intervals[i][1]);
                if (index < 0)
                    index = ~index;
                results[i] = index == intervals.Length ? -1 : startIndex[starts[index]];
            }

            return results;
        }
    }
}
