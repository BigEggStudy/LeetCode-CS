//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 26.4 MB
// Link: https://leetcode.com/submissions/detail/381387185/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0435_NonOverlappingIntervals
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            if (intervals.Length <= 1) return 0;

            Array.Sort(intervals, (a, b) =>
            {
                var comp = a[1].CompareTo(b[1]);
                if (comp == 0)
                    comp = a[0].CompareTo(b[0]);
                return comp;
            });
            var end = intervals[0][1];
            var count = 1;
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] >= end)
                {
                    end = intervals[i][1];
                    count++;
                }
            }
            return intervals.Length - count;
        }
    }
}
