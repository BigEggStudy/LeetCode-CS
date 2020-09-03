//-----------------------------------------------------------------------------
// Runtime: 180ms
// Memory Usage: 34.9 MB
// Link: https://leetcode.com/submissions/detail/372798558/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class _0621_TaskScheduler
    {
        public int LeastInterval(char[] tasks, int n)
        {
            var count = new int[26];
            foreach (var ch in tasks)
                count[ch - 'A']++;

            Array.Sort(count);
            var max = count[25];
            var left_count = max - 1;
            var idleTime = left_count * (n + 1);
            for (int i = 25; i >= 0 && count[i] > 0 && idleTime > 0; i--)
                idleTime -= Math.Min(left_count, count[i]);

            if (idleTime > 0) return idleTime + tasks.Length;
            else return tasks.Length;
        }
    }
}
