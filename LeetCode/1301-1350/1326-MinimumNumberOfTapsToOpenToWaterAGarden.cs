//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 28 MB
// Link: https://leetcode.com/submissions/detail/379501385/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1326_MinimumNumberOfTapsToOpenToWaterAGarden
    {
        public int MinTaps(int n, int[] ranges)
        {
            var tapRanges = new (int start, int end)[n + 1];
            for (int i = 0; i <= n; i++)
                tapRanges[i] = (Math.Max(i - ranges[i], 0), i + ranges[i]);
            Array.Sort(tapRanges, (a, b) => a.start.CompareTo(b.start));

            var count = 0;
            int start = 0, end = 0;
            for (int i = 0; i <= n && start < n; i++)
            {
                while (i <= n && tapRanges[i].start <= start)
                    end = Math.Max(end, tapRanges[i++].end);
                if (start == end) return -1;
                start = end;
                count++;
                i--;
            }
            return count;
        }
    }
}
