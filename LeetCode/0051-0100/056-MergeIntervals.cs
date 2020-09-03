//-----------------------------------------------------------------------------
// Runtime: 256ms
// Memory Usage: 33.3 MB
// Link: https://leetcode.com/submissions/detail/375127990/
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _056_MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1) return intervals;

            Array.Sort(intervals, (a, b) =>
            {
                var comp = a[0].CompareTo(b[0]);
                if (comp == 0)
                    comp = a[1].CompareTo(b[1]);
                return comp;
            });

            var result = new List<int[]>();
            result.Add(intervals[0]);
            for (int i = 1; i < intervals.Length; i++)
            {
                if (result.Last()[1] >= intervals[i][0])
                {
                    if (result.Last()[1] < intervals[i][1])
                        result.Last()[1] = intervals[i][1];
                }
                else
                    result.Add(intervals[i]);
            }

            return result.ToArray(); ;
        }
    }
}
