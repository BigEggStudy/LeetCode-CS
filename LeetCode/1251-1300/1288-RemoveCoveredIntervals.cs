//-----------------------------------------------------------------------------
// Runtime: 100ms
// Memory Usage: 29.7 MB
// Link: https://leetcode.com/submissions/detail/408821739/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1288_RemoveCoveredIntervals
    {
        public int RemoveCoveredIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) =>
            {
                var comp = a[0].CompareTo(b[0]);
                if (comp == 0)
                    comp = b[1].CompareTo(a[1]);
                return comp;
            });

            var count = 0;
            int maxEnd = 0;
            foreach (int[] curr in intervals)
            {
                if (maxEnd < curr[1])
                {
                    count++;
                    maxEnd = curr[1];
                }
            }

            return count;
        }
    }
}
