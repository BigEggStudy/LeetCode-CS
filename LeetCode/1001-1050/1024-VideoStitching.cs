//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 24.3 MB
// Link: https://leetcode.com/submissions/detail/379506299/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _1024_VideoStitching
    {
        public int VideoStitching(int[][] clips, int T)
        {
            Array.Sort(clips, (a, b) => a[0].CompareTo(b[0]));

            int count = 0;
            int start = 0, end = 0;
            for (int i = 0; i < clips.Length && start < T; i++)
            {
                while (i < clips.Length && clips[i][0] <= start)
                    end = Math.Max(end, clips[i++][1]);
                if (start == end) return -1;
                count++;
                i--;
                start = end;
            }

            return start >= T ? count : -1;
        }
    }
}
